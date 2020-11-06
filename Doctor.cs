using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project___Hospital_Management_System
{
    class Doctor
    {
        string id;
        string name, gender, department, designation, tel_no, email, address;

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public string Designation
        {
            get { return this.designation; }
            set { this.designation = value; }
        }

        public string Tel_No
        {
            get { return this.tel_no; }
            set { this.tel_no = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public Doctor()
        {

        }

        public Doctor(string name, string gender, string tel_no, string email, string depart, string desig, string address)
        {
            this.Name = name;
            this.Gender = gender;
            this.Tel_No = tel_no;
            this.Email = email;
            this.Department = depart;
            this.Designation = desig;
            this.address = address;
        }

        public Doctor(string id, string name, string gender, string tel_no, string email, string depart, string desig, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Tel_No = tel_no;
            this.Email = email;
            this.Department = depart;
            this.Designation = desig;
            this.address = address;
        }

        public void InsertDocData()
        {

        }
    }
}
