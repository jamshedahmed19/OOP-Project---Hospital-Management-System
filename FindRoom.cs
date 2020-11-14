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
            this.rOOMTableAdapter.Fill(this.hMS_DatabaseDataSet4.ROOM);
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
    }
}
