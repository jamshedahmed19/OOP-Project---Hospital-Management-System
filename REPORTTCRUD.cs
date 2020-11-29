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
    public partial class REPORTTCRUD : UserControl
    {
        public REPORTTCRUD()
        {
            InitializeComponent();
            display();
        }

        private void textboxREPresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void display()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.display("LABORATORY");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.searchbyname(textBoxSearch.Text);

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxREPid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxREPName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Male")
            {
                comboBoxREPGender.Text = "Male";
            }
            else
            {
                comboBoxREPGender.Text = "Female";
            }
            textBoxLABEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxLABTel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxLABAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "COVID")
            {
                comboBoxREPTEST.Text = "COVID";
                textboxREPresult.Text = "You have tested NEGATIVE";
                textboxREPremarks.Text = "Follow SPS and keep taking Precautions.";

            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "VITAMIN B")
            {
                comboBoxREPTEST.Text = "VITAMIN B";
                textboxREPresult.Text = "Your Vitamin B is fine.";
                textboxREPremarks.Text = "Keeo eating foods full of VITAMIN B";
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()=="BLOOD GROUP")
            {
                comboBoxREPTEST.Text = "BLOOD TEST";
                Random random = new Random();
                int num = random.Next(8);
                if (num==0)
                {
                    textboxREPresult.Text = "O-";
                }
                else if (num==1)
                {
                    textboxREPresult.Text = "O+";
                }
                else if (num == 2)
                {
                    textboxREPresult.Text = "A-";
                }
                else if (num == 3)
                {
                    textboxREPresult.Text = "A+";
                }
                else if (num == 4)
                {
                    textboxREPresult.Text = "B-";
                }
                else if (num==5)
                {
                    textboxREPresult.Text = "B+";
                }
                else if (num==6)
                {
                    textboxREPresult.Text = "AB-";
                }
                else
                {
                    textboxREPresult.Text = "AB+";
                }
            }
            else
            {
                comboBoxREPTEST.Text = "CBC";
                textboxREPresult.Text = "Your platelets are fine";
                textboxREPremarks.Text = "Hypochromic Anisocytosis";
            }
        }
    }
}
