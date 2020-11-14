namespace OOP_Project___Hospital_Management_System
{
    partial class InpatientUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InpatientUserControl));
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNPATCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMS_DatabaseDataSet2 = new OOP_Project___Hospital_Management_System.HMS_DatabaseDataSet2();
            this.comboBoxSearchValue = new System.Windows.Forms.ComboBox();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxInpatientID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rOOMTableAdapter = new OOP_Project___Hospital_Management_System.HMS_DatabaseDataSet2TableAdapters.ROOMTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.buttonRoomDisplay = new System.Windows.Forms.Button();
            this.buttonRoomUpdate = new System.Windows.Forms.Button();
            this.buttonRoomDelete = new System.Windows.Forms.Button();
            this.buttonRoomInsert = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxRoomNo = new System.Windows.Forms.ComboBox();
            this.comboBoxFloorNo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerDOD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDOA = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Panel();
            this.buttonRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DatabaseDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Raleway", 10.2F);
            this.textBoxEmail.Location = new System.Drawing.Point(216, 183);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(418, 20);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDepartment.Font = new System.Drawing.Font("Raleway", 10.2F);
            this.textBoxDepartment.Location = new System.Drawing.Point(216, 157);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(123, 20);
            this.textBoxDepartment.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label8.Location = new System.Drawing.Point(67, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "DEPARTMENT:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress.Font = new System.Drawing.Font("Raleway", 10.2F);
            this.textBoxAddress.Location = new System.Drawing.Point(216, 209);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(418, 56);
            this.textBoxAddress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "PATIENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.rOOMNODataGridViewTextBoxColumn,
            this.rOOMSTATUSDataGridViewTextBoxColumn,
            this.rOOMTYPEDataGridViewTextBoxColumn,
            this.iNPATCODEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rOOMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(511, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 384);
            this.dataGridView1.TabIndex = 13;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rOOMNODataGridViewTextBoxColumn
            // 
            this.rOOMNODataGridViewTextBoxColumn.DataPropertyName = "ROOM_NO";
            this.rOOMNODataGridViewTextBoxColumn.HeaderText = "ROOM_NO";
            this.rOOMNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rOOMNODataGridViewTextBoxColumn.Name = "rOOMNODataGridViewTextBoxColumn";
            // 
            // rOOMSTATUSDataGridViewTextBoxColumn
            // 
            this.rOOMSTATUSDataGridViewTextBoxColumn.DataPropertyName = "ROOM_STATUS";
            this.rOOMSTATUSDataGridViewTextBoxColumn.HeaderText = "ROOM_STATUS";
            this.rOOMSTATUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rOOMSTATUSDataGridViewTextBoxColumn.Name = "rOOMSTATUSDataGridViewTextBoxColumn";
            // 
            // rOOMTYPEDataGridViewTextBoxColumn
            // 
            this.rOOMTYPEDataGridViewTextBoxColumn.DataPropertyName = "ROOM_TYPE";
            this.rOOMTYPEDataGridViewTextBoxColumn.HeaderText = "ROOM_TYPE";
            this.rOOMTYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rOOMTYPEDataGridViewTextBoxColumn.Name = "rOOMTYPEDataGridViewTextBoxColumn";
            // 
            // iNPATCODEDataGridViewTextBoxColumn
            // 
            this.iNPATCODEDataGridViewTextBoxColumn.DataPropertyName = "INPAT_CODE";
            this.iNPATCODEDataGridViewTextBoxColumn.HeaderText = "INPAT_CODE";
            this.iNPATCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iNPATCODEDataGridViewTextBoxColumn.Name = "iNPATCODEDataGridViewTextBoxColumn";
            // 
            // rOOMBindingSource
            // 
            this.rOOMBindingSource.DataMember = "ROOM";
            this.rOOMBindingSource.DataSource = this.hMS_DatabaseDataSet2;
            // 
            // hMS_DatabaseDataSet2
            // 
            this.hMS_DatabaseDataSet2.DataSetName = "HMS_DatabaseDataSet2";
            this.hMS_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSearchValue
            // 
            this.comboBoxSearchValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSearchValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxSearchValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.comboBoxSearchValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSearchValue.Font = new System.Drawing.Font("Raleway", 14F);
            this.comboBoxSearchValue.FormattingEnabled = true;
            this.comboBoxSearchValue.Items.AddRange(new object[] {
            "Doctor ID",
            "Name",
            "Number",
            "Designation",
            "Department"});
            this.comboBoxSearchValue.Location = new System.Drawing.Point(1035, 86);
            this.comboBoxSearchValue.Name = "comboBoxSearchValue";
            this.comboBoxSearchValue.Size = new System.Drawing.Size(159, 40);
            this.comboBoxSearchValue.TabIndex = 3;
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.comboBoxPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPatient.Font = new System.Drawing.Font("Raleway", 12F);
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.comboBoxPatient.Location = new System.Drawing.Point(243, 129);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(254, 36);
            this.comboBoxPatient.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label16.Location = new System.Drawing.Point(67, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 34);
            this.label16.TabIndex = 0;
            this.label16.Text = "PATIENT:";
            // 
            // textBoxInpatientID
            // 
            this.textBoxInpatientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxInpatientID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInpatientID.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxInpatientID.Location = new System.Drawing.Point(243, 95);
            this.textBoxInpatientID.Name = "textBoxInpatientID";
            this.textBoxInpatientID.ReadOnly = true;
            this.textBoxInpatientID.Size = new System.Drawing.Size(254, 28);
            this.textBoxInpatientID.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Raleway", 14F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label17.Location = new System.Drawing.Point(515, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 34);
            this.label17.TabIndex = 0;
            this.label17.Text = "SEARCH BY:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Raleway", 14F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label18.Location = new System.Drawing.Point(831, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(198, 34);
            this.label18.TabIndex = 0;
            this.label18.Text = "SEARCH VALUE:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label19.Location = new System.Drawing.Point(67, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(171, 34);
            this.label19.TabIndex = 0;
            this.label19.Text = "INPATIENT ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label6.Location = new System.Drawing.Point(67, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "EMAIL:";
            // 
            // rOOMTableAdapter
            // 
            this.rOOMTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label11.Location = new System.Drawing.Point(67, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 34);
            this.label11.TabIndex = 0;
            this.label11.Text = "ADMIT DATE:";
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSearchBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.comboBoxSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Raleway", 14F);
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Doctor ID",
            "Name",
            "Number",
            "Designation",
            "Department"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(673, 86);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(136, 40);
            this.comboBoxSearchBy.TabIndex = 3;
            // 
            // buttonRoomDisplay
            // 
            this.buttonRoomDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonRoomDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomDisplay.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRoomDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonRoomDisplay.Image = ((System.Drawing.Image)(resources.GetObject("buttonRoomDisplay.Image")));
            this.buttonRoomDisplay.Location = new System.Drawing.Point(295, 473);
            this.buttonRoomDisplay.Name = "buttonRoomDisplay";
            this.buttonRoomDisplay.Size = new System.Drawing.Size(210, 43);
            this.buttonRoomDisplay.TabIndex = 5;
            this.buttonRoomDisplay.Text = " DISPLAY ROOM";
            this.buttonRoomDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRoomDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRoomDisplay.UseVisualStyleBackColor = false;
            // 
            // buttonRoomUpdate
            // 
            this.buttonRoomUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonRoomUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomUpdate.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRoomUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonRoomUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonRoomUpdate.Image")));
            this.buttonRoomUpdate.Location = new System.Drawing.Point(79, 473);
            this.buttonRoomUpdate.Name = "buttonRoomUpdate";
            this.buttonRoomUpdate.Size = new System.Drawing.Size(210, 43);
            this.buttonRoomUpdate.TabIndex = 9;
            this.buttonRoomUpdate.Text = " UPDATE ROOM";
            this.buttonRoomUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRoomUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRoomUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonRoomDelete
            // 
            this.buttonRoomDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonRoomDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomDelete.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRoomDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonRoomDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonRoomDelete.Image")));
            this.buttonRoomDelete.Location = new System.Drawing.Point(295, 424);
            this.buttonRoomDelete.Name = "buttonRoomDelete";
            this.buttonRoomDelete.Size = new System.Drawing.Size(210, 43);
            this.buttonRoomDelete.TabIndex = 10;
            this.buttonRoomDelete.Text = " DELETE ROOM";
            this.buttonRoomDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRoomDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRoomDelete.UseVisualStyleBackColor = false;
            // 
            // buttonRoomInsert
            // 
            this.buttonRoomInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonRoomInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomInsert.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRoomInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonRoomInsert.Image = ((System.Drawing.Image)(resources.GetObject("buttonRoomInsert.Image")));
            this.buttonRoomInsert.Location = new System.Drawing.Point(79, 424);
            this.buttonRoomInsert.Name = "buttonRoomInsert";
            this.buttonRoomInsert.Size = new System.Drawing.Size(210, 43);
            this.buttonRoomInsert.TabIndex = 8;
            this.buttonRoomInsert.Text = " INSERT ROOM";
            this.buttonRoomInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRoomInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRoomInsert.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label10.Location = new System.Drawing.Point(67, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "LEAVE DATE:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Raleway ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label20.Location = new System.Drawing.Point(19, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(229, 55);
            this.label20.TabIndex = 1;
            this.label20.Text = "INPATIENT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.comboBoxRoomNo);
            this.panel1.Controls.Add(this.comboBoxFloorNo);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dateTimePickerDOD);
            this.panel1.Controls.Add(this.dateTimePickerDOA);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.comboBoxSearchValue);
            this.panel1.Controls.Add(this.comboBoxSearchBy);
            this.panel1.Controls.Add(this.comboBoxPatient);
            this.panel1.Controls.Add(this.buttonRoomDisplay);
            this.panel1.Controls.Add(this.buttonRoomUpdate);
            this.panel1.Controls.Add(this.buttonRoomDelete);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Controls.Add(this.buttonRoomInsert);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.textBoxInpatientID);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 550);
            this.panel1.TabIndex = 12;
            // 
            // comboBoxRoomNo
            // 
            this.comboBoxRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.comboBoxRoomNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRoomNo.Font = new System.Drawing.Font("Raleway", 12F);
            this.comboBoxRoomNo.FormattingEnabled = true;
            this.comboBoxRoomNo.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.comboBoxRoomNo.Location = new System.Drawing.Point(243, 329);
            this.comboBoxRoomNo.Name = "comboBoxRoomNo";
            this.comboBoxRoomNo.Size = new System.Drawing.Size(254, 36);
            this.comboBoxRoomNo.TabIndex = 17;
            // 
            // comboBoxFloorNo
            // 
            this.comboBoxFloorNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.comboBoxFloorNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFloorNo.Font = new System.Drawing.Font("Raleway", 12F);
            this.comboBoxFloorNo.FormattingEnabled = true;
            this.comboBoxFloorNo.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.comboBoxFloorNo.Location = new System.Drawing.Point(243, 287);
            this.comboBoxFloorNo.Name = "comboBoxFloorNo";
            this.comboBoxFloorNo.Size = new System.Drawing.Size(254, 36);
            this.comboBoxFloorNo.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label14.Location = new System.Drawing.Point(67, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 34);
            this.label14.TabIndex = 15;
            this.label14.Text = "ROOM NO. :";
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.Font = new System.Drawing.Font("Raleway", 12F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.comboBoxType.Location = new System.Drawing.Point(243, 245);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(254, 36);
            this.comboBoxType.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label12.Location = new System.Drawing.Point(67, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 34);
            this.label12.TabIndex = 15;
            this.label12.Text = "FLOOR NO. :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label13.Location = new System.Drawing.Point(67, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 34);
            this.label13.TabIndex = 16;
            this.label13.Text = "ROOM TYPE:";
            // 
            // dateTimePickerDOD
            // 
            this.dateTimePickerDOD.Location = new System.Drawing.Point(243, 208);
            this.dateTimePickerDOD.Name = "dateTimePickerDOD";
            this.dateTimePickerDOD.Size = new System.Drawing.Size(254, 31);
            this.dateTimePickerDOD.TabIndex = 14;
            this.dateTimePickerDOD.Value = new System.DateTime(2020, 11, 6, 22, 21, 3, 0);
            // 
            // dateTimePickerDOA
            // 
            this.dateTimePickerDOA.Location = new System.Drawing.Point(243, 171);
            this.dateTimePickerDOA.Name = "dateTimePickerDOA";
            this.dateTimePickerDOA.Size = new System.Drawing.Size(254, 31);
            this.dateTimePickerDOA.TabIndex = 14;
            this.dateTimePickerDOA.Value = new System.DateTime(2020, 11, 6, 22, 21, 3, 0);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.comboBoxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGender.Font = new System.Drawing.Font("Raleway", 6F);
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.comboBoxGender.Location = new System.Drawing.Point(511, 103);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(123, 22);
            this.comboBoxGender.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(971, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(259, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "Add New Patient";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisplay.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonDisplay.Image = ((System.Drawing.Image)(resources.GetObject("buttonDisplay.Image")));
            this.buttonDisplay.Location = new System.Drawing.Point(971, 157);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(259, 46);
            this.buttonDisplay.TabIndex = 5;
            this.buttonDisplay.Text = " Display Data";
            this.buttonDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDisplay.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.Location = new System.Drawing.Point(706, 157);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(259, 46);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = " UPDATE DOCTOR";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(971, 105);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(259, 46);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = " DELETE DOCTOR";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonInsert.Image = ((System.Drawing.Image)(resources.GetObject("buttonInsert.Image")));
            this.buttonInsert.Location = new System.Drawing.Point(706, 105);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(259, 46);
            this.buttonInsert.TabIndex = 8;
            this.buttonInsert.Text = " INSERT DOCTOR";
            this.buttonInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInsert.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label7.Location = new System.Drawing.Point(67, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "ADDRESS:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Raleway", 22F);
            this.textBoxSearch.Location = new System.Drawing.Point(706, 262);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(259, 44);
            this.textBoxSearch.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label5.Location = new System.Drawing.Point(362, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "DESIGNATION:";
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxDesignation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDesignation.Font = new System.Drawing.Font("Raleway", 10.2F);
            this.textBoxDesignation.Location = new System.Drawing.Point(511, 157);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(123, 20);
            this.textBoxDesignation.TabIndex = 5;
            // 
            // textBoxTel
            // 
            this.textBoxTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTel.Font = new System.Drawing.Font("Raleway", 10.2F);
            this.textBoxTel.Location = new System.Drawing.Point(511, 131);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(123, 20);
            this.textBoxTel.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label9.Location = new System.Drawing.Point(362, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "TEL NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label4.Location = new System.Drawing.Point(362, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "GENDER:";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Raleway", 10.2F);
            this.textBoxName.Location = new System.Drawing.Point(216, 131);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(123, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label3.Location = new System.Drawing.Point(67, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "NAME:";
            // 
            // textBoxid
            // 
            this.textBoxid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxid.Font = new System.Drawing.Font("Raleway", 10.2F);
            this.textBoxid.Location = new System.Drawing.Point(216, 105);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.ReadOnly = true;
            this.textBoxid.Size = new System.Drawing.Size(123, 20);
            this.textBoxid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(67, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOCTOR ID:";
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.Content.Controls.Add(this.panel1);
            this.Content.Controls.Add(this.comboBoxGender);
            this.Content.Controls.Add(this.button4);
            this.Content.Controls.Add(this.buttonDisplay);
            this.Content.Controls.Add(this.buttonUpdate);
            this.Content.Controls.Add(this.buttonDelete);
            this.Content.Controls.Add(this.buttonInsert);
            this.Content.Controls.Add(this.textBoxEmail);
            this.Content.Controls.Add(this.label6);
            this.Content.Controls.Add(this.textBoxDepartment);
            this.Content.Controls.Add(this.label8);
            this.Content.Controls.Add(this.textBoxAddress);
            this.Content.Controls.Add(this.label7);
            this.Content.Controls.Add(this.textBoxSearch);
            this.Content.Controls.Add(this.label5);
            this.Content.Controls.Add(this.textBoxDesignation);
            this.Content.Controls.Add(this.textBoxTel);
            this.Content.Controls.Add(this.label9);
            this.Content.Controls.Add(this.label4);
            this.Content.Controls.Add(this.textBoxName);
            this.Content.Controls.Add(this.label3);
            this.Content.Controls.Add(this.textBoxid);
            this.Content.Controls.Add(this.label1);
            this.Content.Controls.Add(this.label2);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Font = new System.Drawing.Font("Raleway ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1261, 550);
            this.Content.TabIndex = 6;
            // 
            // buttonRoom
            // 
            this.buttonRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonRoom.Image = ((System.Drawing.Image)(resources.GetObject("buttonRoom.Image")));
            this.buttonRoom.Location = new System.Drawing.Point(79, 371);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(418, 43);
            this.buttonRoom.TabIndex = 8;
            this.buttonRoom.Text = " FIND A ROOM";
            this.buttonRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRoom.UseVisualStyleBackColor = false;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // InpatientUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Content);
            this.Name = "InpatientUserControl";
            this.Size = new System.Drawing.Size(1261, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DatabaseDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPATCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rOOMBindingSource;
        private HMS_DatabaseDataSet2 hMS_DatabaseDataSet2;
        private System.Windows.Forms.ComboBox comboBoxSearchValue;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxInpatientID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label6;
        private HMS_DatabaseDataSet2TableAdapters.ROOMTableAdapter rOOMTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Button buttonRoomDisplay;
        private System.Windows.Forms.Button buttonRoomUpdate;
        private System.Windows.Forms.Button buttonRoomDelete;
        private System.Windows.Forms.Button buttonRoomInsert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOD;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOA;
        private System.Windows.Forms.ComboBox comboBoxRoomNo;
        private System.Windows.Forms.ComboBox comboBoxFloorNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonRoom;
    }
}
