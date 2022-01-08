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
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            Doctor doctor = new Doctor()
            {
                Name = textBoxName.Text,
                Gender = comboBoxGender.Text,
                Designation = rolecbx.SelectedItem.ToString(),
                Department = depcbx.SelectedItem.ToString(),
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                Tel = textBoxTel.Text,
                starttime = dateTimePicker1.Value,
                endtime = dateTimePicker2.Value,
                PricePerAppointment = int.Parse(priceperappointment.Text),
            };
            DatabaseOps insertDoc = new DatabaseOps();
            insertDoc.insert(doctor);
            display();
            //doctor.addEmployee(doctor);
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            display();
        }
        int DoctorID;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DoctorID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            depcbx.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxTel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "Male")
            {
                comboBoxGender.Text = "Male";
            }
            else
            {
                comboBoxGender.Text = "Female";
            }
            textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            rolecbx.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            //dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString());
            //dateTimePicker2.Value = Convert.ToDateTime();
            priceperappointment.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            //dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString());
            //dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString());

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor()
            {
                ID = textBoxid.Text,
                Name = textBoxName.Text,
                Gender = comboBoxGender.Text,
                Designation = rolecbx.SelectedItem.ToString(),
                Department = depcbx.SelectedItem.ToString(),
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                Password = "123456865",
                Tel = textBoxTel.Text,
                starttime = dateTimePicker1.Value,
                endtime = dateTimePicker2.Value,
                PricePerAppointment = int.Parse(priceperappointment.Text),
            };
            DatabaseOps updateDoc = new DatabaseOps();
            updateDoc.DeleteTimeSlots(DoctorID);
            updateDoc.update(doctor);
            display();
            //doctor.addEmployee(doctor);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text.Length != 0)
            {
                DatabaseOps databaseOps = new DatabaseOps();
                DatabaseOps db = new DatabaseOps();
                databaseOps.DeleteTimeSlots(DoctorID);
                db.delete("DOCTORS", textBoxid.Text);
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
            DataTable dt = new DataTable();
            dataGridView1.DataSource = databaseOps.display("DOCTORS");
            databaseOps.Showincbx(depcbx, "Department", "DepartmentName");
            databaseOps.Showincbx(rolecbx, "DoctorRoles", "Rolename");

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.search("DOCTORS", textBoxSearch.Text, comboBoxSearchBy.Text);
        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void rolecbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void depcbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dOCTORSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
