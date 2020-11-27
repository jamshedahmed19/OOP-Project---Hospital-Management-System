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
        public AdminHomeControl()

        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            PatientCRUD cRUDPatient = new PatientCRUD();
            ControlClass.ShowControl(cRUDPatient, Content);
        }
    }
}
