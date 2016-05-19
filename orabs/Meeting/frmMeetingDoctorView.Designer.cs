namespace orabs.Meeting
{
    partial class frmMeetingDoctorView
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
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblPatientIDTitle = new System.Windows.Forms.Label();
            this.lblPatientNameTitle = new System.Windows.Forms.Label();
            this.lblPatientSexTitle = new System.Windows.Forms.Label();
            this.lblPatientPhoneTitle = new System.Windows.Forms.Label();
            this.lblPatientAddressTitle = new System.Windows.Forms.Label();
            this.lblPatientIdentityNumberTitle = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(53, 31);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(53, 12);
            this.lblDoctor.TabIndex = 0;
            this.lblDoctor.Text = "Doctor: ";
            // 
            // lblPatientIDTitle
            // 
            this.lblPatientIDTitle.AutoSize = true;
            this.lblPatientIDTitle.Location = new System.Drawing.Point(60, 107);
            this.lblPatientIDTitle.Name = "lblPatientIDTitle";
            this.lblPatientIDTitle.Size = new System.Drawing.Size(71, 12);
            this.lblPatientIDTitle.TabIndex = 1;
            this.lblPatientIDTitle.Text = "PatientID: ";
            // 
            // lblPatientNameTitle
            // 
            this.lblPatientNameTitle.AutoSize = true;
            this.lblPatientNameTitle.Location = new System.Drawing.Point(60, 134);
            this.lblPatientNameTitle.Name = "lblPatientNameTitle";
            this.lblPatientNameTitle.Size = new System.Drawing.Size(41, 12);
            this.lblPatientNameTitle.TabIndex = 2;
            this.lblPatientNameTitle.Text = "Name: ";
            // 
            // lblPatientSexTitle
            // 
            this.lblPatientSexTitle.AutoSize = true;
            this.lblPatientSexTitle.Location = new System.Drawing.Point(60, 164);
            this.lblPatientSexTitle.Name = "lblPatientSexTitle";
            this.lblPatientSexTitle.Size = new System.Drawing.Size(35, 12);
            this.lblPatientSexTitle.TabIndex = 3;
            this.lblPatientSexTitle.Text = "Sex: ";
            // 
            // lblPatientPhoneTitle
            // 
            this.lblPatientPhoneTitle.AutoSize = true;
            this.lblPatientPhoneTitle.Location = new System.Drawing.Point(62, 196);
            this.lblPatientPhoneTitle.Name = "lblPatientPhoneTitle";
            this.lblPatientPhoneTitle.Size = new System.Drawing.Size(47, 12);
            this.lblPatientPhoneTitle.TabIndex = 4;
            this.lblPatientPhoneTitle.Text = "Phone: ";
            // 
            // lblPatientAddressTitle
            // 
            this.lblPatientAddressTitle.AutoSize = true;
            this.lblPatientAddressTitle.Location = new System.Drawing.Point(64, 232);
            this.lblPatientAddressTitle.Name = "lblPatientAddressTitle";
            this.lblPatientAddressTitle.Size = new System.Drawing.Size(59, 12);
            this.lblPatientAddressTitle.TabIndex = 5;
            this.lblPatientAddressTitle.Text = "Address: ";
            // 
            // lblPatientIdentityNumberTitle
            // 
            this.lblPatientIdentityNumberTitle.AutoSize = true;
            this.lblPatientIdentityNumberTitle.Location = new System.Drawing.Point(61, 268);
            this.lblPatientIdentityNumberTitle.Name = "lblPatientIdentityNumberTitle";
            this.lblPatientIdentityNumberTitle.Size = new System.Drawing.Size(107, 12);
            this.lblPatientIdentityNumberTitle.TabIndex = 6;
            this.lblPatientIdentityNumberTitle.Text = "Identity Number: ";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(184, 106);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(0, 12);
            this.lblPatientID.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(181, 136);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 12);
            this.lblName.TabIndex = 8;
            // 
            // frmMeetingDoctorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 454);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblPatientIdentityNumberTitle);
            this.Controls.Add(this.lblPatientAddressTitle);
            this.Controls.Add(this.lblPatientPhoneTitle);
            this.Controls.Add(this.lblPatientSexTitle);
            this.Controls.Add(this.lblPatientNameTitle);
            this.Controls.Add(this.lblPatientIDTitle);
            this.Controls.Add(this.lblDoctor);
            this.Name = "frmMeetingDoctorView";
            this.Text = "frmMeetingDoctorView";
            this.Load += new System.EventHandler(this.frmMeetingDoctorView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblPatientIDTitle;
        private System.Windows.Forms.Label lblPatientNameTitle;
        private System.Windows.Forms.Label lblPatientSexTitle;
        private System.Windows.Forms.Label lblPatientPhoneTitle;
        private System.Windows.Forms.Label lblPatientAddressTitle;
        private System.Windows.Forms.Label lblPatientIdentityNumberTitle;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblName;
    }
}