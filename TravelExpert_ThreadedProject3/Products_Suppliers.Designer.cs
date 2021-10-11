
namespace TravelExpert_ThreadedProject3
{
    partial class Products_SuppliersForm
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
            this.dataGridView_Products_Suppliers = new System.Windows.Forms.DataGridView();
            this.btnAddProducts_Suppliers = new System.Windows.Forms.Button();
            this.btnBacktoMain = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products_Suppliers)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Products_Suppliers
            // 
            this.dataGridView_Products_Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Products_Suppliers.Location = new System.Drawing.Point(0, 82);
            this.dataGridView_Products_Suppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Products_Suppliers.Name = "dataGridView_Products_Suppliers";
            this.dataGridView_Products_Suppliers.RowHeadersWidth = 51;
            this.dataGridView_Products_Suppliers.RowTemplate.Height = 29;
            this.dataGridView_Products_Suppliers.Size = new System.Drawing.Size(1080, 259);
            this.dataGridView_Products_Suppliers.TabIndex = 0;
            this.dataGridView_Products_Suppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Products_Suppliers_CellContentClick);
            // 
            // btnAddProducts_Suppliers
            // 
            this.btnAddProducts_Suppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddProducts_Suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducts_Suppliers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProducts_Suppliers.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddProducts_Suppliers.Location = new System.Drawing.Point(191, 37);
            this.btnAddProducts_Suppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProducts_Suppliers.Name = "btnAddProducts_Suppliers";
            this.btnAddProducts_Suppliers.Size = new System.Drawing.Size(279, 58);
            this.btnAddProducts_Suppliers.TabIndex = 1;
            this.btnAddProducts_Suppliers.Text = "Add Products_Suppliers";
            this.btnAddProducts_Suppliers.UseVisualStyleBackColor = false;
            this.btnAddProducts_Suppliers.Click += new System.EventHandler(this.btnAddProducts_Suppliers_Click);
            // 
            // btnBacktoMain
            // 
            this.btnBacktoMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBacktoMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBacktoMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBacktoMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBacktoMain.Location = new System.Drawing.Point(632, 37);
            this.btnBacktoMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBacktoMain.Name = "btnBacktoMain";
            this.btnBacktoMain.Size = new System.Drawing.Size(285, 58);
            this.btnBacktoMain.TabIndex = 1;
            this.btnBacktoMain.Text = "Back to Main Form";
            this.btnBacktoMain.UseVisualStyleBackColor = false;
            this.btnBacktoMain.Click += new System.EventHandler(this.btnBacktoMain_Click);
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
            this.panel4.Size = new System.Drawing.Size(1047, 85);
            this.panel4.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TravelExpert_ThreadedProject3.Properties.Resources.TravelExperts10;
            this.pictureBox1.Location = new System.Drawing.Point(366, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 44);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(464, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "Travel Experts";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnBacktoMain);
            this.panel1.Controls.Add(this.btnAddProducts_Suppliers);
            this.panel1.Location = new System.Drawing.Point(1, 342);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 131);
            this.panel1.TabIndex = 25;
            // 
            // Products_SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 469);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView_Products_Suppliers);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Products_SuppliersForm";
            this.Text = "Products_Suppliers";
            this.Load += new System.EventHandler(this.Products_Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products_Suppliers)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Products_Suppliers;
        private System.Windows.Forms.Button btnAddProducts_Suppliers;
        private System.Windows.Forms.Button btnBacktoMain;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}