namespace GymApplication.Forms
{
    partial class RestouranFormt
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
            this.cmbRestourantCustomer = new System.Windows.Forms.ComboBox();
            this.cmbRestourantMenu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericupdownOrderQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRestourant = new System.Windows.Forms.DataGridView();
            this.Restourantid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestourantCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestourantOrderMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestourantOrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRestourantSave = new System.Windows.Forms.Button();
            this.btnRestourantEdit = new System.Windows.Forms.Button();
            this.btnRestourantDelete = new System.Windows.Forms.Button();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.btnMenuOrderConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownOrderQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestourant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // cmbRestourantCustomer
            // 
            this.cmbRestourantCustomer.FormattingEnabled = true;
            this.cmbRestourantCustomer.Location = new System.Drawing.Point(84, 22);
            this.cmbRestourantCustomer.Name = "cmbRestourantCustomer";
            this.cmbRestourantCustomer.Size = new System.Drawing.Size(180, 21);
            this.cmbRestourantCustomer.TabIndex = 1;
            // 
            // cmbRestourantMenu
            // 
            this.cmbRestourantMenu.FormattingEnabled = true;
            this.cmbRestourantMenu.Location = new System.Drawing.Point(84, 64);
            this.cmbRestourantMenu.Name = "cmbRestourantMenu";
            this.cmbRestourantMenu.Size = new System.Drawing.Size(180, 21);
            this.cmbRestourantMenu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menu";
            // 
            // numericupdownOrderQuantity
            // 
            this.numericupdownOrderQuantity.Location = new System.Drawing.Point(84, 109);
            this.numericupdownOrderQuantity.Name = "numericupdownOrderQuantity";
            this.numericupdownOrderQuantity.Size = new System.Drawing.Size(179, 20);
            this.numericupdownOrderQuantity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // dgvRestourant
            // 
            this.dgvRestourant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRestourant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRestourant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestourant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Restourantid,
            this.RestourantCustomer,
            this.RestourantOrderMenu,
            this.RestourantOrderQuantity});
            this.dgvRestourant.Location = new System.Drawing.Point(6, 183);
            this.dgvRestourant.Name = "dgvRestourant";
            this.dgvRestourant.Size = new System.Drawing.Size(377, 283);
            this.dgvRestourant.TabIndex = 5;
            this.dgvRestourant.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvRestourant_RowHeaderMouseDoubleClick);
            // 
            // Restourantid
            // 
            this.Restourantid.HeaderText = "id";
            this.Restourantid.Name = "Restourantid";
            this.Restourantid.Visible = false;
            // 
            // RestourantCustomer
            // 
            this.RestourantCustomer.HeaderText = "Customer";
            this.RestourantCustomer.Name = "RestourantCustomer";
            // 
            // RestourantOrderMenu
            // 
            this.RestourantOrderMenu.HeaderText = "Menu";
            this.RestourantOrderMenu.Name = "RestourantOrderMenu";
            // 
            // RestourantOrderQuantity
            // 
            this.RestourantOrderQuantity.HeaderText = "Quantity";
            this.RestourantOrderQuantity.Name = "RestourantOrderQuantity";
            // 
            // btnRestourantSave
            // 
            this.btnRestourantSave.Location = new System.Drawing.Point(311, 25);
            this.btnRestourantSave.Name = "btnRestourantSave";
            this.btnRestourantSave.Size = new System.Drawing.Size(75, 23);
            this.btnRestourantSave.TabIndex = 6;
            this.btnRestourantSave.Text = "Save";
            this.btnRestourantSave.UseVisualStyleBackColor = true;
            this.btnRestourantSave.Click += new System.EventHandler(this.BtnRestourantSave_Click);
            // 
            // btnRestourantEdit
            // 
            this.btnRestourantEdit.Location = new System.Drawing.Point(311, 64);
            this.btnRestourantEdit.Name = "btnRestourantEdit";
            this.btnRestourantEdit.Size = new System.Drawing.Size(75, 23);
            this.btnRestourantEdit.TabIndex = 6;
            this.btnRestourantEdit.Text = "Edit";
            this.btnRestourantEdit.UseVisualStyleBackColor = true;
            this.btnRestourantEdit.Click += new System.EventHandler(this.BtnRestourantEdit_Click);
            // 
            // btnRestourantDelete
            // 
            this.btnRestourantDelete.Location = new System.Drawing.Point(311, 109);
            this.btnRestourantDelete.Name = "btnRestourantDelete";
            this.btnRestourantDelete.Size = new System.Drawing.Size(75, 23);
            this.btnRestourantDelete.TabIndex = 6;
            this.btnRestourantDelete.Text = "Delete";
            this.btnRestourantDelete.UseVisualStyleBackColor = true;
            this.btnRestourantDelete.Click += new System.EventHandler(this.BtnRestourantDelete_Click);
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.Location = new System.Drawing.Point(278, 154);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(108, 23);
            this.btnAddMenuItem.TabIndex = 6;
            this.btnAddMenuItem.Text = "Add Menu Item";
            this.btnAddMenuItem.UseVisualStyleBackColor = true;
            this.btnAddMenuItem.Click += new System.EventHandler(this.BtnAddMenuItem_Click);
            // 
            // btnMenuOrderConfirm
            // 
            this.btnMenuOrderConfirm.Location = new System.Drawing.Point(249, 482);
            this.btnMenuOrderConfirm.Name = "btnMenuOrderConfirm";
            this.btnMenuOrderConfirm.Size = new System.Drawing.Size(133, 44);
            this.btnMenuOrderConfirm.TabIndex = 7;
            this.btnMenuOrderConfirm.Text = "Confirm";
            this.btnMenuOrderConfirm.UseVisualStyleBackColor = true;
            this.btnMenuOrderConfirm.Click += new System.EventHandler(this.BtnMenuOrderConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Amount";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(85, 482);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAmount.TabIndex = 9;
            // 
            // RestouranFormt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 538);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMenuOrderConfirm);
            this.Controls.Add(this.btnAddMenuItem);
            this.Controls.Add(this.btnRestourantDelete);
            this.Controls.Add(this.btnRestourantEdit);
            this.Controls.Add(this.btnRestourantSave);
            this.Controls.Add(this.dgvRestourant);
            this.Controls.Add(this.numericupdownOrderQuantity);
            this.Controls.Add(this.cmbRestourantMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRestourantCustomer);
            this.Controls.Add(this.label1);
            this.Name = "RestouranFormt";
            this.Text = "Restourant";
            this.Load += new System.EventHandler(this.RestouranFormt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownOrderQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestourant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRestourantCustomer;
        private System.Windows.Forms.ComboBox cmbRestourantMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericupdownOrderQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRestourant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restourantid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestourantCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestourantOrderMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestourantOrderQuantity;
        private System.Windows.Forms.Button btnRestourantSave;
        private System.Windows.Forms.Button btnRestourantEdit;
        private System.Windows.Forms.Button btnRestourantDelete;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.Button btnMenuOrderConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}