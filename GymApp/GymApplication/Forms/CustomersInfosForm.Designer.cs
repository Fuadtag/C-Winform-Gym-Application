namespace GymApplication.Forms
{
    partial class CustomersInfosForm
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
            this.dgvCustomersInfos = new System.Windows.Forms.DataGridView();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            this.btnMenuOrder = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerRegEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEntryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersInfos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomersInfos
            // 
            this.dgvCustomersInfos.AllowUserToAddRows = false;
            this.dgvCustomersInfos.AllowUserToDeleteRows = false;
            this.dgvCustomersInfos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomersInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersInfos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.CustomerName,
            this.CustomerLastName,
            this.CustomerBirthDate,
            this.CustomerPackage,
            this.PackagePrice,
            this.CustomerRegEndDate,
            this.CustomerEntryQuantity});
            this.dgvCustomersInfos.Location = new System.Drawing.Point(12, 107);
            this.dgvCustomersInfos.Name = "dgvCustomersInfos";
            this.dgvCustomersInfos.Size = new System.Drawing.Size(1102, 528);
            this.dgvCustomersInfos.TabIndex = 0;
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(12, 26);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(139, 23);
            this.btnCreateCustomer.TabIndex = 1;
            this.btnCreateCustomer.Text = "Customer";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.BtnCreateCustomer_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(174, 26);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(139, 23);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // btnPackages
            // 
            this.btnPackages.Location = new System.Drawing.Point(331, 26);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(139, 23);
            this.btnPackages.TabIndex = 1;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = true;
            this.btnPackages.Click += new System.EventHandler(this.BtnPackages_Click);
            // 
            // btnMenuOrder
            // 
            this.btnMenuOrder.Location = new System.Drawing.Point(496, 26);
            this.btnMenuOrder.Name = "btnMenuOrder";
            this.btnMenuOrder.Size = new System.Drawing.Size(139, 23);
            this.btnMenuOrder.TabIndex = 1;
            this.btnMenuOrder.Text = "Menu Order";
            this.btnMenuOrder.UseVisualStyleBackColor = true;
            this.btnMenuOrder.Click += new System.EventHandler(this.BtnMenuOrder_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.Location = new System.Drawing.Point(660, 26);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(139, 23);
            this.btnReporting.TabIndex = 1;
            this.btnReporting.Text = "Reporting";
            this.btnReporting.UseVisualStyleBackColor = true;
            this.btnReporting.Click += new System.EventHandler(this.BtnReporting_Click);
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.Name = "CustomerName";
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.HeaderText = "LastName";
            this.CustomerLastName.Name = "CustomerLastName";
            // 
            // CustomerBirthDate
            // 
            this.CustomerBirthDate.HeaderText = "BirthDate";
            this.CustomerBirthDate.Name = "CustomerBirthDate";
            // 
            // CustomerPackage
            // 
            this.CustomerPackage.HeaderText = "Package";
            this.CustomerPackage.Name = "CustomerPackage";
            // 
            // PackagePrice
            // 
            this.PackagePrice.HeaderText = "Balance";
            this.PackagePrice.Name = "PackagePrice";
            // 
            // CustomerRegEndDate
            // 
            this.CustomerRegEndDate.HeaderText = "EndDate";
            this.CustomerRegEndDate.Name = "CustomerRegEndDate";
            // 
            // CustomerEntryQuantity
            // 
            this.CustomerEntryQuantity.HeaderText = "Entry Quantity";
            this.CustomerEntryQuantity.Name = "CustomerEntryQuantity";
            // 
            // CustomersInfosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 677);
            this.Controls.Add(this.btnReporting);
            this.Controls.Add(this.btnMenuOrder);
            this.Controls.Add(this.btnPackages);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnCreateCustomer);
            this.Controls.Add(this.dgvCustomersInfos);
            this.Name = "CustomersInfosForm";
            this.Text = "CustomersInfos";
            this.Load += new System.EventHandler(this.CustomersInfosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersInfos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomersInfos;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.Button btnMenuOrder;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackagePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerRegEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerEntryQuantity;
    }
}