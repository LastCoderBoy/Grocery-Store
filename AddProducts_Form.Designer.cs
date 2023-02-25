
namespace Grocery
{
    partial class AddProducts_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducts_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.checkBoxID = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(210, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(89, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name:";
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Location = new System.Drawing.Point(294, 148);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(156, 20);
            this.txtBoxProductName.TabIndex = 2;
            this.txtBoxProductName.TextChanged += new System.EventHandler(this.txtBoxProductName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(211, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(294, 195);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(156, 20);
            this.txtBoxID.TabIndex = 4;
            this.txtBoxID.TextChanged += new System.EventHandler(this.txtBoxID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(148, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price(zl) :";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(294, 244);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(156, 20);
            this.txtBoxPrice.TabIndex = 8;
            this.txtBoxPrice.TextChanged += new System.EventHandler(this.txtBoxPrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(196, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Unit:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(153, 358);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(119, 33);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            this.btnAddProduct.MouseEnter += new System.EventHandler(this.btnAddProduct_MouseEnter);
            this.btnAddProduct.MouseLeave += new System.EventHandler(this.btnAddProduct_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(353, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 33);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
            "KG",
            "Liter",
            "Piece"});
            this.comboBoxUnit.Location = new System.Drawing.Point(295, 292);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(155, 21);
            this.comboBoxUnit.TabIndex = 13;
            this.comboBoxUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnit_SelectedIndexChanged);
            // 
            // checkBoxID
            // 
            this.checkBoxID.AutoSize = true;
            this.checkBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxID.Location = new System.Drawing.Point(478, 190);
            this.checkBoxID.Name = "checkBoxID";
            this.checkBoxID.Size = new System.Drawing.Size(146, 29);
            this.checkBoxID.TabIndex = 14;
            this.checkBoxID.Text = "Generate ID";
            this.checkBoxID.UseVisualStyleBackColor = true;
            this.checkBoxID.CheckedChanged += new System.EventHandler(this.checkBoxID_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 34);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // AddProducts_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grocery.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 448);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.checkBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddProducts_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProducts_Form";
            this.Load += new System.EventHandler(this.AddProducts_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.CheckBox checkBoxID;
        private System.Windows.Forms.Button btnBack;
    }
}