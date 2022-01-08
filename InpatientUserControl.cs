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
            inpatient.TotalAmount = int.Parse(textBox1.Text);
            DatabaseOps databaseOps = new DatabaseOps();
            if (inpatient.ifinpatientalreadyexisted(inpatient.PatID, inpatient.Admission) == true)
            {
                databaseOps.insert(inpatient);
                databaseOps.updateRoomAvailability(Convert.ToInt32(inpatient.RoomNo), "Unavailable");
            }
            else
            {
                MessageBox.Show("Unable to Assign room because room already assignes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                TotalAmount = int.Parse(textBox1.Text),
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
            textBox1.Text = dataGridViewINP.Rows[e.RowIndex].Cells[8].Value.ToString();
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

        private void dataGridViewINP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int noofdays;
        private void button1_Click(object sender, EventArgs e)
        {
            Room patientroom = new Room();
            patientroom.Room_type = comboBoxRType.SelectedItem.ToString();
            patientroom.setPricePerHour();
            DateTime dt1 = dateTimePickerDOA.Value;
            DateTime dt2 = dateTimePickerDOD.Value;
            TimeSpan t = dt2 - dt1;
            noofdays = Convert.ToInt32(t.TotalDays);
            textBox1.Text = Convert.ToString(noofdays * patientroom.Price_Per_Hour);
        }
    }

    class Inpatient : Patient
    {
        public int PatID { get; set; }
        public int InPatID { get; set; }
        public string RoomNo { get; set; }
        public DateTime Admission { get; set; }
        public DateTime Discharge { get; set; }
        public int TotalAmount { get; set; }


        public bool ifinpatientalreadyexisted(int pid, DateTime stdate)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            DataTable dt = new DataTable();
            dt = databaseOps.displayInPat();

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (pid == Convert.ToInt32(dt.Rows[i][1].ToString()))
            //    {
            //        if (stdate > Convert.ToDateTime(dt.Rows[i]["DATE_OF_DIS"]))
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }

            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}

            return true;
        }
    }
}
