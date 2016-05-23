namespace orabs.Patient
{
    partial class frmPatientInfo
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblIdentityNumber = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNameTxt = new System.Windows.Forms.Label();
            this.lblAddressTxt = new System.Windows.Forms.Label();
            this.lblPhoneTxt = new System.Windows.Forms.Label();
            this.lblSexTxt = new System.Windows.Forms.Label();
            this.lblIdentityNumberTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(96, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(97, 95);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(23, 12);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "Sex";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(97, 134);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(35, 12);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(97, 174);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(47, 12);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Location = new System.Drawing.Point(97, 219);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(95, 12);
            this.lblIdentityNumber.TabIndex = 4;
            this.lblIdentityNumber.Text = "Identity Number";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 266);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 37);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(262, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNameTxt
            // 
            this.lblNameTxt.AutoSize = true;
            this.lblNameTxt.Location = new System.Drawing.Point(271, 56);
            this.lblNameTxt.Name = "lblNameTxt";
            this.lblNameTxt.Size = new System.Drawing.Size(83, 12);
            this.lblNameTxt.TabIndex = 9;
            this.lblNameTxt.Text = "Not specified";
            // 
            // lblAddressTxt
            // 
            this.lblAddressTxt.AutoSize = true;
            this.lblAddressTxt.Location = new System.Drawing.Point(271, 174);
            this.lblAddressTxt.Name = "lblAddressTxt";
            this.lblAddressTxt.Size = new System.Drawing.Size(83, 12);
            this.lblAddressTxt.TabIndex = 10;
            this.lblAddressTxt.Text = "Not specified";
            // 
            // lblPhoneTxt
            // 
            this.lblPhoneTxt.AutoSize = true;
            this.lblPhoneTxt.Location = new System.Drawing.Point(271, 134);
            this.lblPhoneTxt.Name = "lblPhoneTxt";
            this.lblPhoneTxt.Size = new System.Drawing.Size(83, 12);
            this.lblPhoneTxt.TabIndex = 11;
            this.lblPhoneTxt.Text = "Not specified";
            // 
            // lblSexTxt
            // 
            this.lblSexTxt.AutoSize = true;
            this.lblSexTxt.Location = new System.Drawing.Point(271, 95);
            this.lblSexTxt.Name = "lblSexTxt";
            this.lblSexTxt.Size = new System.Drawing.Size(83, 12);
            this.lblSexTxt.TabIndex = 12;
            this.lblSexTxt.Text = "Not specified";
            // 
            // lblIdentityNumberTxt
            // 
            this.lblIdentityNumberTxt.AutoSize = true;
            this.lblIdentityNumberTxt.Location = new System.Drawing.Point(271, 219);
            this.lblIdentityNumberTxt.Name = "lblIdentityNumberTxt";
            this.lblIdentityNumberTxt.Size = new System.Drawing.Size(83, 12);
            this.lblIdentityNumberTxt.TabIndex = 13;
            this.lblIdentityNumberTxt.Text = "Not specified";
            // 
            // frmPatientInfo
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(492, 348);
            this.ControlBox = false;
            this.Controls.Add(this.lblIdentityNumberTxt);
            this.Controls.Add(this.lblSexTxt);
            this.Controls.Add(this.lblPhoneTxt);
            this.Controls.Add(this.lblAddressTxt);
            this.Controls.Add(this.lblNameTxt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblIdentityNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblName);
            this.Name = "frmPatientInfo";
            this.Text = "Patient Add";
            this.Load += new System.EventHandler(this.frmPatientInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblIdentityNumber;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNameTxt;
        private System.Windows.Forms.Label lblAddressTxt;
        private System.Windows.Forms.Label lblPhoneTxt;
        private System.Windows.Forms.Label lblSexTxt;
        private System.Windows.Forms.Label lblIdentityNumberTxt;

    }
}