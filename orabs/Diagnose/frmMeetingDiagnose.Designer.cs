namespace orabs.Meeting
{
    partial class frmMeetingDiagnose
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
            this.lblSymptom = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblHandle = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.txtSymptom = new System.Windows.Forms.TextBox();
            this.txtConclusion = new System.Windows.Forms.TextBox();
            this.txtHandle = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnControlPurchaseItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSymptom
            // 
            this.lblSymptom.AutoSize = true;
            this.lblSymptom.Location = new System.Drawing.Point(142, 47);
            this.lblSymptom.Name = "lblSymptom";
            this.lblSymptom.Size = new System.Drawing.Size(47, 12);
            this.lblSymptom.TabIndex = 0;
            this.lblSymptom.Text = "Symptom";
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(133, 107);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(65, 12);
            this.lblConclusion.TabIndex = 1;
            this.lblConclusion.Text = "Conclusion";
            // 
            // lblHandle
            // 
            this.lblHandle.AutoSize = true;
            this.lblHandle.Location = new System.Drawing.Point(142, 170);
            this.lblHandle.Name = "lblHandle";
            this.lblHandle.Size = new System.Drawing.Size(41, 12);
            this.lblHandle.TabIndex = 2;
            this.lblHandle.Text = "Handle";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Location = new System.Drawing.Point(32, 32);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(29, 12);
            this.lblNameTitle.TabIndex = 3;
            this.lblNameTitle.Text = "Name";
            // 
            // txtSymptom
            // 
            this.txtSymptom.Location = new System.Drawing.Point(241, 32);
            this.txtSymptom.Multiline = true;
            this.txtSymptom.Name = "txtSymptom";
            this.txtSymptom.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSymptom.Size = new System.Drawing.Size(200, 40);
            this.txtSymptom.TabIndex = 1;
            // 
            // txtConclusion
            // 
            this.txtConclusion.Location = new System.Drawing.Point(241, 92);
            this.txtConclusion.Multiline = true;
            this.txtConclusion.Name = "txtConclusion";
            this.txtConclusion.Size = new System.Drawing.Size(200, 39);
            this.txtConclusion.TabIndex = 2;
            // 
            // txtHandle
            // 
            this.txtHandle.Location = new System.Drawing.Point(241, 157);
            this.txtHandle.Multiline = true;
            this.txtHandle.Name = "txtHandle";
            this.txtHandle.Size = new System.Drawing.Size(200, 39);
            this.txtHandle.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(23, 12);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "---";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(160, 295);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 32);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(308, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnControlPurchaseItem
            // 
            this.btnControlPurchaseItem.Location = new System.Drawing.Point(191, 232);
            this.btnControlPurchaseItem.Name = "btnControlPurchaseItem";
            this.btnControlPurchaseItem.Size = new System.Drawing.Size(164, 35);
            this.btnControlPurchaseItem.TabIndex = 8;
            this.btnControlPurchaseItem.Text = "Control &Items";
            this.btnControlPurchaseItem.UseVisualStyleBackColor = true;
            this.btnControlPurchaseItem.Click += new System.EventHandler(this.btnControlPurchaseItem_Click);
            // 
            // frmMeetingDiagnose
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(534, 365);
            this.Controls.Add(this.btnControlPurchaseItem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtHandle);
            this.Controls.Add(this.txtConclusion);
            this.Controls.Add(this.txtSymptom);
            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.lblHandle);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.lblSymptom);
            this.Name = "frmMeetingDiagnose";
            this.Text = "frmMeetingDiagnose";
            this.Load += new System.EventHandler(this.frmMeetingDiagnose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSymptom;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label lblHandle;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.TextBox txtSymptom;
        private System.Windows.Forms.TextBox txtConclusion;
        private System.Windows.Forms.TextBox txtHandle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnControlPurchaseItem;
    }
}