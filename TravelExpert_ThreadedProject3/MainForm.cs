using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpert_ThreadedProject3.Models;


namespace TravelExpert_ThreadedProject3
{
    public partial class MainForm : Form
    {

        private TravelExpertsContext context = new TravelExpertsContext(); //DB context
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Packages_Click(object sender, EventArgs e)
        {
            var packageForm = new PackageForm();
            packageForm.Show();
            this.Hide();
            
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            var productForm = new ProductForm();
            productForm.Show();
            Hide();

        }

        private void button_prodsup_Click(object sender, EventArgs e)
        {
            var products_SuppliersForm = new Products_SuppliersForm();
            products_SuppliersForm.Show();
            this.Hide();

        }
        private void button_Supplier_Click(object sender, EventArgs e)
        {
            var supplierform = new SupplierForm();
            supplierform.Show();
            this.Hide();

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //customers summary
            var customers = context.Customers
               .OrderBy(c => c.CustomerId)
               .Select(c => new
               {
                   c.CustomerId,

               }).ToList();
            dataGridView_Customer.DataSource = customers;

            int countcust = dataGridView_Customer.Rows.Count;
            textBox_Customer.Text = countcust.ToString();

            //packages summary
            var packages = context.Packages
               .OrderBy(p => p.PackageId)
               .Select(p => new
               {
                   p.PackageId,
                   p.PkgBasePrice,
                   p.PkgAgencyCommission
               }).ToList();
            dataGridView_Packages.DataSource = packages;

            int countpack = dataGridView_Packages.Rows.Count;
            textBox_Packages.Text = countpack.ToString();


            //Calculate averages
            decimal sumprice = 0;
            decimal averageprice = 0;
            decimal sumcomm = 0;
            decimal averagecomm = 0;

            for (int i = 0; i <= dataGridView_Packages.Rows.Count - 1; i++)
            {
                //Calculate average base price
                sumprice = sumprice + decimal.Parse(dataGridView_Packages.Rows[i].Cells[1].Value.ToString());
                averageprice = (sumprice / (dataGridView_Packages.Rows.Count));

                //Calculate average agency commission
                sumcomm = sumcomm + decimal.Parse(dataGridView_Packages.Rows[i].Cells[2].Value.ToString());
                averagecomm = (sumcomm / (dataGridView_Packages.Rows.Count));

            }
            textBox_PackPrice.Text = averageprice.ToString("c");
            textBox_comm.Text = averagecomm.ToString("c");

        }

        private void button_Pps_Click(object sender, EventArgs e)
        {
            var packageproductssupplierform = new PackageProductSupplierForm();
            packageproductssupplierform.Show();
            Hide();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();

        }


    }
}
