namespace OOP_Project___Hospital_Management_System
{
    partial class CRUDDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDDoctor));
            this.Content = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCDEPARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCPASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCGENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCDESIGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hMS_DatabaseDataSet5 = new OOP_Project___Hospital_Management_System.HMS_DatabaseDataSet5();
            this.hMS_DatabaseDataSet6 = new OOP_Project___Hospital_Management_System.HMS_DatabaseDataSet6();
            this.dOCTORSTableAdapter = new OOP_Project___Hospital_Management_System.HMS_DatabaseDataSetTableAdapters.DOCTORSTableAdapter();
            this.hMS_DatabaseDataSet = new OOP_Project___Hospital_Management_System.HMS_DatabaseDataSet();
            this.dOCTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DatabaseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.Content.Controls.Add(this.dataGridView1);
            this.Content.Controls.Add(this.comboBoxSearchBy);
            this.Content.Controls.Add(this.comboBoxGender);
            this.Content.Controls.Add(this.buttonDisplay);
            this.Content.Controls.Add(this.buttonUpdate);
            this.Content.Controls.Add(this.buttonDelete);
            this.Content.Controls.Add(this.buttonInsert);
            this.Content.Controls.Add(this.textBoxSearch);
            this.Content.Controls.Add(this.textBoxEmail);
            this.Content.Controls.Add(this.label6);
            this.Content.Controls.Add(this.textBoxDepartment);
            this.Content.Controls.Add(this.label8);
            this.Content.Controls.Add(this.textBoxAddress);
            this.Content.Controls.Add(this.label7);
            this.Content.Controls.Add(this.label5);
            this.Content.Controls.Add(this.textBoxDesignation);
            this.Content.Controls.Add(this.textBoxTel);
            this.Content.Controls.Add(this.label9);
            this.Content.Controls.Add(this.label4);
            this.Content.Controls.Add(this.textBoxName);
            this.Content.Controls.Add(this.label3);
            this.Content.Controls.Add(this.textBoxid);
            this.Content.Controls.Add(this.label11);
            this.Content.Controls.Add(this.label10);
            this.Content.Controls.Add(this.label1);
            this.Content.Controls.Add(this.label2);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1261, 550);
            this.Content.TabIndex = 2;
            // 
            // dataGridView1
            // 
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
            this.dOCIDDataGridViewTextBoxColumn,
            this.dOCNAMEDataGridViewTextBoxColumn,
            this.dOCDEPARTDataGridViewTextBoxColumn,
            this.dOCTELDataGridViewTextBoxColumn,
            this.dOCEMAILDataGridViewTextBoxColumn,
            this.dOCPASSDataGridViewTextBoxColumn,
            this.dOCGENDERDataGridViewTextBoxColumn,
            this.dOCADDRESSDataGridViewTextBoxColumn,
            this.dOCDESIGDataGridViewTextBoxColumn});
            this.dataGridView1.Location = new System.Drawing.Point(29, 312);
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
            this.dataGridView1.Size = new System.Drawing.Size(1201, 216);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCIDDataGridViewTextBoxColumn
            // 
            this.dOCIDDataGridViewTextBoxColumn.DataPropertyName = "DOC_ID";
            this.dOCIDDataGridViewTextBoxColumn.HeaderText = "DOC_ID";
            this.dOCIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCIDDataGridViewTextBoxColumn.Name = "dOCIDDataGridViewTextBoxColumn";
            this.dOCIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCNAMEDataGridViewTextBoxColumn
            // 
            this.dOCNAMEDataGridViewTextBoxColumn.DataPropertyName = "DOC_NAME";
            this.dOCNAMEDataGridViewTextBoxColumn.HeaderText = "DOC_NAME";
            this.dOCNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCNAMEDataGridViewTextBoxColumn.Name = "dOCNAMEDataGridViewTextBoxColumn";
            // 
            // dOCDEPARTDataGridViewTextBoxColumn
            // 
            this.dOCDEPARTDataGridViewTextBoxColumn.DataPropertyName = "DOC_DEPART";
            this.dOCDEPARTDataGridViewTextBoxColumn.HeaderText = "DOC_DEPART";
            this.dOCDEPARTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCDEPARTDataGridViewTextBoxColumn.Name = "dOCDEPARTDataGridViewTextBoxColumn";
            // 
            // dOCTELDataGridViewTextBoxColumn
            // 
            this.dOCTELDataGridViewTextBoxColumn.DataPropertyName = "DOC_TEL";
            this.dOCTELDataGridViewTextBoxColumn.HeaderText = "DOC_TEL";
            this.dOCTELDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCTELDataGridViewTextBoxColumn.Name = "dOCTELDataGridViewTextBoxColumn";
            // 
            // dOCEMAILDataGridViewTextBoxColumn
            // 
            this.dOCEMAILDataGridViewTextBoxColumn.DataPropertyName = "DOC_EMAIL";
            this.dOCEMAILDataGridViewTextBoxColumn.HeaderText = "DOC_EMAIL";
            this.dOCEMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCEMAILDataGridViewTextBoxColumn.Name = "dOCEMAILDataGridViewTextBoxColumn";
            // 
            // dOCPASSDataGridViewTextBoxColumn
            // 
            this.dOCPASSDataGridViewTextBoxColumn.DataPropertyName = "DOC_PASS";
            this.dOCPASSDataGridViewTextBoxColumn.HeaderText = "DOC_PASS";
            this.dOCPASSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCPASSDataGridViewTextBoxColumn.Name = "dOCPASSDataGridViewTextBoxColumn";
            // 
            // dOCGENDERDataGridViewTextBoxColumn
            // 
            this.dOCGENDERDataGridViewTextBoxColumn.DataPropertyName = "DOC_GENDER";
            this.dOCGENDERDataGridViewTextBoxColumn.HeaderText = "DOC_GENDER";
            this.dOCGENDERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCGENDERDataGridViewTextBoxColumn.Name = "dOCGENDERDataGridViewTextBoxColumn";
            // 
            // dOCADDRESSDataGridViewTextBoxColumn
            // 
            this.dOCADDRESSDataGridViewTextBoxColumn.DataPropertyName = "DOC_ADDRESS";
            this.dOCADDRESSDataGridViewTextBoxColumn.HeaderText = "DOC_ADDRESS";
            this.dOCADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCADDRESSDataGridViewTextBoxColumn.Name = "dOCADDRESSDataGridViewTextBoxColumn";
            // 
            // dOCDESIGDataGridViewTextBoxColumn
            // 
            this.dOCDESIGDataGridViewTextBoxColumn.DataPropertyName = "DOC_DESIG";
            this.dOCDESIGDataGridViewTextBoxColumn.HeaderText = "DOC_DESIG";
            this.dOCDESIGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCDESIGDataGridViewTextBoxColumn.Name = "dOCDESIGDataGridViewTextBoxColumn";
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSearchBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.comboBoxSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Doctor ID",
            "Name",
            "Number",
            "Designation",
            "Department"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(860, 220);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(370, 39);
            this.comboBoxSearchBy.TabIndex = 3;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.comboBoxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGender.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.comboBoxGender.Location = new System.Drawing.Point(569, 92);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(123, 39);
            this.comboBoxGender.TabIndex = 3;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisplay.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonDisplay.Image = ((System.Drawing.Image)(resources.GetObject("buttonDisplay.Image")));
            this.buttonDisplay.Location = new System.Drawing.Point(971, 144);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(259, 46);
            this.buttonDisplay.TabIndex = 5;
            this.buttonDisplay.Text = " DISPLAY DOCTOR";
            this.buttonDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.Location = new System.Drawing.Point(706, 144);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(259, 46);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = " UPDATE DOCTOR";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(971, 92);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(259, 46);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = " DELETE DOCTOR";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonInsert.Image = ((System.Drawing.Image)(resources.GetObject("buttonInsert.Image")));
            this.buttonInsert.Location = new System.Drawing.Point(706, 92);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(259, 46);
            this.buttonInsert.TabIndex = 8;
            this.buttonInsert.Text = " INSERT DOCTOR";
            this.buttonInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Raleway", 16F);
            this.textBoxSearch.Location = new System.Drawing.Point(906, 266);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(324, 32);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxEmail.Location = new System.Drawing.Point(243, 211);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(449, 31);
            this.textBoxEmail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label6.Location = new System.Drawing.Point(67, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "EMAIL:";
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDepartment.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxDepartment.Location = new System.Drawing.Point(243, 174);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(123, 31);
            this.textBoxDepartment.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label8.Location = new System.Drawing.Point(67, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "DEPARTMENT:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxAddress.Location = new System.Drawing.Point(243, 248);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(449, 48);
            this.textBoxAddress.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label7.Location = new System.Drawing.Point(67, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "ADDRESS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label5.Location = new System.Drawing.Point(383, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "DESIGNATION:";
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxDesignation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDesignation.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxDesignation.Location = new System.Drawing.Point(569, 174);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(123, 31);
            this.textBoxDesignation.TabIndex = 5;
            // 
            // textBoxTel
            // 
            this.textBoxTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxTel.Location = new System.Drawing.Point(569, 137);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(123, 31);
            this.textBoxTel.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label9.Location = new System.Drawing.Point(383, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "TEL NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label4.Location = new System.Drawing.Point(383, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "GENDER:";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxName.Location = new System.Drawing.Point(243, 137);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(123, 31);
            this.textBoxName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label3.Location = new System.Drawing.Point(67, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "NAME:";
            // 
            // textBoxid
            // 
            this.textBoxid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxid.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxid.Location = new System.Drawing.Point(243, 96);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.ReadOnly = true;
            this.textBoxid.Size = new System.Drawing.Size(123, 31);
            this.textBoxid.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Raleway", 14F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label11.Location = new System.Drawing.Point(702, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 34);
            this.label11.TabIndex = 0;
            this.label11.Text = "SEARCH BY:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Raleway", 14F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label10.Location = new System.Drawing.Point(702, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "SEARCH VALUE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(67, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOCTOR ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOCTOR";
            // 
            // hMS_DatabaseDataSet5
            // 
            this.hMS_DatabaseDataSet5.DataSetName = "HMS_DatabaseDataSet5";
            this.hMS_DatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hMS_DatabaseDataSet6
            // 
            this.hMS_DatabaseDataSet6.DataSetName = "HMS_DatabaseDataSet6";
            this.hMS_DatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCTORSTableAdapter
            // 
            this.dOCTORSTableAdapter.ClearBeforeFill = true;
            // 
            // hMS_DatabaseDataSet
            // 
            this.hMS_DatabaseDataSet.DataSetName = "HMS_DatabaseDataSet";
            this.hMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCTORSBindingSource
            // 
            this.dOCTORSBindingSource.DataMember = "DOCTORS";
            this.dOCTORSBindingSource.DataSource = this.hMS_DatabaseDataSet;
            // 
            // CRUDDoctor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Content);
            this.Name = "CRUDDoctor";
            this.Size = new System.Drawing.Size(1261, 550);
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DatabaseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCDEPARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCPASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCGENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCDESIGDataGridViewTextBoxColumn;
        private HMS_DatabaseDataSet5 hMS_DatabaseDataSet5;
        private HMS_DatabaseDataSet6 hMS_DatabaseDataSet6;
        private HMS_DatabaseDataSetTableAdapters.DOCTORSTableAdapter dOCTORSTableAdapter;
        private HMS_DatabaseDataSet hMS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource dOCTORSBindingSource;
    }
}
