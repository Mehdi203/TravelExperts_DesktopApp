
namespace TravelExpert_ThreadedProject3
{
    partial class AddPackageProductSupplierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPackageProductSupplierForm));
            this.labelPckID = new System.Windows.Forms.Label();
            this.comboBoxPackage = new System.Windows.Forms.ComboBox();
            this.comboBoxProductSupplier = new System.Windows.Forms.ComboBox();
            this.labelPrdSup = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Accept = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPckID
            // 
            this.labelPckID.AutoSize = true;
            this.labelPckID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPckID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelPckID.Location = new System.Drawing.Point(43, 56);
            this.labelPckID.Name = "labelPckID";
            this.labelPckID.Size = new System.Drawing.Size(66, 21);
            this.labelPckID.TabIndex = 0;
            this.labelPckID.Text = "Package";
            // 
            // comboBoxPackage
            // 
            this.comboBoxPackage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxPackage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBoxPackage.FormattingEnabled = true;
            this.comboBoxPackage.Location = new System.Drawing.Point(204, 124);
            this.comboBoxPackage.Name = "comboBoxPackage";
            this.comboBoxPackage.Size = new System.Drawing.Size(286, 29);
            this.comboBoxPackage.TabIndex = 1;
            this.comboBoxPackage.Tag = "Package ID";
            // 
            // comboBoxProductSupplier
            // 
            this.comboBoxProductSupplier.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxProductSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxProductSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBoxProductSupplier.FormattingEnabled = true;
            this.comboBoxProductSupplier.Location = new System.Drawing.Point(204, 206);
            this.comboBoxProductSupplier.Name = "comboBoxProductSupplier";
            this.comboBoxProductSupplier.Size = new System.Drawing.Size(647, 29);
            this.comboBoxProductSupplier.Sorted = true;
            this.comboBoxProductSupplier.TabIndex = 3;
            this.comboBoxProductSupplier.Tag = "Product Supplier ID";
            // 
            // labelPrdSup
            // 
            this.labelPrdSup.AutoSize = true;
            this.labelPrdSup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrdSup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelPrdSup.Location = new System.Drawing.Point(43, 137);
            this.labelPrdSup.Name = "labelPrdSup";
            this.labelPrdSup.Size = new System.Drawing.Size(126, 21);
            this.labelPrdSup.TabIndex = 2;
            this.labelPrdSup.Text = "Product Supplier";
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Cancel.Location = new System.Drawing.Point(537, 295);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(108, 39);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Accept
            // 
            this.button_Accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Accept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Accept.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Accept.Location = new System.Drawing.Point(228, 295);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(121, 39);
            this.button_Accept.TabIndex = 8;
            this.button_Accept.Text = "Accept";
            this.button_Accept.UseVisualStyleBackColor = false;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(885, 71);
            this.panel4.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TravelExpert_ThreadedProject3.Properties.Resources.TravelExperts10;
            this.pictureBox1.Location = new System.Drawing.Point(204, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 44);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(314, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Travel Experts";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.labelPckID);
            this.panel1.Controls.Add(this.labelPrdSup);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 288);
            this.panel1.TabIndex = 25;
            // 
            // AddPackageProductSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 358);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Accept);
            this.Controls.Add(this.comboBoxProductSupplier);
            this.Controls.Add(this.comboBoxPackage);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPackageProductSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddPackageProductSupplierForm";
            this.Load += new System.EventHandler(this.AddPackageProductsSupplierForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPckID;
        private System.Windows.Forms.ComboBox comboBoxPackage;
        private System.Windows.Forms.ComboBox comboBoxProductSupplier;
        private System.Windows.Forms.Label labelPrdSup;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}