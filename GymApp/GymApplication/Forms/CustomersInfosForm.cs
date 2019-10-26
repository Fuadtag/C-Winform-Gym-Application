using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApplication.DAL;
using GymApplication.Models;
using GymApplication.Forms;

namespace GymApplication.Forms
{
    public partial class CustomersInfosForm : Form
    {
        dbcontext dbcontext;
        string packagename;
        
        public CustomersInfosForm()
        {
            InitializeComponent();
            dbcontext = new dbcontext();
            
        }

        private void BtnCreateCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
         }

       

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            PaymentsForm paymentsform = new PaymentsForm();
            paymentsform.FormClosed += new FormClosedEventHandler(FillCustomersDataGridView);
            paymentsform.ShowDialog();

        }

        private void BtnPackages_Click(object sender, EventArgs e)
        {
            PackagesForm packagesForm = new PackagesForm();
            packagesForm.ShowDialog();
            
        }

        private void BtnMenuOrder_Click(object sender, EventArgs e)
        {
            RestouranFormt restouranFormt = new RestouranFormt();
            restouranFormt.ShowDialog();
        }
        private void CustomersInfosForm_Load(object sender, EventArgs e)
        {
            FillCustomersDataGridView();

        }
        private void FillCustomersDataGridView()
        {
            dgvCustomersInfos.Rows.Clear();
            Customer customer;

            foreach (Payment item in dbcontext.payments.ToList())
            {
                if (item.Status == true)
                {
                    
                    customer = dbcontext.Customers.FirstOrDefault(b => b.id == item.CustomerId);
                    if (customer.PackageId != null)
                    {
                        packagename = dbcontext.packages.FirstOrDefault(a => a.id == customer.PackageId).Name;
                    }
                    
                    if (packagename == null)
                    {
                        packagename = "Empty";
                    }
                    
                    dgvCustomersInfos.Rows.Add(item.id, customer.FirstName, customer.LastName, customer.BirthDate, packagename, customer.Balance, item.CreatedAt.AddMonths(1), customer.PackageEntryQuantity );
                    if (item.CreatedAt.AddMonths(1) < DateTime.Now)
                    {
                        dgvCustomersInfos.Rows[dgvCustomersInfos.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            
        }
        private void FillCustomersDataGridView(object sender, EventArgs e)
        {
            dgvCustomersInfos.Rows.Clear();
            Customer customer;

            foreach (Payment item in dbcontext.payments.ToList())
            {
                if (item.Status == true)
                {

                    customer = dbcontext.Customers.FirstOrDefault(b => b.id == item.CustomerId);
                    if (customer.PackageId != null)
                    {
                        packagename = dbcontext.packages.FirstOrDefault(a => a.id == customer.PackageId).Name;
                    }

                    if (packagename == null)
                    {
                        packagename = "Empty";
                    }

                    dgvCustomersInfos.Rows.Add(item.id, customer.FirstName, customer.LastName, customer.BirthDate, packagename, customer.Balance, item.CreatedAt.AddMonths(1), customer.PackageEntryQuantity);
                    if (item.CreatedAt.AddMonths(1) < new DateTime(2019, 11, 15))
                    {
                        dgvCustomersInfos.Rows[dgvCustomersInfos.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }

        }

        private void BtnReporting_Click(object sender, EventArgs e)
        {
            ReportingForm reportingForm = new ReportingForm();
            reportingForm.ShowDialog();
        }
    }
}
