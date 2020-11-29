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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text.Length != 0 && textBoxUsername.Text.Length != 0)
            {
                UserLogin userLogin = new UserLogin()
                {
                    Username = textBoxUsername.Text,
                    Pass = textBoxPass.Text
                };
                userLogin.login(userLogin);
                this.Close();
            }
            else
            {
                textboxError.Visible = true;
                button1.BackColor = Color.FromArgb(textboxError.ForeColor.ToArgb());
                //DashBoard dashBoard = new DashBoard();
                //dashBoard.Show();
                //this.Close();
            }
        }
    }

    public class UserLogin
    {
        public string Username { get; set; }
        public string Pass { get; set; }

        public void login(UserLogin userLogin)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            databaseOps.login(userLogin);
        }
    }
}
