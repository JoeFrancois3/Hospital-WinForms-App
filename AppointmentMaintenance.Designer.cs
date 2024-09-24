namespace Software_Project
{
    partial class AppointmentMaintenance
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
            lblAppointmentMaintenance = new Label();
            btn_Appointment_Maintenance_Add = new Button();
            btn_Appointment_Maintenance_Edit = new Button();
            btn_Appointment_Maintenance_Delete = new Button();
            btn_Arrow_Down = new Button();
            btn_Arrow_Up = new Button();
            listview_Appointment_Maintenance = new ListView();
            SuspendLayout();
            // 
            // lblAppointmentMaintenance
            // 
            lblAppointmentMaintenance.AutoSize = true;
            lblAppointmentMaintenance.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAppointmentMaintenance.Location = new Point(225, 43);
            lblAppointmentMaintenance.Name = "lblAppointmentMaintenance";
            lblAppointmentMaintenance.Size = new Size(422, 46);
            lblAppointmentMaintenance.TabIndex = 0;
            lblAppointmentMaintenance.Text = "Appointment Maintenance";
            // 
            // btn_Appointment_Maintenance_Add
            // 
            btn_Appointment_Maintenance_Add.Location = new Point(712, 189);
            btn_Appointment_Maintenance_Add.Name = "btn_Appointment_Maintenance_Add";
            btn_Appointment_Maintenance_Add.Size = new Size(98, 29);
            btn_Appointment_Maintenance_Add.TabIndex = 2;
            btn_Appointment_Maintenance_Add.Text = "Add";
            btn_Appointment_Maintenance_Add.UseVisualStyleBackColor = true;
            btn_Appointment_Maintenance_Add.Click += btn_Appointment_Maintenance_Add_Click_1;
            // 
            // btn_Appointment_Maintenance_Edit
            // 
            btn_Appointment_Maintenance_Edit.Location = new Point(712, 224);
            btn_Appointment_Maintenance_Edit.Name = "btn_Appointment_Maintenance_Edit";
            btn_Appointment_Maintenance_Edit.Size = new Size(98, 29);
            btn_Appointment_Maintenance_Edit.TabIndex = 3;
            btn_Appointment_Maintenance_Edit.Text = "Edit";
            btn_Appointment_Maintenance_Edit.UseVisualStyleBackColor = true;
            btn_Appointment_Maintenance_Edit.Click += btn_Appointment_Maintenance_Edit_Click_1;
            // 
            // btn_Appointment_Maintenance_Delete
            // 
            btn_Appointment_Maintenance_Delete.Location = new Point(712, 259);
            btn_Appointment_Maintenance_Delete.Name = "btn_Appointment_Maintenance_Delete";
            btn_Appointment_Maintenance_Delete.Size = new Size(98, 29);
            btn_Appointment_Maintenance_Delete.TabIndex = 4;
            btn_Appointment_Maintenance_Delete.Text = "Delete";
            btn_Appointment_Maintenance_Delete.UseVisualStyleBackColor = true;
            btn_Appointment_Maintenance_Delete.Click += btn_Appointment_Maintenance_Delete_Click_1;
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
            // listview_Appointment_Maintenance
            // 
            listview_Appointment_Maintenance.Location = new Point(32, 137);
            listview_Appointment_Maintenance.Name = "listview_Appointment_Maintenance";
            listview_Appointment_Maintenance.Size = new Size(643, 334);
            listview_Appointment_Maintenance.TabIndex = 64;
            listview_Appointment_Maintenance.UseCompatibleStateImageBehavior = false;
            // 
            // AppointmentMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 556);
            Controls.Add(listview_Appointment_Maintenance);
            Controls.Add(btn_Arrow_Down);
            Controls.Add(btn_Arrow_Up);
            Controls.Add(btn_Appointment_Maintenance_Delete);
            Controls.Add(btn_Appointment_Maintenance_Edit);
            Controls.Add(btn_Appointment_Maintenance_Add);
            Controls.Add(lblAppointmentMaintenance);
            Name = "AppointmentMaintenance";
            Text = "AppointmentMaintenance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppointmentMaintenance;
        private ListView listview_Appointment_Maintenance;
        private Button btn_Appointment_Maintenance_Add;
        private Button btn_Appointment_Maintenance_Edit;
        private Button btn_Appointment_Maintenance_Delete;
        private Button btn_Arrow_Down;
        private Button btn_Arrow_Up;
    }
}

