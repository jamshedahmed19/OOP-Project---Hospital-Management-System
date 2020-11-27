namespace OOP_Project___Hospital_Management_System
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Runtime.InteropServices;
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
                sqlCommand.Parameters.AddWithValue("@tel", doctor.Tel);
                sqlCommand.Parameters.AddWithValue("@email", doctor.Email);
                sqlCommand.Parameters.AddWithValue("@pass", "123456865");
                sqlCommand.Parameters.AddWithValue("@gender", doctor.Gender);
                sqlCommand.Parameters.AddWithValue("@address", doctor.Address);
                sqlCommand.Parameters.AddWithValue("@desig", doctor.Designation);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insert(Patient patient)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO PATIENTS(PAT_NAME, PAT_TEL, PAT_EMAIL, PAT_GENDER, PAT_ADDRESS, DOC_CODE) VALUES (@name, @tel, @email, @gender, @address, @doc)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", patient.Name);
                sqlCommand.Parameters.AddWithValue("@tel", patient.Tel);
                sqlCommand.Parameters.AddWithValue("@email", patient.Email);
                sqlCommand.Parameters.AddWithValue("@gender", patient.Gender);
                sqlCommand.Parameters.AddWithValue("@address", patient.Address);
                sqlCommand.Parameters.AddWithValue("@doc", patient.DocCode);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insert(Room room)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO ROOM(ROOM_NO, FLOOR_NO, ROOM_STATUS, ROOM_TYPE, PRICE_PER_HOUR) VALUES (@ROOM_NO, @FLOOR_NO, @ROOM_STATUS, @ROOM_TYPE, @PRICE_PER_HOUR)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ROOM_NO", room.Room_No);
                sqlCommand.Parameters.AddWithValue("@FLOOR_NO", room.Floor_No);
                sqlCommand.Parameters.AddWithValue("@ROOM_STATUS", room.Room_status);
                sqlCommand.Parameters.AddWithValue("@ROOM_TYPE", room.Room_type);
                sqlCommand.Parameters.AddWithValue("@PRICE_PER_HOUR", room.Price_Per_Hour);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void insert(Inpatient inpatient)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("INSERT INTO INPATIENT(DATE_OF_AD, DATE_OF_DIS, ADVANCE, ROOM_CODE, PAT_CODE) VALUES (@DATE_OF_AD, @DATE_OF_DIS, @ADVANCE, @ROOM_CODE, @PAT_CODE)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@DATE_OF_AD", inpatient.Admission);
                sqlCommand.Parameters.AddWithValue("@DATE_OF_DIS", inpatient.Discharge);
                sqlCommand.Parameters.AddWithValue("@ADVANCE", inpatient.Advance);
                sqlCommand.Parameters.AddWithValue("@ROOM_CODE", inpatient.RoomNo);
                sqlCommand.Parameters.AddWithValue("@PAT_CODE", inpatient.PatID);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registered Successfully", "Registered", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update(Doctor doctor)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE DOCTORS SET DOC_NAME = @NAME, DOC_GENDER = @GENDER, DOC_ADDRESS = @ADDRESS, DOC_tel = @TEL, DOC_DESIG = @DESIG, DOC_DEPART = @DEPART, DOC_EMAIL = @EMAIL WHERE DOC_ID = @DID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@DID", doctor.ID);
                sqlCommand.Parameters.AddWithValue("@NAME", doctor.Name);
                sqlCommand.Parameters.AddWithValue("@GENDER", doctor.Gender);
                sqlCommand.Parameters.AddWithValue("@ADDRESS", doctor.Address);
                sqlCommand.Parameters.AddWithValue("@TEL", doctor.Tel);
                sqlCommand.Parameters.AddWithValue("@DESIG", doctor.Designation);
                sqlCommand.Parameters.AddWithValue("@EMAIL", doctor.Email);
                sqlCommand.Parameters.AddWithValue("@DEPART", doctor.Department);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to updated Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update(Room room)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE ROOM SET FLOOR_NO = @FLOOR_NO, ROOM_STATUS = @ROOM_STATUS, ROOM_TYPE = @ROOM_TYPE, PRICE_PER_HOUR = @PRICE_PER_HOUR WHERE ROOM_NO = @ROOM_NO", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ROOM_NO", room.Room_No);
                sqlCommand.Parameters.AddWithValue("@FLOOR_NO", room.Floor_No);
                sqlCommand.Parameters.AddWithValue("@ROOM_STATUS", room.Room_status);
                sqlCommand.Parameters.AddWithValue("@ROOM_TYPE", room.Room_type);
                sqlCommand.Parameters.AddWithValue("@PRICE_PER_HOUR", room.Price_Per_Hour);
                int a = sqlCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to updated Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void delete(string tableValue, string id)
        {
            try
            {
                sqlConnection.Open();
                if (tableValue == "DOCTORS")
                {
                    sqlCommand = new SqlCommand("DELETE FROM " + tableValue + " WHERE DOC_ID = @DID",
                    sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@DID", id);
                }
                else if (tableValue == "PATIENTS")
                {
                    sqlCommand = new SqlCommand("DELETE FROM " + tableValue + " WHERE PAT_ID = @PID",
                    sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@PID", id);
                }
                else if (tableValue == "ROOM")
                {
                    sqlCommand = new SqlCommand("DELETE FROM " + tableValue + " WHERE ROOM_NO = @RID",
                    sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@RID", id);
                }
                sqlCommand.ExecuteNonQuery();
                int a = sqlCommand.ExecuteNonQuery();
                if (a == 0)
                {
                    MessageBox.Show("Data Deleted Successfully", "Deleted", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to delete Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable display(string value)
        {
            sqlConnection.Open();
            if (value == "PATIENTS")
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT PAT_ID, PAT_NAME, DOC_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS, DOC_DESIG, DOC_DEPART FROM PATIENTS INNER JOIN DOCTORS ON DOC_CODE=DOCTORS.ID", sqlConnection);
            }
            else
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + value + "", sqlConnection);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable display()
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ROOM_STATUS = 'AVAILABLE'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
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
                else if (tableValue == "PATIENTS")
                {
                    if (searchByValue.ToLower() == "patient name")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT PAT_ID, PAT_NAME, DOC_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS, DOC_DESIG, DOC_DEPART FROM PATIENTS INNER JOIN DOCTORS ON PAT_NAME LIKE '%" + searchValue + "%' AND DOC_CODE=DOCTORS.ID", sqlConnection);
                    }
                    else if (searchByValue.ToLower() == "doctor name")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT PAT_ID, PAT_NAME, DOC_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS, DOC_DESIG, DOC_DEPART FROM PATIENTS INNER JOIN DOCTORS ON DOC_NAME LIKE '%" + searchValue + "%' AND DOC_CODE=DOCTORS.ID", sqlConnection);
                    }
                    else if (searchByValue.ToLower() == "patient number")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT PAT_ID, PAT_NAME, DOC_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS, DOC_DESIG, DOC_DEPART FROM PATIENTS INNER JOIN DOCTORS ON PAT_TEL LIKE '%" + searchValue + "%' AND DOC_CODE=DOCTORS.ID", sqlConnection);
                    }
                    else if (searchByValue.ToLower() == "doctor designation")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT PAT_ID, PAT_NAME, DOC_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS, DOC_DESIG, DOC_DEPART FROM PATIENTS INNER JOIN DOCTORS ON DOC_DESIG LIKE '%" + searchValue + "%' AND DOC_CODE=DOCTORS.ID", sqlConnection);
                    }
                    else if (searchByValue.ToLower() == "doctor department")
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT PAT_ID, PAT_NAME, DOC_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS, DOC_DESIG, DOC_DEPART FROM PATIENTS INNER JOIN DOCTORS ON DOC_DEPART LIKE '%" + searchValue + "%' AND DOC_CODE=DOCTORS.ID", sqlConnection);
                    }
                    else
                    {
                        sqlDataAdapter = new SqlDataAdapter("SELECT PAT_ID, PAT_NAME, DOC_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS, DOC_DESIG, DOC_DEPART FROM PATIENTS INNER JOIN DOCTORS ON PAT_ID LIKE '%" + searchValue + "%' AND DOC_CODE=DOCTORS.ID", sqlConnection);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable search(string searchValue, string searchByValue)
        {
            try
            {
                sqlConnection.Open();
                if (searchByValue.ToLower() == "room no")
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ROOM_STATUS = 'AVAILABLE' AND ROOM_NO LIKE '%" + searchValue + "%'", sqlConnection);
                }
                else if (searchByValue.ToLower() == "type")
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ROOM_STATUS = 'AVAILABLE' AND ROOM_TYPE LIKE '%" + searchValue + "%'", sqlConnection);
                }
                else if (searchByValue.ToLower() == "floor no")
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ROOM_STATUS = 'AVAILABLE' AND FLOOR_NO LIKE '%" + searchValue + "%'", sqlConnection);
                }
                else
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ROOM_STATUS = 'AVAILABLE'", sqlConnection);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable search(string tableValue, string roomNo, string roomType, string floorNo)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableValue + " WHERE ROOM_STATUS = 'AVAILABLE' AND ROOM_NO LIKE '%" + roomNo + "%' AND ROOM_TYPE LIKE '%" + roomType + "%' AND FLOOR_NO LIKE '%" + floorNo + "%'", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable doctorList()
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM DOCTORS ORDER BY DOC_NAME", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable patientList()
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM PATIENTS ORDER BY PAT_NAME", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable roomList(string roomType)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ROOM WHERE ROOM_STATUS = 'AVAILABLE' AND ROOM_TYPE = '" + roomType + "'", sqlConnection);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public void login(UserLogin userLogin)
        {
            try
            {
                sqlConnection.Open();
                string query = "SELECT * FROM EMPLOYEE WHERE USERNAME = '" + userLogin.Username + "' AND EMP_PASS = '" + userLogin.Pass + "'";
                sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    DashBoard dashBoard = new DashBoard()
                    {
                        ID = sqlDataReader.GetValue(0).ToString().ToLower(),
                        Role = sqlDataReader.GetValue(10).ToString().ToLower()
                    };
                    dashBoard.Show();
                }
                else
                {
                    MessageBox.Show("Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
