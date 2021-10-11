
namespace TravelExpert_ThreadedProject3
{
    partial class PackageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageForm));
            this.dataGridView_Packages = new System.Windows.Forms.DataGridView();
            this.button_PackAdd = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_AveragePackP = new System.Windows.Forms.TextBox();
            this.button_Summery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_AveComm = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Packages)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Packages
            // 
            this.dataGridView_Packages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Packages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Packages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Packages.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView_Packages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Packages.Location = new System.Drawing.Point(0, 111);
            this.dataGridView_Packages.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Packages.Name = "dataGridView_Packages";
            this.dataGridView_Packages.RowHeadersWidth = 51;
            this.dataGridView_Packages.RowTemplate.Height = 25;
            this.dataGridView_Packages.Size = new System.Drawing.Size(1166, 331);
            this.dataGridView_Packages.TabIndex = 0;
            this.dataGridView_Packages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Packages_CellContentClick);
            // 
            // button_PackAdd
            // 
            this.button_PackAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_PackAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PackAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_PackAdd.Location = new System.Drawing.Point(895, 58);
            this.button_PackAdd.Margin = new System.Windows.Forms.Padding(4);
            this.button_PackAdd.Name = "button_PackAdd";
            this.button_PackAdd.Size = new System.Drawing.Size(204, 47);
            this.button_PackAdd.TabIndex = 1;
            this.button_PackAdd.Text = "Add Travel Package";
            this.button_PackAdd.UseVisualStyleBackColor = false;
            this.button_PackAdd.Click += new System.EventHandler(this.button_PackAdd_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_back.Location = new System.Drawing.Point(895, 203);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(204, 47);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "Back to Main Form";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(94, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Average Package Price:";
            // 
            // textBox_AveragePackP
            // 
            this.textBox_AveragePackP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_AveragePackP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_AveragePackP.Location = new System.Drawing.Point(351, 61);
            this.textBox_AveragePackP.Name = "textBox_AveragePackP";
            this.textBox_AveragePackP.ReadOnly = true;
            this.textBox_AveragePackP.Size = new System.Drawing.Size(117, 34);
            this.textBox_AveragePackP.TabIndex = 6;
            this.textBox_AveragePackP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_Summery
            // 
            this.button_Summery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Summery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Summery.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Summery.Location = new System.Drawing.Point(593, 58);
            this.button_Summery.Name = "button_Summery";
            this.button_Summery.Size = new System.Drawing.Size(204, 47);
            this.button_Summery.TabIndex = 7;
            this.button_Summery.Text = "Get Summary";
            this.button_Summery.UseVisualStyleBackColor = false;
            this.button_Summery.Click += new System.EventHandler(this.button_Summery_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(35, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Average Agency Commission:";
            // 
            // textBox_AveComm
            // 
            this.textBox_AveComm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_AveComm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_AveComm.Location = new System.Drawing.Point(351, 171);
            this.textBox_AveComm.Name = "textBox_AveComm";
            this.textBox_AveComm.ReadOnly = true;
            this.textBox_AveComm.Size = new System.Drawing.Size(117, 34);
            this.textBox_AveComm.TabIndex = 9;
            this.textBox_AveComm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1166, 113);
            this.panel4.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(434, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 58);
            this.label7.TabIndex = 0;
            this.label7.Text = "Travel Experts";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_back);
            this.panel2.Controls.Add(this.textBox_AveComm);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_AveragePackP);
            this.panel2.Controls.Add(this.button_Summery);
            this.panel2.Controls.Add(this.button_PackAdd);
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1268, 279);
            this.panel2.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TravelExpert_ThreadedProject3.Properties.Resources.TravelExperts10;
            this.pictureBox1.Location = new System.Drawing.Point(298, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 59);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 718);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView_Packages);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PackageForm";
            this.Text = "PackageForm";
            this.Load += new System.EventHandler(this.PackageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Packages)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Packages;
        private System.Windows.Forms.Button button_PackAdd;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_AveragePackP;
        private System.Windows.Forms.Button button_Summery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_AveComm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}