using GymApplication.DAL;
using GymApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApplication.Forms
{
    public partial class RestouranFormt : Form
    {
        dbcontext context;
        MenuOrder selectedorder;
        List<MenuOrder> menuOrders = new List<MenuOrder>();
        decimal TotalAmount = 0;
        public RestouranFormt()
        {
            InitializeComponent();
            context = new dbcontext();
            selectedorder = new MenuOrder();
            
        }

        

        private void RestouranFormt_Load(object sender, EventArgs e)
        {
            FillCustomerComboBox();
            FillMenuComboBox();
        }
        private void FillCustomerComboBox()
        {
            foreach (Customer item in context.Customers)
            {
                if (item.Status == true)
                {
                    cmbRestourantCustomer.Items.Add(item.FirstName + " " + item.LastName);
                }

            }
        }
        private void FillMenuComboBox()
        {
            foreach (Models.MenuItem item in context.menuItems)
            {
                if (item.Status == true)
                {
                    cmbRestourantMenu.Items.Add(item.Name + " - " + item.Price + " AZN");
                }
            }
        }


        private void Reset()
        {
            cmbRestourantCustomer.SelectedIndex = -1;
            cmbRestourantMenu.SelectedIndex = -1;
            numericupdownOrderQuantity.Value = 0;
            selectedorder = null;
            


        }

        private void BtnRestourantSave_Click(object sender, EventArgs e)
        {
            if (cmbRestourantCustomer.SelectedIndex < 0 || cmbRestourantMenu.SelectedIndex < 0 || numericupdownOrderQuantity.Value < 1)
            {
                MessageBox.Show("Fill the banks");
                return;
            }
            MenuOrder neworder = new MenuOrder();
            string selectedcustomername = cmbRestourantCustomer.SelectedItem.ToString().Split(' ')[0];
            neworder.customer = context.Customers.FirstOrDefault(a => a.FirstName == selectedcustomername);
            string selectedmenuname = cmbRestourantMenu.SelectedItem.ToString().Split('-')[0].Trim();
            neworder.menu = context.menuItems.FirstOrDefault(b => b.Name == selectedmenuname);
            neworder.Quantity = (int)numericupdownOrderQuantity.Value;
            neworder.Status = true;
            neworder.MenuItemId = context.menuItems.FirstOrDefault(a => a.Name == selectedmenuname).id;
            menuOrders.Add(neworder);
            FillOrdersDataGridView();
        }
        private void FillOrdersDataGridView()
        {
            dgvRestourant.Rows.Clear();
            Models.MenuItem menuItem;
            foreach (MenuOrder item in menuOrders)
            {
                menuItem = context.menuItems.FirstOrDefault(a => a.id == item.MenuItemId);
                TotalAmount += menuItem.Price * item.Quantity;
                lblTotalAmount.Text = TotalAmount.ToString() + " AZN";
                

                if (item.Status == true)
                {
                    dgvRestourant.Rows.Add(item.id, item.customer.FirstName + " " + item.customer.LastName, menuItem.Name, item.Quantity);
                }

            }
            Reset();
        }

        private void BtnMenuOrderConfirm_Click(object sender, EventArgs e)
        {
            context.menuOrders.AddRange(menuOrders);
            context.SaveChanges();
            Customer customer;
            foreach (MenuOrder item in menuOrders)
            {
                
                customer = context.Customers.FirstOrDefault(a => a.id == item.CustomerId);
                customer.Balance = customer.Balance - TotalAmount;
                item.Status = false;
                
            }
            
            dgvRestourant.Rows.Clear();
            lblTotalAmount.Text = "";
            TotalAmount = 0;
             

        }

        private void BtnRestourantEdit_Click(object sender, EventArgs e)
        {
            if (selectedorder == null)
            {
                return;
            }
            selectedorder.Quantity = (int)numericupdownOrderQuantity.Value;
            string selectedcustomer = cmbRestourantCustomer.SelectedItem.ToString().Split(' ')[0];
            selectedorder.customer = context.Customers.FirstOrDefault(a => a.FirstName == selectedcustomer);
            string selectedmenu = cmbRestourantMenu.SelectedItem.ToString().Split('-')[0].Trim();
            selectedorder.menu = context.menuItems.FirstOrDefault(a => a.Name == selectedmenu);
            FillOrdersDataGridView();
        }
        private void BtnRestourantDelete_Click(object sender, EventArgs e)
        {
            if (selectedorder == null)
            {
                return;
            }
            menuOrders.Remove(selectedorder);
            FillOrdersDataGridView();
        }

        private void DgvRestourant_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgvRestourant.Rows[e.RowIndex].Cells[0].Value;
            selectedorder = menuOrders.FirstOrDefault(a => a.id == id);
            cmbRestourantCustomer.SelectedItem = selectedorder.customer.FirstName + " " + selectedorder.customer.LastName;
            Models.MenuItem selectedmenuitem = context.menuItems.FirstOrDefault(a => a.id == selectedorder.MenuItemId);
            cmbRestourantMenu.SelectedItem = selectedmenuitem.Name + " - " + selectedmenuitem.Price + " AZN";
            numericupdownOrderQuantity.Value = selectedorder.Quantity;
        }

        private void BtnAddMenuItem_Click(object sender, EventArgs e)
        {
            MenuItemsForm menuitemform = new MenuItemsForm();
            menuitemform.FormClosed += new FormClosedEventHandler(FillMenuComboBox);
            menuitemform.ShowDialog();
        }
        private void FillMenuComboBox(object sender, EventArgs e)
        {
            foreach (Models.MenuItem item in context.menuItems)
            {
                if (item.Status == true)
                {
                    cmbRestourantMenu.Items.Add(item.Name + " - " + item.Price + " AZN");
                }
            }
        }
    }
}
