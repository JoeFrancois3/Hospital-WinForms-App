using System;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Software_Project
{

    public partial class Home : Form
    {
        private SQLiteConnection sqlite_conn;
        private string query;
        private bool skipNextSelectionChange = false;
        string formattedDate = "";

        public Home()
        {
            InitializeComponent();

            query = "";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            txtbxDoctorsNotes.ReadOnly = true;

            btn_View_Patients.Visible = false;
            sqlite_conn = DatabaseHelperBase.GetConnection();
            recordTypeComboBox.DataSource = Enum.GetValues(typeof(RecordType));

            if (isDataGridViewPopulated == null)
            {
                isDataGridViewPopulated = new Dictionary<RecordType, bool>
                {
                    { RecordType.Patient, false },
                    { RecordType.Doctor, false },
                    { RecordType.Appointment, false }
                };
            }

        }

        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabcontrol_1.TabPages.Remove(tab_home);
            tabcontrol_1.TabPages.Remove(tab_PasswordReset);
        }
        public static class UserContext
        {
            public static string UserType { get; set; }
        }
        private void btn_ForgotPassword_Click(object sender, EventArgs e)
        {
            tabcontrol_1.TabPages.Remove(tab_Login);
            tabcontrol_1.TabPages.Add(tab_PasswordReset);
        }

        private bool loginSuccessful = false;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

            loginSuccessful = CheckLogin(username, password);
            if (loginSuccessful)
            {
                tabcontrol_1.TabPages.Add(tab_home);
                tabcontrol_1.TabPages.Remove(tab_Login);
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                tabcontrol_1.SelectedIndex = 0;
            }
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            tabcontrol_1.TabPages.Remove(tab_home);
            tabcontrol_1.TabPages.Add(tab_Login);
            MessageBox.Show("Logged out!");
        }
        private bool CheckLogin(string username, string password)
        {
            bool isAuthenticated = false;

            string connectionString = "Data Source=Software Project DB.db;";
            string query = "SELECT username, password, user_type FROM Users WHERE username = @username";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader["password"].ToString();
                            if (storedPassword == password)
                            {
                                isAuthenticated = true;
                                UserContext.UserType = reader["user_type"].ToString();
                            }
                        }
                    }
                }
            }

            return isAuthenticated;
        }



        private void btn_Search_Click(object sender, EventArgs e)
        {
            string recordID = tb_IDNumber.Text.Trim();
            RecordType recordType;

            if (recordTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a record type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Enum.TryParse(recordTypeComboBox.SelectedItem.ToString(), out recordType))
            {
                MessageBox.Show("Please select a valid record type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(recordID) && !int.TryParse(recordID, out _))
            {
                MessageBox.Show("Please enter a valid integer for the record ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(sqlite_conn.ConnectionString))
                {
                    connection.Open();

                    SearchRecord(recordType, recordID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Arrow_Down_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int lastRowIndexWithData = dataGridView1.Rows.Count - 1;
                int currentRowIndex = dataGridView1.SelectedRows[0].Index;
                if (currentRowIndex < lastRowIndexWithData)
                {
                    dataGridView1.SelectedRows[0].Selected = false;
                    dataGridView1.Rows[currentRowIndex + 1].Selected = true;

                    HandleDataGridViewSelectionChange(dataGridView1, sqlite_conn);
                }
                else
                {
                    MessageBox.Show("You have reached the last row of the table.");
                }
            }
        }

        private void btn_Arrow_Up_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int currentRowIndex = dataGridView1.SelectedRows[0].Index;

                if (currentRowIndex > 0)
                {
                    dataGridView1.SelectedRows[0].Selected = false;
                    dataGridView1.Rows[currentRowIndex - 1].Selected = true;

                    HandleDataGridViewSelectionChange(dataGridView1, sqlite_conn);
                }
                else
                {
                    MessageBox.Show("You have reached the first row of the table.");
                }
            }
        }

        private void btn_View_Patients_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string doctorID = dataGridView1.SelectedRows[0].Cells["DoctorID"].Value.ToString();

                List<Dictionary<string, string>> patientsData = RetrievePatientsDataByDoctorID(doctorID, sqlite_conn);

                if (patientsData.Count > 0)
                {
                    PatientListForm patientListForm = new PatientListForm(patientsData, this);
                    patientListForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No patients found for the selected doctor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                
                MessageBox.Show("Please select exactly one doctor from the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<Dictionary<string, string>> RetrievePatientsDataByDoctorID(string doctorID, SQLiteConnection connection)
        {
            List<Dictionary<string, string>> patientsData = new List<Dictionary<string, string>>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string patientDataRelatedToDoctor = @"
                    SELECT Patients.*
                    FROM Doctors
                    LEFT JOIN Appointments ON Doctors.doctor_id = Appointments.doctor_id
                    LEFT JOIN Patients ON Patients.patient_id = Appointments.patient_id
                    WHERE Doctors.doctor_id = @doctorID";

                using (SQLiteCommand command = new SQLiteCommand(patientDataRelatedToDoctor, connection))
                {
                    command.Parameters.AddWithValue("@doctorID", doctorID);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, string> patientData = new Dictionary<string, string>();
                            bool hasValidData = false;

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string columnName = reader.GetName(i);
                                string columnValue = reader.GetValue(i)?.ToString();

                                if (!string.IsNullOrEmpty(columnValue))
                                {
                                    patientData.Add(columnName, columnValue);
                                    hasValidData = true;
                                }
                            }

                            if (hasValidData)
                            {
                                patientsData.Add(patientData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while accessing the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return patientsData;
        }


        public void PopulateLabels(string query, RecordType recordtype, string recordID)
        {
            ClearDisplayLabels(this.Controls);
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(sqlite_conn.ConnectionString))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(recordID))
                        {
                            command.Parameters.AddWithValue("@recordID", recordID);
                        }

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No data found for the selected record type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (reader.Read())
                            {
                                switch (recordtype)
                                {
                                    case RecordType.Patient:
                                        lbl_PatientIdDisplay.Text = reader["patient_id"].ToString();
                                        lbl_Patient_FnameDisplay.Text = reader["first_name"].ToString();
                                        lbl_Patient_SnameDisplay.Text = reader["surname"].ToString();
                                        lbl_Patient_DOBDisplay.Text = FormatDate(reader["dob"]);
                                        lbl_Patient_WeightDisplay.Text = reader["weight"].ToString();
                                        lbl_Patient_Address1Display.Text = reader["address_1"].ToString();
                                        lbl_Patient_Address2Display.Text = reader["address_2"].ToString();
                                        lbl_Patient_Address3Display.Text = reader["address_3"].ToString();
                                        lbl_patient_postcodeDisplay.Text = reader["postcode"].ToString();
                                        lbl_patient_TelNoDisplay.Text = reader["home_number"].ToString();
                                        lbl_DoctorIDDisplay.Text = reader["doctor_id"].ToString();
                                        lbl_Doctor_FnameDisplay.Text = reader["d_first_name"].ToString();
                                        lbl_Doctor_SnameDisplay.Text = reader["d_surname"].ToString();
                                        lbl_Doctor_TelNoDisplay.Text = reader["d_home_number"].ToString();
                                        btn_View_Patients.Visible = false;
                                        return;

                                    case RecordType.Doctor:
                                        lbl_DoctorIDDisplay.Text = reader["doctor_id"].ToString();
                                        lbl_Doctor_FnameDisplay.Text = reader["d_first_name"].ToString();
                                        lbl_Doctor_SnameDisplay.Text = reader["d_surname"].ToString();
                                        lbl_Doctor_TelNoDisplay.Text = reader["d_home_number"].ToString();
                                        btn_View_Patients.Visible = true;
                                        return;

                                    case RecordType.Appointment:
                                        lbl_AppointmentIDDisplay.Text = reader["appointment_id"].ToString();
                                        lbl_DoctorIDDisplay.Text = reader["doctor_id"].ToString();
                                        lbl_Doctor_FnameDisplay.Text = reader["first_name"].ToString();
                                        lbl_Doctor_SnameDisplay.Text = reader["surname"].ToString();
                                        lbl_Doctor_TelNoDisplay.Text = reader["home_number"].ToString();
                                        lbl_PatientIdDisplay.Text = reader["patient_id"].ToString();
                                        lbl_Patient_FnameDisplay.Text = reader["first_name"].ToString();
                                        lbl_Patient_SnameDisplay.Text = reader["surname"].ToString();
                                        lbl_Patient_DOBDisplay.Text = FormatDate(reader["dob"]);
                                        lbl_Patient_WeightDisplay.Text = reader["weight"].ToString();
                                        lbl_Patient_Address1Display.Text = reader["address_1"].ToString();
                                        lbl_Patient_Address2Display.Text = reader["address_2"].ToString();
                                        lbl_Patient_Address3Display.Text = reader["address_3"].ToString();
                                        lbl_patient_TelNoDisplay.Text = reader["home_number"].ToString();
                                        lbl_patient_postcodeDisplay.Text = reader["postcode"].ToString();
                                        lbl_AppointmentDateDisplay.Text = FormatDate(reader["appointment_date"]);
                                        lbl_AppointmentTimeDisplay.Text = FormatTime(reader["appointment_time"]);
                                        txtbxDoctorsNotes.Text = reader["doctors_notes"].ToString();
                                        btn_View_Patients.Visible = false;
                                        break;

                                    default:
                                        throw new ArgumentException("Invalid record type.");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while accessing the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectRowByValue(DataGridView dataGridView, string searchValue)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Selected = true;
                        if (row.Index >= 0 && row.Index < dataGridView.Rows.Count)
                        {
                            dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        }
                        else
                        {
                            MessageBox.Show("Index is out of range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                }
            }
            MessageBox.Show("Value not found in DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void ClearDisplayLabels(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Label label && label.Name.EndsWith("Display"))
                {
                    label.Text = "";
                }
                if (control.HasChildren)
                {
                    ClearDisplayLabels(control.Controls);
                }
            }
        }

        private string FormatDate(object dateObject)
        {
            if (dateObject != DBNull.Value)
            {
                DateTime date = Convert.ToDateTime(dateObject);
                return date.ToString("dd-MM-yyyy");
            }
            return string.Empty;
        }
        private string FormatTime(object timeObject)
        {
            if (timeObject != DBNull.Value)
            {
                DateTime time = Convert.ToDateTime(timeObject);
                return time.ToString("HH:mm");
            }
            return string.Empty;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns.Count > 0 && dataGridView1.Columns.Contains("DOB"))
            {
                if (e.ColumnIndex == dataGridView1.Columns["DOB"].Index)
                {
                    e.Value = FormatDate(e.Value);
                    e.FormattingApplied = true;
                }
                else if (e.ColumnIndex == dataGridView1.Columns.Count - 1 && e.RowIndex >= 0)
                {
                    if (dataGridView1[e.ColumnIndex, e.RowIndex].Value != null &&
                        !string.IsNullOrEmpty(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString()))
                    {
                        string doctorID = dataGridView1[e.ColumnIndex - 1, e.RowIndex].Value.ToString();

                        DataGridView nestedDataGridView = new DataGridView();
                        nestedDataGridView.AutoGenerateColumns = true;
                        nestedDataGridView.Dock = DockStyle.Fill;
                        nestedDataGridView.ReadOnly = true;
                        nestedDataGridView.AllowUserToAddRows = false;

                        PopulateDataGridViewDoctor(sqlite_conn, doctorID, DoctorQuery, RecordType.Doctor);

                        e.Value = nestedDataGridView;
                    }
                    else
                    {
                        e.Value = "No Patients";
                    }
                }
            }

        }

        private SQLiteDataReader GetDataReaderForSelectedRow()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return null;
            }
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            string recordID = selectedRow.Cells[0].Value.ToString();

            RecordType recordType = (RecordType)recordTypeComboBox.SelectedItem;

            SearchRecord(recordType, recordID);

            return null;
        }
        private void RemoveAllColumnsAndRowsFromDataGridView(DataGridView dataGridView)
        {
            while (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns.RemoveAt(0);
            }
            dataGridView.Rows.Clear();
        }
        private void PopulateDataGridViewPatient(SQLiteConnection connection, string recordID, string query, RecordType recordType)
        {
            RemoveAllColumnsAndRowsFromDataGridView(dataGridView1);
            RemoveAllColumnsAndRowsFromDataGridView(dataGridView2);
            dataGridView2.Hide();
            dataGridView1.Show();


            dataGridView1.Columns.Add("PatientID", "Patient ID");
            dataGridView1.Columns.Add("FirstName", "First Name");
            dataGridView1.Columns.Add("LastName", "Last Name");
            dataGridView1.Columns.Add("DOB", "Date of Birth");
            dataGridView1.Columns.Add("Weight", "Weight");
            dataGridView1.Columns.Add("Address1", "Address 1");
            dataGridView1.Columns.Add("Address2", "Address 2");
            dataGridView1.Columns.Add("Address3", "Address 3");
            dataGridView1.Columns.Add("HomeNumber", "Home Number");
            dataGridView1.Columns.Add("Postcode", "Postcode");
            dataGridView1.Columns.Add("DoctorID", "Doctor ID");
            dataGridView1.Columns.Add("DoctorFirstName", "Doctor First Name");
            dataGridView1.Columns.Add("DoctorLastName", "Doctor Last Name");

            bool recordFound = false;

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@recordID", recordID);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        isDataGridViewPopulated[RecordType.Patient] = true;

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["patient_id"].ToString(),
                                reader["first_name"].ToString(),
                                reader["surname"].ToString(),
                                reader["dob"].ToString(),
                                reader["weight"].ToString(),
                                reader["address_1"].ToString(),
                                reader["address_2"].ToString(),
                                reader["address_3"].ToString(),
                                reader["home_number"].ToString(),
                                reader["postcode"].ToString(),
                                reader["doctor_id"].ToString(),
                                reader["d_first_name"].ToString(),
                                reader["d_surname"].ToString()
                            );

                            if (reader["patient_id"].ToString() == recordID)
                            {
                                recordFound = true;
                                SelectRowByValue(dataGridView1, recordID);
                                PopulateLabels(query, RecordType.Patient, recordID);
                            }
                        }

                        if (!recordFound)
                        {
                            MessageBox.Show($"Patient with ID {recordID} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating the DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SubscribeToDataBindingCompleteEvent();
        }

        private void PopulateDataGridViewDoctor(SQLiteConnection connection, string recordID, string query, RecordType recordType)
        {
            RemoveAllColumnsAndRowsFromDataGridView(dataGridView1);
            RemoveAllColumnsAndRowsFromDataGridView(dataGridView2);
            dataGridView2.Hide();
            dataGridView1.Show();


            dataGridView1.Columns.Add("DoctorID", "Doctor ID");
            dataGridView1.Columns.Add("FirstName", "First Name");
            dataGridView1.Columns.Add("LastName", "Last Name");
            dataGridView1.Columns.Add("HomeNumber", "Home Number");

            bool recordFound = false;

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@recordID", recordID);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        isDataGridViewPopulated[RecordType.Doctor] = true;

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["doctor_id"].ToString(),
                                reader["d_first_name"].ToString(),
                                reader["d_surname"].ToString(),
                                reader["d_home_number"].ToString()
                            );

                            if (reader["doctor_id"].ToString() == recordID)
                            {
                                recordFound = true;
                            }
                        }

                        if (recordFound)
                        {
                            SelectRowByValue(dataGridView1, recordID);
                            PopulateLabels(DoctorLabelQuery, RecordType.Doctor, recordID);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating the DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!recordFound)
            {
                MessageBox.Show($"Doctor with ID {recordID} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SubscribeToDataBindingCompleteEvent();
        }

        private void PopulateDataGridViewAppointment(SQLiteConnection connection, string recordID, string query, RecordType recordType)
        {
            RemoveAllColumnsAndRowsFromDataGridView(dataGridView2);
            dataGridView1.Hide();
            dataGridView2.Show();
            dataGridView2.Columns.Add("AppointmentID", "Appointment ID");
            dataGridView2.Columns.Add("AppointmentDate", "Appointment Date");
            dataGridView2.Columns.Add("AppointmentTime", "Appointment Time");
            dataGridView2.Columns.Add("AppointmentDoctorsNotes", "Doctor's Notes");
            dataGridView2.Columns.Add("PatientID", "Patient ID");
            dataGridView2.Columns.Add("FirstName", "First Name");
            dataGridView2.Columns.Add("Surname", "Surname");
            dataGridView2.Columns.Add("DOB", "Date of Birth");
            dataGridView2.Columns.Add("Weight", "Weight");
            dataGridView2.Columns.Add("Address1", "Address Line 1");
            dataGridView2.Columns.Add("Address2", "Address Line 2");
            dataGridView2.Columns.Add("Address3", "Address Line 3");
            dataGridView2.Columns.Add("Postcode", "Postcode");
            dataGridView2.Columns.Add("HomeNumber", "Patient Home Number");
            dataGridView2.Columns.Add("DoctorID", "Doctor ID");
            dataGridView2.Columns.Add("FirstName", "Doctor First Name");
            dataGridView2.Columns.Add("Surname", "Doctor Surname");
            dataGridView2.Columns.Add("HomeNumber", "Doctor Home Number");

            bool recordFound = false;

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@recordID", recordID);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        isDataGridViewPopulated[RecordType.Appointment] = true;

                        while (reader.Read())
                        {
                            dataGridView2.Rows.Add(
                                reader["appointment_id"].ToString(),
                                reader["appointment_date"].ToString(),
                                reader["appointment_time"].ToString(),
                                reader["doctors_notes"].ToString(),
                                reader["patient_id"].ToString(),
                                reader["first_name"].ToString(),
                                reader["surname"].ToString(),
                                reader["dob"].ToString(),
                                reader["weight"].ToString(),
                                reader["address_1"].ToString(),
                                reader["address_2"].ToString(),
                                reader["address_3"].ToString(),
                                reader["postcode"].ToString(),
                                reader["home_number"].ToString(),
                                reader["doctor_id"].ToString(),
                                reader["d_first_name"].ToString(),
                                reader["d_surname"].ToString(),
                                reader["d_home_number"].ToString()
                            );

                            if (reader["appointment_id"].ToString() == recordID)
                            {
                                recordFound = true;
                                SelectRowByValue(dataGridView2, recordID);
                                PopulateLabels(query, RecordType.Appointment, recordID);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating the DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!recordFound)
            {
                MessageBox.Show($"Appointment with ID {recordID} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SubscribeToDataBindingCompleteEvent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell is DataGridViewButtonCell && clickedCell.Value != null && clickedCell.Value.ToString() == "View Patients")
                {
                    DataGridView nestedDataGridView = dataGridView1.Rows[e.RowIndex].Cells["View Patients"].Value as DataGridView;

                    if (nestedDataGridView != null && nestedDataGridView.Rows.Count > 0)
                    {
                        Form nestedForm = new Form();
                        nestedForm.Text = "Patients";
                        nestedForm.Size = new System.Drawing.Size(600, 400);
                        nestedForm.StartPosition = FormStartPosition.CenterScreen;

                        nestedDataGridView.Dock = DockStyle.Fill;

                        nestedForm.Controls.Add(nestedDataGridView);

                        nestedForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No Patients to display.");
                    }
                }
            }
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }
        private Dictionary<RecordType, bool> isDataGridViewPopulated = new Dictionary<RecordType, bool>
        {
            { RecordType.Patient, false },
            { RecordType.Doctor, false },
            { RecordType.Appointment, false }
        };

        //SQLite Queries: 
        string PatientQuery = @"SELECT Patients.*, Doctors.* 
                FROM Patients 
                LEFT JOIN Appointments ON Patients.patient_id = Appointments.patient_id 
                LEFT JOIN Doctors ON Appointments.doctor_id = Doctors.doctor_id 
                ORDER BY 
                    CASE 
                        WHEN Patients.patient_id = @recordID THEN 0 
                        ELSE 1 
                    END";
        string DoctorQuery = @"
                SELECT Doctors.*
                FROM Doctors
                ORDER BY
                    CASE
                        WHEN Doctors.doctor_id = @recordID THEN 0
                        ELSE 1
                    END";
        string AppointmentQuery = @"
                SELECT Appointments.appointment_id, Appointments.appointment_date, Appointments.appointment_time, Appointments.doctors_notes, 
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
                ORDER BY
                CASE
                WHEN Appointments.appointment_id = @recordID THEN 0 
                ELSE 1  
                END;";
        string PatientLabelQuery = @"SELECT Patients.*, Doctors.* 
                        FROM Patients 
                        LEFT JOIN Appointments ON Patients.patient_id = Appointments.patient_id 
                        LEFT JOIN Doctors ON Appointments.doctor_id = Doctors.doctor_id 
                        WHERE Patients.patient_id = @recordID";
        string DoctorLabelQuery = @"
                        SELECT Doctors.*, Patients.*
                        FROM Doctors
                        LEFT JOIN Appointments ON Doctors.doctor_id = Appointments.doctor_id
                        LEFT JOIN Patients ON Patients.patient_id = Appointments.patient_id
                        WHERE Doctors.doctor_id = @recordID";
        string AppointmentLabelQuery = @"SELECT Appointments.*, Doctors.*, Patients.* 
                        FROM Patients 
                        LEFT JOIN Appointments ON Patients.patient_id = Appointments.patient_id 
                        LEFT JOIN Doctors ON Appointments.doctor_id = Doctors.doctor_id 
                        WHERE Patients.patient_id = @recordID";
        private void SearchRecord(RecordType recordType, string recordID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sqlite_conn.ConnectionString))
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    if (connection.State == ConnectionState.Open)
                    {
                        if (!isDataGridViewPopulated.ContainsKey(recordType) || !isDataGridViewPopulated[recordType])
                        {
                            switch (recordType)
                            {
                                case RecordType.Patient:
                                    PopulateDataGridViewPatient(connection, recordID, PatientQuery, recordType);
                                    break;
                                case RecordType.Doctor:
                                    PopulateDataGridViewDoctor(connection, recordID, DoctorQuery, recordType);
                                    break;
                                case RecordType.Appointment:
                                    PopulateDataGridViewAppointment(connection, recordID, AppointmentQuery, recordType);
                                    break;
                                default:
                                    throw new ArgumentException("Invalid record type.");
                            }
                            isDataGridViewPopulated[recordType] = true;
                        }
                        else
                        {
                            switch (recordType)
                            {
                                case RecordType.Patient:
                                    PopulateLabels(PatientLabelQuery, recordType, recordID);
                                    break;
                                case RecordType.Doctor:
                                    PopulateLabels(DoctorLabelQuery, recordType, recordID);
                                    break;
                                case RecordType.Appointment:
                                    PopulateLabels(AppointmentLabelQuery, recordType, recordID);
                                    break;
                            }
                        }
                        if (recordType == RecordType.Patient || recordType == RecordType.Doctor)
                        {
                            SelectRowByValue(dataGridView1, recordID);
                        }
                        else if (recordType == RecordType.Appointment)
                        {
                            SelectRowByValue(dataGridView2, recordID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to open the database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while opening the database connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (string.IsNullOrEmpty(recordID))
            {
                dataGridView1.ClearSelection();
            }
        }

        private void HandleDataGridViewSelectionChange(DataGridView dataGridView, SQLiteConnection connection)
        {
            RecordType recordType = (RecordType)recordTypeComboBox.SelectedItem;

            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                string recordID = dataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (selectedRow != null && selectedRow.Cells.Count > 0 && selectedRow.Cells[0].Value != null)
                {
                    recordID = selectedRow.Cells[0].Value.ToString();

                    bool isAlreadyPopulated = isDataGridViewPopulated[recordType];
                    string tableName = GetTableName(recordType);
                    string filterColumnName = GetFilterColumnName(recordType);

                    if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(filterColumnName))
                    {
                        MessageBox.Show("Invalid record type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    switch (recordType)
                    {
                        case RecordType.Patient:
                            if (!isAlreadyPopulated)
                            {
                                PopulateDataGridViewPatient(connection, recordID, PatientQuery, recordType);
                                isDataGridViewPopulated[RecordType.Patient] = true;
                            }
                            PopulateLabels(PatientLabelQuery, recordType, recordID);
                            break;

                        case RecordType.Doctor:
                            if (!isAlreadyPopulated)
                            {
                                PopulateDataGridViewDoctor(connection, recordID, DoctorQuery, recordType);
                                isDataGridViewPopulated[RecordType.Doctor] = true;
                            }
                            PopulateLabels(DoctorLabelQuery, recordType, recordID);
                            break;

                        case RecordType.Appointment:
                            if (!isAlreadyPopulated)
                            {
                                PopulateDataGridViewAppointment(connection, recordID, AppointmentQuery, recordType);
                                isDataGridViewPopulated[RecordType.Appointment] = true;
                            }
                            PopulateLabels(AppointmentQuery, recordType, recordID);
                            break;

                        default:
                            throw new ArgumentException("Invalid record type.");
                    }
                }
            }
            else
            {
                ClearDisplayLabels(this.Controls);
                if (recordType == RecordType.Patient || recordType == RecordType.Doctor)
                {
                    RemoveAllColumnsAndRowsFromDataGridView(dataGridView1);
                }
                else if (recordType == RecordType.Appointment)
                {
                    RemoveAllColumnsAndRowsFromDataGridView(dataGridView2);
                }
            }
        }


        private string GetTableName(RecordType recordType)
        {
            switch (recordType)
            {
                case RecordType.Patient:
                    return "Patients";
                case RecordType.Doctor:
                    return "Doctors";
                case RecordType.Appointment:
                    return "Appointments";
                default:
                    throw new ArgumentException("Invalid record type.");
            }
        }

        private string GetFilterColumnName(RecordType recordType)
        {
            switch (recordType)
            {
                case RecordType.Patient:
                    return "patient_id";
                case RecordType.Doctor:
                    return "doctor_id";
                case RecordType.Appointment:
                    return "appointment_id";
                default:
                    throw new ArgumentException("Invalid record type.");
            }
        }
        private void SubscribeToDataBindingCompleteEvent()
        {
            dataGridView1.DataBindingComplete += DataGridView_DataBindingComplete;
            dataGridView2.DataBindingComplete += DataGridView_DataBindingComplete;
        }

        private void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            string recordID = tb_IDNumber.Text.Trim();
            SelectRowByValue(dataGridView, recordID);
        }

        private void Btn_Doctor_Maintenance_Click(object sender, EventArgs e)
        {
            if (UserContext.UserType == "1" || UserContext.UserType == "2")
            {
                DoctorMaintenance doctorMaintenanceForm = new DoctorMaintenance(sqlite_conn);
                doctorMaintenanceForm.Show();
            }
            else
            {
                MessageBox.Show("Access Denied: Insufficient Privileges. Your current user level does not grant access to this feature.");
            }
        }

        private void Btn_Patient_Maintenance_Click(object sender, EventArgs e)
        {
            if (UserContext.UserType == "1" || UserContext.UserType == "2" || UserContext.UserType == "3")
            {
                PatientMaintenance patientMaintenanceForm = new PatientMaintenance(sqlite_conn);
                patientMaintenanceForm.Show();
            }
            else
            {
                MessageBox.Show("Access Denied: Insufficient Privileges. Your current user level does not grant access to this feature.");
            }
        }

        private void Btn_Appointment_Maintenance_Click(object sender, EventArgs e)
        {
            if (UserContext.UserType == "1" || UserContext.UserType == "2" || UserContext.UserType == "3" || UserContext.UserType == "4")
            {
                AppointmentMaintenance appointmentMaintenanceForm = new AppointmentMaintenance(sqlite_conn);
                appointmentMaintenanceForm.Show();
            }
            else
            {
                MessageBox.Show("Access Denied: Insufficient Privileges. Your current user level does not grant access to this feature.");
            }
        }

    }
    public enum RecordType
    {
        Patient,
        Doctor,
        Appointment,
    }

}