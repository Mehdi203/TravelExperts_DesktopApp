using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class PackageProductSupplierForm : Form
    {
        public PackageProductSupplierForm()
        {
            InitializeComponent();
        }

        private TravelExpertsContext context = new TravelExpertsContext(); //DB context
        private PackagesProductsSupplier selectedPckPrdSup; //Hold selected package information

        private void PackageProductsSupplierForm_Load(object sender, EventArgs e)
        {
            DisplayPckPrdSup();
        }

        //Method to display all Packages Products Supplier
        public void DisplayPckPrdSup()
        {
            dataGridView_PackageProductsSupplier.Columns.Clear();
            var pckPrdSup = context.PackagesProductsSuppliers
                .Join(context.Packages,
                p => p.PackageId,
                pk => pk.PackageId,
                (p, pk) => new { PackagesProductsSupplier = p, Package = pk })
                .Join(context.ProductsSuppliers,
                p1 => p1.PackagesProductsSupplier.ProductSupplierId,
                ps => ps.ProductSupplierId,
                (p1, ps) => new { PackagesProductsSupplier = p1, ProductsSupplier = ps})
                .Join(context.Products,
                ps1 => ps1.ProductsSupplier.ProductId,
                pr => pr.ProductId,
                (ps1, pr) => new {ProductsSupplier = ps1, Product = pr})
                .Join(context.Suppliers,
                ps1 => ps1.ProductsSupplier.ProductsSupplier.SupplierId,
                s => s.SupplierId,
                (ps1, s) => new { ProductsSupplier = ps1, Supplier = s})
                .Select(p2 => new { 
                    p2.ProductsSupplier.ProductsSupplier.PackagesProductsSupplier.PackagesProductsSupplier.PackageId,
                p2.ProductsSupplier.ProductsSupplier.PackagesProductsSupplier.Package.PkgName,
                p2.ProductsSupplier.ProductsSupplier.ProductsSupplier.ProductSupplierId,
                p2.ProductsSupplier.Product.ProductId,
                p2.ProductsSupplier.Product.ProdName,
                p2.ProductsSupplier.ProductsSupplier.ProductsSupplier.SupplierId,
                p2.Supplier.SupName})
                           .OrderBy(p => p.PackageId)
                           .ThenBy(p => p.ProductSupplierId)
                           .ToList();
            //var pckPrdSup = context.PackagesProductsSuppliers
            //               .OrderBy(p => p.PackageId)
            //               .Select(p => new
            //               {
            //                   p.PackageId,
            //                   p.ProductSupplierId,
            //               }).ToList();
            dataGridView_PackageProductsSupplier.DataSource = pckPrdSup;

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dataGridView_PackageProductsSupplier.Columns.Add(deleteColumn);

            // format the column header
            dataGridView_PackageProductsSupplier.EnableHeadersVisualStyles = false;
            dataGridView_PackageProductsSupplier.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView_PackageProductsSupplier.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrchid;
            dataGridView_PackageProductsSupplier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dataGridView_PackageProductsSupplier.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;

            // format the first column
            dataGridView_PackageProductsSupplier.Columns[0].HeaderText = "Package ID";
            dataGridView_PackageProductsSupplier.Columns[0].Width = 80;

            // format the 2nd column
            dataGridView_PackageProductsSupplier.Columns[1].HeaderText = "Package Name";
            dataGridView_PackageProductsSupplier.Columns[1].Width = 180;

            // format the 3rd column
            dataGridView_PackageProductsSupplier.Columns[2].HeaderText = "Product Supplier ID";
            dataGridView_PackageProductsSupplier.Columns[2].Width = 80;

            // format the 4th column
            dataGridView_PackageProductsSupplier.Columns[3].HeaderText = "Product ID";
            dataGridView_PackageProductsSupplier.Columns[3].Width = 80;

            // format the 5th column
            dataGridView_PackageProductsSupplier.Columns[4].HeaderText = "Product Name";
            dataGridView_PackageProductsSupplier.Columns[4].Width = 140;

            // format the 6th column
            dataGridView_PackageProductsSupplier.Columns[5].HeaderText = "Supplier ID";
            dataGridView_PackageProductsSupplier.Columns[5].Width = 80;

            // format the 7th column
            dataGridView_PackageProductsSupplier.Columns[6].HeaderText = "Supplier Name";
            dataGridView_PackageProductsSupplier.Columns[6].Width = 220;
        }
        private void dataGridView_PackageProductsSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // store index values for Delete button columns
            const int DeleteIndex = 7;

            if (e.ColumnIndex == DeleteIndex)
            {

                int packageid = Convert.ToInt32(dataGridView_PackageProductsSupplier.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                int productSupplierId = Convert.ToInt32(dataGridView_PackageProductsSupplier.Rows[e.RowIndex].Cells[2].Value.ToString().Trim());
                //string packageid = dataGridView_Packages.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                selectedPckPrdSup = context.PackagesProductsSuppliers.Find(packageid, productSupplierId );
            }

            if (e.ColumnIndex == DeleteIndex)
            {
                DeletePckPrdSup();
            }

        }

        private void DeletePckPrdSup()
        {
            DialogResult result =
                MessageBox.Show($"Delete the Package ID {selectedPckPrdSup.PackageId} and Product Supplier ID {selectedPckPrdSup.ProductSupplierId}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    context.PackagesProductsSuppliers.Remove(selectedPckPrdSup);
                    context.SaveChanges(true);
                    DisplayPckPrdSup();
                }

                catch (DbUpdateException ex)
                {
                    HandleDataError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }
        private void HandleDataError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE: " + error.Number + " " +
                error.Message + "\n";
            }
            MessageBox.Show(errorMessage);
        }

        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            Close();
        }

        private void button_PckPrdSupAdd_Click(object sender, EventArgs e)
        {
            var addPckPrdSupForm = new AddPackageProductSupplierForm()
            {
                AddPckPrdSupp = true
            };
            DialogResult result = addPckPrdSupForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedPckPrdSup = addPckPrdSupForm.PackagesProductsSupplier;
                    context.PackagesProductsSuppliers.Add(selectedPckPrdSup);
                    context.SaveChanges();
                    DisplayPckPrdSup();
                }
                catch (DbUpdateException ex)
                {
                    HandleDataError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }

        }

    }

}
