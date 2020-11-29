using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml;


namespace OOP_Project___Hospital_Management_System
{
    public partial class LABORATORYCRUD : UserControl
    {
        public LABORATORYCRUD()
        {
            InitializeComponent();
            display();

        }

        private void LABORATORYCRUD_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxPATGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Laboratory laboratory = new Laboratory()
            {
                Name = textBoxLABName.Text,
                Gender = comboBoxLABGender.Text,
                Email = textBoxLABEmail.Text,
                Tel = textBoxLABTel.Text,
                Address = textBoxLABAddress.Text,
                testfor = comboBoxLABTEST.Text
            };
            DatabaseOps insetlab = new DatabaseOps();
            insetlab.insert(laboratory);
            display();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void display()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.display("LABORATORY");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Laboratory lab1 = new Laboratory()
            {
                ID = textBoxLABid.Text,
                Name = textBoxLABName.Text,
                Gender = comboBoxLABGender.Text,
                Email = textBoxLABEmail.Text,
                Tel = textBoxLABTel.Text,
                Address = textBoxLABAddress.Text,
                testfor = comboBoxLABTEST.Text
            };
            DatabaseOps updatelab = new DatabaseOps();
            updatelab.update(lab1);
            display();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxLABid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxLABName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Male")
            {
                comboBoxLABGender.Text = "Male";
            }
            else
            {
                comboBoxLABGender.Text = "Female";
            }
            textBoxLABEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxLABTel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxLABAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "COVID")
            {
                comboBoxLABTEST.Text = "COVID";
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "VITAMIN B")
            {

                comboBoxLABTEST.Text = "VITAMIN B";
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "BLOOD GROUP")
            {

                comboBoxLABTEST.Text = "BLOOD GROUP";
            }
            else
            {
                comboBoxLABTEST.Text = "CBC";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            {
                if (textBoxLABid.Text.Length != 0)
                {
                    DatabaseOps databaseOps = new DatabaseOps();
                    databaseOps.delete("LABORATORY",textBoxLABid.Text);
                    display();
                }
                else
                {
                    MessageBox.Show("Unable to delete Data, Select a row which you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.search(textBoxSearch.Text);

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            display();
        }

        private void textBoxLABid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

