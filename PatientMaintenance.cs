using System;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;
using static Software_Project.Home;

namespace Software_Project
{
    public partial class PatientMaintenance : Form
    {
        private SQLiteConnection sqlite_conn;

        public PatientMaintenance(SQLiteConnection connection)
        {
            InitializeComponent();
            sqlite_conn = connection;

            PopulatePatientListView();
            if (listview_Patient_Maintenance.Items.Count > 0)
            {
                listview_Patient_Maintenance.Items[0].Selected = true;
            }
            listview_Patient_Maintenance.FullRowSelect = true;
        }

        public static string FormatDate(object value)
        {
            if (DateTime.TryParse(value?.ToString(), out DateTime dob))
            {
                return dob.ToString("yyyy-MM-dd");
            }
            return string.Empty;
        }

        private void PopulatePatientListView()
        {
            try
            {
                listview_Patient_Maintenance.Items.Clear();
                listview_Patient_Maintenance.Columns.Clear();

                string query = "SELECT patient_id, first_name, surname, dob, weight, address_1, address_2, address_3, postcode, home_number FROM Patients";

                using (SQLiteCommand command = new SQLiteCommand(query, sqlite_conn))
                {
                    if (sqlite_conn.State != ConnectionState.Open)
                    {
                        sqlite_conn.Open();
                    }

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        listview_Patient_Maintenance.View = View.Details;

                        string[] columnNames = { "Patient ID", "First Name", "Last Name", "Date of Birth", "Weight (kg)", "Address Line 1", "Address Line 2", "Address Line 3", "Postcode", "Home Phone Number" };
                        int[] columnWidths = { 100, 150, 150, 150, 100, 150, 150, 150, 100, 150 };

                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            ColumnHeader columnHeader = new ColumnHeader();
                            columnHeader.Text = columnNames[i];
                            columnHeader.Width = columnWidths[i];
                            listview_Patient_Maintenance.Columns.Add(columnHeader);
                        }

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["patient_id"].ToString());
                            item.SubItems.Add(reader["first_name"].ToString());
                            item.SubItems.Add(reader["surname"].ToString());
                            string dobString = FormatDate(reader["dob"]);
                            item.SubItems.Add(dobString);
                            item.SubItems.Add(reader["weight"].ToString());
                            item.SubItems.Add(reader["address_1"].ToString());
                            item.SubItems.Add(reader["address_2"].ToString());
                            item.SubItems.Add(reader["address_3"].ToString());
                            item.SubItems.Add(reader["postcode"].ToString());
                            item.SubItems.Add(reader["home_number"].ToString());

                            listview_Patient_Maintenance.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating the patient list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlite_conn.State != ConnectionState.Closed)
                {
                    sqlite_conn.Close();
                }
            }
        }

        private void btn_Patient_Maintenance_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Edit_Patient addEditPatientForm = new Add_Edit_Patient(sqlite_conn, false, "", "", "", "", "", "", "", "", "", "", listview_Patient_Maintenance);
                addEditPatientForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Patient_Maintenance_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listview_Patient_Maintenance.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listview_Patient_Maintenance.SelectedItems[0];

                    string patientID = selectedItem.SubItems[0].Text;
                    string firstName = selectedItem.SubItems[1].Text;
                    string lastName = selectedItem.SubItems[2].Text;
                    string dob = selectedItem.SubItems[3].Text;
                    string weight = selectedItem.SubItems[4].Text;
                    string address_1 = selectedItem.SubItems[5].Text;
                    string address_2 = selectedItem.SubItems[6].Text;
                    string address_3 = selectedItem.SubItems[7].Text;
                    string postcode = selectedItem.SubItems[8].Text;
                    string telNo = selectedItem.SubItems[9].Text;

                    Add_Edit_Patient addEditPatientForm = new Add_Edit_Patient(sqlite_conn, true, patientID, firstName, lastName, dob, weight, address_1, address_2, address_3, postcode, telNo, listview_Patient_Maintenance);
                    addEditPatientForm.Show();
                }
                else
                {
                    MessageBox.Show("Please select a patient to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Patient_Maintenance_Delete_Click(object sender, EventArgs e)
        {
            if (UserContext.UserType == "1" || UserContext.UserType == "2")
            {
                try
                {
                    if (listview_Patient_Maintenance.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Please select a patient to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string patientID = (listview_Patient_Maintenance.SelectedItems[0].SubItems[0].Text);
                    string firstName = listview_Patient_Maintenance.SelectedItems[0].SubItems[1].Text;
                    string lastName = listview_Patient_Maintenance.SelectedItems[0].SubItems[2].Text;

                    DialogResult result = MessageBox.Show($"Are you sure you want to delete the selected patient {firstName} {lastName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DatabaseHelperBase.DeletePatient(patientID);
                        PopulatePatientListView();
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

        private void btn_Arrow_Up_Click(object sender, EventArgs e)
        {
            if (listview_Patient_Maintenance.SelectedItems.Count > 0)
            {
                int currentSelectedIndex = listview_Patient_Maintenance.SelectedIndices[0];

                if (currentSelectedIndex > 0)
                {
                    listview_Patient_Maintenance.SelectedItems[0].Selected = false;
                    listview_Patient_Maintenance.Items[currentSelectedIndex - 1].Selected = true;
                }
                else
                {
                    MessageBox.Show("You have reached the first row of the table.");
                }
            }
        }

        private void btn_Arrow_Down_Click(object sender, EventArgs e)
        {
            if (listview_Patient_Maintenance.SelectedItems.Count > 0)
            {
                int lastItemIndexWithData = listview_Patient_Maintenance.Items.Count - 1;
                int currentSelectedIndex = listview_Patient_Maintenance.SelectedIndices[0];
                if (currentSelectedIndex < lastItemIndexWithData)
                {
                    listview_Patient_Maintenance.SelectedItems[0].Selected = false;
                    listview_Patient_Maintenance.Items[currentSelectedIndex + 1].Selected = true;
                }
                else
                {
                    MessageBox.Show("You have reached the last row of the table.");
                }
            }
        }

        private void listview_Patient_Maintenance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
