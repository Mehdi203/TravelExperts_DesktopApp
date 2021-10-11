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
    public partial class Products_SuppliersForm : Form
    {

        //GL
        public Products_SuppliersForm()
        {
            InitializeComponent();
        }

        private TravelExpertsContext context = new TravelExpertsContext(); //DB context
        //Hold selected Products_Suppliers information
        private ProductsSupplier selectedProducts_Suppliers;

        private void Products_Suppliers_Load(object sender, EventArgs e)
        {
            DisplayProducts_Suppliers();
        }

        //Method to display all packages
        public void DisplayProducts_Suppliers()
        {
            dataGridView_Products_Suppliers.Columns.Clear();
            var productssuppliers = context.ProductsSuppliers
                 .Join(context.Products,
                ps1 => ps1.ProductId,
                pr => pr.ProductId,
                (ps1, pr) => new { ProductsSupplier = ps1, Product = pr })
                .Join(context.Suppliers,
                ps1 => ps1.ProductsSupplier.SupplierId,
                s => s.SupplierId,
                (ps1, s) => new { ProductsSupplier = ps1, Supplier = s })
                .Select(p2 => new {
                    p2.ProductsSupplier.ProductsSupplier.ProductSupplierId,
                    p2.ProductsSupplier.Product.ProductId,
                    p2.ProductsSupplier.Product.ProdName,
                    p2.ProductsSupplier.ProductsSupplier.SupplierId,
                    p2.Supplier.SupName
                })
                .OrderBy(ps1 => ps1.ProductSupplierId)
                .ToList();
                            
            dataGridView_Products_Suppliers.DataSource = productssuppliers;

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Edit"
            };
            dataGridView_Products_Suppliers.Columns.Add(modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dataGridView_Products_Suppliers.Columns.Add(deleteColumn);

            // format the column header
            dataGridView_Products_Suppliers.EnableHeadersVisualStyles = false;
            dataGridView_Products_Suppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView_Products_Suppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrchid;
            dataGridView_Products_Suppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dataGridView_Products_Suppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;

            // format the first column
            dataGridView_Products_Suppliers.Columns[0].HeaderText = "Product Supplier Id";
            dataGridView_Products_Suppliers.Columns[0].Width = 200;

            // format the 2nd column
            dataGridView_Products_Suppliers.Columns[1].HeaderText = "Product Id";
            dataGridView_Products_Suppliers.Columns[1].Width = 100;

            // format the 3rd column

            dataGridView_Products_Suppliers.Columns[2].HeaderText = "Product Name";
            dataGridView_Products_Suppliers.Columns[2].Width = 170;

            // format the 4th column

            dataGridView_Products_Suppliers.Columns[3].HeaderText = "Supplier Id";
            dataGridView_Products_Suppliers.Columns[3].Width = 130;

            // format the 5th column

            dataGridView_Products_Suppliers.Columns[4].HeaderText = "Supplier Name";
            dataGridView_Products_Suppliers.Columns[4].Width = 240;

            // format the 6th column

            dataGridView_Products_Suppliers.Columns[5].HeaderText = "Edit";
            dataGridView_Products_Suppliers.Columns[5].Width = 70;

            // format the 7th column

            dataGridView_Products_Suppliers.Columns[6].HeaderText = "Delete";
            dataGridView_Products_Suppliers.Columns[6].Width = 80;
        }

        private void dataGridView_Products_Suppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // store index values for Delete button columns
            const int ModifyIndex = 5;
            const int DeleteIndex = 6;

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                int productssupplierid = Convert.ToInt32(dataGridView_Products_Suppliers.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selectedProducts_Suppliers = context.ProductsSuppliers.Find(productssupplierid);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyProducts_Suppliers();
            }

            if (e.ColumnIndex == DeleteIndex)
            {
                DeleteProducts_Suppliers();
            }
        }

        private void btnAddProducts_Suppliers_Click(object sender, EventArgs e)
        {
            var addProducts_SuppliersForm = new AddProducts_SuppliersForm();
            DialogResult result = addProducts_SuppliersForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProducts_Suppliers = addProducts_SuppliersForm.ProductsSupplier;
                    context.ProductsSuppliers.Add(selectedProducts_Suppliers);
                    context.SaveChanges();
                    DisplayProducts_Suppliers();
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

        private void ModifyProducts_Suppliers()
        {
            var ModProducts_Suppliers = new ModifyProducts_Suppliers()
            {
                //MMProductsSupplier = false,
                ProductsSupplier = selectedProducts_Suppliers
            };

            DialogResult result1 = ModProducts_Suppliers.ShowDialog();
            if (result1 == DialogResult.OK)
            {
                try
                {
                    selectedProducts_Suppliers = ModProducts_Suppliers.ProductsSupplier;
                    context.SaveChanges();
                    DisplayProducts_Suppliers();
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
            this.Close();
        }


        
         // Removing Products_Suppliers from the table
        private void DeleteProducts_Suppliers()
        {
            DialogResult result2 =
                MessageBox.Show($"Delete the Products_Suppliers with ProductSupplier ID of {selectedProducts_Suppliers.ProductSupplierId}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result2 == DialogResult.Yes)
            {
                try
                {
                    context.ProductsSuppliers.Remove(selectedProducts_Suppliers);
                    context.SaveChanges(true);
                    DisplayProducts_Suppliers();
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

        private void btnBacktoMain_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            Close();
        }

        //GL
    }
}
