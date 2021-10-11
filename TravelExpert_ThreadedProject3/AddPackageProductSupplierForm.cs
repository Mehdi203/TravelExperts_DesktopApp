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
    public partial class AddPackageProductSupplierForm : Form
    {
        private TravelExpertsContext context = new TravelExpertsContext();
        public PackagesProductsSupplier PackagesProductsSupplier { get; set; }
        public bool AddPckPrdSupp { get; set; }

        public AddPackageProductSupplierForm()
        {
            InitializeComponent();
        }
        private void AddPackageProductsSupplierForm_Load(object sender, EventArgs e)
        {
            // Load all product codes 
            Object[] pIds = context.Packages.Select(p => p.PackageId.ToString().PadLeft(4) + " - " + p.PkgName).ToArray();
            comboBoxPackage.Items.AddRange(pIds);

            // Load all product supplier codes 
            //Object[] sIds = context.ProductsSuppliers.Select(ps => (Object)ps.ProductSupplierId).ToArray();
            Object[] sIds = context.ProductsSuppliers
                .Join(context.Products,
                ps1 => ps1.ProductId,
                pr => pr.ProductId,
                (ps1, pr) => new { ProductsSupplier = ps1, Product = pr })
                .Join(context.Suppliers,
                ps1 => ps1.ProductsSupplier.SupplierId,
                s => s.SupplierId,
                (ps1, s) => new { ProductsSupplier = ps1, Supplier = s })
                .Select(p2 => 
                p2.ProductsSupplier.ProductsSupplier.ProductSupplierId.ToString().PadLeft(4) + " - Product: " +
                    p2.ProductsSupplier.Product.ProductId + " - " +
                    p2.ProductsSupplier.Product.ProdName + ", Supplier: " +
                    p2.ProductsSupplier.ProductsSupplier.SupplierId + " - " +
                    p2.Supplier.SupName)
                    .ToArray();
            comboBoxProductSupplier.Items.AddRange(sIds);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (AddPckPrdSupp)
                {
                    this.PackagesProductsSupplier = new PackagesProductsSupplier();
                }
                this.LoadPckPrdSupData();
                this.DialogResult = DialogResult.OK;
            }
        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            // Check if not null
            if (comboBoxPackage.SelectedItem is null)
                errorMessage += Validator.IsPresent("", comboBoxPackage.Tag.ToString());
            //errorMessage += Validator.IsPresent(comboBoxPackage.SelectedItem.ToString(), comboBoxPackage.Tag.ToString());

            if (comboBoxProductSupplier.SelectedItem is null)
                errorMessage += Validator.IsPresent("", comboBoxProductSupplier.Tag.ToString());

            // Check if already exist
            if (errorMessage == "")
            {
                int packageid = Convert.ToInt32(comboBoxPackage.SelectedItem.ToString().Substring(0, 4).Trim());
                int productSupplierId = Convert.ToInt32(comboBoxProductSupplier.SelectedItem.ToString().Substring(0, 4).Trim());
                if (context.PackagesProductsSuppliers.Find(packageid, productSupplierId) is not null)
                    errorMessage += "Duplicate record, cannot add.";
            }

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;

        }
        private void LoadPckPrdSupData()
        {
            PackagesProductsSupplier.PackageId = Convert.ToInt32(comboBoxPackage.SelectedItem.ToString().Substring(0,4));
            PackagesProductsSupplier.ProductSupplierId = Convert.ToInt32(comboBoxProductSupplier.SelectedItem.ToString().Substring(0, 4));
        }

    }
}
