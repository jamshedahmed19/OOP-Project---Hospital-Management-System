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
    public partial class InpatientUserControl : UserControl
    {
        public InpatientUserControl()
        {
            InitializeComponent();
            patientList();
            display();
        }

        public void roomList()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            DataTable dataTable = new DataTable();
            dataTable = databaseOps.roomList(comboBoxRType.Text);
            comboBoxRNo.DataSource = dataTable;
            comboBoxRNo.ValueMember = "ID";
            comboBoxRNo.DisplayMember = "ID";
        }

        public void patientList()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            DataTable dataTable = new DataTable();
            dataTable = databaseOps.patientList();
            comboBoxPatient.DataSource = dataTable;
            comboBoxPatient.DisplayMember = "PAT_NAME";
            comboBoxPatient.ValueMember = "ID";
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            FindRoom findRoom = new FindRoom();
            findRoom.Show();
        }

        private void comboBoxRType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRNo.Enabled = true;
            roomList();
        }

        private void buttonRoomInsert_Click(object sender, EventArgs e)
        {
            Inpatient inpatient = new Inpatient();
            inpatient.PatID = int.Parse(comboBoxPatient.SelectedValue.ToString());
            inpatient.RoomNo = comboBoxRNo.SelectedValue.ToString();
            inpatient.Admission = dateTimePickerDOA.Value.Date;
            inpatient.Discharge = dateTimePickerDOD.Value.Date;
            inpatient.Advance = 10000;
            DatabaseOps databaseOps = new DatabaseOps();
            databaseOps.insert(inpatient);
            display();
        }

        public void display()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridViewINP.DataSource = databaseOps.displayInPat();
        }

        private void buttonRoomUpdate_Click(object sender, EventArgs e)
        {
            Inpatient inpatient = new Inpatient()
            {
                PatID = int.Parse(comboBoxPatient.SelectedValue.ToString()),
                InPatID = int.Parse(textBoxInpatientID.Text),
                RoomNo = comboBoxRNo.SelectedValue.ToString(),
                Admission = dateTimePickerDOA.Value.Date,
                Discharge = dateTimePickerDOD.Value.Date,
            };
            DatabaseOps databaseOps = new DatabaseOps();
            databaseOps.update(inpatient);
            display();
        }

        private void textBoxSearchVal_TextChanged(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridViewINP.DataSource = databaseOps.search("INPATIENTS", textBoxSearchVal.Text, comboBoxSearchBy.Text);
        }

        private void dataGridViewINP_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxInpatientID.Text = dataGridViewINP.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxPatient.SelectedValue = dataGridViewINP.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxPatient.SelectedText = dataGridViewINP.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridViewINP.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePickerDOA.Value = Convert.ToDateTime(dataGridViewINP.Rows[e.RowIndex].Cells[4].Value);
            dateTimePickerDOD.Value = Convert.ToDateTime(dataGridViewINP.Rows[e.RowIndex].Cells[5].Value);
            comboBoxRNo.Text = dataGridViewINP.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBoxRType.Text = dataGridViewINP.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void buttonRoomDelete_Click(object sender, EventArgs e)
        {
            if (textBoxInpatientID.Text.Length != 0)
            {
                DatabaseOps databaseOps = new DatabaseOps();
                databaseOps.delete("INPATIENT", textBoxInpatientID.Text);
                display();
            }
            else
            {
                MessageBox.Show("Unable to delete Data, Select a row which you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            display();
        }
    }

    class Inpatient : Patient
    {
        public int PatID { get; set; }
        public int InPatID { get; set; }
        public string RoomNo { get; set; }
        public DateTime Admission { get; set; }
        public DateTime Discharge { get; set; }
        public int Advance { get; set; }
    }
}
