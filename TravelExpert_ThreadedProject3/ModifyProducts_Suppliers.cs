using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpert_ThreadedProject3.Models;

namespace TravelExpert_ThreadedProject3
{
    public partial class ModifyProducts_Suppliers : Form
    {
        //GL
        public ProductsSupplier ProductsSupplier { get; set; }    // selected ProductsSupplier on the main form
        //public bool MMProductsSupplier { get; set; }  // flag that distinguishes Add from Modify

        //DB context
        private TravelExpertsContext context = new TravelExpertsContext();
        //Hold selected Product/Supplier information

        public ModifyProducts_Suppliers()
        {
            InitializeComponent();
        }

        private void ModifyProducts_Suppliers_Load(object sender, EventArgs e)
        {
            //txtProdSuppId.ReadOnly = true;
            Object[] pIds = context.Products.Select(p => (Object)p.ProductId.ToString() + "-" + p.ProdName).ToArray();
            Object[] sIds = context.Suppliers.Select(s => (Object)s.SupplierId.ToString() + "-" + s.SupName).ToArray();
            cmdProdId.Items.AddRange(pIds);
            cmdSuppId.Items.AddRange(sIds);

            txtProdSuppId.Text = ProductsSupplier.ProductSupplierId.ToString();   
        }

         private void btnModifyAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                // initialize the ProductsSupplier property with new ProductsSupplier object
                //this.ProductsSupplier = new ProductsSupplier();
                this.LoadProductsSupplierModify();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void LoadProductsSupplierModify()
        {
             ProductsSupplier.ProductSupplierId = Convert.ToInt32(txtProdSuppId.Text);
            ProductsSupplier.ProductId = Convert.ToInt32(System.Text.RegularExpressions.Regex.Replace(cmdProdId.Text, @"[^0-9]+", ""));

            ProductsSupplier.SupplierId = Convert.ToInt32(System.Text.RegularExpressions.Regex.Replace(cmdSuppId.Text, @"[^0-9]+", ""));
        }


        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            ///////// errorMessage += Validator.IsPresent(txtPackageId.Text, txtPackageId.Tag.ToString());
            //errorMessage += Validator.IsInt32(cmdProdId.Text, "Product ID");
            //errorMessage += Validator.IsInt32(cmdSuppId.Text, "Supplier ID");

            // Check if already exist
            if (errorMessage == "")
            {
                int productidsearch = Convert.ToInt32(System.Text.RegularExpressions.Regex.Replace(cmdProdId.Text, @"[^0-9]+",""));
                int supplieridsearch = Convert.ToInt32(System.Text.RegularExpressions.Regex.Replace(cmdSuppId.Text, @"[^0-9]+", ""));
                var prodSuppId = context.ProductsSuppliers
                    .Where(p => p.ProductId == productidsearch)
                    .Where(s => s.SupplierId == supplieridsearch).ToList();
                if (prodSuppId.Count() > 0)
                    errorMessage += "Record exists with duplicate Product ID and Supplier ID, cannot add.";
            }

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnModifyCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
