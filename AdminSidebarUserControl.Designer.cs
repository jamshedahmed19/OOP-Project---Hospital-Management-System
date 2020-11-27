namespace OOP_Project___Hospital_Management_System
{
    partial class AdminSidebarUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSidebarUserControl));
            this.Content = new System.Windows.Forms.Panel();
            this.buttonCovid = new System.Windows.Forms.Button();
            this.buttonDoctor = new System.Windows.Forms.Button();
            this.buttonPatient = new System.Windows.Forms.Button();
            this.buttonBilling = new System.Windows.Forms.Button();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.Content.Controls.Add(this.buttonCovid);
            this.Content.Controls.Add(this.buttonDoctor);
            this.Content.Controls.Add(this.buttonBilling);
            this.Content.Controls.Add(this.buttonPatient);
            this.Content.Dock = System.Windows.Forms.DockStyle.Left;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(98, 349);
            this.Content.TabIndex = 4;
            // 
            // buttonCovid
            // 
            this.buttonCovid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCovid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.buttonCovid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCovid.BackgroundImage")));
            this.buttonCovid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCovid.FlatAppearance.BorderSize = 0;
            this.buttonCovid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCovid.Location = new System.Drawing.Point(30, 122);
            this.buttonCovid.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCovid.Name = "buttonCovid";
            this.buttonCovid.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCovid.Size = new System.Drawing.Size(39, 37);
            this.buttonCovid.TabIndex = 2;
            this.buttonCovid.UseVisualStyleBackColor = false;
            this.buttonCovid.Click += new System.EventHandler(this.buttonCovid_Click);
            // 
            // buttonDoctor
            // 
            this.buttonDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.buttonDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDoctor.BackgroundImage")));
            this.buttonDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDoctor.FlatAppearance.BorderSize = 0;
            this.buttonDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoctor.Location = new System.Drawing.Point(30, 57);
            this.buttonDoctor.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDoctor.Name = "buttonDoctor";
            this.buttonDoctor.Padding = new System.Windows.Forms.Padding(5);
            this.buttonDoctor.Size = new System.Drawing.Size(39, 37);
            this.buttonDoctor.TabIndex = 3;
            this.buttonDoctor.UseVisualStyleBackColor = false;
            this.buttonDoctor.Click += new System.EventHandler(this.buttonDoctor_Click);
            // 
            // buttonPatient
            // 
            this.buttonPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.buttonPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPatient.BackgroundImage")));
            this.buttonPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPatient.FlatAppearance.BorderSize = 0;
            this.buttonPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatient.Location = new System.Drawing.Point(30, 187);
            this.buttonPatient.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPatient.Name = "buttonPatient";
            this.buttonPatient.Padding = new System.Windows.Forms.Padding(5);
            this.buttonPatient.Size = new System.Drawing.Size(39, 37);
            this.buttonPatient.TabIndex = 4;
            this.buttonPatient.UseVisualStyleBackColor = false;
            this.buttonPatient.Click += new System.EventHandler(this.buttonPatient_Click);
            // 
            // buttonBilling
            // 
            this.buttonBilling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.buttonBilling.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBilling.BackgroundImage")));
            this.buttonBilling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBilling.FlatAppearance.BorderSize = 0;
            this.buttonBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBilling.Location = new System.Drawing.Point(30, 255);
            this.buttonBilling.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBilling.Name = "buttonBilling";
            this.buttonBilling.Padding = new System.Windows.Forms.Padding(5);
            this.buttonBilling.Size = new System.Drawing.Size(39, 37);
            this.buttonBilling.TabIndex = 4;
            this.buttonBilling.UseVisualStyleBackColor = false;
            // 
            // AdminSidebarUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Content);
            this.Name = "AdminSidebarUserControl";
            this.Size = new System.Drawing.Size(98, 349);
            this.Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Button buttonCovid;
        private System.Windows.Forms.Button buttonDoctor;
        private System.Windows.Forms.Button buttonPatient;
        private System.Windows.Forms.Button buttonBilling;
    }
}
