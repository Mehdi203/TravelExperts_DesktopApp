
namespace TravelExpert_ThreadedProject3
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_SupId = new System.Windows.Forms.ComboBox();
            this.textBox_SupName = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Mod = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name";
            // 
            // comboBox_SupId
            // 
            this.comboBox_SupId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBox_SupId.FormattingEnabled = true;
            this.comboBox_SupId.Location = new System.Drawing.Point(244, 66);
            this.comboBox_SupId.Name = "comboBox_SupId";
            this.comboBox_SupId.Size = new System.Drawing.Size(191, 29);
            this.comboBox_SupId.TabIndex = 2;
            this.comboBox_SupId.SelectedIndexChanged += new System.EventHandler(this.comboBox_SupId_SelectedIndexChanged);
            // 
            // textBox_SupName
            // 
            this.textBox_SupName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_SupName.Location = new System.Drawing.Point(244, 147);
            this.textBox_SupName.Multiline = true;
            this.textBox_SupName.Name = "textBox_SupName";
            this.textBox_SupName.ReadOnly = true;
            this.textBox_SupName.Size = new System.Drawing.Size(191, 72);
            this.textBox_SupName.TabIndex = 3;
            this.textBox_SupName.Tag = "Name";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Add.Location = new System.Drawing.Point(616, 122);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(113, 40);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Add Supplier";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Mod
            // 
            this.button_Mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Mod.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Mod.Location = new System.Drawing.Point(616, 190);
            this.button_Mod.Name = "button_Mod";
            this.button_Mod.Size = new System.Drawing.Size(113, 40);
            this.button_Mod.TabIndex = 5;
            this.button_Mod.Text = "Edit Supplier";
            this.button_Mod.UseVisualStyleBackColor = false;
            this.button_Mod.Click += new System.EventHandler(this.button_Mod_Click);
            // 
            // button_Del
            // 
            this.button_Del.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Del.Location = new System.Drawing.Point(616, 259);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(113, 40);
            this.button_Del.TabIndex = 6;
            this.button_Del.Text = "Delete";
            this.button_Del.UseVisualStyleBackColor = false;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Back.Location = new System.Drawing.Point(329, 34);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(206, 40);
            this.button_Back.TabIndex = 7;
            this.button_Back.Text = "Back to Main Form";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(837, 87);
            this.panel4.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TravelExpert_ThreadedProject3.Properties.Resources.TravelExperts10;
            this.pictureBox1.Location = new System.Drawing.Point(169, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 59);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(289, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Travel Experts";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button_Back);
            this.panel1.Location = new System.Drawing.Point(0, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 111);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox_SupId);
            this.panel2.Controls.Add(this.textBox_SupName);
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 271);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Location = new System.Drawing.Point(488, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 265);
            this.panel3.TabIndex = 26;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 438);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Mod);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_SupId;
        private System.Windows.Forms.TextBox textBox_SupName;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Mod;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}