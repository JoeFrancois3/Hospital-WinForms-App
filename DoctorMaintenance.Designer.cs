namespace Software_Project
{
    partial class DoctorMaintenance
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
            lblDoctorMaintenance = new Label();
            listview_Doctor_Maintenance = new ListView();
            btn_Doctor_Maintenance_Add = new Button();
            btn_Doctor_Maintenance_Edit = new Button();
            btn_Doctor_Maintenance_Delete = new Button();
            btn_Arrow_Down = new Button();
            btn_Arrow_Up = new Button();
            SuspendLayout();
            // 
            // lblDoctorMaintenance
            // 
            lblDoctorMaintenance.AutoSize = true;
            lblDoctorMaintenance.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDoctorMaintenance.Location = new Point(225, 43);
            lblDoctorMaintenance.Name = "lblDoctorMaintenance";
            lblDoctorMaintenance.Size = new Size(327, 46);
            lblDoctorMaintenance.TabIndex = 0;
            lblDoctorMaintenance.Text = "Doctor Maintenance";
            // 
            // listview_Doctor_Maintenance
            // 
            listview_Doctor_Maintenance.Location = new Point(32, 137);
            listview_Doctor_Maintenance.Name = "listview_Doctor_Maintenance";
            listview_Doctor_Maintenance.Size = new Size(643, 334);
            listview_Doctor_Maintenance.TabIndex = 1;
            listview_Doctor_Maintenance.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Doctor_Maintenance_Add
            // 
            btn_Doctor_Maintenance_Add.Location = new Point(712, 189);
            btn_Doctor_Maintenance_Add.Name = "btn_Doctor_Maintenance_Add";
            btn_Doctor_Maintenance_Add.Size = new Size(98, 29);
            btn_Doctor_Maintenance_Add.TabIndex = 2;
            btn_Doctor_Maintenance_Add.Text = "Add";
            btn_Doctor_Maintenance_Add.UseVisualStyleBackColor = true;
            btn_Doctor_Maintenance_Add.Click += btn_Doctor_Maintenance_Add_Click;
            // 
            // btn_Doctor_Maintenance_Edit
            // 
            btn_Doctor_Maintenance_Edit.Location = new Point(712, 224);
            btn_Doctor_Maintenance_Edit.Name = "btn_Doctor_Maintenance_Edit";
            btn_Doctor_Maintenance_Edit.Size = new Size(98, 29);
            btn_Doctor_Maintenance_Edit.TabIndex = 3;
            btn_Doctor_Maintenance_Edit.Text = "Edit";
            btn_Doctor_Maintenance_Edit.UseVisualStyleBackColor = true;
            btn_Doctor_Maintenance_Edit.Click += btn_Doctor_Maintenance_Edit_Click;
            // 
            // btn_Doctor_Maintenance_Delete
            // 
            btn_Doctor_Maintenance_Delete.Location = new Point(712, 259);
            btn_Doctor_Maintenance_Delete.Name = "btn_Doctor_Maintenance_Delete";
            btn_Doctor_Maintenance_Delete.Size = new Size(98, 29);
            btn_Doctor_Maintenance_Delete.TabIndex = 4;
            btn_Doctor_Maintenance_Delete.Text = "Delete";
            btn_Doctor_Maintenance_Delete.UseVisualStyleBackColor = true;
            btn_Doctor_Maintenance_Delete.Click += btn_Doctor_Maintenance_Delete_Click;
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
            // DoctorMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 556);
            Controls.Add(btn_Arrow_Down);
            Controls.Add(btn_Arrow_Up);
            Controls.Add(btn_Doctor_Maintenance_Delete);
            Controls.Add(btn_Doctor_Maintenance_Edit);
            Controls.Add(btn_Doctor_Maintenance_Add);
            Controls.Add(listview_Doctor_Maintenance);
            Controls.Add(lblDoctorMaintenance);
            Name = "DoctorMaintenance";
            Text = "DoctorMaintenance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDoctorMaintenance;
        private ListView listview_Doctor_Maintenance;
        private Button btn_Doctor_Maintenance_Add;
        private Button btn_Doctor_Maintenance_Edit;
        private Button btn_Doctor_Maintenance_Delete;
        private Button btn_Arrow_Down;
        private Button btn_Arrow_Up;
    }
}