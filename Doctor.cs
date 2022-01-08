using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OOP_Project___Hospital_Management_System
{
    class Doctor : Person
    {
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Departmental_ID { get; set; }

        public string Password { get; set; }

        public int PricePerAppointment { get; set; }
        public Employee Employee { get; set; }

        public DateTime starttime { get; set; }

        public DateTime endtime { get; set; }
        public Doctor() : base() { }
        public Doctor(string iD, string name, string email, string gender, string tel, string address, string doc_desig, string depart) : base(iD, name, email, gender, tel, address)
        {
            this.Designation = doc_desig;
            this.Department = depart;
        }

        public string getDoctorID(string email)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            DataTable dataTable = new DataTable();
            return databaseOps.getDoctorID(email);
        }

        //public void addEmployee(Doctor doctor)
        //{
        //    Employee employee = new Employee()
        //    {
        //        Name = doctor.Name,
        //        Username = doctor.Email,
        //        Pass = "0123456789",
        //        Email = doctor.Email,
        //        Tel = doctor.Tel,
        //        Gender = doctor.Gender,
        //        Address = doctor.Address,
        //        Department = doctor.Department,
        //        Designation = doctor.Designation,
        //        Departmental_ID = getDoctorID(doctor.Email),
        //        Role = "Doctor",
        //    };
            //DatabaseOps databaseOps = new DatabaseOps();
            //databaseOps.insert(employee);
        //}
    }


    public class Appointment
    {
        public string AppointmentID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int TimeslotID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
    }
}
