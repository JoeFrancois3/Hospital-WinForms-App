using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class AppointmentMaintenance : Form
    {
        private SQLiteConnection sqlite_conn;

        public AppointmentMaintenance(SQLiteConnection connection)
        {
            InitializeComponent();
            sqlite_conn = connection;

            PopulateAppointmentListView();
            if (listview_Appointment_Maintenance.Items.Count > 0)
            {
                listview_Appointment_Maintenance.Items[0].Selected = true;
            }
            listview_Appointment_Maintenance.FullRowSelect = true;
        }

        public static string FormatDate(object value)
        {
            if (DateTime.TryParse(value?.ToString(), out DateTime dob))
            {
                return dob.ToString("yyyy-MM-dd");
            }
            return string.Empty;
        }
        private void PopulateAppointmentListView()
        {
            try
            {
                listview_Appointment_Maintenance.Items.Clear();
                listview_Appointment_Maintenance.Columns.Clear();

                string query = @"
                    SELECT 
                        Appointments.appointment_id, 
                        Appointments.appointment_date, 
                        Appointments.appointment_time,
                        Appointments.doctors_notes, 
                        Patients.*, 
                        Doctors.*
                    FROM 
                        Patients 
                    LEFT JOIN 
                        Appointments ON Patients.patient_id = Appointments.patient_id 
                    LEFT JOIN 
                        Doctors ON Appointments.doctor_id = Doctors.doctor_id 
                    WHERE 
                        Appointments.appointment_id IS NOT NULL
                    ";

                using (SQLiteCommand command = new SQLiteCommand(query, sqlite_conn))
                {
                    if (sqlite_conn.State != ConnectionState.Open)
                    {
                        sqlite_conn.Open();
                    }

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        listview_Appointment_Maintenance.View = View.Details;

                        string[] columnNames = { "Appointment ID", "Date", "Time", "Doctor's Notes", "Patient ID", "Patient First Name", "Patient  Surname", "Patient Date of Birth", "Weight (kg)", "Address Line 1", "Address Line 2", "Address Line 3", "Postcode", "Patient Home Number", "Doctor ID", "Doctor First Name", "Doctor Surname", "Doctor Home Number" };
                        int[] columnWidths = { 100, 150, 100, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150, 150 };

                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            ColumnHeader columnHeader = new ColumnHeader();
                            columnHeader.Text = columnNames[i];
                            columnHeader.Width = columnWidths[i];
                            listview_Appointment_Maintenance.Columns.Add(columnHeader);
                        }

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["appointment_id"].ToString());
                            item.SubItems.Add(DateTime.Parse(reader["appointment_date"].ToString()).ToString("dd-MM-yyyy"));

                            string timeString = reader["appointment_time"].ToString();
                            string formattedTime = "";
                            if (!string.IsNullOrEmpty(timeString))
                            {
                                if (TimeSpan.TryParse(timeString, out TimeSpan appointmentTime))
                                {
                                    formattedTime = appointmentTime.ToString(@"hh\:mm");
                                }
                                else if (DateTime.TryParse(timeString, out DateTime appointmentDateTime))
                                {
                                    formattedTime = appointmentDateTime.ToString("HH:mm");
                                }
                            }
                            item.SubItems.Add(formattedTime);

                            item.SubItems.Add(reader["doctors_notes"].ToString());
                            item.SubItems.Add(reader["patient_id"].ToString());
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
                            item.SubItems.Add(reader["doctor_id"].ToString());
                            item.SubItems.Add(reader["d_first_name"].ToString());
                            item.SubItems.Add(reader["d_surname"].ToString());
                            item.SubItems.Add(reader["d_home_number"].ToString());

                            listview_Appointment_Maintenance.Items.Add(item);
                        }



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating the appointment list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlite_conn.State != ConnectionState.Closed)
                {
                    sqlite_conn.Close();
                }
            }
        }

        private void DeleteAppointment(int appointmentID)
        {
            // Implement the logic to delete an appointment from the database           
        }

        private void btn_Appointment_Maintenance_Add_Click_1(object sender, EventArgs e)
        {
            try
            {
                string doctorID = "";
                string patientID = "";
                Add_Edit_Appointment addEditAppointmentForm = new Add_Edit_Appointment(sqlite_conn, false, 0, DateTime.Today, TimeSpan.Zero, listview_Appointment_Maintenance, doctorID, patientID);
                addEditAppointmentForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Add_Edit_Appointment addEditAppointmentForm;
        private void btn_Appointment_Maintenance_Edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listview_Appointment_Maintenance.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listview_Appointment_Maintenance.SelectedItems[0];
                    int appointmentID = int.Parse(selectedItem.SubItems[0].Text);
                    DateTime appointmentDate = DateTime.Parse(selectedItem.SubItems[1].Text);
                    TimeSpan appointmentTime = TimeSpan.Parse(selectedItem.SubItems[2].Text);
                    string doctorID = selectedItem.SubItems[14].Text;
                    string patientID = selectedItem.SubItems[4].Text;

                    if (addEditAppointmentForm == null || addEditAppointmentForm.IsDisposed)
                    {
                        addEditAppointmentForm = new Add_Edit_Appointment(sqlite_conn, true, appointmentID, appointmentDate, appointmentTime, listview_Appointment_Maintenance, doctorID, patientID);
                        addEditAppointmentForm.Show();
                    }
                    else
                    {
                        addEditAppointmentForm.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an appointment to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Appointment_Maintenance_Delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listview_Appointment_Maintenance.SelectedItems.Count > 0)
                {
                    int appointmentID = int.Parse(listview_Appointment_Maintenance.SelectedItems[0].SubItems[0].Text);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DeleteAppointment(appointmentID);
                        PopulateAppointmentListView();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an appointment to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btn_Arrow_Up_Click(object sender, EventArgs e)
        {
            if (listview_Appointment_Maintenance.SelectedItems.Count > 0)
            {
                int currentSelectedIndex = listview_Appointment_Maintenance.SelectedIndices[0];

                if (currentSelectedIndex > 0)
                {
                    listview_Appointment_Maintenance.SelectedItems[0].Selected = false;
                    listview_Appointment_Maintenance.Items[currentSelectedIndex - 1].Selected = true;
                }
                else
                {
                    MessageBox.Show("You have reached the first row of the table.");
                }
            }
        }

        private void btn_Arrow_Down_Click(object sender, EventArgs e)
        {
            if (listview_Appointment_Maintenance.SelectedItems.Count > 0)
            {
                int lastItemIndexWithData = listview_Appointment_Maintenance.Items.Count - 1;
                int currentSelectedIndex = listview_Appointment_Maintenance.SelectedIndices[0];
                if (currentSelectedIndex < lastItemIndexWithData)
                {
                    listview_Appointment_Maintenance.SelectedItems[0].Selected = false;
                    listview_Appointment_Maintenance.Items[currentSelectedIndex + 1].Selected = true;
                }
                else
                {
                    MessageBox.Show("You have reached the last row of the table.");
                }
            }
        }
    }
}
