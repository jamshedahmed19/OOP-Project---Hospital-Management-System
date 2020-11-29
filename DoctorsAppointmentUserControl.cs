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
    public partial class DoctorsAppointmentUserControl : UserControl
    {
        public DoctorsAppointmentUserControl(string id)
        {
            InitializeComponent();
            ID = id;
        }

        public string ID { get; set; }

        public void display()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridViewINP.DataSource = databaseOps.doctorAppointment(ID);
        }

        private void DoctorsAppointmentUserControl_Load(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridViewINP_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxAppointmentID.Text = dataGridViewINP.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxPatName.Text = dataGridViewINP.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePickerDAY.Value = Convert.ToDateTime(dataGridViewINP.Rows[e.RowIndex].Cells[4].Value);
            dateTimePickerSTARTTIME.Value = Convert.ToDateTime(dataGridViewINP.Rows[e.RowIndex].Cells[5].Value.ToString());
            dateTimePickerENDTIME.Value = Convert.ToDateTime(dataGridViewINP.Rows[e.RowIndex].Cells[6].Value.ToString());
            textBoxPatientId.Text = dataGridViewINP.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {
            if(textBoxAppointmentID.Text.Length != 0)
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

        private void buttonReschedule_Click(object sender, EventArgs e)
        {

        }
    }
}
