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
        }

        private void buttonRoomInsert_Click(object sender, EventArgs e)
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
            insertRoom.insertRoom(room);
        }

        private void buttonRoomDisplay_Click(object sender, EventArgs e)
        {
            DatabaseOps insertRoom = new DatabaseOps();
            dataGridView1.DataSource = insertRoom.display("ROOM");
        }
    }
}
