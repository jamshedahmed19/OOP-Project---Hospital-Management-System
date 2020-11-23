using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml;

namespace OOP_Project___Hospital_Management_System
{
    public partial class CRUDDoctor : UserControl
    {
        public CRUDDoctor()
        {
            InitializeComponent();
            display();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            Doctor doctor = new Doctor()
            {
                Name = textBoxName.Text,
                Gender = comboBoxGender.Text,
                Designation = textBoxDesignation.Text,
                Department = textBoxDepartment.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                Tel = textBoxTel.Text
            };
            DatabaseOps insertDoc = new DatabaseOps();
            insertDoc.insert(doctor);
            display();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxTel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString() == "Male")
            {
                comboBoxGender.Text = "Male";
            }
            else
            {
                comboBoxGender.Text = "Female";
            }
            textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxDesignation.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Doctor doctor1 = new Doctor()
            {
                ID = textBoxid.Text,
                Name = textBoxName.Text,
                Gender = comboBoxGender.Text,
                Designation = textBoxDesignation.Text,
                Department = textBoxDepartment.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                Tel = textBoxTel.Text
            };
            DatabaseOps updateDoc = new DatabaseOps();
            updateDoc.update(doctor1);
            display();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text.Length != 0)
            {
                DatabaseOps databaseOps = new DatabaseOps();
                databaseOps.delete("DOCTORS", textBoxid.Text);
                display();
            }
            else
            {
                MessageBox.Show("Unable to delete Data, Select a row which you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void display()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.display("DOCTORS");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.search("DOCTORS", textBoxSearch.Text, comboBoxSearchBy.Text);
        }
    }
}
