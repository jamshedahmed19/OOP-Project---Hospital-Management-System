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
    public partial class AdminSidebarUserControl : UserControl
    {
        public AdminSidebarUserControl()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

        }

        private void buttonPatient_Click(object sender, EventArgs e)
        {

        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            CRUDDoctor cRUDDoctor = new CRUDDoctor();
            ControlClass.ShowControl(cRUDDoctor, Content);
        }

        private void buttonCovid_Click(object sender, EventArgs e)
        {

        }
    }
}
