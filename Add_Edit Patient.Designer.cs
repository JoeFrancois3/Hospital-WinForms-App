using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Software_Project
{
    partial class Add_Edit_Patient
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
            lblAdd_Edit_Patient = new Label();
            lbl_Patient_TelNo = new Label();
            lbl_Patient_Sname = new Label();
            lbl_Patient_Fname = new Label();
            lbl_PatientID = new Label();
            lbl_patientInfo = new Label();
            txtbx_Patient_TelNo = new TextBox();
            txtbx_Patient_Sname = new TextBox();
            txtbx_Patient_Fname = new TextBox();
            txtbx_Patient_ID = new TextBox();
            btn_OK = new Button();
            btn_Cancel = new Button();
            txtbx_Patient_dob = new TextBox();
            txtbx_Patient_Weight = new TextBox();
            txtbx_Patient_Address2 = new TextBox();
            lbl_Patient_dob = new Label();
            lbl_Patient_weight = new Label();
            lbl_Patient_address2 = new Label();
            lbl_Patient_Postcode = new Label();
            txtbx_Patient_Postcode = new TextBox();
            lbl_Patient_address1 = new Label();
            lbl_Patient_address3 = new Label();
            txtbx_Patient_Address1 = new TextBox();
            txtbx_Patient_Address3 = new TextBox();
            SuspendLayout();
            // 
            // lblAdd_Edit_Patient
            // 
            lblAdd_Edit_Patient.AutoSize = true;
            lblAdd_Edit_Patient.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdd_Edit_Patient.Location = new Point(96, 43);
            lblAdd_Edit_Patient.Name = "lblAdd_Edit_Patient";
            lblAdd_Edit_Patient.Size = new Size(604, 46);
            lblAdd_Edit_Patient.TabIndex = 1;
            lblAdd_Edit_Patient.Text = "Patient Maintenance - Add/Edit Patient";
            // 
            // lbl_Patient_TelNo
            // 
            lbl_Patient_TelNo.AutoSize = true;
            lbl_Patient_TelNo.Location = new Point(98, 616);
            lbl_Patient_TelNo.Name = "lbl_Patient_TelNo";
            lbl_Patient_TelNo.Size = new Size(72, 20);
            lbl_Patient_TelNo.TabIndex = 12;
            lbl_Patient_TelNo.Text = "H-Tel No:";
            // 
            // lbl_Patient_Sname
            // 
            lbl_Patient_Sname.AutoSize = true;
            lbl_Patient_Sname.Location = new Point(98, 234);
            lbl_Patient_Sname.Name = "lbl_Patient_Sname";
            lbl_Patient_Sname.Size = new Size(70, 20);
            lbl_Patient_Sname.TabIndex = 11;
            lbl_Patient_Sname.Text = "Surname:";
            // 
            // lbl_Patient_Fname
            // 
            lbl_Patient_Fname.AutoSize = true;
            lbl_Patient_Fname.Location = new Point(98, 183);
            lbl_Patient_Fname.Name = "lbl_Patient_Fname";
            lbl_Patient_Fname.Size = new Size(76, 20);
            lbl_Patient_Fname.TabIndex = 10;
            lbl_Patient_Fname.Text = "Firstname:";
            // 
            // lbl_PatientID
            // 
            lbl_PatientID.AutoSize = true;
            lbl_PatientID.Location = new Point(98, 136);
            lbl_PatientID.Name = "lbl_PatientID";
            lbl_PatientID.Size = new Size(76, 20);
            lbl_PatientID.TabIndex = 9;
            lbl_PatientID.Text = "Patient ID:";
            // 
            // lbl_patientInfo
            // 
            lbl_patientInfo.AutoSize = true;
            lbl_patientInfo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_patientInfo.Location = new Point(96, 109);
            lbl_patientInfo.Name = "lbl_patientInfo";
            lbl_patientInfo.Size = new Size(0, 25);
            lbl_patientInfo.TabIndex = 8;
            // 
            // txtbx_Patient_TelNo
            // 
            txtbx_Patient_TelNo.Location = new Point(323, 616);
            txtbx_Patient_TelNo.Name = "txtbx_Patient_TelNo";
            txtbx_Patient_TelNo.Size = new Size(125, 27);
            txtbx_Patient_TelNo.TabIndex = 10;
            // 
            // txtbx_Patient_Sname
            // 
            txtbx_Patient_Sname.Location = new Point(325, 227);
            txtbx_Patient_Sname.Name = "txtbx_Patient_Sname";
            txtbx_Patient_Sname.Size = new Size(125, 27);
            txtbx_Patient_Sname.TabIndex = 3;
            // 
            // txtbx_Patient_Fname
            // 
            txtbx_Patient_Fname.Location = new Point(325, 176);
            txtbx_Patient_Fname.Name = "txtbx_Patient_Fname";
            txtbx_Patient_Fname.Size = new Size(125, 27);
            txtbx_Patient_Fname.TabIndex = 2;
            // 
            // txtbx_Patient_ID
            // 
            txtbx_Patient_ID.Location = new Point(325, 129);
            txtbx_Patient_ID.Name = "txtbx_Patient_ID";
            txtbx_Patient_ID.Size = new Size(125, 27);
            txtbx_Patient_ID.TabIndex = 1;
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(265, 686);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(94, 29);
            btn_OK.TabIndex = 11;
            btn_OK.Text = "Ok";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(393, 686);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 12;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // txtbx_Patient_dob
            // 
            txtbx_Patient_dob.Location = new Point(325, 285);
            txtbx_Patient_dob.Name = "txtbx_Patient_dob";
            txtbx_Patient_dob.Size = new Size(125, 27);
            txtbx_Patient_dob.TabIndex = 4;
            // 
            // txtbx_Patient_Weight
            // 
            txtbx_Patient_Weight.Location = new Point(323, 335);
            txtbx_Patient_Weight.Name = "txtbx_Patient_Weight";
            txtbx_Patient_Weight.Size = new Size(125, 27);
            txtbx_Patient_Weight.TabIndex = 5;
            // 
            // txtbx_Patient_Address2
            // 
            txtbx_Patient_Address2.Location = new Point(323, 447);
            txtbx_Patient_Address2.Name = "txtbx_Patient_Address2";
            txtbx_Patient_Address2.Size = new Size(125, 27);
            txtbx_Patient_Address2.TabIndex = 7;
            // 
            // lbl_Patient_dob
            // 
            lbl_Patient_dob.AutoSize = true;
            lbl_Patient_dob.Location = new Point(96, 292);
            lbl_Patient_dob.Name = "lbl_Patient_dob";
            lbl_Patient_dob.Size = new Size(97, 20);
            lbl_Patient_dob.TabIndex = 24;
            lbl_Patient_dob.Text = "Date of Birth:";
            // 
            // lbl_Patient_weight
            // 
            lbl_Patient_weight.AutoSize = true;
            lbl_Patient_weight.Location = new Point(96, 342);
            lbl_Patient_weight.Name = "lbl_Patient_weight";
            lbl_Patient_weight.Size = new Size(59, 20);
            lbl_Patient_weight.TabIndex = 25;
            lbl_Patient_weight.Text = "Weight:";
            // 
            // lbl_Patient_address2
            // 
            lbl_Patient_address2.AutoSize = true;
            lbl_Patient_address2.Location = new Point(96, 454);
            lbl_Patient_address2.Name = "lbl_Patient_address2";
            lbl_Patient_address2.Size = new Size(108, 20);
            lbl_Patient_address2.TabIndex = 27;
            lbl_Patient_address2.Text = "Address Line 2:";
            // 
            // lbl_Patient_Postcode
            // 
            lbl_Patient_Postcode.AutoSize = true;
            lbl_Patient_Postcode.Location = new Point(96, 562);
            lbl_Patient_Postcode.Name = "lbl_Patient_Postcode";
            lbl_Patient_Postcode.Size = new Size(72, 20);
            lbl_Patient_Postcode.TabIndex = 29;
            lbl_Patient_Postcode.Text = "Postcode:";
            // 
            // txtbx_Patient_Postcode
            // 
            txtbx_Patient_Postcode.Location = new Point(325, 555);
            txtbx_Patient_Postcode.Name = "txtbx_Patient_Postcode";
            txtbx_Patient_Postcode.Size = new Size(125, 27);
            txtbx_Patient_Postcode.TabIndex = 9;
            // 
            // lbl_Patient_address1
            // 
            lbl_Patient_address1.AutoSize = true;
            lbl_Patient_address1.Location = new Point(96, 398);
            lbl_Patient_address1.Name = "lbl_Patient_address1";
            lbl_Patient_address1.Size = new Size(108, 20);
            lbl_Patient_address1.TabIndex = 31;
            lbl_Patient_address1.Text = "Address Line 1:";
            // 
            // lbl_Patient_address3
            // 
            lbl_Patient_address3.AutoSize = true;
            lbl_Patient_address3.Location = new Point(96, 504);
            lbl_Patient_address3.Name = "lbl_Patient_address3";
            lbl_Patient_address3.Size = new Size(108, 20);
            lbl_Patient_address3.TabIndex = 32;
            lbl_Patient_address3.Text = "Address Line 3:";
            // 
            // txtbx_Patient_Address1
            // 
            txtbx_Patient_Address1.Location = new Point(323, 391);
            txtbx_Patient_Address1.Name = "txtbx_Patient_Address1";
            txtbx_Patient_Address1.Size = new Size(125, 27);
            txtbx_Patient_Address1.TabIndex = 6;
            // 
            // txtbx_Patient_Address3
            // 
            txtbx_Patient_Address3.Location = new Point(323, 501);
            txtbx_Patient_Address3.Name = "txtbx_Patient_Address3";
            txtbx_Patient_Address3.Size = new Size(125, 27);
            txtbx_Patient_Address3.TabIndex = 8;
            // 
            // Add_Edit_Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 776);
            Controls.Add(txtbx_Patient_Address3);
            Controls.Add(txtbx_Patient_Address1);
            Controls.Add(lbl_Patient_address3);
            Controls.Add(lbl_Patient_address1);
            Controls.Add(txtbx_Patient_Postcode);
            Controls.Add(lbl_Patient_Postcode);
            Controls.Add(lbl_Patient_address2);
            Controls.Add(lbl_Patient_weight);
            Controls.Add(lbl_Patient_dob);
            Controls.Add(txtbx_Patient_Address2);
            Controls.Add(txtbx_Patient_Weight);
            Controls.Add(txtbx_Patient_dob);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_OK);
            Controls.Add(txtbx_Patient_TelNo);
            Controls.Add(txtbx_Patient_Sname);
            Controls.Add(txtbx_Patient_Fname);
            Controls.Add(txtbx_Patient_ID);
            Controls.Add(lbl_Patient_TelNo);
            Controls.Add(lbl_Patient_Sname);
            Controls.Add(lbl_Patient_Fname);
            Controls.Add(lbl_PatientID);
            Controls.Add(lbl_patientInfo);
            Controls.Add(lblAdd_Edit_Patient);
            Name = "Add_Edit_Patient";
            Text = "Add_Edit_Patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdd_Edit_Patient;
        private Label lbl_Patient_TelNo;
        private Label lbl_Patient_Sname;
        private Label lbl_Patient_Fname;
        private Label lbl_PatientID;
        private Label lbl_patientInfo;
        private TextBox txtbx_Patient_TelNo;
        private TextBox txtbx_Patient_Sname;
        private TextBox txtbx_Patient_Fname;
        private TextBox txtbx_Patient_ID;
        private Button btn_OK;
        private Button btn_Cancel;
        private TextBox txtbx_Patient_dob;
        private TextBox textBox2;
        private TextBox txtbx_Patient_Weight;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox txtbx_Patient_Address2;
        private Label lbl_Patient_dob;
        private Label lbl_Patient_weight;
        private Label lbl_Patient_address2;
        private Label lbl_Patient_Postcode;
        private TextBox txtbx_Patient_Postcode;
        private Label lbl_Patient_address1;
        private Label lbl_Patient_address3;
        private TextBox txtbx_Patient_Address1;
        private TextBox txtbx_Patient_Address3;
    }
}
