using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
   

    public partial class Form1 : Form
    {
        
       
        double total;
        double Result;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClcked = false;
        public Form1()
        { 
            InitializeComponent();
          
        }

        private void butnTwo_Click(object sender, EventArgs e)
        {
            label1.Text += btnTwo.Text;
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void butnFour_Click(object sender, EventArgs e)
        {
            label1.Text += btnFour.Text;

            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void butnSix_Click(object sender, EventArgs e)
        {
            label1.Text += btnSix.Text;

            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void butnPlus_Click(object sender, EventArgs e)
        {
            label1.Text += btnPlus.Text;

       
            total += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClcked = false;
            

        }

        private void butnMultiply_Click(object sender, EventArgs e)
        {
            label1.Text += btnMultiply.Text;
            total += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            multiplyButtonClcked = true;
            plusButtonClicked = false;
            minusButtonClicked = false;
           


        }

      

        private void butnMinus_Click(object sender, EventArgs e)
        {

            label1.Text +=btnMinus.Text;

            total += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            minusButtonClicked = true;
            plusButtonClicked = false;
            multiplyButtonClcked = false;
        }

        private void butnOne_Click(object sender, EventArgs e)
        {
            label1.Text += btnOne.Text;

            txtDisplay.Text += btnOne.Text;
           
            

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            label1.Text += btnThree.Text;

            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            label1.Text += btnFive.Text;

            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            label1.Text += btnSeven.Text;

            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            label1.Text += btnEight.Text;

            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            label1.Text += btnNine.Text;

            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            label1.Text += btnZero.Text;

            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (minusButtonClicked == true)
            {
                Result = total - double.Parse(txtDisplay.Text);

            }
            else if (plusButtonClicked == true)
            {
                Result = total + double.Parse(txtDisplay.Text);

            }
            else if (multiplyButtonClcked == true)
            {
                Result = total * double.Parse(txtDisplay.Text);
             }
            MessageBox.Show(Result.ToString());
            txtDisplay.Clear();
            label1.ResetText();
            total = 0;



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDisplay.Text))
            {

                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                if (label1.Text.Length == 0) {
                    MessageBox.Show("Textbox is cleared !");
                    total = 0;
                }

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
            
                 

            }


        }
        private void butnClear_Click(object sender, EventArgs e)
        {
            label1.ResetText();


            txtDisplay.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if (!Char.IsDigit(e.KeyChar))
            //    e.Handled = true;
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar);

        }
    }
}
