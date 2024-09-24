using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Software_Project
{
    public partial class Add_Edit_Patient : Form
    {
        private ListView listview_Patient_Maintenance;
        private string connectionString = "Data Source=Software Project DB.db;Version=3;";
        private bool isEditMode;
        private SQLiteConnection sqlite_conn;
        private ListView listViewToUpdate;

        public Add_Edit_Patient(SQLiteConnection connection, bool isEditMode, string patientID, string firstName, string lastName, string dob, string weight, string address_1, string address_2, string address_3, string postcode, string telNo, ListView listViewToUpdate)
        {
            InitializeComponent();
            this.isEditMode = isEditMode;
            txtbx_Patient_ID.Enabled = false;

            if (isEditMode)
            {
                txtbx_Patient_ID.Text = patientID;
                txtbx_Patient_Fname.Text = firstName;
                txtbx_Patient_Sname.Text = lastName;
                txtbx_Patient_dob.Text = dob;
                txtbx_Patient_Weight.Text = weight;
                txtbx_Patient_Address1.Text = address_1;
                txtbx_Patient_Address2.Text = address_2;
                txtbx_Patient_Address3.Text = address_3;
                txtbx_Patient_Postcode.Text = postcode;
                txtbx_Patient_TelNo.Text = telNo;

                txtbx_Patient_ID.Visible = true;
                lbl_PatientID.Visible = true;

                this.listViewToUpdate = listViewToUpdate;
            }
            else // Add Mode
            {
                txtbx_Patient_ID.Visible = false;
                lbl_PatientID.Visible = false;
            }

            this.listViewToUpdate = listViewToUpdate;
            this.listview_Patient_Maintenance = listViewToUpdate;
        }


        private void btn_OK_Click(object sender, EventArgs e)
        {
            List<string> missingFields = new List<string>();

            if (string.IsNullOrEmpty(txtbx_Patient_Fname.Text))
            {
                missingFields.Add("First Name");
            }

            if (string.IsNullOrEmpty(txtbx_Patient_Sname.Text))
            {
                missingFields.Add("Last Name");
            }

            if (string.IsNullOrEmpty(txtbx_Patient_TelNo.Text))
            {
                missingFields.Add("Telephone Number");
            }

            if (string.IsNullOrEmpty(txtbx_Patient_dob.Text) || !Regex.IsMatch(txtbx_Patient_dob.Text, @"\b\d{4}-\d{2}-\d{2}\b"))
            {
                missingFields.Add("Date of Birth (YYYY-MM-DD)");
            }

            if (string.IsNullOrEmpty(txtbx_Patient_Weight.Text))
            {
                missingFields.Add("Weight");
            }

            if (string.IsNullOrEmpty(txtbx_Patient_Address1.Text))
            {
                missingFields.Add("Address Line 1");
            }

            if (string.IsNullOrEmpty(txtbx_Patient_Address2.Text))
            {
                missingFields.Add("Address Line 2");
            }

            if (string.IsNullOrEmpty(txtbx_Patient_Address3.Text))
            {
                missingFields.Add("Address Line 3");
            }

            if (string.IsNullOrEmpty(txtbx_Patient_Postcode.Text))
            {
                missingFields.Add("Postcode");
            }

            if (missingFields.Any())
            {
                string errorMessage = "Please fill in the following fields:\n" + string.Join("\n", missingFields);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string patientID = txtbx_Patient_ID.Text;
            string firstName = txtbx_Patient_Fname.Text;
            string lastName = txtbx_Patient_Sname.Text;
            string dob = txtbx_Patient_dob.Text;
            string weight = txtbx_Patient_Weight.Text;
            string address_1 = txtbx_Patient_Address1.Text;
            string address_2 = txtbx_Patient_Address2.Text;
            string address_3 = txtbx_Patient_Address3.Text;
            string postcode = txtbx_Patient_Postcode.Text;
            string telNo = txtbx_Patient_TelNo.Text;


            if (isEditMode)
            {
                UpdatePatientRecord(patientID, firstName, lastName, dob, weight, address_1, address_2, address_3, postcode, telNo);
                MessageBox.Show("Patient record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                InsertNewPatientRecord(firstName, lastName, dob, weight, address_1, address_2, address_3, postcode, telNo);
                MessageBox.Show("New patient record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DatabaseHelperBase.RefreshPatientListViewBox(listview_Patient_Maintenance);
            Close();
        }

        private int GetNextPatientId()
        {
            int nextPatientId = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT MAX(patient_id) FROM Patients", conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextPatientId = Convert.ToInt32(result) + 1;
                    }
                }
            }
            return nextPatientId;
        }

        private void UpdatePatientRecord(string patientID, string firstName, string lastName, string dob, string weight, string address_1, string address_2, string address_3, string postcode, string telNo)
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
                            cmd.CommandText = "UPDATE Patients SET first_name = @FirstName, surname = @LastName, dob = @Dob, weight = @Weight, address_1 = @Address1, address_2 = @Address2, address_3 = @Address3, postcode = @Postcode, home_number = @HomeNumber WHERE patient_id = @PatientID;";
                            cmd.Parameters.AddWithValue("@FirstName", firstName);
                            cmd.Parameters.AddWithValue("@LastName", lastName);
                            cmd.Parameters.AddWithValue("@Dob", dob);
                            cmd.Parameters.AddWithValue("@Weight", weight);
                            cmd.Parameters.AddWithValue("@Address1", address_1);
                            cmd.Parameters.AddWithValue("@Address2", address_2);
                            cmd.Parameters.AddWithValue("@Address3", address_3);
                            cmd.Parameters.AddWithValue("@Postcode", postcode);
                            cmd.Parameters.AddWithValue("@HomeNumber", telNo);
                            cmd.Parameters.AddWithValue("@PatientID", patientID);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while updating patient record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void InsertNewPatientRecord(string firstName, string lastName, string dob, string weight, string address_1, string address_2, string address_3, string postcode, string telNo)
        {
            int nextPatientId = GetNextPatientId();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Patients (patient_id, first_name, surname, dob, weight, address_1, address_2, address_3, postcode, home_number) VALUES (@PatientId, @FirstName, @LastName, @Dob, @Weight, @Address1, @Address2, @Address3, @Postcode, @TelNo)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientId", nextPatientId);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Dob", dob);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@Address1", address_1);
                    cmd.Parameters.AddWithValue("@Address2", address_2);
                    cmd.Parameters.AddWithValue("@Address3", address_3);
                    cmd.Parameters.AddWithValue("@Postcode", postcode);
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
