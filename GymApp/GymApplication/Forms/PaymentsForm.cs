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
    public partial class PaymentsForm : Form
    {
        dbcontext context;
        Payment payment;
        string customerfirstname;
        string packagename;
        Payment selectedcustomer;
        public PaymentsForm()
        {
            InitializeComponent();
            context = new dbcontext();
            payment = new Payment();
            
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            CustomerCombobox();
            FillPaymentsDataGridView();


        }
        private void CustomerCombobox()
        {
            foreach (Customer item in context.Customers)

            {
                if (item.Status == true)
                {
                    cmbPaymentsCustomer.Items.Add(item.FirstName + " " + item.LastName);
                }
                
            }
            foreach (Package item in context.packages)
            {
                if (item.Status == true)
                {
                cmbPaymentsPackage.Items.Add(item.Name + "-" + item.Price);
                }
                
            }
        }
        private void FillPaymentsDataGridView()
        {
            dgvPayments.Rows.Clear();
            foreach (Payment item in context.payments.ToList())
            {
                if (item.Status == true && item.customer.Status == true)
                {
                    dgvPayments.Rows.Add(item.id, item.customer.FirstName + " " + item.customer.LastName, item.Package.Name + " - " + item.Package.Name, item.Amount);
                }
             }
            Reset();
        }

        private void BtnPaymentSave_Click(object sender, EventArgs e)
        {
            if (cmbPaymentsCustomer.SelectedIndex < 0 || 
                cmbPaymentsPackage.SelectedIndex < 0 || 
                string.IsNullOrEmpty(txtPaymentsAmount.Text))
            {
                MessageBox.Show("Fill the banks");
                return;
            }
            customerfirstname = cmbPaymentsCustomer.SelectedItem.ToString().Split(' ')[0];
            payment.customer = context.Customers.FirstOrDefault(a => a.FirstName == customerfirstname);
            packagename = cmbPaymentsPackage.SelectedItem.ToString().Split('-')[0];
            payment.Package = context.packages.FirstOrDefault(a => a.Name == packagename);
            payment.CreatedAt = DateTime.Now;
            payment.Amount = Convert.ToDecimal(txtPaymentsAmount.Text);
            payment.Status = true;
            payment.customer.Balance = payment.Amount;
            
            context.payments.Add(payment);
            foreach (Payment item in context.payments.ToList())
            {
                if (payment.CustomerId == item.CustomerId)
                {
                    item.Status = false;
                }
            }
            context.SaveChanges();
            FillPaymentsDataGridView();

            }

        private void BtnPaymentEdit_Click(object sender, EventArgs e)
        {
            if (selectedcustomer == null)
            {
                return;
            }

            customerfirstname = cmbPaymentsCustomer.SelectedItem.ToString().Split(' ')[0];
            selectedcustomer = context.payments.FirstOrDefault(a => a.customer.FirstName == customerfirstname);
            packagename = cmbPaymentsPackage.SelectedItem.ToString().Split('-')[0];
            payment.Package = context.packages.FirstOrDefault(a => a.Name == packagename);
            payment.CreatedAt = DateTime.Now;
            payment.Amount = Convert.ToDecimal(txtPaymentsAmount.Text);
            context.SaveChanges();
            FillPaymentsDataGridView();
        }

        private void DgvPayments_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgvPayments.Rows[e.RowIndex].Cells[0].Value;
            selectedcustomer = context.payments.FirstOrDefault(a => a.id == id);
            cmbPaymentsCustomer.SelectedItem = selectedcustomer.customer.FirstName + " " + selectedcustomer.customer.LastName;
            cmbPaymentsPackage.SelectedItem = selectedcustomer.Package.Name + "-" + selectedcustomer.Package.Price;
            txtPaymentsAmount.Text = selectedcustomer.Amount.ToString("#.00");
        }

        private void BtnPaymentDelete_Click(object sender, EventArgs e)
        {
            if (selectedcustomer == null)
            {
                return;
            }
            selectedcustomer.Status = false;
            context.SaveChanges();
            FillPaymentsDataGridView();

        }
        private void Reset()
        {
            cmbPaymentsCustomer.SelectedIndex = -1;
            cmbPaymentsPackage.SelectedIndex = -1;
            txtPaymentsAmount.Text = "";

        }
    }
}
