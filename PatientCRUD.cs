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
        public PatientCRUD()
        {
            InitializeComponent();
            doctorList();
            display();
        }


        public void doctorList()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            DataTable dataTable = new DataTable();
            dataTable = databaseOps.doctorList();
            comboBoxDOCID.DataSource = dataTable;
            comboBoxDOCID.ValueMember = "ID";
            comboBoxDOCID.DisplayMember = "DOC_NAME";
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
                DocCode = int.Parse(comboBoxDOCID.SelectedValue.ToString()),
                Email = textBoxPATEmail.Text,
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
            textBoxPATID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxPATName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxDOCID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Male")
            {
                comboBoxPATGender.Text = "Male";
            }
            else
            {
                comboBoxPATGender.Text = "Female";
            }
            textBoxPATTel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxPATEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxPATAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void buttonPATUpdate_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient()
            {
                Name = textBoxPATName.Text,
                Gender = comboBoxPATGender.Text,
                Tel = textBoxPATTel.Text,
                DocCode = int.Parse(comboBoxDOCID.Text),
                Email = textBoxPATEmail.Text,
                Address = textBoxPATAddress.Text,
            };
            DatabaseOps databaseOps = new DatabaseOps();
            databaseOps.insert(patient);
            display();
        }

        private void textBoxSearchVal_TextChanged(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.search("PATIENTS", textBoxSearchVal.Text, comboBoxSearchBy.Text);
        }

        private void buttonPATDisplay_Click(object sender, EventArgs e)
        {
            OutPatientUserControl outPatientUserControl = new OutPatientUserControl(textBoxPATID.Text, textBoxPATName.Text, comboBoxDOCID.SelectedValue.ToString());
            ControlClass.ShowControl(outPatientUserControl, Content);
        }
    }
}
