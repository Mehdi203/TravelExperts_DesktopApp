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
    public partial class AddModifyProductForm : Form
    {
        public AddModifyProductForm()
        {
            InitializeComponent();
        }

        //to control add/modify action
        public Product Product { get; set; }
        public bool AddProduct { get; set; }

        private void AddModifyProductForm_Load(object sender, EventArgs e)
        {
            if (this.AddProduct)
            {
                this.Text = "Add Product";
                textBox_ProdId.ReadOnly = true;
            }

            else
            {
                this.Text = "Modify Product";
                textBox_ProdId.ReadOnly = true;
                DisplayProduct();
            }

        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(textBox_ProdName.Text, textBox_ProdName.Tag.ToString());


            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;

        }

        //to display product
        private void DisplayProduct()
        {
            textBox_ProdId.Text = Product.ProductId.ToString();
            textBox_ProdName.Text = Product.ProdName;
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (this.AddProduct)
                {
                    this.Product = new Product();
                }
                this.LoadProductData();
                this.DialogResult = DialogResult.OK;
            }

        }

        private void LoadProductData()
        {
            //Product.ProductId = Convert.ToInt32(textBox_ProdId.Text);
            Product.ProdName = textBox_ProdName.Text;
        }
    }
}
