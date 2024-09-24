using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class PatientListForm : Form
    {
        private ListView listViewPatients;
        private Home mainForm; 

        public PatientListForm(List<Dictionary<string, string>> patientsData, Home mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm; 
            listViewPatients.Enabled = true;

            listViewPatients.View = View.Details;
            listViewPatients.Columns.Add("PatientID");
            listViewPatients.Columns.Add("FirstName");
            listViewPatients.Columns.Add("LastName");
            listViewPatients.Columns.Add("DOB");
            listViewPatients.Columns.Add("Weight");
            listViewPatients.Columns.Add("Address1");
            listViewPatients.Columns.Add("Address2");
            listViewPatients.Columns.Add("Address3");
            listViewPatients.Columns.Add("HomeNumber");
            listViewPatients.Columns.Add("Postcode");



            this.Controls.Add(listViewPatients);
            PopulateListViewPatients(patientsData);
        }


        private void PopulateListViewPatients(List<Dictionary<string, string>> patientsData)
        {
            listViewPatients.Items.Clear();

            List<string> columnNames = patientsData.FirstOrDefault()?.Keys.ToList();


            if (columnNames == null)
            {
                Debug.WriteLine("No data available.");
                return;
            }

            foreach (var patientData in patientsData)
            {
                string patientID = patientData.ContainsKey("patient_id") ? patientData["patient_id"] : "";

                ListViewItem item = new ListViewItem(patientID);

                foreach (string columnName in columnNames)
                {
                    if (columnName == "patient_id")
                        continue;

                    string subItemValue = patientData.ContainsKey(columnName) ? patientData[columnName] : "";

                    item.SubItems.Add(subItemValue);
                }

                listViewPatients.Items.Add(item);
            }

        }



        private void Btn_Select_Patient_PLF_Click(object sender, EventArgs e)
        {
            if (listViewPatients.SelectedItems.Count > 0)
            {
                string patientID = listViewPatients.SelectedItems[0].SubItems[0].Text;
                string query = @"SELECT Patients.*
                        FROM Patients 
                        LEFT JOIN Appointments ON Patients.patient_id = Appointments.patient_id 
                        LEFT JOIN Doctors ON Appointments.doctor_id = Doctors.doctor_id 
                        WHERE Patients.patient_id = @recordID";
                RecordType recordtype = RecordType.Patient;

                Close();
                string PatientLabelQuery = @"SELECT Patients.*, Doctors.* 
                        FROM Patients 
                        LEFT JOIN Appointments ON Patients.patient_id = Appointments.patient_id 
                        LEFT JOIN Doctors ON Appointments.doctor_id = Doctors.doctor_id 
                        WHERE Patients.patient_id = @recordID";
                mainForm.PopulateLabels(PatientLabelQuery, recordtype, patientID);
            }
            else
            {
                MessageBox.Show("Please select a patient from the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
