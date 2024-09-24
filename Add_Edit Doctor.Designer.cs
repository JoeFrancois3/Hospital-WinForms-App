namespace Software_Project
{
    partial class Add_Edit_Doctor
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
            lblAdd_Edit_Doctor = new Label();
            lbl_Doctor_TelNo = new Label();
            lbl_Doctor_Sname = new Label();
            lbl_Doctor_Fname = new Label();
            lbl_DoctorID = new Label();
            lbl_doctorInfo = new Label();
            txtbx_Doctor_TelNo = new TextBox();
            txtbx_Doctor_Sname = new TextBox();
            txtbx_Doctor_Fname = new TextBox();
            txtbx_Doctor_ID = new TextBox();
            btn_OK = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // lblAdd_Edit_Doctor
            // 
            lblAdd_Edit_Doctor.AutoSize = true;
            lblAdd_Edit_Doctor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdd_Edit_Doctor.Location = new Point(96, 43);
            lblAdd_Edit_Doctor.Name = "lblAdd_Edit_Doctor";
            lblAdd_Edit_Doctor.Size = new Size(604, 46);
            lblAdd_Edit_Doctor.TabIndex = 1;
            lblAdd_Edit_Doctor.Text = "Doctor Maintenance - Add/Edit Doctor";
            // 
            // lbl_Doctor_TelNo
            // 
            lbl_Doctor_TelNo.AutoSize = true;
            lbl_Doctor_TelNo.Location = new Point(98, 291);
            lbl_Doctor_TelNo.Name = "lbl_Doctor_TelNo";
            lbl_Doctor_TelNo.Size = new Size(72, 20);
            lbl_Doctor_TelNo.TabIndex = 12;
            lbl_Doctor_TelNo.Text = "H-Tel No:";
            // 
            // lbl_Doctor_Sname
            // 
            lbl_Doctor_Sname.AutoSize = true;
            lbl_Doctor_Sname.Location = new Point(98, 234);
            lbl_Doctor_Sname.Name = "lbl_Doctor_Sname";
            lbl_Doctor_Sname.Size = new Size(70, 20);
            lbl_Doctor_Sname.TabIndex = 11;
            lbl_Doctor_Sname.Text = "Surname:";
            // 
            // lbl_Doctor_Fname
            // 
            lbl_Doctor_Fname.AutoSize = true;
            lbl_Doctor_Fname.Location = new Point(98, 183);
            lbl_Doctor_Fname.Name = "lbl_Doctor_Fname";
            lbl_Doctor_Fname.Size = new Size(76, 20);
            lbl_Doctor_Fname.TabIndex = 10;
            lbl_Doctor_Fname.Text = "Firstname:";
            // 
            // lbl_DoctorID
            // 
            lbl_DoctorID.AutoSize = true;
            lbl_DoctorID.Location = new Point(98, 136);
            lbl_DoctorID.Name = "lbl_DoctorID";
            lbl_DoctorID.Size = new Size(77, 20);
            lbl_DoctorID.TabIndex = 9;
            lbl_DoctorID.Text = "Doctor ID:";
            // 
            // lbl_doctorInfo
            // 
            lbl_doctorInfo.AutoSize = true;
            lbl_doctorInfo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_doctorInfo.Location = new Point(96, 109);
            lbl_doctorInfo.Name = "lbl_doctorInfo";
            lbl_doctorInfo.Size = new Size(0, 25);
            lbl_doctorInfo.TabIndex = 8;
            // 
            // txtbx_Doctor_TelNo
            // 
            txtbx_Doctor_TelNo.Location = new Point(325, 284);
            txtbx_Doctor_TelNo.Name = "txtbx_Doctor_TelNo";
            txtbx_Doctor_TelNo.Size = new Size(125, 27);
            txtbx_Doctor_TelNo.TabIndex = 16;
            // 
            // txtbx_Doctor_Sname
            // 
            txtbx_Doctor_Sname.Location = new Point(325, 227);
            txtbx_Doctor_Sname.Name = "txtbx_Doctor_Sname";
            txtbx_Doctor_Sname.Size = new Size(125, 27);
            txtbx_Doctor_Sname.TabIndex = 15;
            // 
            // txtbx_Doctor_Fname
            // 
            txtbx_Doctor_Fname.Location = new Point(325, 176);
            txtbx_Doctor_Fname.Name = "txtbx_Doctor_Fname";
            txtbx_Doctor_Fname.Size = new Size(125, 27);
            txtbx_Doctor_Fname.TabIndex = 14;
            // 
            // txtbx_Doctor_ID
            // 
            txtbx_Doctor_ID.Location = new Point(325, 129);
            txtbx_Doctor_ID.Name = "txtbx_Doctor_ID";
            txtbx_Doctor_ID.Size = new Size(125, 27);
            txtbx_Doctor_ID.TabIndex = 13;
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(281, 367);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(94, 29);
            btn_OK.TabIndex = 17;
            btn_OK.Text = "Ok";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(409, 367);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 18;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // Add_Edit_Doctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_OK);
            Controls.Add(txtbx_Doctor_TelNo);
            Controls.Add(txtbx_Doctor_Sname);
            Controls.Add(txtbx_Doctor_Fname);
            Controls.Add(txtbx_Doctor_ID);
            Controls.Add(lbl_Doctor_TelNo);
            Controls.Add(lbl_Doctor_Sname);
            Controls.Add(lbl_Doctor_Fname);
            Controls.Add(lbl_DoctorID);
            Controls.Add(lbl_doctorInfo);
            Controls.Add(lblAdd_Edit_Doctor);
            Name = "Add_Edit_Doctor";
            Text = "Add_Edit_Doctor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdd_Edit_Doctor;
        private Label lbl_Doctor_TelNo;
        private Label lbl_Doctor_Sname;
        private Label lbl_Doctor_Fname;
        private Label lbl_DoctorID;
        private Label lbl_doctorInfo;
        private TextBox txtbx_Doctor_TelNo;
        private TextBox txtbx_Doctor_Sname;
        private TextBox txtbx_Doctor_Fname;
        private TextBox txtbx_Doctor_ID;
        private Button btn_OK;
        private Button btn_Cancel;
    }
}
