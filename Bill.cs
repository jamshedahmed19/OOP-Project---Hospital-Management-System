using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project___Hospital_Management_System
{
    class Bill
    {
        public string PatType { get; set; }
        public string RoomType { get; set; }
        public int RoomCharge { get; set; }
        public int DocCharge { get; set; }
        public int ServiceCharge { get; set; }
        public int NursingCharge { get; set; }
        public int NumberOfDays { get; set; }

        public Bill(string roomType, int noOfDays)
        {
            //PatType = patType;
            RoomType = roomType;
            NumberOfDays = noOfDays;
        }

        public void getBill()
        {
            if (RoomType == "deluxe")
            {
                RoomCharge = 5000 * NumberOfDays;
                ServiceCharge = 1500 * NumberOfDays;
                NursingCharge = 1500 * NumberOfDays;
                DocCharge = 2500 * NumberOfDays;
            }
            else if (RoomType == "private")
            {
                RoomCharge = 3000 * NumberOfDays;
                ServiceCharge = 1000 * NumberOfDays;
                NursingCharge = 1000 * NumberOfDays;
                DocCharge = 2000 * NumberOfDays;
            }
            else
            {
                RoomCharge = 2000 * NumberOfDays;
                ServiceCharge = 500 * NumberOfDays;
                NursingCharge = 800 * NumberOfDays;
                DocCharge = 1500 * NumberOfDays;
            }
        }
    }
}
