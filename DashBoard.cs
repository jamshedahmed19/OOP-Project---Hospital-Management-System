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

        private void DashBoard_Load(object sender, EventArgs e)
        {
            AdminHomeControl homeControl = new AdminHomeControl();
            ControlClass.ShowControl(homeControl, Content);
            if (Role == "admin")
            {
                AdminSidebarUserControl adminSidebar = new AdminSidebarUserControl();
                ControlClass.ShowControl(adminSidebar, SideBar);
            }
            else if (Role == "doctor")
            {
                DoctorSidebarUserControl doctorSidebar = new DoctorSidebarUserControl();
                ControlClass.ShowControl(doctorSidebar, SideBar);
            }
            else
            {
                AdminSidebarUserControl adminSidebar = new AdminSidebarUserControl();
                ControlClass.ShowControl(adminSidebar, SideBar);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            AdminHomeControl homeControl = new AdminHomeControl();
            ControlClass.ShowControl(homeControl, Content);
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

        private void buttonPatient_Click(object sender, EventArgs e)
        {
            RoomCRUD room = new RoomCRUD();
            ControlClass.ShowControl(room, Content);
        }
    }
}
