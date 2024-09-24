using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class Add_Edit_Appointment : Form
    {
        private bool isEditMode;
        private SQLiteConnection sqlite_conn;
        private ListView listViewToUpdate;
        private string connectionString = "Data Source=Software Project DB.db;Version=3;";

        public Add_Edit_Appointment(SQLiteConnection connection, bool isEditMode, int appointmentID, DateTime appointmentDate, TimeSpan appointmentTime, ListView listViewToUpdate, string doctorID, string patientID)
        {
            InitializeComponent();
            this.isEditMode = isEditMode;
            txtbx_Appointment_ID.Enabled = false;

            if (isEditMode)
            {
                txtbx_Appointment_ID.Text = appointmentID.ToString();
                txtbx_AppointmentDateDisplay.Text = appointmentDate.ToString("yyyy-MM-dd");
                txtbx_AppointmentTimeDisplay.Text = appointmentTime.ToString(@"hh\:mm\:ss");
                combobx_Doctor.Text = doctorID.ToString();
                combobx_Patient.Text = patientID.ToString();

                txtbx_Appointment_ID.Visible = true;
                lbl_AppointmentID.Visible = true;
            }
            else
            {
                txtbx_Appointment_ID.Visible = false;
                lbl_AppointmentID.Visible = false;
            }

            string queryDoctors = "SELECT doctor_id FROM Doctors";
            using (SQLiteCommand command = new SQLiteCommand(queryDoctors, connection))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string doctorIdFromDB = reader["doctor_id"].ToString();
                        combobx_Doctor.Items.Add(doctorIdFromDB);
                    }
                }
            }

            string queryPatients = "SELECT patient_id FROM Patients";
            using (SQLiteCommand command = new SQLiteCommand(queryPatients, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    while (reader.Read())
                    {
                        string patientIdFromDB = reader["patient_id"].ToString();
                        combobx_Patient.Items.Add(patientIdFromDB);
                    }
                }
            }

            this.sqlite_conn = connection;
            this.listViewToUpdate = listViewToUpdate;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            List<string> missingFields = new List<string>();

            if (string.IsNullOrEmpty(txtbx_AppointmentDateDisplay.Text))
            {
                missingFields.Add("Appointment Date");
            }

            if (string.IsNullOrEmpty(txtbx_AppointmentTimeDisplay.Text))
            {
                missingFields.Add("Appointment Time");
            }

            if (missingFields.Any())
            {
                string errorMessage = "Please fill in the following fields correctly:\n" + string.Join("\n", missingFields);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string doctorID = combobx_Doctor.Text.ToString();
                string patientID = combobx_Patient.Text.ToString();
                int appointmentID = isEditMode ? int.Parse(txtbx_Appointment_ID.Text) : GetNextAppointmentId();

                DateTime appointmentDate;
                if (!DateTime.TryParseExact(txtbx_AppointmentDateDisplay.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out appointmentDate))
                {
                    MessageBox.Show("Invalid date format. Please enter the date in yyyy-MM-dd format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TimeSpan appointmentTime;
                if (!TimeSpan.TryParseExact(txtbx_AppointmentTimeDisplay.Text, @"hh\:mm\:ss", CultureInfo.InvariantCulture, out appointmentTime))
                {
                    MessageBox.Show("Invalid time format. Please enter the time in hh:mm:ss format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (isEditMode)
                {
                    UpdateAppointmentRecord(appointmentID, appointmentDate, appointmentTime, doctorID, patientID);
                    MessageBox.Show("Appointment record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                {
                    
                    InsertNewAppointmentRecord(appointmentID, appointmentDate, appointmentTime, doctorID, patientID);
                    MessageBox.Show("New appointment record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DatabaseHelperBase.RefreshAppointmentListViewBox(listViewToUpdate);
                Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close(); 
            }
        }



        private int GetNextAppointmentId()
        {
            int nextAppointmentId = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT MAX(appointment_id) FROM Appointments", conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextAppointmentId = Convert.ToInt32(result) + 1;
                    }
                }
            }
            return nextAppointmentId;
        }

        private void UpdateAppointmentRecord(int appointmentID, DateTime appointmentDate, TimeSpan appointmentTime, string doctorID, string patientID)
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
                            cmd.CommandText = @"
                            UPDATE Appointments 
                            SET 
                            appointment_date = @AppointmentDate, 
                            appointment_time = @AppointmentTime,
                            doctor_id = @DoctorId,
                            patient_id = @PatientId
                        WHERE appointment_id = @AppointmentID;
                                ";
                            cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@AppointmentTime", appointmentTime.ToString(@"hh\:mm\:ss"));
                            cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);
                            cmd.Parameters.AddWithValue("@DoctorId", doctorID);
                            cmd.Parameters.AddWithValue("@PatientId", patientID);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while updating appointment record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void InsertNewAppointmentRecord(int appointmentID, DateTime appointmentDate, TimeSpan appointmentTime, string doctorID, string patientID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO Appointments (appointment_id, appointment_date, appointment_time, doctor_id, patient_id)
                    SELECT @AppointmentId, @AppointmentDate, @AppointmentTime, d.doctor_id, p.patient_id
                    FROM Doctors d, Patients p
                    WHERE d.doctor_id = @DoctorId AND p.patient_id = @PatientId
                        "; 
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AppointmentId", appointmentID);
                    cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@AppointmentTime", appointmentTime.ToString(@"hh\:mm\:ss"));
                    cmd.Parameters.AddWithValue("@DoctorId", doctorID);
                    cmd.Parameters.AddWithValue("@PatientId", patientID);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void btn_Appointment_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
