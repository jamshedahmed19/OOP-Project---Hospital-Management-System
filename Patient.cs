using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project___Hospital_Management_System
{
    class Patient : Person
    {
        public int DocCode { get; set; }
        public Patient() : base() { }
        public Patient(string iD, string name, string email, string gender, string tel, string address, int doc_code) : base(iD, name, email, gender, tel, address)
        {
            this.DocCode = doc_code;
        }
    }
}
