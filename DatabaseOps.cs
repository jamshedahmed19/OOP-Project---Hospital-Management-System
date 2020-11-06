namespace OOP_Project___Hospital_Management_System
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    
    internal class DatabaseOps
    {
        internal static string connection_string = @"Data Source=DESKTOP-3O5KR6I;Initial Catalog=HMS Database;Integrated Security=True";       
        internal SqlConnection sqlConnection;
        internal SqlDataAdapter sqlDataAdapter;
        internal SqlCommand sqlCommand; 

        public DatabaseOps()
        {
            sqlConnection = new SqlConnection(connection_string);
        }

        public void insert(Doctor doctor)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable display(string value)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + value + "", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                return dataTable;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable search(string tableValue, string searchValue, string searchByValue)
        {
            try
            {
                sqlConnection.Open();
                if (tableValue == "DOCTORS")
                {
                    if (searchByValue.ToLower() == "doctor id")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableValue + " WHERE DOC_ID LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                    else if (searchByValue.ToLower() == "number")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableValue + " WHERE DOC_TEL LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                    else if (searchByValue.ToLower() == "department")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableValue + " WHERE DOC_DEPART LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                    else if (searchByValue.ToLower() == "designation")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableValue + " WHERE DOC_DESIG LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                    else
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableValue + " WHERE DOC_NAME LIKE '%" + searchValue + "%'", sqlConnection);
                    }
                }
                else
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableValue + " WHERE DOC_NAME LIKE '%" + searchValue + "%'", sqlConnection);
                }
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                return dataTable;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void update(Doctor doctor)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE DOCTORS SET DOC_NAME = @NAME, DOC_GENDER = @GENDER, DOC_ADDRESS = @ADDRESS, DOC_tel = @TEL, DOC_DESIG = @DESIG, DOC_DEPART = @DEPART, DOC_EMAIL = @EMAIL WHERE DOC_ID = @DID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@DID", doctor.Id);
                sqlCommand.Parameters.AddWithValue("@NAME", doctor.Name);
                sqlCommand.Parameters.AddWithValue("@GENDER", doctor.Gender);
                sqlCommand.Parameters.AddWithValue("@ADDRESS", doctor.Address);
                sqlCommand.Parameters.AddWithValue("@TEL", doctor.Tel_No);
                sqlCommand.Parameters.AddWithValue("@DESIG", doctor.Designation);
                sqlCommand.Parameters.AddWithValue("@EMAIL", doctor.Email);
                sqlCommand.Parameters.AddWithValue("@DEPART", doctor.Department);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
