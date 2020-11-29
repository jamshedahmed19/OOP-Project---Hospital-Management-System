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

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void display()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridViewINP.DataSource = databaseOps.displayInPat();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class Inpatient : Patient
    {
        public int PatID { get; set; }
        public string RoomNo { get; set; }
        public DateTime Admission { get; set; }
        public DateTime Discharge { get; set; }
        public int Advance { get; set; }
    }
}
