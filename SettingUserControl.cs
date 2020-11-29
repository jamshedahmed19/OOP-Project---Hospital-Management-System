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
        }
        public string ID { get; set; }

        public DataTable getEmployeeeDetail(string id)
        {
            DatabaseOps databaseOps = new DatabaseOps();
            return databaseOps.getEmployeeDetail(id);
        }

        private void SettingUserControl_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = getEmployeeeDetail(ID);
            textBoxEMPID.Text = dataTable.Rows[0][1].ToString();
            textBoxDepartid.Text = dataTable.Rows[0][11].ToString();
            textBoxName.Text = dataTable.Rows[0][2].ToString();
            textBoxDepartment.Text = dataTable.Rows[0][5].ToString();
            textBoxDesignation.Text = dataTable.Rows[0][4].ToString();
            textBoxEmail.Text = dataTable.Rows[0][7].ToString();
            textBoxGender.Text = dataTable.Rows[0][8].ToString();
            textBoxTel.Text = dataTable.Rows[0][6].ToString();
            textBoxAddress.Text = dataTable.Rows[0][9].ToString();
            textBoxPass.Text = dataTable.Rows[0][4].ToString();
        }
    }
}
