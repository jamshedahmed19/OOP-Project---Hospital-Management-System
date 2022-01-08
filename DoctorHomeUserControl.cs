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
    public partial class DoctorHomeUserControl : UserControl
    {
        public DoctorHomeUserControl(string iD, string depart_id)
        {
            InitializeComponent();
            ID = iD;
            Departmental_ID = depart_id;
        }

        public string ID { get; set; }
        public string Departmental_ID { get; set; }
        private void buttondoctorspatient_Click(object sender, EventArgs e)
        {
            DoctorsPatientListControl doctorsPatientListControl = new DoctorsPatientListControl(ID);
            ControlClass.ShowControl(doctorsPatientListControl, Content);
        }

        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            Docappointment doctorsAppointmentUserControl = new Docappointment(Convert.ToInt32(this.ID));
            ControlClass.ShowControl(doctorsAppointmentUserControl, Content);
        }
    }
}
