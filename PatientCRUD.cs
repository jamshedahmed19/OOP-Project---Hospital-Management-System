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
    public partial class PatientCRUD : UserControl
    {
        public PatientCRUD(string id)
        {
            InitializeComponent();
            display();
            employeeid.Text = id;
        }


        public void display()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.display("PATIENTS");
        }

        private void buttonPATInsert_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient()
            {
                Name = textBoxPATName.Text,
                Gender = comboBoxPATGender.Text,
                Tel = textBoxPATTel.Text,
                CreatedBy = int.Parse(employeeid.Text),
                Date = dateTimePicker1.Value,
                Email = emailt.Text,
                Address = textBoxPATAddress.Text,
            };
            DatabaseOps databaseOps = new DatabaseOps();
            databaseOps.insert(patient);
            display();
        }

        private void buttonPATDelete_Click(object sender, EventArgs e)
        {
            if (textBoxPATID.Text.Length != 0)
            {
                DatabaseOps databaseOps = new DatabaseOps();
                databaseOps.delete("PATIENTS", textBoxPATID.Text);
                display();
            }
            else
            {
                MessageBox.Show("Unable to delete Data, Select a row which you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            display();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxPATID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxPATName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            
            if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "Male")
            {
                comboBoxPATGender.Text = "Male";
            }
            else
            {
                comboBoxPATGender.Text = "Female";
            }
            textBoxPATTel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            emailt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); 
            employeeid.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            textBoxPATAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void buttonPATUpdate_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient()
            {
                ID = textBoxPATID.Text,
                Name = textBoxPATName.Text,
                Gender = comboBoxPATGender.Text,
                Tel = textBoxPATTel.Text,
                Date = dateTimePicker1.Value,
                CreatedBy = int.Parse(employeeid.Text),
                Email = emailt.Text,
                Address = textBoxPATAddress.Text,
            };
            DatabaseOps databaseOps = new DatabaseOps();
            databaseOps.update(patient);
            display();
        }

        private void textBoxSearchVal_TextChanged(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.search("PATIENTS", textBoxSearchVal.Text, comboBoxSearchBy.Text);
        }

        private void buttonPATDisplay_Click(object sender, EventArgs e)
        {
            DoctorsAppointmentUserControl doctorsAppointmentUserControl = new DoctorsAppointmentUserControl();
            doctorsAppointmentUserControl.Show(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
