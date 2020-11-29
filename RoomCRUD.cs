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
    public partial class RoomCRUD : UserControl
    {
        public RoomCRUD()
        {
            InitializeComponent();
            display();
        }

        private void buttonRoomInsert_Click(object sender, EventArgs e)
        {
            if (textBoxRoomNo.Text.Length != 0 && comboBoxFloorNo.Text.Length != 0)
            {
                Room room = new Room()
                {
                    Room_No = int.Parse(textBoxRoomNo.Text),
                    Room_status = comboBoxStatus.Text,
                    Room_type = comboBoxType.Text,
                    Floor_No = char.Parse(comboBoxFloorNo.Text),
                };
                room.setPricePerHour();
                DatabaseOps insertRoom = new DatabaseOps();
                insertRoom.insert(room);
                display();
            }
            else
            {
                MessageBox.Show("Values Must not be Empty, Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRoomDisplay_Click(object sender, EventArgs e)
        {
            display();
        }

        public void display()
        {
            DatabaseOps insertRoom = new DatabaseOps();
            dataGridView1.DataSource = insertRoom.display("ROOM");
        }

        private void buttonRoomDelete_Click(object sender, EventArgs e)
        {
            if (textBoxRoomID.Text.Length != 0)
            {
                DatabaseOps databaseOps = new DatabaseOps();
                databaseOps.delete("ROOM", textBoxRoomNo.Text);
                display();
            }
            else
            {
                MessageBox.Show("Unable to delete Data, Select a row which you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRoomUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxRoomNo.Text.Length != 0 && comboBoxFloorNo.Text.Length != 0)
            {
                Room room = new Room()
                {
                    Room_No = int.Parse(textBoxRoomNo.Text),
                    Room_status = comboBoxStatus.Text,
                    Room_type = comboBoxType.Text,
                    Floor_No = char.Parse(comboBoxFloorNo.Text),
                };
                room.setPricePerHour();
                DatabaseOps updateRoom = new DatabaseOps();
                updateRoom.update(room);
                display();
            }
            else
            {
                MessageBox.Show("Values Must not be Empty, Unable to updated data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearchValue_TextChanged(object sender, EventArgs e)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            dataGridView1.DataSource = databaseOps.search("ROOM", textBoxSearchValue.Text, comboBoxSearchBy.Text);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxRoomID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxRoomNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxFloorNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxType.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
