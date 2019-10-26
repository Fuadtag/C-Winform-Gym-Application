namespace GymApplication.Forms
{
    partial class ReportingForm
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
            this.cmbReportingCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReportingAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbReportingCustomer
            // 
            this.cmbReportingCustomer.FormattingEnabled = true;
            this.cmbReportingCustomer.Location = new System.Drawing.Point(86, 26);
            this.cmbReportingCustomer.Name = "cmbReportingCustomer";
            this.cmbReportingCustomer.Size = new System.Drawing.Size(255, 21);
            this.cmbReportingCustomer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // btnReportingAccept
            // 
            this.btnReportingAccept.Location = new System.Drawing.Point(180, 95);
            this.btnReportingAccept.Name = "btnReportingAccept";
            this.btnReportingAccept.Size = new System.Drawing.Size(160, 42);
            this.btnReportingAccept.TabIndex = 2;
            this.btnReportingAccept.Text = "Accept";
            this.btnReportingAccept.UseVisualStyleBackColor = true;
            this.btnReportingAccept.Click += new System.EventHandler(this.BtnReportingAccept_Click);
            // 
            // ReportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.btnReportingAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbReportingCustomer);
            this.Name = "ReportingForm";
            this.Text = "ReportingForm";
            this.Load += new System.EventHandler(this.ReportingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbReportingCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReportingAccept;
    }
}