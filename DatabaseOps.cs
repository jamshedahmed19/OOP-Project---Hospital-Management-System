using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace OOP_Project___Hospital_Management_System
{
    class DatabaseOps
    {
        static string connection_string = @"Data Source=DESKTOP-3O5KR6I;Initial Catalog=HMS Database;Integrated Security=True";
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        SqlCommand sqlCommand;

        public DatabaseOps()
        {
            sqlConnection = new SqlConnection(connection_string);
        }

        public void insert(Doctor doctor)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("INSERT INTO DOCTORS(DOC_NAME, DOC_DEPART, DOC_TEL, DOC_EMAIL, DOC_PASS, DOC_GENDER, DOC_ADDRESS, DOC_DESIG) VALUES (@name, @depart, @tel, @email, @pass, @gender, @address, @desig)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", doctor.Name);
            sqlCommand.Parameters.AddWithValue("@depart", doctor.Department);
            sqlCommand.Parameters.AddWithValue("@tel", doctor.Tel_No);
            sqlCommand.Parameters.AddWithValue("@email", doctor.Email);
            sqlCommand.Parameters.AddWithValue("@pass", "123456865");
            sqlCommand.Parameters.AddWithValue("@gender", doctor.Gender);
            sqlCommand.Parameters.AddWithValue("@address", doctor.Address);
            sqlCommand.Parameters.AddWithValue("@desig", doctor.Designation);
            sqlCommand.ExecuteNonQuery();
        }

        public DataTable display(string value)
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + value + "", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
    }
}
