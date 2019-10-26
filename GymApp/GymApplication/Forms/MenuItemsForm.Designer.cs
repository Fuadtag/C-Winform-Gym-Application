namespace GymApplication.Forms
{
    partial class MenuItemsForm
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
            this.btnMenuItemSave = new System.Windows.Forms.Label();
            this.txtMenuItemName = new System.Windows.Forms.TextBox();
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.MenuItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMEnuItemPrice = new System.Windows.Forms.TextBox();
            this.btnMenuItemAdd = new System.Windows.Forms.Button();
            this.btnMenuItemEdit = new System.Windows.Forms.Button();
            this.btnMenuItemDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuItemSave
            // 
            this.btnMenuItemSave.AutoSize = true;
            this.btnMenuItemSave.Location = new System.Drawing.Point(12, 15);
            this.btnMenuItemSave.Name = "btnMenuItemSave";
            this.btnMenuItemSave.Size = new System.Drawing.Size(35, 13);
            this.btnMenuItemSave.TabIndex = 0;
            this.btnMenuItemSave.Text = "Name";
            // 
            // txtMenuItemName
            // 
            this.txtMenuItemName.Location = new System.Drawing.Point(71, 12);
            this.txtMenuItemName.Name = "txtMenuItemName";
            this.txtMenuItemName.Size = new System.Drawing.Size(181, 20);
            this.txtMenuItemName.TabIndex = 1;
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenuItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuItemId,
            this.MenuItemName,
            this.MenuItemPrice});
            this.dgvMenuItems.Location = new System.Drawing.Point(15, 154);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.Size = new System.Drawing.Size(344, 284);
            this.dgvMenuItems.TabIndex = 6;
            this.dgvMenuItems.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMenuItems_RowHeaderMouseDoubleClick);
            // 
            // MenuItemId
            // 
            this.MenuItemId.HeaderText = "id";
            this.MenuItemId.Name = "MenuItemId";
            this.MenuItemId.Visible = false;
            // 
            // MenuItemName
            // 
            this.MenuItemName.HeaderText = "Name";
            this.MenuItemName.Name = "MenuItemName";
            // 
            // MenuItemPrice
            // 
            this.MenuItemPrice.HeaderText = "Price";
            this.MenuItemPrice.Name = "MenuItemPrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            // 
            // txtMEnuItemPrice
            // 
            this.txtMEnuItemPrice.Location = new System.Drawing.Point(71, 50);
            this.txtMEnuItemPrice.Name = "txtMEnuItemPrice";
            this.txtMEnuItemPrice.Size = new System.Drawing.Size(181, 20);
            this.txtMEnuItemPrice.TabIndex = 2;
            // 
            // btnMenuItemAdd
            // 
            this.btnMenuItemAdd.Location = new System.Drawing.Point(15, 83);
            this.btnMenuItemAdd.Name = "btnMenuItemAdd";
            this.btnMenuItemAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMenuItemAdd.TabIndex = 3;
            this.btnMenuItemAdd.Text = "Save";
            this.btnMenuItemAdd.UseVisualStyleBackColor = true;
            this.btnMenuItemAdd.Click += new System.EventHandler(this.BtnMenuItemAdd_Click);
            // 
            // btnMenuItemEdit
            // 
            this.btnMenuItemEdit.Location = new System.Drawing.Point(96, 83);
            this.btnMenuItemEdit.Name = "btnMenuItemEdit";
            this.btnMenuItemEdit.Size = new System.Drawing.Size(75, 23);
            this.btnMenuItemEdit.TabIndex = 4;
            this.btnMenuItemEdit.Text = "Edit";
            this.btnMenuItemEdit.UseVisualStyleBackColor = true;
            this.btnMenuItemEdit.Click += new System.EventHandler(this.BtnMenuItemEdit_Click);
            // 
            // btnMenuItemDelete
            // 
            this.btnMenuItemDelete.Location = new System.Drawing.Point(177, 83);
            this.btnMenuItemDelete.Name = "btnMenuItemDelete";
            this.btnMenuItemDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMenuItemDelete.TabIndex = 5;
            this.btnMenuItemDelete.Text = "Delete";
            this.btnMenuItemDelete.UseVisualStyleBackColor = true;
            this.btnMenuItemDelete.Click += new System.EventHandler(this.BtnMenuItemDelete_Click);
            // 
            // MenuItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.btnMenuItemDelete);
            this.Controls.Add(this.btnMenuItemEdit);
            this.Controls.Add(this.btnMenuItemAdd);
            this.Controls.Add(this.dgvMenuItems);
            this.Controls.Add(this.txtMEnuItemPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMenuItemName);
            this.Controls.Add(this.btnMenuItemSave);
            this.Name = "MenuItemsForm";
            this.Text = "MenuItems";
            this.Load += new System.EventHandler(this.MenuItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnMenuItemSave;
        private System.Windows.Forms.TextBox txtMenuItemName;
        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMEnuItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuItemPrice;
        private System.Windows.Forms.Button btnMenuItemAdd;
        private System.Windows.Forms.Button btnMenuItemEdit;
        private System.Windows.Forms.Button btnMenuItemDelete;
    }
}