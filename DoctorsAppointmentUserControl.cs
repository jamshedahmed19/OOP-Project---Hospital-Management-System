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

        public void patientList()
        {
            comboBoxpatient.Items.Clear();
            DatabaseOps databaseOps = new DatabaseOps();
            DataTable dataTable = new DataTable();
            dataTable = databaseOps.patientList();
            comboBoxpatient.DataSource = dataTable;
            comboBoxpatient.DisplayMember = "PAT_NAME" ;
            comboBoxpatient.ValueMember = "ID";
        }

        public void DoctorList()
        {
            comboBoxDoctor.Items.Clear();   
            DatabaseOps databaseOps = new DatabaseOps();
            comboBoxDoctor.DataSource = databaseOps.doctorList(); ;
            comboBoxDoctor.DisplayMember = "DOC_NAME";
            comboBoxDoctor.ValueMember = "ID";
        }

        public void TimeSlotlist()
        {
            //comboBoxslots.Items.Clear();    
            DatabaseOps databaseOps = new DatabaseOps();
            comboBoxslots.DataSource = databaseOps.timeslotlist(Convert.ToInt32(comboBoxDoctor.SelectedValue.ToString())); ;
            comboBoxslots.DisplayMember = "slotdec";
            comboBoxslots.ValueMember = "id";
        }

        private void DoctorsAppointmentUserControl_Load(object sender, EventArgs e)
        {
            //display();
            patientList();
            DoctorList();
        }

        private void dataGridViewINP_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //textBoxAppointmentID.Text = dataGridViewINP.Rows[e.RowIndex].Cells[0].Value.ToString();
            //textBoxPatName.Text = dataGridViewINP.Rows[e.RowIndex].Cells[1].Value.ToString();
            //dateTimePickerDAY.Value = Convert.ToDateTime(dataGridViewINP.Rows[e.RowIndex].Cells[4].Value);
            //dateTimePickerSTARTTIME.Value = Convert.ToDateTime(dataGridViewINP.Rows[e.RowIndex].Cells[5].Value.ToString());
            //dateTimePickerENDTIME.Value = Convert.ToDateTime(dataGridViewINP.Rows[e.RowIndex].Cells[6].Value.ToString());
            //textBoxPatientId.Text = dataGridViewINP.Rows[e.RowIndex].Cells[7].Value.ToString();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxDoctor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TimeSlotlist();
        }
    }
}
