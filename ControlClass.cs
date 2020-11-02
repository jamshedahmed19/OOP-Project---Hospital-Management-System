using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project___Hospital_Management_System
{
    class ControlClass
    {
        public static void ShowControl(System.Windows.Forms.Control control, System.Windows.Forms.Control content)
        {
            content.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            content.Controls.Add(control);
        }

        public static void ShowPreviousControl(System.Windows.Forms.Control control)
        {
            
        }
    }
}
