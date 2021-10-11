
namespace TravelExpert_ThreadedProject3
{
    partial class AddModifyProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModifyProductForm));
            this.label_ProdId = new System.Windows.Forms.Label();
            this.label_ProdName = new System.Windows.Forms.Label();
            this.textBox_ProdId = new System.Windows.Forms.TextBox();
            this.textBox_ProdName = new System.Windows.Forms.TextBox();
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ProdId
            // 
            this.label_ProdId.AutoSize = true;
            this.label_ProdId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ProdId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_ProdId.Location = new System.Drawing.Point(204, 194);
            this.label_ProdId.Name = "label_ProdId";
            this.label_ProdId.Size = new System.Drawing.Size(64, 21);
            this.label_ProdId.TabIndex = 0;
            this.label_ProdId.Text = "Product";
            this.label_ProdId.Visible = false;
            // 
            // label_ProdName
            // 
            this.label_ProdName.AutoSize = true;
            this.label_ProdName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_ProdName.Location = new System.Drawing.Point(113, 45);
            this.label_ProdName.Name = "label_ProdName";
            this.label_ProdName.Size = new System.Drawing.Size(110, 21);
            this.label_ProdName.TabIndex = 1;
            this.label_ProdName.Text = "Product Name";
            // 
            // textBox_ProdId
            // 
            this.textBox_ProdId.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_ProdId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_ProdId.Location = new System.Drawing.Point(193, 225);
            this.textBox_ProdId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ProdId.Name = "textBox_ProdId";
            this.textBox_ProdId.ReadOnly = true;
            this.textBox_ProdId.Size = new System.Drawing.Size(110, 23);
            this.textBox_ProdId.TabIndex = 2;
            this.textBox_ProdId.Visible = false;
            // 
            // textBox_ProdName
            // 
            this.textBox_ProdName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_ProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_ProdName.Location = new System.Drawing.Point(248, 45);
            this.textBox_ProdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ProdName.Name = "textBox_ProdName";
            this.textBox_ProdName.Size = new System.Drawing.Size(110, 23);
            this.textBox_ProdName.TabIndex = 3;
            this.textBox_ProdName.Tag = "Product Name";
            // 
            // button_Accept
            // 
            this.button_Accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Accept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Accept.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Accept.Location = new System.Drawing.Point(64, 119);
            this.button_Accept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(123, 38);
            this.button_Accept.TabIndex = 4;
            this.button_Accept.Text = "Accept";
            this.button_Accept.UseVisualStyleBackColor = false;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Cancel.Location = new System.Drawing.Point(312, 119);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(123, 38);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
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
            this.panel4.Size = new System.Drawing.Size(520, 71);
            this.panel4.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TravelExpert_ThreadedProject3.Properties.Resources.TravelExperts10;
            this.pictureBox1.Location = new System.Drawing.Point(25, 11);
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
            this.label7.Location = new System.Drawing.Point(140, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Travel Experts";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label_ProdId);
            this.panel1.Controls.Add(this.button_Cancel);
            this.panel1.Controls.Add(this.label_ProdName);
            this.panel1.Controls.Add(this.button_Accept);
            this.panel1.Controls.Add(this.textBox_ProdId);
            this.panel1.Controls.Add(this.textBox_ProdName);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 250);
            this.panel1.TabIndex = 25;
            // 
            // AddModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 265);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddModifyProductForm";
            this.Text = "Add/Modify Product";
            this.Load += new System.EventHandler(this.AddModifyProductForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_ProdId;
        private System.Windows.Forms.Label label_ProdName;
        private System.Windows.Forms.TextBox textBox_ProdId;
        private System.Windows.Forms.TextBox textBox_ProdName;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}