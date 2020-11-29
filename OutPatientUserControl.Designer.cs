namespace OOP_Project___Hospital_Management_System
{
    partial class OutPatientUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutPatientUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerDAY = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSTARTTIME = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewINP = new System.Windows.Forms.DataGridView();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDoctorName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.buttonRoomDisplay = new System.Windows.Forms.Button();
            this.buttonRoomCancelApp = new System.Windows.Forms.Button();
            this.buttonBookApp = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxAppointmentID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPatName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDoctorID = new System.Windows.Forms.TextBox();
            this.textBoxPatientId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePickerENDTIME = new System.Windows.Forms.DateTimePicker();
            this.buttonReschedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewINP)).BeginInit();
            this.Content.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label13.Location = new System.Drawing.Point(63, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 34);
            this.label13.TabIndex = 16;
            this.label13.Text = "DOCTOR NAME:";
            // 
            // dateTimePickerDAY
            // 
            this.dateTimePickerDAY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDAY.Location = new System.Drawing.Point(243, 290);
            this.dateTimePickerDAY.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDAY.MinDate = new System.DateTime(2020, 1, 10, 0, 0, 0, 0);
            this.dateTimePickerDAY.Name = "dateTimePickerDAY";
            this.dateTimePickerDAY.Size = new System.Drawing.Size(254, 31);
            this.dateTimePickerDAY.TabIndex = 14;
            this.dateTimePickerDAY.Value = new System.DateTime(2020, 11, 6, 22, 21, 3, 0);
            // 
            // dateTimePickerSTARTTIME
            // 
            this.dateTimePickerSTARTTIME.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerSTARTTIME.Location = new System.Drawing.Point(243, 327);
            this.dateTimePickerSTARTTIME.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerSTARTTIME.MinDate = new System.DateTime(2020, 1, 10, 0, 0, 0, 0);
            this.dateTimePickerSTARTTIME.Name = "dateTimePickerSTARTTIME";
            this.dateTimePickerSTARTTIME.Size = new System.Drawing.Size(254, 31);
            this.dateTimePickerSTARTTIME.TabIndex = 14;
            this.dateTimePickerSTARTTIME.Value = new System.DateTime(2020, 11, 6, 22, 21, 3, 0);
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
            // dataGridViewINP
            // 
            this.dataGridViewINP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewINP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewINP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewINP.ColumnHeadersHeight = 40;
            this.dataGridViewINP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewINP.Location = new System.Drawing.Point(511, 132);
            this.dataGridViewINP.Name = "dataGridViewINP";
            this.dataGridViewINP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewINP.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewINP.RowHeadersWidth = 50;
            this.dataGridViewINP.RowTemplate.Height = 24;
            this.dataGridViewINP.Size = new System.Drawing.Size(683, 384);
            this.dataGridViewINP.TabIndex = 13;
            this.dataGridViewINP.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewINP_RowHeaderMouseClick);
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
            this.Content.Size = new System.Drawing.Size(1264, 626);
            this.Content.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.buttonReschedule);
            this.panel1.Controls.Add(this.textBoxDoctorID);
            this.panel1.Controls.Add(this.textBoxDoctorName);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dateTimePickerDAY);
            this.panel1.Controls.Add(this.dateTimePickerENDTIME);
            this.panel1.Controls.Add(this.dateTimePickerSTARTTIME);
            this.panel1.Controls.Add(this.dataGridViewINP);
            this.panel1.Controls.Add(this.comboBoxSearchBy);
            this.panel1.Controls.Add(this.buttonRoomDisplay);
            this.panel1.Controls.Add(this.buttonRoomCancelApp);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.buttonBookApp);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.textBoxPatientId);
            this.panel1.Controls.Add(this.textBoxPatName);
            this.panel1.Controls.Add(this.textBoxAppointmentID);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 626);
            this.panel1.TabIndex = 12;
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDoctorName.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxDoctorName.Location = new System.Drawing.Point(268, 234);
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.ReadOnly = true;
            this.textBoxDoctorName.Size = new System.Drawing.Size(229, 28);
            this.textBoxDoctorName.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(1035, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 28);
            this.textBox1.TabIndex = 17;
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
            this.buttonRoomDisplay.Location = new System.Drawing.Point(984, 20);
            this.buttonRoomDisplay.Name = "buttonRoomDisplay";
            this.buttonRoomDisplay.Size = new System.Drawing.Size(210, 43);
            this.buttonRoomDisplay.TabIndex = 5;
            this.buttonRoomDisplay.Text = " DISPLAY ROOM";
            this.buttonRoomDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRoomDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRoomDisplay.UseVisualStyleBackColor = false;
            // 
            // buttonRoomCancelApp
            // 
            this.buttonRoomCancelApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonRoomCancelApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomCancelApp.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRoomCancelApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonRoomCancelApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonRoomCancelApp.Image")));
            this.buttonRoomCancelApp.Location = new System.Drawing.Point(79, 424);
            this.buttonRoomCancelApp.Name = "buttonRoomCancelApp";
            this.buttonRoomCancelApp.Size = new System.Drawing.Size(426, 43);
            this.buttonRoomCancelApp.TabIndex = 10;
            this.buttonRoomCancelApp.Text = " CANCEL APPOINTMENT";
            this.buttonRoomCancelApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRoomCancelApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRoomCancelApp.UseVisualStyleBackColor = false;
            this.buttonRoomCancelApp.Click += new System.EventHandler(this.buttonRoomCancelApp_Click);
            // 
            // buttonBookApp
            // 
            this.buttonBookApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonBookApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookApp.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBookApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonBookApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookApp.Image")));
            this.buttonBookApp.Location = new System.Drawing.Point(79, 522);
            this.buttonBookApp.Name = "buttonBookApp";
            this.buttonBookApp.Size = new System.Drawing.Size(426, 43);
            this.buttonBookApp.TabIndex = 8;
            this.buttonBookApp.Text = " BOOK APPOINTMENT";
            this.buttonBookApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBookApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBookApp.UseVisualStyleBackColor = false;
            this.buttonBookApp.Click += new System.EventHandler(this.buttonBookApp_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label11.Location = new System.Drawing.Point(67, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 34);
            this.label11.TabIndex = 0;
            this.label11.Text = "START TIME:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label10.Location = new System.Drawing.Point(67, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "DAY:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label16.Location = new System.Drawing.Point(67, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 34);
            this.label16.TabIndex = 0;
            this.label16.Text = "PATIENT ID:";
            // 
            // textBoxAppointmentID
            // 
            this.textBoxAppointmentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxAppointmentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAppointmentID.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxAppointmentID.Location = new System.Drawing.Point(268, 98);
            this.textBoxAppointmentID.Name = "textBoxAppointmentID";
            this.textBoxAppointmentID.ReadOnly = true;
            this.textBoxAppointmentID.Size = new System.Drawing.Size(229, 28);
            this.textBoxAppointmentID.TabIndex = 0;
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
            this.label19.Location = new System.Drawing.Point(67, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 34);
            this.label19.TabIndex = 0;
            this.label19.Text = "AID:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Raleway ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label20.Location = new System.Drawing.Point(19, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(336, 55);
            this.label20.TabIndex = 1;
            this.label20.Text = "APPOINTMENTS";
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
            // textBoxPatName
            // 
            this.textBoxPatName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxPatName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPatName.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxPatName.Location = new System.Drawing.Point(268, 166);
            this.textBoxPatName.Name = "textBoxPatName";
            this.textBoxPatName.ReadOnly = true;
            this.textBoxPatName.Size = new System.Drawing.Size(229, 28);
            this.textBoxPatName.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label12.Location = new System.Drawing.Point(65, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 34);
            this.label12.TabIndex = 16;
            this.label12.Text = "DOCTOR ID:";
            // 
            // textBoxDoctorID
            // 
            this.textBoxDoctorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxDoctorID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDoctorID.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxDoctorID.Location = new System.Drawing.Point(268, 200);
            this.textBoxDoctorID.Name = "textBoxDoctorID";
            this.textBoxDoctorID.ReadOnly = true;
            this.textBoxDoctorID.Size = new System.Drawing.Size(229, 28);
            this.textBoxDoctorID.TabIndex = 18;
            this.textBoxDoctorID.TextChanged += new System.EventHandler(this.textBoxDoctorID_TextChanged);
            // 
            // textBoxPatientId
            // 
            this.textBoxPatientId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxPatientId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPatientId.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxPatientId.Location = new System.Drawing.Point(268, 132);
            this.textBoxPatientId.Name = "textBoxPatientId";
            this.textBoxPatientId.ReadOnly = true;
            this.textBoxPatientId.Size = new System.Drawing.Size(229, 28);
            this.textBoxPatientId.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label14.Location = new System.Drawing.Point(67, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 34);
            this.label14.TabIndex = 0;
            this.label14.Text = "PATIENT NAME:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label15.Location = new System.Drawing.Point(67, 362);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 34);
            this.label15.TabIndex = 0;
            this.label15.Text = "END TIME:";
            // 
            // dateTimePickerENDTIME
            // 
            this.dateTimePickerENDTIME.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerENDTIME.Location = new System.Drawing.Point(243, 364);
            this.dateTimePickerENDTIME.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerENDTIME.MinDate = new System.DateTime(2020, 1, 10, 0, 0, 0, 0);
            this.dateTimePickerENDTIME.Name = "dateTimePickerENDTIME";
            this.dateTimePickerENDTIME.Size = new System.Drawing.Size(254, 31);
            this.dateTimePickerENDTIME.TabIndex = 14;
            this.dateTimePickerENDTIME.Value = new System.DateTime(2020, 11, 6, 22, 21, 3, 0);
            // 
            // buttonReschedule
            // 
            this.buttonReschedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonReschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReschedule.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonReschedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonReschedule.Image = ((System.Drawing.Image)(resources.GetObject("buttonReschedule.Image")));
            this.buttonReschedule.Location = new System.Drawing.Point(79, 473);
            this.buttonReschedule.Name = "buttonReschedule";
            this.buttonReschedule.Size = new System.Drawing.Size(426, 43);
            this.buttonReschedule.TabIndex = 19;
            this.buttonReschedule.Text = " RESCHEDULE APPOINTMENT";
            this.buttonReschedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReschedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReschedule.UseVisualStyleBackColor = false;
            this.buttonReschedule.Click += new System.EventHandler(this.buttonReschedule_Click);
            // 
            // OutPatientUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Content);
            this.Name = "OutPatientUserControl";
            this.Size = new System.Drawing.Size(1264, 626);
            this.Load += new System.EventHandler(this.OutPatientUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewINP)).EndInit();
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerDAY;
        private System.Windows.Forms.DateTimePicker dateTimePickerSTARTTIME;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewINP;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Button buttonRoomDisplay;
        private System.Windows.Forms.Button buttonRoomCancelApp;
        private System.Windows.Forms.Button buttonBookApp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxAppointmentID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAddress;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDoctorName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxPatName;
        private System.Windows.Forms.TextBox textBoxDoctorID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPatientId;
        private System.Windows.Forms.DateTimePicker dateTimePickerENDTIME;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonReschedule;
    }
}
