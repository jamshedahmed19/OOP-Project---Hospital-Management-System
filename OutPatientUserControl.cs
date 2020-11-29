using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project___Hospital_Management_System
{
    public partial class OutPatientUserControl : UserControl
    {
        public OutPatientUserControl(string pid, string pname, string did)
        {
            InitializeComponent();
            Pat_ID = pid;
            Pat_Name = pname;
            Doc_Code = did;
        }

        public string Pat_ID { get; set; }
        public string Doc_Code { get; set; }
        public string Pat_Name { get; set; }

        public string doctorName(string did)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            DataTable dataTable = new DataTable();
            return databaseOps.getDoctorName(did);
        }

        private void OutPatientUserControl_Load(object sender, EventArgs e)
        {
            textBoxDoctorID.Text = Doc_Code;
            textBoxPatientId.Text = Pat_ID;
            textBoxPatName.Text = Pat_Name;
            display();
        }

        private void textBoxDoctorID_TextChanged(object sender, EventArgs e)
        {
            textBoxDoctorName.Text = doctorName(Doc_Code);
        }

        private void buttonBookApp_Click(object sender, EventArgs e)
        {
            if (textBoxPatientId.Text.Length != 0 && textBoxPatName.Text.Length != 0 && dateTimePickerDAY.Value.ToString().Length != 0 && dateTimePickerSTARTTIME.Value.ToString().Length != 0 && dateTimePickerENDTIME.Value.ToString().Length != 0)
            {
                OutPatient outPatient = new OutPatient()
                {
                    PatID = textBoxPatientId.Text,
                    Name = textBoxPatName.Text,
                    Date_Of_Appointment = dateTimePickerDAY.Value.Date,
                    Start_Time_of_Appointment = dateTimePickerSTARTTIME.Value,
                    End_Time_of_Appointment = dateTimePickerENDTIME.Value
                };
                DatabaseOps databaseOps = new DatabaseOps();
                databaseOps.insert(outPatient);
                display();
            }
            else
            {
                MessageBox.Show("Unable to Book Appointment, Please Enter all the required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void display()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridViewINP.DataSource = databaseOps.displayAppointment(textBoxPatientId.Text);
        }

        private void buttonReschedule_Click(object sender, EventArgs e)
        {
            if (textBoxPatientId.Text.Length != 0 && textBoxPatName.Text.Length != 0 && dateTimePickerDAY.Value.ToString().Length != 0 && dateTimePickerSTARTTIME.Value.ToString().Length != 0 && dateTimePickerENDTIME.Value.ToString().Length != 0)
            {
                OutPatient outPatient = new OutPatient()
                {
                    PatID = textBoxPatientId.Text,
                    Name = textBoxPatName.Text,
                    Date_Of_Appointment = dateTimePickerDAY.Value.Date,
                    Start_Time_of_Appointment = dateTimePickerSTARTTIME.Value,
                    End_Time_of_Appointment = dateTimePickerENDTIME.Value,
                    AID = textBoxAppointmentID.Text
                };
                DatabaseOps databaseOps = new DatabaseOps();
                databaseOps.update(outPatient);
                display();
            }
            else
            {
                MessageBox.Show("Unable to Resedule Appointment, Please Enter all the required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRoomCancelApp_Click(object sender, EventArgs e)
        {
            if (textBoxAppointmentID.Text.Length != 0)
            {
                DatabaseOps databaseOps = new DatabaseOps();
                databaseOps.delete("APPOINTMENT", textBoxAppointmentID.Text);
                display();
            }
            else
            {
                MessageBox.Show("Unable to Cancel Appointment, Select a row which you want to Cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewINP_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxAppointmentID.Text = dataGridViewINP.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxPatName.Text = dataGridViewINP.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDoctorName.Text = dataGridViewINP.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePickerDAY.Value = Convert.ToDateTime(dataGridViewINP.Rows[e.RowIndex].Cells[4].Value);
            dateTimePickerSTARTTIME.Value = Convert.ToDateTime(dataGridViewINP.Rows[e.RowIndex].Cells[5].Value.ToString());
            dateTimePickerENDTIME.Value = Convert.ToDateTime(dataGridViewINP.Rows[e.RowIndex].Cells[6].Value.ToString());
            textBoxPatientId.Text = dataGridViewINP.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }

    class OutPatient : Patient
    {
        public string AID { get; set; }
        public string PatID { get; set; }
        public DateTime Date_Of_Appointment { get; set; }
        public DateTime Start_Time_of_Appointment { get; set; }
        public DateTime End_Time_of_Appointment { get; set; }
    }
}
