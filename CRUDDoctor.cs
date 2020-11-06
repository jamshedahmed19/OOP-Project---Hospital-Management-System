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
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            Doctor doctor = new Doctor();
            doctor.Name = textBoxName.Text;
            doctor.Gender = comboBoxGender.Text;
            doctor.Designation = textBoxDesignation.Text;
            doctor.Department = textBoxDepartment.Text;
            doctor.Email = textBoxEmail.Text;
            doctor.Address = textBoxAddress.Text;
            doctor.Tel_No = textBoxTel.Text;
            DatabaseOps insertDoc = new DatabaseOps();
            insertDoc.insert(doctor);
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DatabaseOps displayDoc = new DatabaseOps();
            dataGridView1.DataSource = displayDoc.display("DOCTORS");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.search("DOCTORS", textBoxSearch.Text, comboBoxSearchBy.Text);
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
                comboBoxGender.Text = "Male";
            }
            textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxDesignation.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Doctor doctor1 = new Doctor();
            doctor1.Id = textBoxid.Text;
            doctor1.Name = textBoxName.Text;
            doctor1.Gender = comboBoxGender.Text;
            doctor1.Designation = textBoxDesignation.Text;
            doctor1.Department = textBoxDepartment.Text;
            doctor1.Email = textBoxEmail.Text;
            doctor1.Address = textBoxAddress.Text;
            doctor1.Tel_No = textBoxTel.Text;
            DatabaseOps insertDoc = new DatabaseOps();
            insertDoc.update(doctor1);
        }
    }
}
