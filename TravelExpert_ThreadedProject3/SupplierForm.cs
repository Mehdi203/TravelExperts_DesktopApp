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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private TravelExpertsContext context = new TravelExpertsContext(); // Create a new object
        private Supplier selectedSupplier; //Create a single supplier from the supplier class

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            try
            {
                selectedSupplier = context.Suppliers.FirstOrDefault();
                Object[] sIds = context.Suppliers.Select(s => (Object)s.SupplierId.ToString() + "-" + (Object)s.SupName.ToString()).ToArray();
                comboBox_SupId.Items.AddRange(sIds);
                this.comboBox_SupId.SelectedIndex = 0;

                DisplaySupplier();
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

        private void DisplaySupplier()
        {

            comboBox_SupId.SelectedItem = selectedSupplier.SupplierId.ToString() + "_" + selectedSupplier.SupName.ToString();
            textBox_SupName.Text = selectedSupplier.SupName;



        }

        private void ClearControls()
        {
            textBox_SupName.Text = "";

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var addmodifysupplierform = new AddModifySupplierForm()
            {
                AddSupplier = true
            };

            DialogResult result = addmodifysupplierform.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    selectedSupplier = addmodifysupplierform.Supplier;
                    context.Suppliers.Add(selectedSupplier);
                    context.SaveChanges();
                    comboBox_SupId.Items.Add(selectedSupplier.SupplierId.ToString() + "-" + selectedSupplier.SupName);

                    this.comboBox_SupId.SelectedIndex = this.comboBox_SupId.Items.Count - 1;

                    this.DisplaySupplier();

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

        //Method to edit supplier
        private void ModifySupplier()
        {
            var addmodifysupplierform = new AddModifySupplierForm()
            {
                AddSupplier = false,
                Supplier = selectedSupplier
            };

            DialogResult result = addmodifysupplierform.ShowDialog();
            if (result == DialogResult.OK)
            {

                try
                {
                    selectedSupplier = addmodifysupplierform.Supplier;
                    context.SaveChanges();
                    this.comboBox_SupId.SelectedIndex = this.comboBox_SupId.Items.Count - 1;
                    DisplaySupplier();

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

        //Method to delete supplier

        private void DeleteSupplier()
        {
            DialogResult result =
                MessageBox.Show($"Delete the Supplier with Supplier ID of {selectedSupplier.SupplierId}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                try
                {
                    context.Suppliers.Remove(selectedSupplier);
                    comboBox_SupId.Items.Remove(selectedSupplier.SupplierId);
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


        private void button_Mod_Click(object sender, EventArgs e)
        {
            if (selectedSupplier != null)
                ModifySupplier();

        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (selectedSupplier != null)
                DeleteSupplier();

        }

        private void button_Back_Click(object sender, EventArgs e)
        {

            new MainForm().Show();
            Close();
        }


        private void comboBox_SupId_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(System.Text.RegularExpressions.Regex.Replace(comboBox_SupId.SelectedItem.ToString(), @"[^0-9]+", ""));
            selectedSupplier = context.Suppliers.Find(id);
            DisplaySupplier();


        }
        //Exception handler to show data error
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

        //Exception handler to show general error
        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }


    }
}
