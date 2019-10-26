namespace GymApplication.Forms
{
    partial class PaymentsForm
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
            this.cmbPaymentsCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPaymentsPackage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaymentsAmount = new System.Windows.Forms.TextBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.PaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPaymentDelete = new System.Windows.Forms.Button();
            this.btnPaymentEdit = new System.Windows.Forms.Button();
            this.btnPaymentSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPaymentsCustomer
            // 
            this.cmbPaymentsCustomer.FormattingEnabled = true;
            this.cmbPaymentsCustomer.Location = new System.Drawing.Point(72, 20);
            this.cmbPaymentsCustomer.Name = "cmbPaymentsCustomer";
            this.cmbPaymentsCustomer.Size = new System.Drawing.Size(237, 21);
            this.cmbPaymentsCustomer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Package";
            // 
            // cmbPaymentsPackage
            // 
            this.cmbPaymentsPackage.FormattingEnabled = true;
            this.cmbPaymentsPackage.Location = new System.Drawing.Point(72, 61);
            this.cmbPaymentsPackage.Name = "cmbPaymentsPackage";
            this.cmbPaymentsPackage.Size = new System.Drawing.Size(237, 21);
            this.cmbPaymentsPackage.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // txtPaymentsAmount
            // 
            this.txtPaymentsAmount.Location = new System.Drawing.Point(72, 103);
            this.txtPaymentsAmount.Name = "txtPaymentsAmount";
            this.txtPaymentsAmount.Size = new System.Drawing.Size(237, 20);
            this.txtPaymentsAmount.TabIndex = 4;
            // 
            // dgvPayments
            // 
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentId,
            this.PaymentCustomerName,
            this.PackageName,
            this.PaymentAmount});
            this.dgvPayments.Location = new System.Drawing.Point(12, 201);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.Size = new System.Drawing.Size(343, 289);
            this.dgvPayments.TabIndex = 5;
            this.dgvPayments.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPayments_RowHeaderMouseDoubleClick);
            // 
            // PaymentId
            // 
            this.PaymentId.HeaderText = "Id";
            this.PaymentId.Name = "PaymentId";
            this.PaymentId.Visible = false;
            // 
            // PaymentCustomerName
            // 
            this.PaymentCustomerName.HeaderText = "Customer Name";
            this.PaymentCustomerName.Name = "PaymentCustomerName";
            // 
            // PackageName
            // 
            this.PackageName.HeaderText = "Package";
            this.PackageName.Name = "PackageName";
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.HeaderText = "Amount";
            this.PaymentAmount.Name = "PaymentAmount";
            // 
            // btnPaymentDelete
            // 
            this.btnPaymentDelete.Location = new System.Drawing.Point(234, 142);
            this.btnPaymentDelete.Name = "btnPaymentDelete";
            this.btnPaymentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPaymentDelete.TabIndex = 6;
            this.btnPaymentDelete.Text = "Delete";
            this.btnPaymentDelete.UseVisualStyleBackColor = true;
            this.btnPaymentDelete.Click += new System.EventHandler(this.BtnPaymentDelete_Click);
            // 
            // btnPaymentEdit
            // 
            this.btnPaymentEdit.Location = new System.Drawing.Point(153, 142);
            this.btnPaymentEdit.Name = "btnPaymentEdit";
            this.btnPaymentEdit.Size = new System.Drawing.Size(75, 23);
            this.btnPaymentEdit.TabIndex = 6;
            this.btnPaymentEdit.Text = "Edit";
            this.btnPaymentEdit.UseVisualStyleBackColor = true;
            this.btnPaymentEdit.Click += new System.EventHandler(this.BtnPaymentEdit_Click);
            // 
            // btnPaymentSave
            // 
            this.btnPaymentSave.Location = new System.Drawing.Point(72, 142);
            this.btnPaymentSave.Name = "btnPaymentSave";
            this.btnPaymentSave.Size = new System.Drawing.Size(75, 23);
            this.btnPaymentSave.TabIndex = 6;
            this.btnPaymentSave.Text = "Save";
            this.btnPaymentSave.UseVisualStyleBackColor = true;
            this.btnPaymentSave.Click += new System.EventHandler(this.BtnPaymentSave_Click);
            // 
            // PaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 509);
            this.Controls.Add(this.btnPaymentSave);
            this.Controls.Add(this.btnPaymentEdit);
            this.Controls.Add(this.btnPaymentDelete);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.txtPaymentsAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPaymentsPackage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPaymentsCustomer);
            this.Name = "PaymentsForm";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.PaymentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPaymentsCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPaymentsPackage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaymentsAmount;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentAmount;
        private System.Windows.Forms.Button btnPaymentDelete;
        private System.Windows.Forms.Button btnPaymentEdit;
        private System.Windows.Forms.Button btnPaymentSave;
    }
}