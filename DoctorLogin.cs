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
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text.Length != 0 && textBoxUsername.Text.Length != 0)
            {
                UserLogin login = new UserLogin();
                login.Username = textBoxUsername.Text;
                login.Pass = textBoxPass.Text;
                DatabaseOps databaseOps = new DatabaseOps();
                databaseOps.login(login, "doctorLogin");
            }
            else
            {
                textboxError.Visible = true;
                button1.BackColor = Color.FromArgb(textboxError.ForeColor.ToArgb());
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            DatabaseOps db = new DatabaseOps();
            db.makeslotsavailable();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
