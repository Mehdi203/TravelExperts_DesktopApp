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
    public partial class PackageForm : Form
    {
        public PackageForm()
        {
            InitializeComponent();
        }

        private TravelExpertsContext context = new TravelExpertsContext(); //DB context
        private Package selectedPackage; //Hold selected package information
        

        private void PackageForm_Load(object sender, EventArgs e)
        {
            DisplayPackages();


        }

        //Method to display all packages
        public void DisplayPackages()
        {
            dataGridView_Packages.Columns.Clear();

            var packages = context.Packages
                           .OrderBy(p => p.PackageId)
                           .Select(p => new
                           {
                               p.PackageId,
                               p.PkgName,
                               p.PkgStartDate,
                               p.PkgEndDate,
                               p.PkgDesc,
                               p.PkgBasePrice,
                               p.PkgAgencyCommission
                           }).ToList();
            dataGridView_Packages.DataSource = packages;

            //if (selectedPackage is null) return;
            //textBox_Desc.Text = selectedPackage.PkgDesc;


            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Edit"
            };
            dataGridView_Packages.Columns.Add(modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dataGridView_Packages.Columns.Add(deleteColumn);

            // format the column header
            dataGridView_Packages.EnableHeadersVisualStyles = false;
            dataGridView_Packages.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView_Packages.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSalmon;
            dataGridView_Packages.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Packages.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the odd numbered rows
            dataGridView_Packages.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;

            // format the first column
            dataGridView_Packages.Columns[0].HeaderText = "Package ID";
            dataGridView_Packages.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Packages.Columns[0].Width = 60;

            // format the 2nd column
            dataGridView_Packages.Columns[1].HeaderText = "Package Name";
            dataGridView_Packages.Columns[1].Width = 140;

            // format the 3rd column
            dataGridView_Packages.Columns[2].HeaderText = "Start Date";
            dataGridView_Packages.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Packages.Columns[2].Width = 110;

            // format the 4th column
            dataGridView_Packages.Columns[4].HeaderText = "Description";
            dataGridView_Packages.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Packages.Columns[4].Width = 210;

            // format the 4th column
            dataGridView_Packages.Columns[3].HeaderText = "End Date";
            dataGridView_Packages.Columns[3].Width = 110;
            dataGridView_Packages.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the 5th column
            dataGridView_Packages.Columns[5].HeaderText = "Base Price";
            dataGridView_Packages.Columns[5].Width = 120;

            // format the 6th column
            dataGridView_Packages.Columns[6].HeaderText = "Agency Commission";
            dataGridView_Packages.Columns[6].Width = 120;

            // format the 7th column

            dataGridView_Packages.Columns[7].Width = 70;

            // format the 8th column

            dataGridView_Packages.Columns[8].Width = 70;


            //Display 2 digits
            dataGridView_Packages.Columns[5].DefaultCellStyle.Format = "c";
            dataGridView_Packages.Columns[6].DefaultCellStyle.Format = "c";

        }

        private void dataGridView_Packages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // store index values for Modify and Delete button columns
            const int ModifyIndex = 7;
            const int DeleteIndex = 8;

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {

                int packageid = Convert.ToInt32(dataGridView_Packages.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                //string packageid = dataGridView_Packages.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                selectedPackage = context.Packages.Find(packageid);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyPackage();
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeletePackage();
            }



        }

        private void ModifyPackage()
        {
            var addModifyPackageForm = new AddMoifyPackageForm()
            {
                AddPackage = false,
                Package = selectedPackage
            };
            DialogResult result = addModifyPackageForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedPackage = addModifyPackageForm.Package;
                    context.SaveChanges();
                    DisplayPackages();
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

        private void DeletePackage()
        {
            DialogResult result =
                MessageBox.Show($"Delete the Package with Package ID of {selectedPackage.PackageId}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    context.Packages.Remove(selectedPackage);
                    context.SaveChanges(true);
                    DisplayPackages();
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

        private void button_PackAdd_Click(object sender, EventArgs e)
        {
            var addModifyPackageForm = new AddMoifyPackageForm()
            {
                AddPackage = true
            };
            DialogResult result = addModifyPackageForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedPackage = addModifyPackageForm.Package;
                    context.Packages.Add(selectedPackage);
                    context.SaveChanges();
                    DisplayPackages();
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

        private void button_Summery_Click(object sender, EventArgs e)
        {
            //Calculate averages
            decimal sumprice = 0;
            decimal averageprice = 0;
            decimal sumcomm = 0;
            decimal averagecomm = 0;

            for (int i = 0; i <= dataGridView_Packages.Rows.Count-1; i++)
            {
                //Calculate average base price
                sumprice = sumprice + decimal.Parse(dataGridView_Packages.Rows[i].Cells[5].Value.ToString());
                averageprice = (sumprice / (dataGridView_Packages.Rows.Count));

                //Calculate average agency commission
                sumcomm = sumcomm + decimal.Parse(dataGridView_Packages.Rows[i].Cells[6].Value.ToString());
                averagecomm = (sumcomm / (dataGridView_Packages.Rows.Count));

            }
            textBox_AveragePackP.Text = averageprice.ToString("c");
            textBox_AveComm.Text = averagecomm.ToString("c");

           

        }
    }
}
