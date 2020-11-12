using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project___Hospital_Management_System
{
    public abstract class Person
    {
        protected Person()
        {

        }
        protected Person(string iD, string name, string email, string gender, string tel, string address)
        {
            ID = iD;
            Name = name;
            Email = email;
            Gender = gender;
            Tel = tel;
            Address = address;
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
    }
}
