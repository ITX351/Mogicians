namespace orabs
{
    partial class frmMain
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorGroupControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(601, 21);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 12);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User:";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.userToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.departmentToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(746, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.mainMenuToolStripMenuItem.Text = "&MainMenu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorGroupControlToolStripMenuItem,
            this.doctorControlToolStripMenuItem});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.doctorToolStripMenuItem.Text = "&Doctor";
            // 
            // doctorGroupControlToolStripMenuItem
            // 
            this.doctorGroupControlToolStripMenuItem.Name = "doctorGroupControlToolStripMenuItem";
            this.doctorGroupControlToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.doctorGroupControlToolStripMenuItem.Text = "Doctor &Group Control";
            this.doctorGroupControlToolStripMenuItem.Click += new System.EventHandler(this.doctorGroupControlToolStripMenuItem_Click);
            // 
            // doctorControlToolStripMenuItem
            // 
            this.doctorControlToolStripMenuItem.Name = "doctorControlToolStripMenuItem";
            this.doctorControlToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.doctorControlToolStripMenuItem.Text = "&Doctor Control";
            this.doctorControlToolStripMenuItem.Click += new System.EventHandler(this.doctorControlToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userControlToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "&User";
            // 
            // userControlToolStripMenuItem
            // 
            this.userControlToolStripMenuItem.Name = "userControlToolStripMenuItem";
            this.userControlToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userControlToolStripMenuItem.Text = "&User Control";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientControlToolStripMenuItem,
            this.personalInformationToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "&Patient";
            // 
            // patientControlToolStripMenuItem
            // 
            this.patientControlToolStripMenuItem.Name = "patientControlToolStripMenuItem";
            this.patientControlToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.patientControlToolStripMenuItem.Text = "P&atient Control";
            this.patientControlToolStripMenuItem.Click += new System.EventHandler(this.patientControlToolStripMenuItem_Click);
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.personalInformationToolStripMenuItem.Text = "&Personal Information";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentControlToolStripMenuItem});
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.departmentToolStripMenuItem.Text = "D&epartment";
            // 
            // departmentControlToolStripMenuItem
            // 
            this.departmentControlToolStripMenuItem.Name = "departmentControlToolStripMenuItem";
            this.departmentControlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.departmentControlToolStripMenuItem.Text = "&Department Control";
            this.departmentControlToolStripMenuItem.Click += new System.EventHandler(this.departmentControlToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 506);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.Text = "Outpatient registering and billing system";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorGroupControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentControlToolStripMenuItem;
    }
}