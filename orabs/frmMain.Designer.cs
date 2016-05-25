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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.meetingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingHandleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(601, 43);
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
            this.departmentToolStripMenuItem,
            this.meetingToolStripMenuItem,
            this.itemToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(746, 25);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.mainMenuToolStripMenuItem.Text = "&MainMenu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorGroupControlToolStripMenuItem,
            this.doctorControlToolStripMenuItem});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.doctorToolStripMenuItem.Text = "&Doctor";
            // 
            // doctorGroupControlToolStripMenuItem
            // 
            this.doctorGroupControlToolStripMenuItem.Name = "doctorGroupControlToolStripMenuItem";
            this.doctorGroupControlToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.doctorGroupControlToolStripMenuItem.Text = "Doctor &Group Control";
            this.doctorGroupControlToolStripMenuItem.Click += new System.EventHandler(this.doctorGroupControlToolStripMenuItem_Click);
            // 
            // doctorControlToolStripMenuItem
            // 
            this.doctorControlToolStripMenuItem.Name = "doctorControlToolStripMenuItem";
            this.doctorControlToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.doctorControlToolStripMenuItem.Text = "&Doctor Control";
            this.doctorControlToolStripMenuItem.Click += new System.EventHandler(this.doctorControlToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userControlToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.userToolStripMenuItem.Text = "&User";
            // 
            // userControlToolStripMenuItem
            // 
            this.userControlToolStripMenuItem.Name = "userControlToolStripMenuItem";
            this.userControlToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.userControlToolStripMenuItem.Text = "&Reset Password";
            this.userControlToolStripMenuItem.Click += new System.EventHandler(this.userControlToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientControlToolStripMenuItem,
            this.personalInformationToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.patientToolStripMenuItem.Text = "&Patient";
            // 
            // patientControlToolStripMenuItem
            // 
            this.patientControlToolStripMenuItem.Name = "patientControlToolStripMenuItem";
            this.patientControlToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.patientControlToolStripMenuItem.Text = "P&atient Control";
            this.patientControlToolStripMenuItem.Click += new System.EventHandler(this.patientControlToolStripMenuItem_Click);
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.personalInformationToolStripMenuItem.Text = "&Personal Information";
            this.personalInformationToolStripMenuItem.Click += new System.EventHandler(this.personalInformationToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentControlToolStripMenuItem});
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(89, 21);
            this.departmentToolStripMenuItem.Text = "D&epartment";
            // 
            // departmentControlToolStripMenuItem
            // 
            this.departmentControlToolStripMenuItem.Name = "departmentControlToolStripMenuItem";
            this.departmentControlToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.departmentControlToolStripMenuItem.Text = "&Department Control";
            this.departmentControlToolStripMenuItem.Click += new System.EventHandler(this.departmentControlToolStripMenuItem_Click);
            // 
            // meetingToolStripMenuItem
            // 
            this.meetingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meetingRegisterToolStripMenuItem,
            this.meetingControlToolStripMenuItem,
            this.meetingHandleToolStripMenuItem});
            this.meetingToolStripMenuItem.Name = "meetingToolStripMenuItem";
            this.meetingToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.meetingToolStripMenuItem.Text = "Mee&ting";
            // 
            // meetingRegisterToolStripMenuItem
            // 
            this.meetingRegisterToolStripMenuItem.Name = "meetingRegisterToolStripMenuItem";
            this.meetingRegisterToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.meetingRegisterToolStripMenuItem.Text = "Meeting Register";
            this.meetingRegisterToolStripMenuItem.Click += new System.EventHandler(this.meetingRegisterToolStripMenuItem_Click);
            // 
            // meetingControlToolStripMenuItem
            // 
            this.meetingControlToolStripMenuItem.Name = "meetingControlToolStripMenuItem";
            this.meetingControlToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.meetingControlToolStripMenuItem.Text = "Meeting Control";
            this.meetingControlToolStripMenuItem.Click += new System.EventHandler(this.meetingControlToolStripMenuItem_Click);
            // 
            // meetingHandleToolStripMenuItem
            // 
            this.meetingHandleToolStripMenuItem.Name = "meetingHandleToolStripMenuItem";
            this.meetingHandleToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.meetingHandleToolStripMenuItem.Text = "Meeting Handle";
            this.meetingHandleToolStripMenuItem.Click += new System.EventHandler(this.meetingHandleToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemControlToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.itemToolStripMenuItem.Text = "&Item";
            // 
            // itemControlToolStripMenuItem
            // 
            this.itemControlToolStripMenuItem.Name = "itemControlToolStripMenuItem";
            this.itemControlToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.itemControlToolStripMenuItem.Text = "ItemControl";
            this.itemControlToolStripMenuItem.Click += new System.EventHandler(this.itemControlToolStripMenuItem_Click);
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Location = new System.Drawing.Point(601, 65);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(65, 12);
            this.lblIdentity.TabIndex = 2;
            this.lblIdentity.Text = "Identity: ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(746, 506);
            this.Controls.Add(this.lblIdentity);
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
        private System.Windows.Forms.ToolStripMenuItem meetingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meetingRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meetingControlToolStripMenuItem;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.ToolStripMenuItem meetingHandleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemControlToolStripMenuItem;
    }
}