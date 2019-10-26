using GymApplication.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApplication.Models;

namespace GymApplication.Forms
{
   

    public partial class MenuItemsForm : Form
    {
        dbcontext context;
        Models.MenuItem selectedmenuitem;
        public MenuItemsForm()
        {
            InitializeComponent();
            context = new dbcontext();
            selectedmenuitem = new Models.MenuItem();

        }

        private void MenuItemsForm_Load(object sender, EventArgs e)
        {
            FillMenuItemsDataGridView();

        }
        private void FillMenuItemsDataGridView()
        {
            dgvMenuItems.Rows.Clear();
            foreach (Models.MenuItem item in context.menuItems)
            {
                if (item.Status == true)
                {
                    dgvMenuItems.Rows.Add(item.id, item.Name, item.Price);
                }

            }
            Reset();
        }
        private void Reset()
        {
            txtMenuItemName.Text = "";
            txtMEnuItemPrice.Text = "";
            selectedmenuitem = null;

        }

        private void BtnMenuItemAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMenuItemName.Text)&&
                string.IsNullOrEmpty(txtMEnuItemPrice.Text))
            {
                MessageBox.Show("Fill the banks");
                return;
            }
            try
            {
                Models.MenuItem newmenuitem = new Models.MenuItem();
                newmenuitem.Name = txtMenuItemName.Text;
                newmenuitem.Price = Convert.ToDecimal(txtMEnuItemPrice.Text);
                newmenuitem.Status = true;
                context.menuItems.Add(newmenuitem);
                
                context.SaveChanges();
                FillMenuItemsDataGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show($"{exc.Message}");
            }
            
        }

        private void BtnMenuItemEdit_Click(object sender, EventArgs e)
        {
            if (selectedmenuitem == null)
            {
                return;
            }
            try
            {
                selectedmenuitem.Name = txtMenuItemName.Text;
                selectedmenuitem.Price = Convert.ToDecimal(txtMEnuItemPrice.Text);
                context.SaveChanges();
                FillMenuItemsDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            


        }

        private void DgvMenuItems_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selecteditemid = (int)dgvMenuItems.Rows[e.RowIndex].Cells[0].Value;
            selectedmenuitem = context.menuItems.FirstOrDefault(a => a.id == selecteditemid);
            txtMenuItemName.Text = selectedmenuitem.Name;
            txtMEnuItemPrice.Text = selectedmenuitem.Price.ToString();
        }

        private void BtnMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (selectedmenuitem == null)
            {
                return;
            }
            selectedmenuitem.Status = false;
            context.SaveChanges();
            FillMenuItemsDataGridView();
        }

      
    }
}
