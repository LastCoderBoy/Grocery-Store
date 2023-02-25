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
    public partial class AddProducts_Form : Form
    {
        public AddProducts_Form()
        {
            InitializeComponent();
        }

        private void txtBoxProductName_TextChanged(object sender, EventArgs e)
        {
            Product pr = new Product();
            pr.productName = txtBoxProductName.Text;

            KeepValue.productName = pr.productName;
        }

        private void txtBoxID_TextChanged(object sender, EventArgs e)
        {
            Product pr = new Product();
            pr.productID = txtBoxID.Text;

            KeepValue.productID = pr.productID;
        }

        private void checkBoxID_CheckedChanged(object sender, EventArgs e)
        {
            Product pr = new Product();
            
            if (checkBoxID.Checked && pr.IDnum()=="Error")
            {
                MessageBox.Show("Please, enter Product Name first!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(checkBoxID.Checked)
            {
                txtBoxID.Text = pr.IDnum();
            }
            else
            {
                txtBoxID.Text = string.Empty;
            }
        }


        private void txtBoxPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Product pr = new Product();
                pr.price = Convert.ToDecimal(txtBoxPrice.Text);

                KeepValue.price = pr.price;
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the correct format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPrice.Clear();
            }   
        }

        private void comboBoxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product pr = new Product();
            pr.unit = comboBoxUnit.GetItemText(comboBoxUnit.SelectedItem);

            KeepValue.unit = pr.unit;


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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtBoxProductName.Text == string.Empty)
            {
                MessageBox.Show("Please, Enter the Product Name","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBoxID.Text == string.Empty)
            {
                MessageBox.Show("Please, Enter the ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBoxPrice.Text == string.Empty)
            {
                MessageBox.Show("Please, Enter the Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxUnit.GetItemText(comboBoxUnit.SelectedItem) == "")
            {
                MessageBox.Show("Please, Choose the Unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                FileStream fs = new FileStream("products.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(KeepValue.productName +"\n"+ KeepValue.productID +"\n"+ KeepValue.price +"\n"+ KeepValue.unit);
                sw.Close();
                fs.Close();
                MessageBox.Show("Product Added!");


                this.Hide();
                Shopping ShoppingForm = new Shopping();
                ShoppingForm.ShowDialog();
                this.Close();
            }
            
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainMenu = new Form1();
            mainMenu.ShowDialog();
            this.Close();
        }

        //Some decorations Down Below
        //*   *   *   *   *   *   *   *
        private void AddProducts_Form_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            checkBoxID.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.PeachPuff;
        }
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Transparent;
        }


        private void btnAddProduct_MouseLeave(object sender, EventArgs e)
        {
            btnAddProduct.BackColor = Color.Transparent;
        }
        private void btnAddProduct_MouseEnter(object sender, EventArgs e)
        {
            btnAddProduct.BackColor = Color.PeachPuff;
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
