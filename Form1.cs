using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProducts_Form AddPage = new AddProducts_Form();
            AddPage.ShowDialog();
            this.Close();  //If you don't Close the Form1,
                           //it will continuously work at the background 
                           //even after you close the Form2(AddPage)
        }

        private void btnShoppingMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shopping ShopPage = new Shopping();
            ShopPage.ShowDialog();
            this.Close();
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

        //Some decorations Down Below
        //*   *   *   *   *   *   *   *
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Transparent;
        }
        private void btnAdd_MouseEnter_1(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.PeachPuff;
        }

        private void btnShoppingMenu_MouseEnter(object sender, EventArgs e)
        {
            btnShoppingMenu.BackColor = Color.PeachPuff;
        }
        private void btnShoppingMenu_MouseLeave(object sender, EventArgs e)
        {
            btnShoppingMenu.BackColor = Color.Transparent;
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
