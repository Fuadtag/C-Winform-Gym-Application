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
    public partial class CustomerForm : Form
    {
        dbcontext context;
        Customer customer;
        Customer selectedcustomer;
        string packagename;
        public CustomerForm()
        {
            InitializeComponent();
            context = new dbcontext();
            customer = new Customer();

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            FillCustomerDataGView();

        }
        private void FillCustomerDataGView()
        {
            dgvCustomers.Rows.Clear();
            
            
            foreach (Customer item in context.Customers.ToList())
            {
                if (item.Status == true)
                {
                    if (packagename == null)
                    {
                        packagename = "Empty";
                        dgvCustomers.Rows.Add(item.id, item.FirstName, item.LastName, item.BirthDate, item.PhoneNumber, packagename);
                        return;
                    }
                        //packagename = context.packages.FirstOrDefault(a => a.customers.FirstOrDefault(b => b.FirstName == item.FirstName).FirstName == item.FirstName).Name;
                        dgvCustomers.Rows.Add(item.id, item.FirstName, item.LastName, item.BirthDate, item.PhoneNumber, "None");
                    
                    
                  
                }

            }
            Reset();
        }

        private void BtnCustomerSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerLastName.Text) || 
                string.IsNullOrEmpty(txtCustomerName.Text) || 
                string.IsNullOrEmpty(txtCustomerPhone.Text))
            {
                MessageBox.Show("Fill the banks");
                return;
            }
            try
            {
                customer.FirstName = txtCustomerName.Text;
                customer.LastName = txtCustomerLastName.Text;
                customer.BirthDate = dtpCustomerBirthDate.Value;
                customer.PhoneNumber = txtCustomerPhone.Text;
                customer.Status = true;
                customer.PackageEntryQuantity = (byte)customer.package.EntryQuantity;
            }
            catch (Exception a)
            {
                MessageBox.Show($"{a.Message}");
            }
            
            
            
            //customer.Balance += customer.payments.FirstOrDefault(n => n.CustomerId == customer.id).Amount;
            context.Customers.Add(customer);
            context.SaveChanges();
            FillCustomerDataGView();



        }

        private void BtnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (selectedcustomer == null)

            {
                return;
            }
            selectedcustomer.Status = false;
            context.SaveChanges();
            FillCustomerDataGView();
        }

        private void DgvCustomers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgvCustomers.Rows[e.RowIndex].Cells[0].Value;
            selectedcustomer = context.Customers.FirstOrDefault(a => a.id == id);
            txtCustomerName.Text = selectedcustomer.FirstName;
            txtCustomerLastName.Text = selectedcustomer.LastName;
            txtCustomerPhone.Text = selectedcustomer.PhoneNumber;
            dtpCustomerBirthDate.Value = selectedcustomer.BirthDate;

        }
        private void Reset()
        {
            txtCustomerLastName.Text = "";
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            dtpCustomerBirthDate.Value = DateTime.Now;
            packagename = "";
        }

        private void BtnCustomerEdit_Click(object sender, EventArgs e)
        {
            if (selectedcustomer == null)
            {
                return;
            }
            selectedcustomer.FirstName = txtCustomerName.Text;
            selectedcustomer.LastName = txtCustomerLastName.Text;
            selectedcustomer.PhoneNumber = txtCustomerPhone.Text;
            selectedcustomer.BirthDate = dtpCustomerBirthDate.Value;
            context.SaveChanges();
            FillCustomerDataGView();
        }
    }
}
