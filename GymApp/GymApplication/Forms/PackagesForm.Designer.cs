namespace GymApplication.Forms
{
    partial class PackagesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPackagePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPackageEntryQuantity = new System.Windows.Forms.TextBox();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.PackageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageEntryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPackageDelete = new System.Windows.Forms.Button();
            this.btnPackageEdit = new System.Windows.Forms.Button();
            this.btnPackageSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(217, 26);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(150, 20);
            this.txtPackageName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // txtPackagePrice
            // 
            this.txtPackagePrice.Location = new System.Drawing.Point(217, 60);
            this.txtPackagePrice.Name = "txtPackagePrice";
            this.txtPackagePrice.Size = new System.Drawing.Size(150, 20);
            this.txtPackagePrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Entry Quantity";
            // 
            // txtPackageEntryQuantity
            // 
            this.txtPackageEntryQuantity.Location = new System.Drawing.Point(217, 93);
            this.txtPackageEntryQuantity.Name = "txtPackageEntryQuantity";
            this.txtPackageEntryQuantity.Size = new System.Drawing.Size(150, 20);
            this.txtPackageEntryQuantity.TabIndex = 3;
            // 
            // dgvPackages
            // 
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageID,
            this.PackageName,
            this.PackagePrice,
            this.PackageEntryQuantity});
            this.dgvPackages.Location = new System.Drawing.Point(34, 173);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.Size = new System.Drawing.Size(333, 287);
            this.dgvPackages.TabIndex = 5;
            this.dgvPackages.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPackages_RowHeaderMouseDoubleClick);
            // 
            // PackageID
            // 
            this.PackageID.HeaderText = "Id";
            this.PackageID.Name = "PackageID";
            this.PackageID.Visible = false;
            // 
            // PackageName
            // 
            this.PackageName.HeaderText = "Name";
            this.PackageName.Name = "PackageName";
            // 
            // PackagePrice
            // 
            this.PackagePrice.HeaderText = "Price";
            this.PackagePrice.Name = "PackagePrice";
            // 
            // PackageEntryQuantity
            // 
            this.PackageEntryQuantity.HeaderText = "Entry Quantity";
            this.PackageEntryQuantity.Name = "PackageEntryQuantity";
            // 
            // btnPackageDelete
            // 
            this.btnPackageDelete.Location = new System.Drawing.Point(291, 135);
            this.btnPackageDelete.Name = "btnPackageDelete";
            this.btnPackageDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPackageDelete.TabIndex = 6;
            this.btnPackageDelete.Text = "Delete";
            this.btnPackageDelete.UseVisualStyleBackColor = true;
            this.btnPackageDelete.Click += new System.EventHandler(this.BtnPackageDelete_Click);
            // 
            // btnPackageEdit
            // 
            this.btnPackageEdit.Location = new System.Drawing.Point(200, 135);
            this.btnPackageEdit.Name = "btnPackageEdit";
            this.btnPackageEdit.Size = new System.Drawing.Size(75, 23);
            this.btnPackageEdit.TabIndex = 6;
            this.btnPackageEdit.Text = "Edit";
            this.btnPackageEdit.UseVisualStyleBackColor = true;
            this.btnPackageEdit.Click += new System.EventHandler(this.BtnPackageEdit_Click);
            // 
            // btnPackageSave
            // 
            this.btnPackageSave.Location = new System.Drawing.Point(106, 135);
            this.btnPackageSave.Name = "btnPackageSave";
            this.btnPackageSave.Size = new System.Drawing.Size(75, 23);
            this.btnPackageSave.TabIndex = 6;
            this.btnPackageSave.Text = "Save";
            this.btnPackageSave.UseVisualStyleBackColor = true;
            this.btnPackageSave.Click += new System.EventHandler(this.BtnPackageSave_Click);
            // 
            // PackagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 504);
            this.Controls.Add(this.btnPackageSave);
            this.Controls.Add(this.btnPackageEdit);
            this.Controls.Add(this.btnPackageDelete);
            this.Controls.Add(this.dgvPackages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPackageEntryQuantity);
            this.Controls.Add(this.txtPackagePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.label1);
            this.Name = "PackagesForm";
            this.Text = "Packages";
            this.Load += new System.EventHandler(this.PackagesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPackagePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPackageEntryQuantity;
        private System.Windows.Forms.DataGridView dgvPackages;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackagePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageEntryQuantity;
        private System.Windows.Forms.Button btnPackageDelete;
        private System.Windows.Forms.Button btnPackageEdit;
        private System.Windows.Forms.Button btnPackageSave;
    }
}