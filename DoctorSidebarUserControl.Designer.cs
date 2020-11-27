namespace OOP_Project___Hospital_Management_System
{
    partial class DoctorSidebarUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorSidebarUserControl));
            this.buttonDoctor = new System.Windows.Forms.Button();
            this.SideBar = new System.Windows.Forms.Panel();
            this.buttonCovid = new System.Windows.Forms.Button();
            this.buttonPatient = new System.Windows.Forms.Button();
            this.SideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDoctor
            // 
            this.buttonDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.buttonDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDoctor.BackgroundImage")));
            this.buttonDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDoctor.FlatAppearance.BorderSize = 0;
            this.buttonDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoctor.Location = new System.Drawing.Point(27, 140);
            this.buttonDoctor.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDoctor.Name = "buttonDoctor";
            this.buttonDoctor.Padding = new System.Windows.Forms.Padding(5);
            this.buttonDoctor.Size = new System.Drawing.Size(39, 37);
            this.buttonDoctor.TabIndex = 3;
            this.buttonDoctor.UseVisualStyleBackColor = false;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.SideBar.Controls.Add(this.buttonCovid);
            this.SideBar.Controls.Add(this.buttonDoctor);
            this.SideBar.Controls.Add(this.buttonPatient);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(98, 349);
            this.SideBar.TabIndex = 3;
            // 
            // buttonCovid
            // 
            this.buttonCovid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCovid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.buttonCovid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCovid.BackgroundImage")));
            this.buttonCovid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCovid.FlatAppearance.BorderSize = 0;
            this.buttonCovid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCovid.Location = new System.Drawing.Point(27, 31);
            this.buttonCovid.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCovid.Name = "buttonCovid";
            this.buttonCovid.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCovid.Size = new System.Drawing.Size(39, 37);
            this.buttonCovid.TabIndex = 2;
            this.buttonCovid.UseVisualStyleBackColor = false;
            // 
            // buttonPatient
            // 
            this.buttonPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.buttonPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPatient.BackgroundImage")));
            this.buttonPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPatient.FlatAppearance.BorderSize = 0;
            this.buttonPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatient.Location = new System.Drawing.Point(27, 268);
            this.buttonPatient.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPatient.Name = "buttonPatient";
            this.buttonPatient.Padding = new System.Windows.Forms.Padding(5);
            this.buttonPatient.Size = new System.Drawing.Size(39, 37);
            this.buttonPatient.TabIndex = 4;
            this.buttonPatient.UseVisualStyleBackColor = false;
            // 
            // DoctorSidebarUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.SideBar);
            this.Name = "DoctorSidebarUserControl";
            this.Size = new System.Drawing.Size(98, 349);
            this.SideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDoctor;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Button buttonCovid;
        private System.Windows.Forms.Button buttonPatient;
    }
}
