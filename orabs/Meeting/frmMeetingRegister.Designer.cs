namespace orabs.Meeting
{
    partial class frmMeetingRegister
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
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDoctorGroup = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.cboDoctorName = new System.Windows.Forms.ComboBox();
            this.lblWaitingTitle = new System.Windows.Forms.Label();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(118, 76);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(83, 12);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Departement: ";
            // 
            // lblDoctorGroup
            // 
            this.lblDoctorGroup.AutoSize = true;
            this.lblDoctorGroup.Location = new System.Drawing.Point(118, 121);
            this.lblDoctorGroup.Name = "lblDoctorGroup";
            this.lblDoctorGroup.Size = new System.Drawing.Size(89, 12);
            this.lblDoctorGroup.TabIndex = 1;
            this.lblDoctorGroup.Text = "Doctor Group: ";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(118, 166);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(83, 12);
            this.lblDoctorName.TabIndex = 2;
            this.lblDoctorName.Text = "Doctor Name: ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(122, 251);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // bntCancel
            // 
            this.bntCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancel.Location = new System.Drawing.Point(273, 251);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.TabIndex = 5;
            this.bntCancel.Text = "&Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(236, 73);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(121, 20);
            this.cboDepartment.TabIndex = 1;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboGroup
            // 
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(236, 118);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(121, 20);
            this.cboGroup.TabIndex = 2;
            this.cboGroup.SelectedIndexChanged += new System.EventHandler(this.cboGroup_SelectedIndexChanged);
            // 
            // cboDoctorName
            // 
            this.cboDoctorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctorName.FormattingEnabled = true;
            this.cboDoctorName.Location = new System.Drawing.Point(236, 163);
            this.cboDoctorName.Name = "cboDoctorName";
            this.cboDoctorName.Size = new System.Drawing.Size(121, 20);
            this.cboDoctorName.TabIndex = 3;
            this.cboDoctorName.SelectedIndexChanged += new System.EventHandler(this.cboDoctorName_SelectedIndexChanged);
            // 
            // lblWaitingTitle
            // 
            this.lblWaitingTitle.AutoSize = true;
            this.lblWaitingTitle.Location = new System.Drawing.Point(120, 216);
            this.lblWaitingTitle.Name = "lblWaitingTitle";
            this.lblWaitingTitle.Size = new System.Drawing.Size(113, 12);
            this.lblWaitingTitle.TabIndex = 6;
            this.lblWaitingTitle.Text = "Waiting patients: ";
            // 
            // lblWaiting
            // 
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Location = new System.Drawing.Point(236, 216);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(17, 12);
            this.lblWaiting.TabIndex = 7;
            this.lblWaiting.Text = "--";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(363, 121);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 12);
            this.lblPrice.TabIndex = 8;
            // 
            // frmMeetingRegister
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntCancel;
            this.ClientSize = new System.Drawing.Size(479, 355);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.lblWaitingTitle);
            this.Controls.Add(this.cboDoctorName);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblDoctorGroup);
            this.Controls.Add(this.lblDepartment);
            this.Name = "frmMeetingRegister";
            this.Text = "Meeting Register";
            this.Load += new System.EventHandler(this.frmMeetingRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDoctorGroup;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.ComboBox cboDoctorName;
        private System.Windows.Forms.Label lblWaitingTitle;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.Label lblPrice;

    }
}