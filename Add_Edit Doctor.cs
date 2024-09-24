using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project
{

    public partial class Add_Edit_Doctor : Form
    {
        private ListView listview_Doctor_Maintenance;
        private string connectionString = "Data Source=Software Project DB.db;Version=3;";
        private bool isEditMode;
        private SQLiteConnection sqlite_conn;
        private ListView listViewToUpdate;

        public Add_Edit_Doctor(SQLiteConnection connection, bool isEditMode, string doctorID, string firstName, string lastName, string telNo, ListView listViewToUpdate)
        {
            InitializeComponent();
            this.isEditMode = isEditMode;
            txtbx_Doctor_ID.Enabled = false;

            if (isEditMode)
            {
                txtbx_Doctor_ID.Text = doctorID;
                txtbx_Doctor_Fname.Text = firstName;
                txtbx_Doctor_Sname.Text = lastName;
                txtbx_Doctor_TelNo.Text = telNo;

                txtbx_Doctor_ID.Visible = true;
                lbl_DoctorID.Visible = true;
            }
            else 
            {
                txtbx_Doctor_ID.Visible = false;
                lbl_DoctorID.Visible = false;
            }

            this.listview_Doctor_Maintenance = listViewToUpdate;
        }




        private void btn_OK_Click(object sender, EventArgs e)
        {
            List<string> missingFields = new List<string>();

            if (string.IsNullOrEmpty(txtbx_Doctor_Fname.Text))
            {
                missingFields.Add("First Name");
            }

            if (string.IsNullOrEmpty(txtbx_Doctor_Sname.Text))
            {
                missingFields.Add("Last Name");
            }

            if (string.IsNullOrEmpty(txtbx_Doctor_TelNo.Text))
            {
                missingFields.Add("Telephone Number");
            }

            if (missingFields.Any())
            {
                string errorMessage = "Please fill in the following fields:\n" + string.Join("\n", missingFields);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string doctorID = txtbx_Doctor_ID.Text;
            string firstName = txtbx_Doctor_Fname.Text;
            string lastName = txtbx_Doctor_Sname.Text;
            string telNo = txtbx_Doctor_TelNo.Text;

            if (isEditMode)
            {
                UpdateDoctorRecord(doctorID, firstName, lastName, telNo);
                MessageBox.Show("Doctor record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                InsertNewDoctorRecord(firstName, lastName, telNo);
                MessageBox.Show("New doctor record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DatabaseHelperBase.RefreshDoctorListViewBox(listview_Doctor_Maintenance);
            Close();
        }


        private int GetNextDoctorId()
        {
            int nextDoctorId = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT MAX(doctor_id) FROM Doctors", conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextDoctorId = Convert.ToInt32(result) + 1;
                    }
                }
            }
            return nextDoctorId;
        }

        private void UpdateDoctorRecord(string doctorID, string firstName, string lastName, string telNo)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "UPDATE Doctors SET d_first_name = @FirstName, d_surname = @LastName, d_home_number = @TelNo WHERE doctor_id = @DoctorID;";
                            cmd.Parameters.AddWithValue("@FirstName", firstName);
                            cmd.Parameters.AddWithValue("@LastName", lastName);
                            cmd.Parameters.AddWithValue("@TelNo", telNo);
                            cmd.Parameters.AddWithValue("@DoctorID", doctorID);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while updating doctor record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void InsertNewDoctorRecord(string firstName, string lastName, string telNo)
        {
            int nextDoctorId = GetNextDoctorId();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Doctors (doctor_id, d_first_name, d_surname, d_home_number) VALUES (@DoctorId, @FirstName, @LastName, @TelNo)", conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorId", nextDoctorId);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@TelNo", telNo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
