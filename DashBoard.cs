using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project___Hospital_Management_System
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        public string ID { get; set; }
        public string Role { get; set; }
        public string Departmental_ID { get; set; }
        string[] roles { get; set; }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            roles = databaseOps.getRoles();
            if (roles.Contains(Role))
            {
                AdminHomeControl homeControl = new AdminHomeControl();
                ControlClass.ShowControl(homeControl, Content);
                //buttonDoctor.Image = (new Bitmap(Image.FromFile(@"C:\Users\User\OneDrive\Desktop\Icons\stethoscope.png"), new Size(32, 32)));
                buttonDoctor.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                DoctorHomeUserControl doctorHomeUserControl = new DoctorHomeUserControl(ID, Departmental_ID);
                ControlClass.ShowControl(doctorHomeUserControl, Content);
                buttonBed.Visible = false;
                //buttonDoctor.Visible = false;
                //buttonDoctor.Image = (new Bitmap(Image.FromFile(@"C:\Users\User\OneDrive\Desktop\Icons\appointment1.png"), new Size(32, 32)));
                buttonDoctor.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (roles.Contains(Role))
            {
                AdminHomeControl homeControl = new AdminHomeControl();
                ControlClass.ShowControl(homeControl, Content);

                //DoctorHomeUserControl doctorHomeUserControl = new DoctorHomeUserControl(ID, Departmental_ID);
                //ControlClass.ShowControl(doctorHomeUserControl, Content);
            }
            else
            {
                DoctorHomeUserControl doctorHomeUserControl = new DoctorHomeUserControl(ID, Departmental_ID);
                ControlClass.ShowControl(doctorHomeUserControl, Content);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCovid_Click(object sender, EventArgs e)
        {
            InpatientUserControl inpatientUser = new InpatientUserControl();
            ControlClass.ShowControl(inpatientUser, Content);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Content.Controls[0].SendToBack();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            if (roles.Contains(Role))
            {
                CRUDDoctor cRUDDoctor = new CRUDDoctor();
                ControlClass.ShowControl(cRUDDoctor, Content);
            }
            else
            {
                DoctorsAppointmentUserControl doctorsAppointmentUserControl = new DoctorsAppointmentUserControl(Departmental_ID);
                ControlClass.ShowControl(doctorsAppointmentUserControl, Content);
            }
        }

        private void buttonBilling_Click(object sender, EventArgs e)
        {
            //BillingUserControl billingUserControl = new BillingUserControl();
            //ControlClass.ShowControl(billingUserControl, Content);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingUserControl settingUserControl = new SettingUserControl(ID);
            ControlClass.ShowControl(settingUserControl, Content);
        }

        private void buttonPatient_Click_1(object sender, EventArgs e)
        {
            if (roles.Contains(Role))
            {
                InpatientUserControl inpatientUserControl = new InpatientUserControl();
                ControlClass.ShowControl(inpatientUserControl, Content);
            }
            else
            {
                InpatientUserControl inpatientUserControl = new InpatientUserControl();
                ControlClass.ShowControl(inpatientUserControl, Content);
            }
        }

        private void buttonBed_Click(object sender, EventArgs e)
        {
            RoomCRUD roomCRUD = new RoomCRUD();
            ControlClass.ShowControl(roomCRUD, Content);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DoctorsAppointmentUserControl appointmentUserControl = new DoctorsAppointmentUserControl();
            //appointmentUserControl.Show();
        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
