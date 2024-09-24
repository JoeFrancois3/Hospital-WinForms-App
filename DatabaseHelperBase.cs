using System.Configuration;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;

namespace Software_Project
{
    public static class DatabaseHelperBase
    {
        private static readonly string connectionStringName = "SQLiteConnectionString";

        public static SQLiteConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            return new SQLiteConnection(connectionString);
        }

        public static void RefreshDoctorListViewBox(ListView listView)
        {
            try
            {
                listView.Items.Clear();
                using (SQLiteConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Doctors";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["doctor_id"].ToString());
                            item.SubItems.Add(reader["d_first_name"].ToString());
                            item.SubItems.Add(reader["d_surname"].ToString());
                            item.SubItems.Add(reader["d_home_number"].ToString());
                            listView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing the doctor list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string FormatDate(object value)
        {
            if (DateTime.TryParse(value?.ToString(), out DateTime dob))
            {
                return dob.ToString("yyyy-MM-dd");
            }
            return string.Empty;
        }
        public static void RefreshAppointmentListViewBox(ListView listView)
        {
            try
            {
                listView.Items.Clear();
                using (SQLiteConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Appointments.appointment_id, Appointments.appointment_date, Appointments.appointment_time, Appointments.doctors_notes, \r\nPatients.*, \r\nDoctors.*\r\nFROM \r\nPatients \r\nLEFT JOIN \r\nAppointments ON Patients.patient_id = Appointments.patient_id \r\nLEFT JOIN \r\nDoctors ON Appointments.doctor_id = Doctors.doctor_id \r\nWHERE \r\nAppointments.appointment_id IS NOT NULL";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
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

                            listView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing the appointment list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        public static void RefreshPatientListViewBox(ListView listView)
        {
            try
            {
                listView.Items.Clear();
                using (SQLiteConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Patients";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["patient_id"].ToString());
                            item.SubItems.Add(reader["first_name"].ToString());
                            item.SubItems.Add(reader["surname"].ToString());
                            item.SubItems.Add(reader["dob"].ToString());
                            item.SubItems.Add(reader["weight"].ToString());
                            item.SubItems.Add(reader["address_1"].ToString());
                            item.SubItems.Add(reader["address_2"].ToString());
                            item.SubItems.Add(reader["address_3"].ToString());
                            item.SubItems.Add(reader["postcode"].ToString());
                            item.SubItems.Add(reader["home_number"].ToString());
                            listView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing the patient list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteDoctor(string doctorID)
        {
            try
            {
                using (SQLiteConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = "DELETE FROM Doctors WHERE doctor_id = @DoctorID";
                        cmd.Parameters.AddWithValue("@DoctorID", doctorID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the doctor record: " + ex.Message);
            }
        }

        public static void DeletePatient(string patientID)
        {
            try
            {
                using (SQLiteConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = "DELETE FROM Patients WHERE patient_id = @PatientID";
                        cmd.Parameters.AddWithValue("@PatientID", patientID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the patient record: " + ex.Message);
            }
        }
    }
}
