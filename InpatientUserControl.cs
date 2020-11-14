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
    public partial class InpatientUserControl : UserControl
    {
        public InpatientUserControl()
        {
            InitializeComponent();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            FindRoom findRoom = new FindRoom();
            findRoom.Show();
        }
    }
}
