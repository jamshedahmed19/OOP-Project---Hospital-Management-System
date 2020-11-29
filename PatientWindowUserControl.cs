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
    public partial class PatientWindowUserControl : UserControl
    {
        public PatientWindowUserControl()
        {
            InitializeComponent();
        }

        private void buttonOUTPAT_Click(object sender, EventArgs e)
        {
            //OutPatientUserControl outPatientUserControl = new OutPatientUserControl();
            //ControlClass.ShowControl(outPatientUserControl, Content);
        }

        private void buttonINPAT_Click(object sender, EventArgs e)
        {
            InpatientUserControl inpatientUserControl = new InpatientUserControl();
            ControlClass.ShowControl(inpatientUserControl, Content);
        }
    }
}
