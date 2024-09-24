namespace Software_Project
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabcontrol_1 = new TabControl();
            tab_Login = new TabPage();
            btn_ForgotPassword = new Button();
            btn_login = new Button();
            tb_password = new TextBox();
            lbl_Password = new Label();
            lbl_username = new Label();
            tb_username = new TextBox();
            tab_home = new TabPage();
            txtbxDoctorsNotes = new TextBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            Btn_Appointment_Maintenance = new Button();
            Btn_Patient_Maintenance = new Button();
            Btn_Doctor_Maintenance = new Button();
            btn_View_Patients = new Button();
            lbl_AppointmentTimeDisplay = new Label();
            lbl_ = new Label();
            lbl_AppointmentDateDisplay = new Label();
            lbl_AppointmentIDDisplay = new Label();
            btn_Arrow_Down = new Button();
            btn_Arrow_Up = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            lbl_Doctor_TelNoDisplay = new Label();
            lbl_Doctor_SnameDisplay = new Label();
            lbl_Doctor_FnameDisplay = new Label();
            lbl_DoctorIDDisplay = new Label();
            lbl_patient_postcodeDisplay = new Label();
            lbl_patient_TelNoDisplay = new Label();
            lbl_Patient_Address3Display = new Label();
            lbl_Patient_Address2Display = new Label();
            lbl_Patient_Address1Display = new Label();
            lbl_Patient_WeightDisplay = new Label();
            lbl_Patient_DOBDisplay = new Label();
            lbl_Patient_SnameDisplay = new Label();
            lbl_Patient_FnameDisplay = new Label();
            lbl_PatientIdDisplay = new Label();
            lblRecordType = new Label();
            recordTypeComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            lbl_date = new Label();
            lbl_appointmentID = new Label();
            lbl_appointmentinfo = new Label();
            btn_Logout = new Button();
            btn_Save = new Button();
            lbl_patient_postcode = new Label();
            lbl_patient_TelNo = new Label();
            lbl_Patient_Address3 = new Label();
            lbl_Patient_Address2 = new Label();
            lbl_Patient_Address1 = new Label();
            lbl_Patient_Weight = new Label();
            lbl_Patient_DOB = new Label();
            lbl_Patient_Sname = new Label();
            lbl_Patient_Fname = new Label();
            lbl_PatientID = new Label();
            lbl_PatientInfo = new Label();
            lbl_Doctor_TelNo = new Label();
            lbl_Doctor_Sname = new Label();
            lbl_Doctor_Fname = new Label();
            lbl_DoctorID = new Label();
            lbl_doctorInfo = new Label();
            btn_Search = new Button();
            tb_IDNumber = new TextBox();
            lbl_IDNumber = new Label();
            tab_PasswordReset = new TabPage();
            tabcontrol_1.SuspendLayout();
            tab_Login.SuspendLayout();
            tab_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabcontrol_1
            // 
            tabcontrol_1.Controls.Add(tab_Login);
            tabcontrol_1.Controls.Add(tab_home);
            tabcontrol_1.Controls.Add(tab_PasswordReset);
            tabcontrol_1.Dock = DockStyle.Fill;
            tabcontrol_1.Location = new Point(0, 0);
            tabcontrol_1.Name = "tabcontrol_1";
            tabcontrol_1.SelectedIndex = 0;
            tabcontrol_1.Size = new Size(1267, 1055);
            tabcontrol_1.TabIndex = 6;
            // 
            // tab_Login
            // 
            tab_Login.Controls.Add(btn_ForgotPassword);
            tab_Login.Controls.Add(btn_login);
            tab_Login.Controls.Add(tb_password);
            tab_Login.Controls.Add(lbl_Password);
            tab_Login.Controls.Add(lbl_username);
            tab_Login.Controls.Add(tb_username);
            tab_Login.Location = new Point(4, 29);
            tab_Login.Name = "tab_Login";
            tab_Login.Size = new Size(1259, 1022);
            tab_Login.TabIndex = 0;
            tab_Login.Text = "Login";
            tab_Login.UseVisualStyleBackColor = true;
            // 
            // btn_ForgotPassword
            // 
            btn_ForgotPassword.Location = new Point(326, 311);
            btn_ForgotPassword.Name = "btn_ForgotPassword";
            btn_ForgotPassword.Size = new Size(141, 29);
            btn_ForgotPassword.TabIndex = 11;
            btn_ForgotPassword.Text = "Forgot password?";
            btn_ForgotPassword.UseVisualStyleBackColor = true;
            btn_ForgotPassword.Click += btn_ForgotPassword_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(326, 258);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(141, 29);
            btn_login.TabIndex = 10;
            btn_login.Text = "Log in";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(326, 197);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(141, 27);
            tb_password.TabIndex = 9;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(354, 158);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(73, 20);
            lbl_Password.TabIndex = 8;
            lbl_Password.Text = "Password:";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(354, 77);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(78, 20);
            lbl_username.TabIndex = 7;
            lbl_username.Text = "Username:";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(326, 113);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(141, 27);
            tb_username.TabIndex = 6;
            // 
            // tab_home
            // 
            tab_home.Controls.Add(txtbxDoctorsNotes);
            tab_home.Controls.Add(dataGridView2);
            tab_home.Controls.Add(Btn_Appointment_Maintenance);
            tab_home.Controls.Add(Btn_Patient_Maintenance);
            tab_home.Controls.Add(Btn_Doctor_Maintenance);
            tab_home.Controls.Add(btn_View_Patients);
            tab_home.Controls.Add(lbl_AppointmentTimeDisplay);
            tab_home.Controls.Add(lbl_);
            tab_home.Controls.Add(lbl_AppointmentDateDisplay);
            tab_home.Controls.Add(lbl_AppointmentIDDisplay);
            tab_home.Controls.Add(btn_Arrow_Down);
            tab_home.Controls.Add(btn_Arrow_Up);
            tab_home.Controls.Add(dataGridView1);
            tab_home.Controls.Add(lbl_Doctor_TelNoDisplay);
            tab_home.Controls.Add(lbl_Doctor_SnameDisplay);
            tab_home.Controls.Add(lbl_Doctor_FnameDisplay);
            tab_home.Controls.Add(lbl_DoctorIDDisplay);
            tab_home.Controls.Add(lbl_patient_postcodeDisplay);
            tab_home.Controls.Add(lbl_patient_TelNoDisplay);
            tab_home.Controls.Add(lbl_Patient_Address3Display);
            tab_home.Controls.Add(lbl_Patient_Address2Display);
            tab_home.Controls.Add(lbl_Patient_Address1Display);
            tab_home.Controls.Add(lbl_Patient_WeightDisplay);
            tab_home.Controls.Add(lbl_Patient_DOBDisplay);
            tab_home.Controls.Add(lbl_Patient_SnameDisplay);
            tab_home.Controls.Add(lbl_Patient_FnameDisplay);
            tab_home.Controls.Add(lbl_PatientIdDisplay);
            tab_home.Controls.Add(lblRecordType);
            tab_home.Controls.Add(recordTypeComboBox);
            tab_home.Controls.Add(label2);
            tab_home.Controls.Add(label1);
            tab_home.Controls.Add(lbl_date);
            tab_home.Controls.Add(lbl_appointmentID);
            tab_home.Controls.Add(lbl_appointmentinfo);
            tab_home.Controls.Add(btn_Logout);
            tab_home.Controls.Add(btn_Save);
            tab_home.Controls.Add(lbl_patient_postcode);
            tab_home.Controls.Add(lbl_patient_TelNo);
            tab_home.Controls.Add(lbl_Patient_Address3);
            tab_home.Controls.Add(lbl_Patient_Address2);
            tab_home.Controls.Add(lbl_Patient_Address1);
            tab_home.Controls.Add(lbl_Patient_Weight);
            tab_home.Controls.Add(lbl_Patient_DOB);
            tab_home.Controls.Add(lbl_Patient_Sname);
            tab_home.Controls.Add(lbl_Patient_Fname);
            tab_home.Controls.Add(lbl_PatientID);
            tab_home.Controls.Add(lbl_PatientInfo);
            tab_home.Controls.Add(lbl_Doctor_TelNo);
            tab_home.Controls.Add(lbl_Doctor_Sname);
            tab_home.Controls.Add(lbl_Doctor_Fname);
            tab_home.Controls.Add(lbl_DoctorID);
            tab_home.Controls.Add(lbl_doctorInfo);
            tab_home.Controls.Add(btn_Search);
            tab_home.Controls.Add(tb_IDNumber);
            tab_home.Controls.Add(lbl_IDNumber);
            tab_home.Location = new Point(4, 29);
            tab_home.Name = "tab_home";
            tab_home.Size = new Size(1259, 1022);
            tab_home.TabIndex = 1;
            tab_home.Text = "Home";
            tab_home.UseVisualStyleBackColor = true;
            // 
            // txtbxDoctorsNotes
            // 
            txtbxDoctorsNotes.Location = new Point(402, 328);
            txtbxDoctorsNotes.Multiline = true;
            txtbxDoctorsNotes.Name = "txtbxDoctorsNotes";
            txtbxDoctorsNotes.Size = new Size(320, 151);
            txtbxDoctorsNotes.TabIndex = 72;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dataGridView2.Location = new Point(41, 661);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(952, 304);
            dataGridView2.TabIndex = 71;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Column1";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Column2";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Column3";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Column4";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Column5";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Column6";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Column7";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Column8";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Column9";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Column10";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // Btn_Appointment_Maintenance
            // 
            Btn_Appointment_Maintenance.Location = new Point(1058, 460);
            Btn_Appointment_Maintenance.Name = "Btn_Appointment_Maintenance";
            Btn_Appointment_Maintenance.Size = new Size(176, 68);
            Btn_Appointment_Maintenance.TabIndex = 70;
            Btn_Appointment_Maintenance.Text = "Appointment Maintenance";
            Btn_Appointment_Maintenance.UseVisualStyleBackColor = true;
            Btn_Appointment_Maintenance.Click += Btn_Appointment_Maintenance_Click;
            // 
            // Btn_Patient_Maintenance
            // 
            Btn_Patient_Maintenance.Location = new Point(1058, 370);
            Btn_Patient_Maintenance.Name = "Btn_Patient_Maintenance";
            Btn_Patient_Maintenance.Size = new Size(176, 68);
            Btn_Patient_Maintenance.TabIndex = 69;
            Btn_Patient_Maintenance.Text = "Patient Maintenance";
            Btn_Patient_Maintenance.UseVisualStyleBackColor = true;
            Btn_Patient_Maintenance.Click += Btn_Patient_Maintenance_Click;
            // 
            // Btn_Doctor_Maintenance
            // 
            Btn_Doctor_Maintenance.Location = new Point(1058, 286);
            Btn_Doctor_Maintenance.Name = "Btn_Doctor_Maintenance";
            Btn_Doctor_Maintenance.Size = new Size(176, 68);
            Btn_Doctor_Maintenance.TabIndex = 68;
            Btn_Doctor_Maintenance.Text = "Doctor Maintenance";
            Btn_Doctor_Maintenance.UseVisualStyleBackColor = true;
            Btn_Doctor_Maintenance.Click += Btn_Doctor_Maintenance_Click;
            // 
            // btn_View_Patients
            // 
            btn_View_Patients.Location = new Point(1058, 553);
            btn_View_Patients.Name = "btn_View_Patients";
            btn_View_Patients.Size = new Size(176, 55);
            btn_View_Patients.TabIndex = 67;
            btn_View_Patients.Text = "View Patients";
            btn_View_Patients.UseVisualStyleBackColor = true;
            btn_View_Patients.Click += btn_View_Patients_Click;
            // 
            // lbl_AppointmentTimeDisplay
            // 
            lbl_AppointmentTimeDisplay.AutoSize = true;
            lbl_AppointmentTimeDisplay.Location = new Point(537, 215);
            lbl_AppointmentTimeDisplay.Name = "lbl_AppointmentTimeDisplay";
            lbl_AppointmentTimeDisplay.Size = new Size(0, 20);
            lbl_AppointmentTimeDisplay.TabIndex = 66;
            // 
            // lbl_
            // 
            lbl_.AutoSize = true;
            lbl_.Location = new Point(537, 215);
            lbl_.Name = "lbl_";
            lbl_.Size = new Size(0, 20);
            lbl_.TabIndex = 65;
            // 
            // lbl_AppointmentDateDisplay
            // 
            lbl_AppointmentDateDisplay.AutoSize = true;
            lbl_AppointmentDateDisplay.Location = new Point(537, 174);
            lbl_AppointmentDateDisplay.Name = "lbl_AppointmentDateDisplay";
            lbl_AppointmentDateDisplay.Size = new Size(0, 20);
            lbl_AppointmentDateDisplay.TabIndex = 64;
            // 
            // lbl_AppointmentIDDisplay
            // 
            lbl_AppointmentIDDisplay.AutoSize = true;
            lbl_AppointmentIDDisplay.Location = new Point(537, 144);
            lbl_AppointmentIDDisplay.Name = "lbl_AppointmentIDDisplay";
            lbl_AppointmentIDDisplay.Size = new Size(0, 20);
            lbl_AppointmentIDDisplay.TabIndex = 63;
            // 
            // btn_Arrow_Down
            // 
            btn_Arrow_Down.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Arrow_Down.Location = new Point(1044, 818);
            btn_Arrow_Down.Name = "btn_Arrow_Down";
            btn_Arrow_Down.Size = new Size(94, 65);
            btn_Arrow_Down.TabIndex = 61;
            btn_Arrow_Down.Text = "🔽";
            btn_Arrow_Down.UseVisualStyleBackColor = true;
            btn_Arrow_Down.Click += btn_Arrow_Down_Click_1;
            // 
            // btn_Arrow_Up
            // 
            btn_Arrow_Up.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Arrow_Up.Location = new Point(1044, 747);
            btn_Arrow_Up.Name = "btn_Arrow_Up";
            btn_Arrow_Up.Size = new Size(94, 65);
            btn_Arrow_Up.TabIndex = 60;
            btn_Arrow_Up.Text = "🔼";
            btn_Arrow_Up.UseVisualStyleBackColor = true;
            btn_Arrow_Up.Click += btn_Arrow_Up_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(41, 661);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(952, 304);
            dataGridView1.TabIndex = 58;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Column8";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Column9";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Column10";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // lbl_Doctor_TelNoDisplay
            // 
            lbl_Doctor_TelNoDisplay.AutoSize = true;
            lbl_Doctor_TelNoDisplay.Location = new Point(168, 239);
            lbl_Doctor_TelNoDisplay.Name = "lbl_Doctor_TelNoDisplay";
            lbl_Doctor_TelNoDisplay.Size = new Size(0, 20);
            lbl_Doctor_TelNoDisplay.TabIndex = 55;
            // 
            // lbl_Doctor_SnameDisplay
            // 
            lbl_Doctor_SnameDisplay.AutoSize = true;
            lbl_Doctor_SnameDisplay.Location = new Point(168, 208);
            lbl_Doctor_SnameDisplay.Name = "lbl_Doctor_SnameDisplay";
            lbl_Doctor_SnameDisplay.Size = new Size(0, 20);
            lbl_Doctor_SnameDisplay.TabIndex = 54;
            // 
            // lbl_Doctor_FnameDisplay
            // 
            lbl_Doctor_FnameDisplay.AutoSize = true;
            lbl_Doctor_FnameDisplay.Location = new Point(168, 174);
            lbl_Doctor_FnameDisplay.Name = "lbl_Doctor_FnameDisplay";
            lbl_Doctor_FnameDisplay.Size = new Size(0, 20);
            lbl_Doctor_FnameDisplay.TabIndex = 53;
            // 
            // lbl_DoctorIDDisplay
            // 
            lbl_DoctorIDDisplay.AutoSize = true;
            lbl_DoctorIDDisplay.Location = new Point(168, 144);
            lbl_DoctorIDDisplay.Name = "lbl_DoctorIDDisplay";
            lbl_DoctorIDDisplay.Size = new Size(0, 20);
            lbl_DoctorIDDisplay.TabIndex = 52;
            // 
            // lbl_patient_postcodeDisplay
            // 
            lbl_patient_postcodeDisplay.AutoSize = true;
            lbl_patient_postcodeDisplay.Location = new Point(168, 619);
            lbl_patient_postcodeDisplay.Name = "lbl_patient_postcodeDisplay";
            lbl_patient_postcodeDisplay.Size = new Size(0, 20);
            lbl_patient_postcodeDisplay.TabIndex = 51;
            // 
            // lbl_patient_TelNoDisplay
            // 
            lbl_patient_TelNoDisplay.AutoSize = true;
            lbl_patient_TelNoDisplay.Location = new Point(168, 588);
            lbl_patient_TelNoDisplay.Name = "lbl_patient_TelNoDisplay";
            lbl_patient_TelNoDisplay.Size = new Size(0, 20);
            lbl_patient_TelNoDisplay.TabIndex = 50;
            // 
            // lbl_Patient_Address3Display
            // 
            lbl_Patient_Address3Display.AutoSize = true;
            lbl_Patient_Address3Display.Location = new Point(168, 556);
            lbl_Patient_Address3Display.Name = "lbl_Patient_Address3Display";
            lbl_Patient_Address3Display.Size = new Size(0, 20);
            lbl_Patient_Address3Display.TabIndex = 49;
            // 
            // lbl_Patient_Address2Display
            // 
            lbl_Patient_Address2Display.AutoSize = true;
            lbl_Patient_Address2Display.Location = new Point(168, 524);
            lbl_Patient_Address2Display.Name = "lbl_Patient_Address2Display";
            lbl_Patient_Address2Display.Size = new Size(0, 20);
            lbl_Patient_Address2Display.TabIndex = 48;
            // 
            // lbl_Patient_Address1Display
            // 
            lbl_Patient_Address1Display.AutoSize = true;
            lbl_Patient_Address1Display.Location = new Point(168, 493);
            lbl_Patient_Address1Display.Name = "lbl_Patient_Address1Display";
            lbl_Patient_Address1Display.Size = new Size(0, 20);
            lbl_Patient_Address1Display.TabIndex = 47;
            // 
            // lbl_Patient_WeightDisplay
            // 
            lbl_Patient_WeightDisplay.AutoSize = true;
            lbl_Patient_WeightDisplay.Location = new Point(168, 459);
            lbl_Patient_WeightDisplay.Name = "lbl_Patient_WeightDisplay";
            lbl_Patient_WeightDisplay.Size = new Size(0, 20);
            lbl_Patient_WeightDisplay.TabIndex = 46;
            // 
            // lbl_Patient_DOBDisplay
            // 
            lbl_Patient_DOBDisplay.AutoSize = true;
            lbl_Patient_DOBDisplay.Location = new Point(168, 426);
            lbl_Patient_DOBDisplay.Name = "lbl_Patient_DOBDisplay";
            lbl_Patient_DOBDisplay.Size = new Size(0, 20);
            lbl_Patient_DOBDisplay.TabIndex = 45;
            // 
            // lbl_Patient_SnameDisplay
            // 
            lbl_Patient_SnameDisplay.AutoSize = true;
            lbl_Patient_SnameDisplay.Location = new Point(168, 394);
            lbl_Patient_SnameDisplay.Name = "lbl_Patient_SnameDisplay";
            lbl_Patient_SnameDisplay.Size = new Size(0, 20);
            lbl_Patient_SnameDisplay.TabIndex = 44;
            // 
            // lbl_Patient_FnameDisplay
            // 
            lbl_Patient_FnameDisplay.AutoSize = true;
            lbl_Patient_FnameDisplay.Location = new Point(168, 362);
            lbl_Patient_FnameDisplay.Name = "lbl_Patient_FnameDisplay";
            lbl_Patient_FnameDisplay.Size = new Size(0, 20);
            lbl_Patient_FnameDisplay.TabIndex = 43;
            // 
            // lbl_PatientIdDisplay
            // 
            lbl_PatientIdDisplay.AutoSize = true;
            lbl_PatientIdDisplay.Location = new Point(168, 325);
            lbl_PatientIdDisplay.Name = "lbl_PatientIdDisplay";
            lbl_PatientIdDisplay.Size = new Size(0, 20);
            lbl_PatientIdDisplay.TabIndex = 42;
            // 
            // lblRecordType
            // 
            lblRecordType.AutoSize = true;
            lblRecordType.Location = new Point(19, 55);
            lblRecordType.Name = "lblRecordType";
            lblRecordType.Size = new Size(92, 20);
            lblRecordType.TabIndex = 41;
            lblRecordType.Text = "Record type:";
            // 
            // recordTypeComboBox
            // 
            recordTypeComboBox.FormattingEnabled = true;
            recordTypeComboBox.Location = new Point(120, 52);
            recordTypeComboBox.Name = "recordTypeComboBox";
            recordTypeComboBox.Size = new Size(125, 28);
            recordTypeComboBox.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(402, 285);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 38;
            label2.Text = "Doctor's Notes:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 215);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 28;
            label1.Text = "Time:";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(402, 177);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(44, 20);
            lbl_date.TabIndex = 25;
            lbl_date.Text = "Date:";
            // 
            // lbl_appointmentID
            // 
            lbl_appointmentID.AutoSize = true;
            lbl_appointmentID.Location = new Point(402, 144);
            lbl_appointmentID.Name = "lbl_appointmentID";
            lbl_appointmentID.Size = new Size(119, 20);
            lbl_appointmentID.TabIndex = 24;
            lbl_appointmentID.Text = "Appointment ID:";
            // 
            // lbl_appointmentinfo
            // 
            lbl_appointmentinfo.AutoSize = true;
            lbl_appointmentinfo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_appointmentinfo.Location = new Point(402, 104);
            lbl_appointmentinfo.Name = "lbl_appointmentinfo";
            lbl_appointmentinfo.Size = new Size(230, 25);
            lbl_appointmentinfo.TabIndex = 23;
            lbl_appointmentinfo.Text = "Appointment Information:";
            // 
            // btn_Logout
            // 
            btn_Logout.Location = new Point(136, 971);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(94, 32);
            btn_Logout.TabIndex = 22;
            btn_Logout.Text = "Log out";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(24, 971);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(94, 32);
            btn_Save.TabIndex = 21;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // lbl_patient_postcode
            // 
            lbl_patient_postcode.AutoSize = true;
            lbl_patient_postcode.Location = new Point(40, 619);
            lbl_patient_postcode.Name = "lbl_patient_postcode";
            lbl_patient_postcode.Size = new Size(72, 20);
            lbl_patient_postcode.TabIndex = 20;
            lbl_patient_postcode.Text = "Postcode:";
            // 
            // lbl_patient_TelNo
            // 
            lbl_patient_TelNo.AutoSize = true;
            lbl_patient_TelNo.Location = new Point(41, 588);
            lbl_patient_TelNo.Name = "lbl_patient_TelNo";
            lbl_patient_TelNo.Size = new Size(72, 20);
            lbl_patient_TelNo.TabIndex = 19;
            lbl_patient_TelNo.Text = "H-Tel No:";
            // 
            // lbl_Patient_Address3
            // 
            lbl_Patient_Address3.AutoSize = true;
            lbl_Patient_Address3.Location = new Point(41, 556);
            lbl_Patient_Address3.Name = "lbl_Patient_Address3";
            lbl_Patient_Address3.Size = new Size(108, 20);
            lbl_Patient_Address3.TabIndex = 18;
            lbl_Patient_Address3.Text = "Address Line 3:";
            // 
            // lbl_Patient_Address2
            // 
            lbl_Patient_Address2.AutoSize = true;
            lbl_Patient_Address2.Location = new Point(41, 524);
            lbl_Patient_Address2.Name = "lbl_Patient_Address2";
            lbl_Patient_Address2.Size = new Size(108, 20);
            lbl_Patient_Address2.TabIndex = 17;
            lbl_Patient_Address2.Text = "Address Line 2:";
            // 
            // lbl_Patient_Address1
            // 
            lbl_Patient_Address1.AutoSize = true;
            lbl_Patient_Address1.Location = new Point(41, 493);
            lbl_Patient_Address1.Name = "lbl_Patient_Address1";
            lbl_Patient_Address1.Size = new Size(108, 20);
            lbl_Patient_Address1.TabIndex = 16;
            lbl_Patient_Address1.Text = "Address Line 1:";
            // 
            // lbl_Patient_Weight
            // 
            lbl_Patient_Weight.AutoSize = true;
            lbl_Patient_Weight.Location = new Point(41, 459);
            lbl_Patient_Weight.Name = "lbl_Patient_Weight";
            lbl_Patient_Weight.Size = new Size(89, 20);
            lbl_Patient_Weight.TabIndex = 15;
            lbl_Patient_Weight.Text = "Weight (kg):";
            // 
            // lbl_Patient_DOB
            // 
            lbl_Patient_DOB.AutoSize = true;
            lbl_Patient_DOB.Location = new Point(41, 426);
            lbl_Patient_DOB.Name = "lbl_Patient_DOB";
            lbl_Patient_DOB.Size = new Size(97, 20);
            lbl_Patient_DOB.TabIndex = 14;
            lbl_Patient_DOB.Text = "Date of Birth:";
            // 
            // lbl_Patient_Sname
            // 
            lbl_Patient_Sname.AutoSize = true;
            lbl_Patient_Sname.Location = new Point(41, 394);
            lbl_Patient_Sname.Name = "lbl_Patient_Sname";
            lbl_Patient_Sname.Size = new Size(70, 20);
            lbl_Patient_Sname.TabIndex = 13;
            lbl_Patient_Sname.Text = "Surname:";
            // 
            // lbl_Patient_Fname
            // 
            lbl_Patient_Fname.AutoSize = true;
            lbl_Patient_Fname.Location = new Point(41, 362);
            lbl_Patient_Fname.Name = "lbl_Patient_Fname";
            lbl_Patient_Fname.Size = new Size(76, 20);
            lbl_Patient_Fname.TabIndex = 12;
            lbl_Patient_Fname.Text = "Firstname:";
            // 
            // lbl_PatientID
            // 
            lbl_PatientID.AutoSize = true;
            lbl_PatientID.Location = new Point(41, 328);
            lbl_PatientID.Name = "lbl_PatientID";
            lbl_PatientID.Size = new Size(76, 20);
            lbl_PatientID.TabIndex = 11;
            lbl_PatientID.Text = "Patient ID:";
            // 
            // lbl_PatientInfo
            // 
            lbl_PatientInfo.AutoSize = true;
            lbl_PatientInfo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_PatientInfo.Location = new Point(40, 285);
            lbl_PatientInfo.Name = "lbl_PatientInfo";
            lbl_PatientInfo.Size = new Size(178, 25);
            lbl_PatientInfo.TabIndex = 10;
            lbl_PatientInfo.Text = "Patient Information:";
            // 
            // lbl_Doctor_TelNo
            // 
            lbl_Doctor_TelNo.AutoSize = true;
            lbl_Doctor_TelNo.Location = new Point(41, 239);
            lbl_Doctor_TelNo.Name = "lbl_Doctor_TelNo";
            lbl_Doctor_TelNo.Size = new Size(72, 20);
            lbl_Doctor_TelNo.TabIndex = 7;
            lbl_Doctor_TelNo.Text = "H-Tel No:";
            // 
            // lbl_Doctor_Sname
            // 
            lbl_Doctor_Sname.AutoSize = true;
            lbl_Doctor_Sname.Location = new Point(41, 208);
            lbl_Doctor_Sname.Name = "lbl_Doctor_Sname";
            lbl_Doctor_Sname.Size = new Size(70, 20);
            lbl_Doctor_Sname.TabIndex = 6;
            lbl_Doctor_Sname.Text = "Surname:";
            // 
            // lbl_Doctor_Fname
            // 
            lbl_Doctor_Fname.AutoSize = true;
            lbl_Doctor_Fname.Location = new Point(41, 174);
            lbl_Doctor_Fname.Name = "lbl_Doctor_Fname";
            lbl_Doctor_Fname.Size = new Size(76, 20);
            lbl_Doctor_Fname.TabIndex = 5;
            lbl_Doctor_Fname.Text = "Firstname:";
            // 
            // lbl_DoctorID
            // 
            lbl_DoctorID.AutoSize = true;
            lbl_DoctorID.Location = new Point(41, 144);
            lbl_DoctorID.Name = "lbl_DoctorID";
            lbl_DoctorID.Size = new Size(77, 20);
            lbl_DoctorID.TabIndex = 4;
            lbl_DoctorID.Text = "Doctor ID:";
            // 
            // lbl_doctorInfo
            // 
            lbl_doctorInfo.AutoSize = true;
            lbl_doctorInfo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_doctorInfo.Location = new Point(41, 104);
            lbl_doctorInfo.Name = "lbl_doctorInfo";
            lbl_doctorInfo.Size = new Size(177, 25);
            lbl_doctorInfo.TabIndex = 3;
            lbl_doctorInfo.Text = "Doctor Information:";
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(251, 19);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(94, 61);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // tb_IDNumber
            // 
            tb_IDNumber.Location = new Point(120, 19);
            tb_IDNumber.Name = "tb_IDNumber";
            tb_IDNumber.Size = new Size(125, 27);
            tb_IDNumber.TabIndex = 1;
            // 
            // lbl_IDNumber
            // 
            lbl_IDNumber.AutoSize = true;
            lbl_IDNumber.Location = new Point(19, 19);
            lbl_IDNumber.Name = "lbl_IDNumber";
            lbl_IDNumber.Size = new Size(85, 20);
            lbl_IDNumber.TabIndex = 0;
            lbl_IDNumber.Text = "ID Number:";
            // 
            // tab_PasswordReset
            // 
            tab_PasswordReset.Location = new Point(4, 29);
            tab_PasswordReset.Name = "tab_PasswordReset";
            tab_PasswordReset.Size = new Size(1259, 1022);
            tab_PasswordReset.TabIndex = 2;
            tab_PasswordReset.Text = "PasswordReset";
            tab_PasswordReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 1055);
            Controls.Add(tabcontrol_1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabcontrol_1.ResumeLayout(false);
            tab_Login.ResumeLayout(false);
            tab_Login.PerformLayout();
            tab_home.ResumeLayout(false);
            tab_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabcontrol_1;
        private TabPage tab_Login;
        private Button btn_ForgotPassword;
        private Button btn_login;
        private TextBox tb_password;
        private Label lbl_Password;
        private Label lbl_username;
        private TextBox tb_username;
        private TabPage tab_home;
        private TabPage tab_PasswordReset;
        private Label lbl_DoctorID;
        private Label lbl_doctorInfo;
        private Button btn_Search;
        private TextBox tb_IDNumber;
        private Label lbl_IDNumber;
        private Label lbl_Doctor_TelNo;
        private Label lbl_Doctor_Sname;
        private Label lbl_Doctor_Fname;
        private Label lbl_PatientID;
        private Label lbl_PatientInfo;
        private Label lbl_Patient_Sname;
        private Label lbl_Patient_Fname;
        private Label lbl_Patient_Address3;
        private Label lbl_Patient_Address2;
        private Label lbl_Patient_Address1;
        private Label lbl_Patient_Weight;
        private Label lbl_Patient_DOB;
        private Label lbl_patient_TelNo;
        private Button btn_Logout;
        private Button btn_Save;
        private Label lbl_patient_postcode;
        private DateTimePicker dateTimePicker1;
        private Label lbl_date;
        private Label lbl_appointmentID;
        private Label lbl_appointmentinfo;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private ComboBox recordTypeComboBox;
        private Label lblRecordType;
        private Label lbl_Patient_SnameDisplay;
        private Label lbl_Patient_FnameDisplay;
        private Label lbl_PatientIdDisplay;
        private Label lbl_patient_postcodeDisplay;
        private Label lbl_patient_TelNoDisplay;
        private Label lbl_Patient_Address3Display;
        private Label lbl_Patient_Address2Display;
        private Label lbl_Patient_Address1Display;
        private Label lbl_Patient_WeightDisplay;
        private Label lbl_Patient_DOBDisplay;
        private Label lbl_DoctorIDDisplay;
        private Label lbl_Doctor_TelNoDisplay;
        private Label lbl_Doctor_SnameDisplay;
        private Label lbl_Doctor_FnameDisplay;
        private DataGridView dataGridView1;
        private Button btn_Arrow_Down;
        private Button btn_Arrow_Up;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Label lbl_AppointmentIDDisplay;
        private Label label3;
        private Label lbl;
        private Label label4;
        private Label lbl_;
        private Label lbl_AppointmentDateDisplay;
        private Label lbl_AppointmentTimeDisplay;
        private Button btn_View_Patients;
        private Button Btn_Appointment_Maintenance;
        private Button Btn_Patient_Maintenance;
        private Button Btn_Doctor_Maintenance;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Label lblDoctorsNotes;
        private TextBox txtbxDoctorsNotes;
    }
}