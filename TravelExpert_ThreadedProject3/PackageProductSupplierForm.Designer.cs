
namespace TravelExpert_ThreadedProject3
{
    partial class PackageProductSupplierForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageProductSupplierForm));
            this.dataGridView_PackageProductsSupplier = new System.Windows.Forms.DataGridView();
            this.button_PckPrdSupAdd = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PackageProductsSupplier)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_PackageProductsSupplier
            // 
            this.dataGridView_PackageProductsSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_PackageProductsSupplier.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_PackageProductsSupplier.Location = new System.Drawing.Point(0, 112);
            this.dataGridView_PackageProductsSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_PackageProductsSupplier.Name = "dataGridView_PackageProductsSupplier";
            this.dataGridView_PackageProductsSupplier.RowHeadersWidth = 51;
            this.dataGridView_PackageProductsSupplier.RowTemplate.Height = 25;
            this.dataGridView_PackageProductsSupplier.Size = new System.Drawing.Size(1169, 359);
            this.dataGridView_PackageProductsSupplier.TabIndex = 0;
            this.dataGridView_PackageProductsSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PackageProductsSupplier_CellContentClick);
            // 
            // button_PckPrdSupAdd
            // 
            this.button_PckPrdSupAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_PckPrdSupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PckPrdSupAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_PckPrdSupAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_PckPrdSupAdd.Location = new System.Drawing.Point(175, 49);
            this.button_PckPrdSupAdd.Margin = new System.Windows.Forms.Padding(5);
            this.button_PckPrdSupAdd.Name = "button_PckPrdSupAdd";
            this.button_PckPrdSupAdd.Size = new System.Drawing.Size(364, 83);
            this.button_PckPrdSupAdd.TabIndex = 2;
            this.button_PckPrdSupAdd.Text = "Add Package Product Supplier";
            this.button_PckPrdSupAdd.UseVisualStyleBackColor = false;
            this.button_PckPrdSupAdd.Click += new System.EventHandler(this.button_PckPrdSupAdd_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_back.Location = new System.Drawing.Point(619, 49);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(364, 83);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Back to Main Form";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1168, 113);
            this.panel4.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(416, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 58);
            this.label7.TabIndex = 0;
            this.label7.Text = "Travel Experts";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.button_PckPrdSupAdd);
            this.panel2.Controls.Add(this.button_back);
            this.panel2.Location = new System.Drawing.Point(0, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 188);
            this.panel2.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TravelExpert_ThreadedProject3.Properties.Resources.TravelExperts10;
            this.pictureBox1.Location = new System.Drawing.Point(285, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 59);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PackageProductSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 651);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView_PackageProductsSupplier);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PackageProductSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PackageProductSupplierForm";
            this.Load += new System.EventHandler(this.PackageProductsSupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PackageProductsSupplier)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_PackageProductsSupplier;
        private System.Windows.Forms.Button button_PckPrdSupAdd;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}