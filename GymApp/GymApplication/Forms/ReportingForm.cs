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
using GymApplication.DAL;

namespace GymApplication.Forms
{
    public partial class ReportingForm : Form
    {
        dbcontext context;
        Customer customer;
        public ReportingForm()
        {
            InitializeComponent();
            context = new dbcontext();
        }

        private void ReportingForm_Load(object sender, EventArgs e)
        {
            foreach (Customer item in context.Customers.ToList())
            {
                if (item.Status == true)
                {
                    cmbReportingCustomer.Items.Add(item.FirstName + " " + item.LastName);
                }
                
            }
            
        }

        private void BtnReportingAccept_Click(object sender, EventArgs e)
        {
            string selectedCustomer = cmbReportingCustomer.SelectedItem.ToString().Split(' ')[0];
            customer = context.Customers.FirstOrDefault(a => a.FirstName == selectedCustomer);
            string packagename = context.packages.FirstOrDefault(a => a.id == customer.PackageId).Name;
            customer.package = context.packages.FirstOrDefault(a => a.Name == packagename);
            customer.package.EntryQuantity -= 1;
        }
    }
}
