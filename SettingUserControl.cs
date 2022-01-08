using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project___Hospital_Management_System
{
    public partial class SettingUserControl : UserControl
    {
        public SettingUserControl(string iD)
        {
            InitializeComponent();
            ID = iD;
            departmentList();
            RolesList(); 
        }
        public string ID { get; set; }

        public DataTable getEmployeeeDetail(string id)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            return databaseOps.getEmployeeDetail(id);
        }


        public void departmentList()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            DataTable dataTable = new DataTable();
            dataTable = databaseOps.DepartmentList();
            comboBox2.DataSource = dataTable;
            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "DepartmentName";
        }

        public void RolesList()
        {
            DatabaseOps databaseOps = new DatabaseOps();
            DataTable dataTable = new DataTable();
            dataTable = databaseOps.RoleList();
            comboBox1.DataSource = dataTable;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Rolename";
        }

        private void SettingUserControl_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = getEmployeeeDetail(ID);
            textBoxEMPID.Text = dataTable.Rows[0][1].ToString();
            textBoxName.Text = dataTable.Rows[0][2].ToString();
            comboBox2.Text = dataTable.Rows[0][3].ToString();
            textBoxTel.Text = dataTable.Rows[0][4].ToString();
            textBoxEmail.Text = dataTable.Rows[0][5].ToString();
            textBoxPass.Text = dataTable.Rows[0][6].ToString();
            textBoxGender.Text = dataTable.Rows[0][7].ToString();
            textBoxAddress.Text = dataTable.Rows[0][8].ToString();
            comboBox1.Text = dataTable.Rows[0][9].ToString();
            textboxprice.Text = dataTable.Rows[0][10].ToString();

            //textBoxDesignation.Text = dataTable.Rows[0][4].ToString();





        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            textBoxName.ReadOnly = false;
            textBoxGender.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            textBoxAddress.ReadOnly = false;  
            textBoxTel.ReadOnly = false;
            textBoxPass.ReadOnly = false;
            textboxprice.ReadOnly = false;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor()
            {
                ID = textBoxEMPID.Text,
                Name = textBoxName.Text,
                Gender = textBoxGender.Text,
                Designation = comboBox1.SelectedValue.ToString(),
                Department = comboBox2.SelectedValue.ToString(),
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                Tel = textBoxTel.Text,
                Password = textBoxPass.Text,
                PricePerAppointment = int.Parse(textboxprice.Text),
            };
            DatabaseOps updateDoc = new DatabaseOps();
            updateDoc.update(doctor,"doctorlogin");
            textBoxName.ReadOnly = true;
            textBoxGender.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
            textBoxAddress.ReadOnly = true;
            textBoxTel.ReadOnly = true;
            textBoxPass.ReadOnly = true;
            textboxprice.ReadOnly = true;
        }

        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonInsert_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
