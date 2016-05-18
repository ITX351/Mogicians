namespace orabs.Meeting
{
    partial class frmMeetingQuery
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
            this.bntCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusAt = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.dtpStatusAt = new System.Windows.Forms.DateTimePicker();
            this.dtpCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // bntCancel
            // 
            this.bntCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancel.Location = new System.Drawing.Point(283, 276);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.TabIndex = 12;
            this.bntCancel.Text = "&Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(119, 276);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(67, 47);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(77, 12);
            this.lblPatientName.TabIndex = 13;
            this.lblPatientName.Text = "Patient Name";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(67, 88);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(71, 12);
            this.lblDoctorName.TabIndex = 14;
            this.lblDoctorName.Text = "Doctor Name";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(67, 126);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 12);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status";
            // 
            // lblStatusAt
            // 
            this.lblStatusAt.AutoSize = true;
            this.lblStatusAt.Location = new System.Drawing.Point(67, 167);
            this.lblStatusAt.Name = "lblStatusAt";
            this.lblStatusAt.Size = new System.Drawing.Size(137, 12);
            this.lblStatusAt.TabIndex = 16;
            this.lblStatusAt.Text = "Status Last Changed At";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(67, 216);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(65, 12);
            this.lblCreatedAt.TabIndex = 17;
            this.lblCreatedAt.Text = "Created At";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(241, 44);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(198, 21);
            this.txtPatientName.TabIndex = 18;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(241, 85);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(198, 21);
            this.txtDoctorName.TabIndex = 19;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(241, 123);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(198, 20);
            this.cboStatus.TabIndex = 22;
            // 
            // dtpStatusAt
            // 
            this.dtpStatusAt.Location = new System.Drawing.Point(241, 161);
            this.dtpStatusAt.Name = "dtpStatusAt";
            this.dtpStatusAt.Size = new System.Drawing.Size(200, 21);
            this.dtpStatusAt.TabIndex = 23;       
            // 
            // dtpCreatedAt
            // 
            this.dtpCreatedAt.Location = new System.Drawing.Point(241, 207);
            this.dtpCreatedAt.Name = "dtpCreatedAt";
            this.dtpCreatedAt.Size = new System.Drawing.Size(200, 21);
            this.dtpCreatedAt.TabIndex = 24;
            // 
            // frmMeetingQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 355);
            this.Controls.Add(this.dtpCreatedAt);
            this.Controls.Add(this.dtpStatusAt);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.lblStatusAt);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "frmMeetingQuery";
            this.Text = "Meeting Query";
            this.Load += new System.EventHandler(this.frmMeetingQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusAt;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.DateTimePicker dtpStatusAt;
        private System.Windows.Forms.DateTimePicker dtpCreatedAt;


    }
}