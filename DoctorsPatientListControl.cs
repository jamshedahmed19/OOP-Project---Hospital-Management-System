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
    public partial class DoctorsPatientListControl : UserControl
    {

        public string ID { get; set; }

        public DoctorsPatientListControl(string id)
        {
            InitializeComponent();
            ID = id;
        }

        public void display()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridViewINP.DataSource = databaseOps.doctosPatient(ID);
        }

        private void DoctorsPatientListControl_Load(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridViewINP_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxInpatientID.Text = dataGridViewINP.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxPatientName.Text = dataGridViewINP.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void buttonPATDelete_Click(object sender, EventArgs e)
        {
            //if (textBoxInpatientID.Text.Length != 0)
            //{
            //    DatabaseOps databaseOps = new DatabaseOps();
            //    databaseOps.delete("PATIENTS", textBoxInpatientID.Text);
            //    display();
            //}
            //else
            //{
                MessageBox.Show("Sorry You Cannot Delete Any Patient", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void textBoxSearchValue_TextChanged(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridViewINP.DataSource = databaseOps.searchPat(textBoxSearchValue.Text, comboBoxSearchBy.Text, ID);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
