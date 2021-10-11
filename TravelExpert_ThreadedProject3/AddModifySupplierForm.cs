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
    public partial class AddModifySupplierForm : Form
    {
        public AddModifySupplierForm()
        {
            InitializeComponent();
        }

        public Supplier Supplier { get; set; }
        public bool AddSupplier { get; set; } // to control add/modify action



        private void AddModifySupplierForm_Load(object sender, EventArgs e)
        {
            if (this.AddSupplier)
            {
                this.Text = "Add Supplier";
                textBox_SuppId.ReadOnly = true;
            }

            else
            {
                this.Text = "Modify Supplier";
                textBox_SuppId.ReadOnly = true;
                DisplaySupplier();

            }

        }



        //to display supplier
        private void DisplaySupplier()
        {
            textBox_SuppId.Text = Supplier.SupplierId.ToString();
            textBox_Name.Text = Supplier.SupName;

        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (this.AddSupplier)
                {
                    this.Supplier = new Supplier();
                }

                this.LoadSupplierData();
                this.DialogResult = DialogResult.OK;

            }
  

        }



        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(textBox_Name.Text, textBox_Name.Tag.ToString());


            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;

        }

        private void LoadSupplierData()
        {
            //Supplier.SupplierId = Convert.ToInt32(textBox_SuppId.Text);
            Supplier.SupName = textBox_Name.Text;
        }


    }
}
