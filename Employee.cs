using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project___Hospital_Management_System
{
    class Employee : Person
    {
        public string Department { get; set; }
        public string Designation { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Role { get; set; }
        public string Departmental_ID { get; set; }
        public Employee() : base() { }
    }
}
