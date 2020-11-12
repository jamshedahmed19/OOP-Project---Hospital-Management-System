using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project___Hospital_Management_System
{
    class Doctor : Person
    {
        public string Designation { get; set; }
        public string Department { get; set; }
        public Doctor() : base() { }
        public Doctor(string iD, string name, string email, string gender, string tel, string address, string doc_desig, string depart) : base(iD, name, email, gender, tel, address)
        {
            this.Designation = doc_desig;
            this.Department = depart;
        }

    }
}
