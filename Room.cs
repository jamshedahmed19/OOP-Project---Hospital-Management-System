using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project___Hospital_Management_System
{
    class Room
    {
        int room_no;
        char floor_no;
        string room_status;
        int price_per_hour;
        string room_type;

        public string InPat_Code { get; set; }
        public int Room_ID { get; }

        public int Room_No
        {
            get => room_no;
            set
            {
                if (this.room_no >= 0)
                {
                    this.room_no = value;
                }
                else
                {
                    MessageBox.Show("Room Number can't be negative");
                }
            }
        }

        public char Floor_No
        {
            get => floor_no;
            set
            {
                if (this.floor_no.ToString().Length == 1)
                {
                    this.floor_no = value;
                }
                else
                {
                    MessageBox.Show("Floor should be correct");
                }
            }
        }

        public string Room_status
        {
            get => room_status;
            set
            {
                if (this.room_status != "")
                {
                    room_status = value;
                }
                else
                {
                    MessageBox.Show("Status is not correct");
                }
            }
        }

        public int Price_Per_Hour
        {
            get => price_per_hour;
        }

        public void setPricePerHour()
        {
            if (this.room_type == "Deluxe")
            {
                price_per_hour = 1500;
            }
            else if (this.Room_type == "Private")
            {
                price_per_hour = 1000;
            }
            else
            {
                price_per_hour = 500;
            }
        }


        //public int GetPricePerDay()
        //{
        //    return price_per_hour;
        //}

        public string Room_type
        {
            get => room_type;
            set
            {
                if (this.room_type != "")
                {
                    room_type = value;
                }
                else
                {
                    MessageBox.Show("Value is too short");
                }
            }
        }


        //public int GetTotalAmount()
        //{

        //}
    }
}
