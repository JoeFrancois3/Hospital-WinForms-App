using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Software_Project
{
    partial class Add_Edit_Appointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_AppointmentTimeDisplay = new Label();
            lbl_AppointmentDateDisplay = new Label();
            lbl_AppointmentID = new Label();
            lbl_Appointment_patientInfo = new Label();
            txtbx_AppointmentTimeDisplay = new TextBox();
            txtbx_AppointmentDateDisplay = new TextBox();
            txtbx_Appointment_ID = new TextBox();
            btn_Appointment_OK = new Button();
            btn_Appointment_Cancel = new Button();
            txtbx_Appointment_Patient_Address2 = new TextBox();
            lblAdd_Edit_Appointment = new Label();
            combobx_Doctor = new ComboBox();
            combobx_Patient = new ComboBox();
            lbl_Doctor = new Label();
            lbl_Patient = new Label();
            SuspendLayout();
            // 
            // lbl_AppointmentTimeDisplay
            // 
            lbl_AppointmentTimeDisplay.AutoSize = true;
            lbl_AppointmentTimeDisplay.Location = new Point(98, 234);
            lbl_AppointmentTimeDisplay.Name = "lbl_AppointmentTimeDisplay";
            lbl_AppointmentTimeDisplay.Size = new Size(128, 20);
            lbl_AppointmentTimeDisplay.TabIndex = 11;
            lbl_AppointmentTimeDisplay.Text = "Appintment Time:";
            // 
            // lbl_AppointmentDateDisplay
            // 
            lbl_AppointmentDateDisplay.AutoSize = true;
            lbl_AppointmentDateDisplay.Location = new Point(98, 183);
            lbl_AppointmentDateDisplay.Name = "lbl_AppointmentDateDisplay";
            lbl_AppointmentDateDisplay.Size = new Size(136, 20);
            lbl_AppointmentDateDisplay.TabIndex = 10;
            lbl_AppointmentDateDisplay.Text = "Appointment Date:";
            // 
            // lbl_AppointmentID
            // 
            lbl_AppointmentID.AutoSize = true;
            lbl_AppointmentID.Location = new Point(98, 136);
            lbl_AppointmentID.Name = "lbl_AppointmentID";
            lbl_AppointmentID.Size = new Size(119, 20);
            lbl_AppointmentID.TabIndex = 9;
            lbl_AppointmentID.Text = "Appointment ID:";
            // 
            // lbl_Appointment_patientInfo
            // 
            lbl_Appointment_patientInfo.AutoSize = true;
            lbl_Appointment_patientInfo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Appointment_patientInfo.Location = new Point(96, 109);
            lbl_Appointment_patientInfo.Name = "lbl_Appointment_patientInfo";
            lbl_Appointment_patientInfo.Size = new Size(0, 25);
            lbl_Appointment_patientInfo.TabIndex = 8;
            // 
            // txtbx_AppointmentTimeDisplay
            // 
            txtbx_AppointmentTimeDisplay.Location = new Point(325, 227);
            txtbx_AppointmentTimeDisplay.Name = "txtbx_AppointmentTimeDisplay";
            txtbx_AppointmentTimeDisplay.Size = new Size(125, 27);
            txtbx_AppointmentTimeDisplay.TabIndex = 15;
            // 
            // txtbx_AppointmentDateDisplay
            // 
            txtbx_AppointmentDateDisplay.Location = new Point(325, 176);
            txtbx_AppointmentDateDisplay.Name = "txtbx_AppointmentDateDisplay";
            txtbx_AppointmentDateDisplay.Size = new Size(125, 27);
            txtbx_AppointmentDateDisplay.TabIndex = 14;
            // 
            // txtbx_Appointment_ID
            // 
            txtbx_Appointment_ID.Location = new Point(325, 129);
            txtbx_Appointment_ID.Name = "txtbx_Appointment_ID";
            txtbx_Appointment_ID.Size = new Size(125, 27);
            txtbx_Appointment_ID.TabIndex = 13;
            // 
            // btn_Appointment_OK
            // 
            btn_Appointment_OK.Location = new Point(233, 328);
            btn_Appointment_OK.Name = "btn_Appointment_OK";
            btn_Appointment_OK.Size = new Size(94, 29);
            btn_Appointment_OK.TabIndex = 17;
            btn_Appointment_OK.Text = "Ok";
            btn_Appointment_OK.UseVisualStyleBackColor = true;
            btn_Appointment_OK.Click += btn_OK_Click;
            // 
            // btn_Appointment_Cancel
            // 
            btn_Appointment_Cancel.Location = new Point(361, 328);
            btn_Appointment_Cancel.Name = "btn_Appointment_Cancel";
            btn_Appointment_Cancel.Size = new Size(94, 29);
            btn_Appointment_Cancel.TabIndex = 18;
            btn_Appointment_Cancel.Text = "Cancel";
            btn_Appointment_Cancel.UseVisualStyleBackColor = true;
            btn_Appointment_Cancel.Click += btn_Appointment_Cancel_Click;
            // 
            // txtbx_Appointment_Patient_Address2
            // 
            txtbx_Appointment_Patient_Address2.Location = new Point(323, 447);
            txtbx_Appointment_Patient_Address2.Name = "txtbx_Appointment_Patient_Address2";
            txtbx_Appointment_Patient_Address2.Size = new Size(125, 27);
            txtbx_Appointment_Patient_Address2.TabIndex = 23;
            // 
            // lblAdd_Edit_Appointment
            // 
            lblAdd_Edit_Appointment.AutoSize = true;
            lblAdd_Edit_Appointment.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdd_Edit_Appointment.Location = new Point(51, 41);
            lblAdd_Edit_Appointment.Name = "lblAdd_Edit_Appointment";
            lblAdd_Edit_Appointment.Size = new Size(794, 46);
            lblAdd_Edit_Appointment.TabIndex = 35;
            lblAdd_Edit_Appointment.Text = "Appointment Maintenance - Add/Edit Appointment";
            // 
            // combobx_Doctor
            // 
            combobx_Doctor.FormattingEnabled = true;
            combobx_Doctor.Location = new Point(645, 133);
            combobx_Doctor.Name = "combobx_Doctor";
            combobx_Doctor.Size = new Size(151, 28);
            combobx_Doctor.TabIndex = 36;
            // 
            // combobx_Patient
            // 
            combobx_Patient.FormattingEnabled = true;
            combobx_Patient.Location = new Point(645, 175);
            combobx_Patient.Name = "combobx_Patient";
            combobx_Patient.Size = new Size(151, 28);
            combobx_Patient.TabIndex = 37;
            // 
            // lbl_Doctor
            // 
            lbl_Doctor.AutoSize = true;
            lbl_Doctor.Location = new Point(509, 136);
            lbl_Doctor.Name = "lbl_Doctor";
            lbl_Doctor.Size = new Size(58, 20);
            lbl_Doctor.TabIndex = 38;
            lbl_Doctor.Text = "Doctor:";
            // 
            // lbl_Patient
            // 
            lbl_Patient.AutoSize = true;
            lbl_Patient.Location = new Point(509, 183);
            lbl_Patient.Name = "lbl_Patient";
            lbl_Patient.Size = new Size(54, 20);
            lbl_Patient.TabIndex = 39;
            lbl_Patient.Text = "Patient";
            // 
            // Add_Edit_Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 455);
            Controls.Add(lbl_Patient);
            Controls.Add(lbl_Doctor);
            Controls.Add(combobx_Patient);
            Controls.Add(combobx_Doctor);
            Controls.Add(lblAdd_Edit_Appointment);
            Controls.Add(btn_Appointment_Cancel);
            Controls.Add(btn_Appointment_OK);
            Controls.Add(txtbx_AppointmentTimeDisplay);
            Controls.Add(txtbx_AppointmentDateDisplay);
            Controls.Add(txtbx_Appointment_ID);
            Controls.Add(lbl_AppointmentTimeDisplay);
            Controls.Add(lbl_AppointmentDateDisplay);
            Controls.Add(lbl_AppointmentID);
            Controls.Add(lbl_Appointment_patientInfo);
            Name = "Add_Edit_Appointment";
            Text = "Add_Appointment_Edit_Patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Add_Edit_Appointment_Patient;
        private Label lbl_AppointmentTimeDisplay;
        private Label lbl_AppointmentDateDisplay;
        private Label lbl_AppointmentID;
        private Label lbl_Appointment_patientInfo;
        private TextBox txtbx_AppointmentTimeDisplay;
        private TextBox txtbx_AppointmentDateDisplay;
        private TextBox txtbx_Appointment_ID;
        private Button btn_Appointment_OK;
        private Button btn_Appointment_Cancel;
        private TextBox _AppointmenttextBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox txtbx_Appointment_Patient_Address2;
        private Label lblAdd_Edit_Appointment;
        private ComboBox combobx_Doctor;
        private ComboBox combobx_Patient;
        private Label lbl_Doctor;
        private Label lbl_Patient;
    }
}
