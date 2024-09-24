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
using static Software_Project.Home;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Software_Project
{
    public partial class DoctorMaintenance : Form
    {
        private string connectionString = "Data Source=Software Project DB.db;Version=3;";
        private SQLiteConnection sqlite_conn;
        string DoctorQuery = @"
                SELECT doctor_id, d_first_name, d_surname, d_home_number
                FROM Doctors";
        string userType = UserContext.UserType;

        public DoctorMaintenance(SQLiteConnection connection)
        {
            InitializeComponent();
            sqlite_conn = connection;

            
            PopulateDoctorListView(DoctorQuery);

            if (listview_Doctor_Maintenance.Items.Count > 0)
            {
                listview_Doctor_Maintenance.Items[0].Selected = true;
            }
            listview_Doctor_Maintenance.FullRowSelect = true;
        }

        private void PopulateDoctorListView(string query)
        {
                listview_Doctor_Maintenance.View = View.Details;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        listview_Doctor_Maintenance.Items.Clear();
                        listview_Doctor_Maintenance.Columns.Clear();

                        string[] columnNames = { "DoctorID", "First Name", "Last Name", "Home Number" };

                        int[] columnWidths = { 100, 150, 150, 150 };

                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            ColumnHeader columnHeader = new ColumnHeader();
                            columnHeader.Text = columnNames[i];
                            columnHeader.Width = columnWidths[i];
                            listview_Doctor_Maintenance.Columns.Add(columnHeader);
                        }

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["doctor_id"].ToString());
                            item.SubItems.Add(reader["d_first_name"].ToString());
                            item.SubItems.Add(reader["d_surname"].ToString());
                            item.SubItems.Add(reader["d_home_number"].ToString());

                            listview_Doctor_Maintenance.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating the doctor list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Doctor_Maintenance_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Pass false to indicate "add" mode
                Add_Edit_Doctor addEditDoctorForm = new Add_Edit_Doctor(sqlite_conn, false, "", "", "", "", listview_Doctor_Maintenance);
                addEditDoctorForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Doctor_Maintenance_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listview_Doctor_Maintenance.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listview_Doctor_Maintenance.SelectedItems[0];

                    
                    string doctorID = selectedItem.SubItems[0].Text;
                    string firstName = selectedItem.SubItems[1].Text;
                    string lastName = selectedItem.SubItems[2].Text;
                    string telNo = selectedItem.SubItems[3].Text;

                    
                    Add_Edit_Doctor addEditDoctorForm = new Add_Edit_Doctor(sqlite_conn, true, doctorID, firstName, lastName, telNo, listview_Doctor_Maintenance);
                    addEditDoctorForm.Show();
                }
                else
                {
                    MessageBox.Show("Please select a doctor to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Doctor_Maintenance_Delete_Click(object sender, EventArgs e)
        {
            if (UserContext.UserType == "1")
            {
                try
                {
                    if (listview_Doctor_Maintenance.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Please select a doctor to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string doctorID = (listview_Doctor_Maintenance.SelectedItems[0].SubItems[0].Text);
                    string firstName = listview_Doctor_Maintenance.SelectedItems[0].SubItems[1].Text;
                    string lastName = listview_Doctor_Maintenance.SelectedItems[0].SubItems[2].Text;

                    DialogResult result = MessageBox.Show($"Are you sure you want to delete the selected doctor {firstName} {lastName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DeleteDoctor(doctorID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Access Denied: Insufficient Privileges. Your current user level does not grant access to this feature.");
            }
            
        }

        private void DeleteDoctor(string doctorID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = "DELETE FROM Doctors WHERE doctor_id = @DoctorID";
                        cmd.Parameters.AddWithValue("@DoctorID", doctorID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Doctor record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    PopulateDoctorListView(DoctorQuery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the doctor record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Arrow_Up_Click(object sender, EventArgs e)
        {
            if (listview_Doctor_Maintenance.SelectedItems.Count > 0)
            {
                int currentSelectedIndex = listview_Doctor_Maintenance.SelectedIndices[0];

                if (currentSelectedIndex > 0)
                {
                    listview_Doctor_Maintenance.SelectedItems[0].Selected = false;
                    listview_Doctor_Maintenance.Items[currentSelectedIndex - 1].Selected = true;
                }
                else
                {
                    MessageBox.Show("You have reached the first row of the table.");
                }
            }
        }

        private void btn_Arrow_Down_Click(object sender, EventArgs e)
        {
            if (listview_Doctor_Maintenance.SelectedItems.Count > 0)
            {
                int lastItemIndexWithData = listview_Doctor_Maintenance.Items.Count - 1;
                int currentSelectedIndex = listview_Doctor_Maintenance.SelectedIndices[0];
                if (currentSelectedIndex < lastItemIndexWithData)
                {
                    listview_Doctor_Maintenance.SelectedItems[0].Selected = false;
                    listview_Doctor_Maintenance.Items[currentSelectedIndex + 1].Selected = true;
                }
                else
                {
                    MessageBox.Show("You have reached the last row of the table.");
                }
            }
        }
    }
}
