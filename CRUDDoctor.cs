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
    }
}
