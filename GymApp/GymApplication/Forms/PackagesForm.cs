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
    public partial class PackagesForm : Form
    {
        dbcontext context;
        Package package;
        Package selectedpackage;
        public PackagesForm()
        {
            InitializeComponent();
            context = new dbcontext();
            selectedpackage = new Package();
        }

        private void PackagesForm_Load(object sender, EventArgs e)
        {
            FillPackagesDataGView();
        }
        private void FillPackagesDataGView()
        {
            dgvPackages.Rows.Clear();
            foreach (Package item in context.packages)
             {
                if (item.Status != false)
                {
                    dgvPackages.Rows.Add(item.id, item.Name, item.Price, item.EntryQuantity);
                }
                Reset();
                
                
            }
            
        }
        private void Reset()
        {
            txtPackageName.Text = "";
            txtPackagePrice.Text = "";
            txtPackageEntryQuantity.Text = "";
            selectedpackage = null;
        }

        private void BtnPackageSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPackageEntryQuantity.Text.Trim()) &&
                string.IsNullOrEmpty(txtPackageName.Text.Trim()) &&
                string.IsNullOrEmpty(txtPackagePrice.Text.Trim()))
            {
                MessageBox.Show("Fill the banks");
                return;

            }


            try
            {
                package = new Package();
                package.Name = txtPackageName.Text;
                package.Price = Convert.ToDecimal(txtPackagePrice.Text);
                package.EntryQuantity = Convert.ToInt32(txtPackageEntryQuantity.Text);
                package.Status = true;
                context.packages.Add(package);
                context.SaveChanges();
                FillPackagesDataGView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");

            }
            
           
        }

        

        

        private void DgvPackages_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgvPackages.Rows[e.RowIndex].Cells[0].Value;
            selectedpackage = context.packages.FirstOrDefault(i => i.id == id);
            txtPackageName.Text = selectedpackage.Name;
            txtPackagePrice.Text = selectedpackage.Price.ToString();
            txtPackageEntryQuantity.Text = selectedpackage.EntryQuantity.ToString();
        }

        private void BtnPackageEdit_Click(object sender, EventArgs e)
        {
            if (selectedpackage == null)
            {
                return;
            }
            
                selectedpackage.Name = txtPackageName.Text;
                selectedpackage.Price = Convert.ToDecimal(txtPackagePrice.Text);
                selectedpackage.EntryQuantity = Convert.ToInt32(txtPackageEntryQuantity.Text);
                context.SaveChanges();
                FillPackagesDataGView();
            
        }

        private void BtnPackageDelete_Click(object sender, EventArgs e)
        {
            if (selectedpackage == null)
            {
                return;
            }
            selectedpackage.Status = false;
            context.SaveChanges();
            FillPackagesDataGView();
        }
    }
}
