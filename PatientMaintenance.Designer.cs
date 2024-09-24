namespace Software_Project
{
    partial class PatientMaintenance
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
            lblPatientMaintenance = new Label();
            btn_Patient_Maintenance_Add = new Button();
            btn_Patient_Maintenance_Edit = new Button();
            btn_Patient_Maintenance_Delete = new Button();
            btn_Arrow_Down = new Button();
            btn_Arrow_Up = new Button();
            listview_Patient_Maintenance = new ListView();
            SuspendLayout();
            // 
            // lblPatientMaintenance
            // 
            lblPatientMaintenance.AutoSize = true;
            lblPatientMaintenance.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPatientMaintenance.Location = new Point(225, 43);
            lblPatientMaintenance.Name = "lblPatientMaintenance";
            lblPatientMaintenance.Size = new Size(327, 46);
            lblPatientMaintenance.TabIndex = 0;
            lblPatientMaintenance.Text = "Patient Maintenance";
            // 
            // btn_Patient_Maintenance_Add
            // 
            btn_Patient_Maintenance_Add.Location = new Point(712, 189);
            btn_Patient_Maintenance_Add.Name = "btn_Patient_Maintenance_Add";
            btn_Patient_Maintenance_Add.Size = new Size(98, 29);
            btn_Patient_Maintenance_Add.TabIndex = 2;
            btn_Patient_Maintenance_Add.Text = "Add";
            btn_Patient_Maintenance_Add.UseVisualStyleBackColor = true;
            btn_Patient_Maintenance_Add.Click += btn_Patient_Maintenance_Add_Click;
            // 
            // btn_Patient_Maintenance_Edit
            // 
            btn_Patient_Maintenance_Edit.Location = new Point(712, 224);
            btn_Patient_Maintenance_Edit.Name = "btn_Patient_Maintenance_Edit";
            btn_Patient_Maintenance_Edit.Size = new Size(98, 29);
            btn_Patient_Maintenance_Edit.TabIndex = 3;
            btn_Patient_Maintenance_Edit.Text = "Edit";
            btn_Patient_Maintenance_Edit.UseVisualStyleBackColor = true;
            btn_Patient_Maintenance_Edit.Click += btn_Patient_Maintenance_Edit_Click;
            // 
            // btn_Patient_Maintenance_Delete
            // 
            btn_Patient_Maintenance_Delete.Location = new Point(712, 259);
            btn_Patient_Maintenance_Delete.Name = "btn_Patient_Maintenance_Delete";
            btn_Patient_Maintenance_Delete.Size = new Size(98, 29);
            btn_Patient_Maintenance_Delete.TabIndex = 4;
            btn_Patient_Maintenance_Delete.Text = "Delete";
            btn_Patient_Maintenance_Delete.UseVisualStyleBackColor = true;
            btn_Patient_Maintenance_Delete.Click += btn_Patient_Maintenance_Delete_Click;
            // 
            // btn_Arrow_Down
            // 
            btn_Arrow_Down.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Arrow_Down.Location = new Point(712, 399);
            btn_Arrow_Down.Name = "btn_Arrow_Down";
            btn_Arrow_Down.Size = new Size(94, 65);
            btn_Arrow_Down.TabIndex = 63;
            btn_Arrow_Down.Text = "🔽";
            btn_Arrow_Down.UseVisualStyleBackColor = true;
            btn_Arrow_Down.Click += btn_Arrow_Down_Click;
            // 
            // btn_Arrow_Up
            // 
            btn_Arrow_Up.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Arrow_Up.Location = new Point(712, 318);
            btn_Arrow_Up.Name = "btn_Arrow_Up";
            btn_Arrow_Up.Size = new Size(94, 65);
            btn_Arrow_Up.TabIndex = 62;
            btn_Arrow_Up.Text = "🔼";
            btn_Arrow_Up.UseVisualStyleBackColor = true;
            btn_Arrow_Up.Click += btn_Arrow_Up_Click;
            // 
            // listview_Patient_Maintenance
            // 
            listview_Patient_Maintenance.Location = new Point(32, 137);
            listview_Patient_Maintenance.Name = "listview_Patient_Maintenance";
            listview_Patient_Maintenance.Size = new Size(643, 334);
            listview_Patient_Maintenance.TabIndex = 64;
            listview_Patient_Maintenance.UseCompatibleStateImageBehavior = false;
            // 
            // PatientMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 556);
            Controls.Add(listview_Patient_Maintenance);
            Controls.Add(btn_Arrow_Down);
            Controls.Add(btn_Arrow_Up);
            Controls.Add(btn_Patient_Maintenance_Delete);
            Controls.Add(btn_Patient_Maintenance_Edit);
            Controls.Add(btn_Patient_Maintenance_Add);
            Controls.Add(lblPatientMaintenance);
            Name = "PatientMaintenance";
            Text = "PatientMaintenance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPatientMaintenance;
        private ListView listview_Patient_Maintenance;
        private Button btn_Patient_Maintenance_Add;
        private Button btn_Patient_Maintenance_Edit;
        private Button btn_Patient_Maintenance_Delete;
        private Button btn_Arrow_Down;
        private Button btn_Arrow_Up;
    }
}

