using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Grocery
{
    public partial class Shopping : Form
    {
        private List<ProductInfo> infoKeeper = new List<ProductInfo>();

        public Shopping()
        {
            InitializeComponent();

        }

        private void Shopping_Load(object sender, EventArgs e)
        {
            btnAddToBasket.Enabled = false;
            btnCheckout.Enabled = false;
            try
            {
                FileStream fs = new FileStream("products.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string line;
                int counter = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    counter++;
                    if (counter % 4 == 1) listBox1.Items.Add(line);
                }

                sr.Close();
                fs.Close();
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Your Product List is empty. \nPlease, first Add the Product!");;
            }

            //******Some Decorations******
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            ProductNameLabel.BackColor = System.Drawing.Color.Transparent;
            IDLabel.BackColor = System.Drawing.Color.Transparent;
            PriceLabel.BackColor = System.Drawing.Color.Transparent;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    string selected = listBox1.SelectedItem.ToString();
                    ProductNameLabel.Text = ProductNameLabel.Text + " " + selected;

                    FileStream fs = new FileStream("products.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);

                    string reader;
                    

                    while ((reader = sr.ReadLine()) != null)
                    {
                        KeepDataAfterTxt.lines.Add(reader);
                    }

                    sr.Close();
                    fs.Close();

                    int IDindex = KeepDataAfterTxt.lines.FindIndex(a => a.Contains(selected));
                    IDLabel.Text = IDLabel.Text + " " + KeepDataAfterTxt.lines[IDindex + 1];
                    PriceLabel.Text = PriceLabel.Text + " " + KeepDataAfterTxt.lines[IDindex + 2] +" zl "+ KeepDataAfterTxt.lines[IDindex + 3];
                    btnSelect.Enabled = false;
                    btnAddToBasket.Enabled = true;
                    btnCheckout.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please, select the product first!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {

            //We accessed to Price, ID, Unit by finding index of Product Name.
            //everything is related to Product Name.

            int quantity = Convert.ToInt32(quantityUpDown.Value);
            string selected = listBox1.SelectedItem.ToString();
            int IDindex = KeepDataAfterTxt.lines.FindIndex(a => a.Contains(selected));
            decimal price = Convert.ToDecimal(KeepDataAfterTxt.lines[IDindex + 2]);

            //IDindex is declared as an INT in order to get price position^

            //ProductInfo class is used to store new selected products to a List.

            ProductInfo p = new ProductInfo();
            p.NameProduct = selected;
            p.IDproduct = IDindex;
            p.PriceProduct = price;
            p.Quantity = quantity;
            infoKeeper.Add(p);

            if (p.Quantity != 0)
            {

                listBox2.Items.Add(p.Quantity + "x " + p.NameProduct);

                var sum = infoKeeper.Sum(a => (a.PriceProduct * a.Quantity));
                sumLabel.Text = "Sum: " + sum.ToString();


                ProductNameLabel.Text = "Product Name:";
                IDLabel.Text = "ID:";
                PriceLabel.Text = "Price:";
                btnSelect.Enabled = true;
                btnAddToBasket.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter the Quantity!");
            }
            
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if ((sumLabel.Text != "Sum: 0") && (listBox2.Items.Count != 0 ))
            {
                MessageBox.Show("Your " + sumLabel.Text + "\n" + "Thank you for Shopping!");
                listBox2.Items.Clear();
                sumLabel.Text = "Sum: 0";
                infoKeeper.Clear();
                btnCheckout.Enabled = false;
                //Need to clear a LIST, otherwise it will add the previous prices 
                // after checkout
            }
            else
            {
                MessageBox.Show("Your Basket is empty!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you Sure?!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }


        //*****Decorations Continue*****
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.PeachPuff;
        }
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Transparent;
        }


        private void btnSelect_MouseEnter(object sender, EventArgs e)
        {
            btnSelect.BackColor = Color.PeachPuff;
        }
        private void btnSelect_MouseLeave(object sender, EventArgs e)
        {
            btnSelect.BackColor = Color.Transparent;
        }


        private void btnAddToBasket_MouseEnter(object sender, EventArgs e)
        {
            btnAddToBasket.BackColor = Color.PeachPuff;
        }
        private void btnAddToBasket_MouseLeave(object sender, EventArgs e)
        {
            btnAddToBasket.BackColor = Color.Transparent;
        }


        private void btnCheckout_MouseEnter(object sender, EventArgs e)
        {
            btnCheckout.BackColor = Color.PeachPuff;
        }
        private void btnCheckout_MouseLeave(object sender, EventArgs e)
        {
            btnCheckout.BackColor = Color.Transparent;
        }


        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.PeachPuff;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Transparent;
        }
    }
}
