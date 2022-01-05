namespace OOP_Project___Hospital_Management_System
{
    partial class FindRoom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindRoom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBoxFloorNo = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rOOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.hMS_DatabaseDataSet4 = new OOP_Project___Hospital_Management_System.HMS_DatabaseDataSet4();
            this.buttonFindRoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            //this.rOOMTableAdapter = new OOP_Project___Hospital_Management_System.HMS_DatabaseDataSet4TableAdapters.ROOMTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLOORNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEPERHOURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECT = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.hMS_DatabaseDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(913, 14);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(5);
            this.buttonExit.Size = new System.Drawing.Size(27, 27);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Raleway ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label20.Location = new System.Drawing.Point(12, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(362, 55);
            this.label20.TabIndex = 10;
            this.label20.Text = "BED AVAILIBILITY";
            // 
            // comboBoxFloorNo
            // 
            this.comboBoxFloorNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFloorNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.comboBoxFloorNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFloorNo.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.comboBoxFloorNo.FormattingEnabled = true;
            this.comboBoxFloorNo.Items.AddRange(new object[] {
            "B",
            "G",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxFloorNo.Location = new System.Drawing.Point(219, 132);
            this.comboBoxFloorNo.Name = "comboBoxFloorNo";
            this.comboBoxFloorNo.Size = new System.Drawing.Size(254, 39);
            this.comboBoxFloorNo.TabIndex = 18;
            // 
            // comboBoxType
            // 
            this.comboBoxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Deluxe",
            "Private",
            "Ward"});
            this.comboBoxType.Location = new System.Drawing.Point(657, 82);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(254, 39);
            this.comboBoxType.TabIndex = 20;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label10.Location = new System.Drawing.Point(43, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 34);
            this.label10.TabIndex = 11;
            this.label10.Text = "FLOOR NO. :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label11.Location = new System.Drawing.Point(481, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 34);
            this.label11.TabIndex = 12;
            this.label11.Text = "ROOM TYPE:";
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.textBoxRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRoomNo.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxRoomNo.Location = new System.Drawing.Point(219, 89);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(254, 31);
            this.textBoxRoomNo.TabIndex = 14;
            this.textBoxRoomNo.TextChanged += new System.EventHandler(this.textBoxRoomNo_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label13.Location = new System.Drawing.Point(43, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 34);
            this.label13.TabIndex = 16;
            this.label13.Text = "ROOM NO:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.rOOMNODataGridViewTextBoxColumn,
            this.fLOORNODataGridViewTextBoxColumn,
            this.rOOMSTATUSDataGridViewTextBoxColumn,
            this.rOOMTYPEDataGridViewTextBoxColumn,
            this.pRICEPERHOURDataGridViewTextBoxColumn,
            this.SELECT});
            this.dataGridView1.DataSource = this.rOOMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 215);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rOOMBindingSource
            // 
            this.rOOMBindingSource.DataMember = "ROOM";
            //this.rOOMBindingSource.DataSource = this.hMS_DatabaseDataSet4;
            // 
            // hMS_DatabaseDataSet4
            // 
            //this.hMS_DatabaseDataSet4.DataSetName = "HMS_DatabaseDataSet4";
            //this.hMS_DatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonFindRoom
            // 
            this.buttonFindRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.buttonFindRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindRoom.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold);
            this.buttonFindRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.buttonFindRoom.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindRoom.Image")));
            this.buttonFindRoom.Location = new System.Drawing.Point(487, 129);
            this.buttonFindRoom.Name = "buttonFindRoom";
            this.buttonFindRoom.Size = new System.Drawing.Size(424, 43);
            this.buttonFindRoom.TabIndex = 22;
            this.buttonFindRoom.Text = " FIND";
            this.buttonFindRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFindRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFindRoom.UseVisualStyleBackColor = false;
            this.buttonFindRoom.Click += new System.EventHandler(this.buttonFindRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(39, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "AVAILABLE ROOMS";
            // 
            // rOOMTableAdapter
            // 
            //this.rOOMTableAdapter.ClearBeforeFill = true;
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
            // fLOORNODataGridViewTextBoxColumn
            // 
            this.fLOORNODataGridViewTextBoxColumn.DataPropertyName = "FLOOR_NO";
            this.fLOORNODataGridViewTextBoxColumn.HeaderText = "FLOOR_NO";
            this.fLOORNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fLOORNODataGridViewTextBoxColumn.Name = "fLOORNODataGridViewTextBoxColumn";
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
            // pRICEPERHOURDataGridViewTextBoxColumn
            // 
            this.pRICEPERHOURDataGridViewTextBoxColumn.DataPropertyName = "PRICE_PER_HOUR";
            this.pRICEPERHOURDataGridViewTextBoxColumn.HeaderText = "PRICE_PER_HOUR";
            this.pRICEPERHOURDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEPERHOURDataGridViewTextBoxColumn.Name = "pRICEPERHOURDataGridViewTextBoxColumn";
            // 
            // SELECT
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.SELECT.DefaultCellStyle = dataGridViewCellStyle3;
            this.SELECT.FillWeight = 200F;
            this.SELECT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SELECT.HeaderText = "SELECT";
            this.SELECT.MinimumWidth = 6;
            this.SELECT.Name = "SELECT";
            this.SELECT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SELECT.Text = "SELECT ROOM";
            this.SELECT.ToolTipText = "Click to Select a Room";
            this.SELECT.UseColumnTextForButtonValue = true;
            // 
            // FindRoom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(954, 486);
            this.Controls.Add(this.buttonFindRoom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxFloorNo);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxRoomNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buttonExit);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindRoom";
            this.Load += new System.EventHandler(this.FindRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.hMS_DatabaseDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBoxFloorNo;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonFindRoom;
        private System.Windows.Forms.Label label1;
        //private HMS_DatabaseDataSet4 hMS_DatabaseDataSet4;
        private System.Windows.Forms.BindingSource rOOMBindingSource;
        //private HMS_DatabaseDataSet4TableAdapters.ROOMTableAdapter rOOMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLOORNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEPERHOURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SELECT;
    }
}