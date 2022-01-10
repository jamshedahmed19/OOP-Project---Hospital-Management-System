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
    public partial class AdminHomeControl : UserControl
    {
        public string employeeID { get; set; }
        public AdminHomeControl(string id)
        {
            InitializeComponent();
            employeeID = id;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUDDoctor cRUDDoctor = new CRUDDoctor();
            ControlClass.ShowControl(cRUDDoctor, Content);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PatientCRUD cRUDPatient = new PatientCRUD(employeeID);
            ControlClass.ShowControl(cRUDPatient, Content);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InpatientUserControl inpatientUserControl = new InpatientUserControl();
            ControlClass.ShowControl(inpatientUserControl, Content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomCRUD roomCRUD = new RoomCRUD();
            ControlClass.ShowControl(roomCRUD, Content);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CrudEmployee emp = new CrudEmployee();
            emp.Show();
            this.Hide();
        }

        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            DoctorsAppointmentUserControl doctorsAppointmentUserControl = new DoctorsAppointmentUserControl();
            ControlClass.ShowControl(doctorsAppointmentUserControl, Content);
        }
    }
}
