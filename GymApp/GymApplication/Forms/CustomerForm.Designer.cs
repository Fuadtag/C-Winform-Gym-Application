namespace GymApplication.Forms
{
    partial class CustomerForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerEdit = new System.Windows.Forms.Button();
            this.btnCustomerSave = new System.Windows.Forms.Button();
            this.dtpCustomerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Birthdate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "FirstName";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(103, 131);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(246, 20);
            this.txtCustomerPhone.TabIndex = 3;
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(103, 54);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(246, 20);
            this.txtCustomerLastName.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(103, 13);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(246, 20);
            this.txtCustomerName.TabIndex = 6;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.CustomerFirstName,
            this.CustomerLastName,
            this.CustomerBirthDate,
            this.CustomerPhone});
            this.dgvCustomers.Location = new System.Drawing.Point(24, 181);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(626, 407);
            this.dgvCustomers.TabIndex = 13;
            this.dgvCustomers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCustomers_RowHeaderMouseDoubleClick);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(391, 94);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerDelete.TabIndex = 14;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.BtnCustomerDelete_Click);
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.Location = new System.Drawing.Point(391, 51);
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerEdit.TabIndex = 14;
            this.btnCustomerEdit.Text = "Edit";
            this.btnCustomerEdit.UseVisualStyleBackColor = true;
            this.btnCustomerEdit.Click += new System.EventHandler(this.BtnCustomerEdit_Click);
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.Location = new System.Drawing.Point(391, 12);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerSave.TabIndex = 14;
            this.btnCustomerSave.Text = "Save";
            this.btnCustomerSave.UseVisualStyleBackColor = true;
            this.btnCustomerSave.Click += new System.EventHandler(this.BtnCustomerSave_Click);
            // 
            // dtpCustomerBirthDate
            // 
            this.dtpCustomerBirthDate.Location = new System.Drawing.Point(103, 93);
            this.dtpCustomerBirthDate.Name = "dtpCustomerBirthDate";
            this.dtpCustomerBirthDate.Size = new System.Drawing.Size(246, 20);
            this.dtpCustomerBirthDate.TabIndex = 15;
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = false;
            // 
            // CustomerFirstName
            // 
            this.CustomerFirstName.HeaderText = "Firstname";
            this.CustomerFirstName.Name = "CustomerFirstName";
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.HeaderText = "LastName";
            this.CustomerLastName.Name = "CustomerLastName";
            // 
            // CustomerBirthDate
            // 
            this.CustomerBirthDate.HeaderText = "Birthdate";
            this.CustomerBirthDate.Name = "CustomerBirthDate";
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.HeaderText = "Phone Number";
            this.CustomerPhone.Name = "CustomerPhone";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 645);
            this.Controls.Add(this.dtpCustomerBirthDate);
            this.Controls.Add(this.btnCustomerSave);
            this.Controls.Add(this.btnCustomerEdit);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerEdit;
        private System.Windows.Forms.Button btnCustomerSave;
        private System.Windows.Forms.DateTimePicker dtpCustomerBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
    }
}