
namespace Grocery
{
    partial class Shopping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shopping));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.sumLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shopping Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Available Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(351, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shopping Basket";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.SeaShell;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(28, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(188, 140);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.SeaShell;
            this.listBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 17;
            this.listBox2.Location = new System.Drawing.Point(347, 121);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 140);
            this.listBox2.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(28, 270);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(187, 34);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            this.btnSelect.MouseEnter += new System.EventHandler(this.btnSelect_MouseEnter);
            this.btnSelect.MouseLeave += new System.EventHandler(this.btnSelect_MouseLeave);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(347, 304);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(188, 34);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            this.btnCheckout.MouseEnter += new System.EventHandler(this.btnCheckout_MouseEnter);
            this.btnCheckout.MouseLeave += new System.EventHandler(this.btnCheckout_MouseLeave);
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumLabel.Location = new System.Drawing.Point(352, 272);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(55, 19);
            this.sumLabel.TabIndex = 7;
            this.sumLabel.Text = "Sum: 0";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.ProductNameLabel.Location = new System.Drawing.Point(38, 320);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(106, 17);
            this.ProductNameLabel.TabIndex = 8;
            this.ProductNameLabel.Text = "Product Name:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.IDLabel.Location = new System.Drawing.Point(38, 351);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(30, 17);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "ID:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.PriceLabel.Location = new System.Drawing.Point(38, 381);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(47, 17);
            this.PriceLabel.TabIndex = 10;
            this.PriceLabel.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(38, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity:";
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Location = new System.Drawing.Point(113, 415);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(92, 20);
            this.quantityUpDown.TabIndex = 12;
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Location = new System.Drawing.Point(28, 453);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(187, 34);
            this.btnAddToBasket.TabIndex = 13;
            this.btnAddToBasket.Text = "Add To Basket";
            this.btnAddToBasket.UseVisualStyleBackColor = true;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            this.btnAddToBasket.MouseEnter += new System.EventHandler(this.btnAddToBasket_MouseEnter);
            this.btnAddToBasket.MouseLeave += new System.EventHandler(this.btnAddToBasket_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(347, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 34);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 34);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // Shopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grocery.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 499);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddToBasket);
            this.Controls.Add(this.quantityUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Shopping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping";
            this.Load += new System.EventHandler(this.Shopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.Button btnAddToBasket;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}