using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project___Hospital_Management_System
{
    public partial class FindRoom : Form
    {
        public FindRoom()
        {
            InitializeComponent();
            display();
        }

        private void FindRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMS_DatabaseDataSet4.ROOM' table. You can move, or remove it, as needed.
            //this.rOOMTableAdapter.Fill(this.hMS_DatabaseDataSet4.ROOM);
        }

        private void textBoxRoomNo_TextChanged(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.search("ROOM", textBoxRoomNo.Text, "room no");
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.search("ROOM", comboBoxType.Text, "type");
        }

        private void buttonFindRoom_Click(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.search("ROOM", textBoxRoomNo.Text, comboBoxType.Text, comboBoxFloorNo.Text);
        }

        public void display()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.display();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxRoomNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxFloorNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxType.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "SELECT")
            {
                if (MessageBox.Show("Are you sure you want to select this room?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //InpatientUserControl inpatientUserControl = new InpatientUserControl()
                    //{ 
                    //    RoomNo = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    //    FloorNo = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    //    RoomType = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    //};
                    ////inpatientUserControl.SelectRoom();
                    //this.Close();
                }
            }
        }
    }
}
