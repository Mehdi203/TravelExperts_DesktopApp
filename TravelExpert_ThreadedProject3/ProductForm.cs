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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private TravelExpertsContext context = new TravelExpertsContext(); //Crate a new object
        private Product selectedProduct; //Create a new product from the product class

        private void ProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                selectedProduct = context.Products.First();
                Object[] productIds = context.Products.Select(p => (Object)p.ProductId.ToString() + "-" + (Object)p.ProdName.ToString()).ToArray();
                comboBox_ProdId.Items.AddRange(productIds);
                this.comboBox_ProdId.SelectedIndex = 0;
                DisplayProduct();
            }

            catch (SqlException sqlException)
            {
                string errorMessage = "";
                foreach (SqlError error in sqlException.Errors)
                {
                    errorMessage += "ERROR CODE:  " + error.Number +
                                    " " + error.Message + "\n";
                }
                MessageBox.Show(errorMessage);
            }
            catch (Exception ex)
            {
                string errorMessage = "DB error: " + ex.Message + "\n";
                MessageBox.Show(errorMessage);
            }

        }

        private void DisplayProduct()
        {

            comboBox_ProdId.SelectedItem = selectedProduct.ProductId.ToString() + "_" + selectedProduct.ProdName.ToString();
            textBox_ProdName.Text = selectedProduct.ProdName;


        }

        private void ClearControls()
        {
            textBox_ProdName.Text = "";
        } 
        private void button_Add_Click(object sender, EventArgs e)
        {
            var addmodifyproductform = new AddModifyProductForm()
            {
                AddProduct = true
            };

            DialogResult result = addmodifyproductform.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProduct = addmodifyproductform.Product;
                    context.Products.Add(selectedProduct);
                    context.SaveChanges();
                    comboBox_ProdId.Items.Add(selectedProduct.ProductId.ToString() + "-" + selectedProduct.ProdName);

                    this.comboBox_ProdId.SelectedIndex = this.comboBox_ProdId.Items.Count - 1;

                    this.DisplayProduct();
                }

                catch (DbUpdateException ex)
                {
                    this.HandleDataError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }

        }

        private void HandleGeneralError(Exception ex)
        {
            throw new NotImplementedException();
        }

        private void HandleDataError(DbUpdateException ex)
        {
            throw new NotImplementedException();
        }

        private void comboBox_ProdId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(System.Text.RegularExpressions.Regex.Replace(comboBox_ProdId.SelectedItem.ToString(), @"[^0-9]+", ""));
            selectedProduct = context.Products.Find(id);
            DisplayProduct();
        }

        //method to edit product
        private void ModifyProduct()
        {
            var addmodifyproductform = new AddModifyProductForm()
            {
                AddProduct = false,
                Product = selectedProduct
            };
            
            DialogResult result = addmodifyproductform.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProduct = addmodifyproductform.Product;
                    context.SaveChanges();
                    DisplayProduct();
                }

                catch (DbUpdateException ex)
                {
                    this.HandleDataError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }

            }
        }

        //method to delete product
        private void DeleteProduct()
        {
            DialogResult result =
                MessageBox.Show($"Delete the Product with Product ID of {selectedProduct.ProductId}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    context.Products.Remove(selectedProduct);
                    comboBox_ProdId.Items.Remove(selectedProduct.ProductId);
                    context.SaveChanges(true);
                    this.ClearControls();
                }

                catch (DbUpdateException ex)
                {
                    this.HandleDataError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }

            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
                ModifyProduct();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
                DeleteProduct();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            Close();
        }
    }
}
