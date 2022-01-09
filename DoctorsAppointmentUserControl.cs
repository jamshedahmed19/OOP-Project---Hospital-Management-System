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
        public DoctorsAppointmentUserControl()
        {
            InitializeComponent();
           dateTimePicker1.Value = DateTime.Today;

        }

        public string ID { get; set; }

        public void display()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridViewINP.DataSource = databaseOps.doctorAppointment();
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
            display();
            patientList();
            DoctorList();
        }

        private void dataGridViewINP_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            comboBoxDoctor.Text = "";
            comboBoxpatient.Text = "";
            comboBoxslots.Text = "";
            textBoxAppointmentID.Text = dataGridViewINP.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxDoctor.Text = dataGridViewINP.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxpatient.Text = dataGridViewINP.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridViewINP.Rows[e.RowIndex].Cells[3].Value.ToString());
            comboBoxslots.Text = "";
            comboBoxslots.Text = dataGridViewINP.Rows[e.RowIndex].Cells[4].Value.ToString();
            
            
           
        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {
            if(textBoxAppointmentID.Text.Length != 0)
            {
                
                DatabaseOps databaseOps = new DatabaseOps();
                
                int oldslotid = databaseOps.gettimeslotidfromappointment(textBoxAppointmentID.Text);
                databaseOps.updatetimeslotavailability(oldslotid, 1);
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
            Appointment appointment = new Appointment();
            appointment.AppointmentID = textBoxAppointmentID.Text;
            appointment.AppointmentDate = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            appointment.TimeslotID = Convert.ToInt32(comboBoxslots.SelectedValue.ToString());
            appointment.DoctorID = Convert.ToInt32(comboBoxDoctor.SelectedValue.ToString());
            appointment.PatientID = Convert.ToInt32(comboBoxpatient.SelectedValue.ToString());
            DatabaseOps update = new DatabaseOps();
            int oldslotid = update.gettimeslotidfromappointment(appointment.AppointmentID);
            update.updatetimeslotavailability(oldslotid, 1);
            update.update(appointment);
            update.updatetimeslotavailability(appointment.TimeslotID, 0);
            display();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.AppointmentDate = dateTimePicker1.Value;
            appointment.TimeslotID = Convert.ToInt32(comboBoxslots.SelectedValue.ToString());
            appointment.DoctorID = Convert.ToInt32(comboBoxDoctor.SelectedValue.ToString());
            appointment.PatientID = Convert.ToInt32(comboBoxpatient.SelectedValue.ToString());
            DatabaseOps insert = new DatabaseOps();
            insert.insert(appointment);
            insert.updatetimeslotavailability(appointment.TimeslotID, 0);
            display();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerENDTIME_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewINP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAppointmentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxslots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxpatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
