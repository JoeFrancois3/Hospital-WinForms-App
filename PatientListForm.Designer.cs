namespace Software_Project
{
    partial class PatientListForm
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
            Btn_Select_Patient_PLF = new Button();
            btn_Arrow_Up_PLF = new Button();
            btn_Arrow_Down_PLF = new Button();
            listViewPatients = new ListView();
            SuspendLayout();
            // 
            // Btn_Select_Patient_PLF
            // 
            Btn_Select_Patient_PLF.Location = new Point(511, 80);
            Btn_Select_Patient_PLF.Name = "Btn_Select_Patient_PLF";
            Btn_Select_Patient_PLF.Size = new Size(145, 29);
            Btn_Select_Patient_PLF.TabIndex = 1;
            Btn_Select_Patient_PLF.Text = "Select Patient";
            Btn_Select_Patient_PLF.UseVisualStyleBackColor = true;
            Btn_Select_Patient_PLF.Click += Btn_Select_Patient_PLF_Click;
            // 
            // btn_Arrow_Up_PLF
            // 
            btn_Arrow_Up_PLF.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Arrow_Up_PLF.Location = new Point(511, 155);
            btn_Arrow_Up_PLF.Name = "btn_Arrow_Up_PLF";
            btn_Arrow_Up_PLF.Size = new Size(94, 59);
            btn_Arrow_Up_PLF.TabIndex = 61;
            btn_Arrow_Up_PLF.Text = "🔼";
            btn_Arrow_Up_PLF.UseVisualStyleBackColor = true;
            // 
            // btn_Arrow_Down_PLF
            // 
            btn_Arrow_Down_PLF.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Arrow_Down_PLF.Location = new Point(511, 233);
            btn_Arrow_Down_PLF.Name = "btn_Arrow_Down_PLF";
            btn_Arrow_Down_PLF.Size = new Size(94, 54);
            btn_Arrow_Down_PLF.TabIndex = 62;
            btn_Arrow_Down_PLF.Text = "🔽";
            btn_Arrow_Down_PLF.UseVisualStyleBackColor = true;
            // 
            // listViewPatients
            // 
            listViewPatients.FullRowSelect = true;
            listViewPatients.Location = new Point(30, 68);
            listViewPatients.MultiSelect = false;
            listViewPatients.Name = "listViewPatients";
            listViewPatients.Size = new Size(450, 341);
            listViewPatients.TabIndex = 63;
            listViewPatients.UseCompatibleStateImageBehavior = false;
            // 
            // PatientListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewPatients);
            Controls.Add(btn_Arrow_Down_PLF);
            Controls.Add(btn_Arrow_Up_PLF);
            Controls.Add(Btn_Select_Patient_PLF);
            Name = "PatientListForm";
            Text = "PatientListForm";
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Select_Patient_PLF;
        private Button btn_Arrow_Up_PLF;
        private Button btn_Arrow_Down_PLF;
        private ListView listView1;
        private ListView listviewPatients;
    }
}