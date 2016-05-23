namespace orabs.Diagnose
{
    partial class frmMeetingDiagnoseItems
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
            this.lblNamePrefix = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lstAllItems = new System.Windows.Forms.ListBox();
            this.txtNamePrefix = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstChosenItems = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReduce = new System.Windows.Forms.Button();
            this.lblTotalPriceText = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNamePrefix
            // 
            this.lblNamePrefix.AutoSize = true;
            this.lblNamePrefix.Location = new System.Drawing.Point(34, 47);
            this.lblNamePrefix.Name = "lblNamePrefix";
            this.lblNamePrefix.Size = new System.Drawing.Size(77, 12);
            this.lblNamePrefix.TabIndex = 0;
            this.lblNamePrefix.Text = "Name Prefix:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(184, 47);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 12);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number:";
            // 
            // lstAllItems
            // 
            this.lstAllItems.FormattingEnabled = true;
            this.lstAllItems.ItemHeight = 12;
            this.lstAllItems.Location = new System.Drawing.Point(36, 89);
            this.lstAllItems.Name = "lstAllItems";
            this.lstAllItems.Size = new System.Drawing.Size(187, 184);
            this.lstAllItems.TabIndex = 2;
            // 
            // txtNamePrefix
            // 
            this.txtNamePrefix.Location = new System.Drawing.Point(36, 62);
            this.txtNamePrefix.Name = "txtNamePrefix";
            this.txtNamePrefix.Size = new System.Drawing.Size(144, 21);
            this.txtNamePrefix.TabIndex = 0;
            this.txtNamePrefix.TextChanged += new System.EventHandler(this.txtNamePrefix_TextChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(186, 62);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(37, 21);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.Text = "1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(229, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(551, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(463, 329);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 36);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lstChosenItems
            // 
            this.lstChosenItems.FormattingEnabled = true;
            this.lstChosenItems.ItemHeight = 12;
            this.lstChosenItems.Location = new System.Drawing.Point(303, 89);
            this.lstChosenItems.Name = "lstChosenItems";
            this.lstChosenItems.Size = new System.Drawing.Size(187, 184);
            this.lstChosenItems.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(496, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(496, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReduce
            // 
            this.btnReduce.Location = new System.Drawing.Point(496, 89);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(63, 32);
            this.btnReduce.TabIndex = 9;
            this.btnReduce.Text = "&Reduce";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // lblTotalPriceText
            // 
            this.lblTotalPriceText.AutoSize = true;
            this.lblTotalPriceText.Location = new System.Drawing.Point(301, 276);
            this.lblTotalPriceText.Name = "lblTotalPriceText";
            this.lblTotalPriceText.Size = new System.Drawing.Size(83, 12);
            this.lblTotalPriceText.TabIndex = 10;
            this.lblTotalPriceText.Text = "Total Price: ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(390, 276);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 12);
            this.lblTotalPrice.TabIndex = 11;
            // 
            // frmMeetingDiagnoseItems
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(673, 386);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalPriceText);
            this.Controls.Add(this.btnReduce);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstChosenItems);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtNamePrefix);
            this.Controls.Add(this.lstAllItems);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblNamePrefix);
            this.Name = "frmMeetingDiagnoseItems";
            this.Text = "Meeting Diagnose Items";
            this.Load += new System.EventHandler(this.frmMeetingDiagnoseItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamePrefix;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ListBox lstAllItems;
        private System.Windows.Forms.TextBox txtNamePrefix;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lstChosenItems;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Label lblTotalPriceText;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}