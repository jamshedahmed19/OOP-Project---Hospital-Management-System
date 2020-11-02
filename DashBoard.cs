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

        private void panelHead_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            AdminHomeControl homeControl = new AdminHomeControl();
            ControlClass.ShowControl(homeControl, Content);
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
            CovidUserControl covidUserControl = new CovidUserControl();
            ControlClass.ShowControl(covidUserControl, Content);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Content.Controls[0].SendToBack();
        }
    }
}
