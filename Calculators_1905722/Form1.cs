using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators_1905722
{
    public partial class Form1 : Form
    {
        float num1 = 0;
        float num2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
       
        string funtion = "";
        string input = "0";

        private void btnOne_Click(object sender, EventArgs e)
        {

            if (txtValue.Text != "0")
            {
                input += "1";
                txtValue.Text += "1";
            }
            else
            {
                input = "1";
                txtValue.Text = "1";
            }

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "0")
            {
                input += "2";
                txtValue.Text += "2";
            }
            else
            {
                txtValue.Text = "2";
                input = "2";
            }

        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "0")
            {
                input += "3";
                txtValue.Text += "3";

            }
            else
            {
                txtValue.Text = "3";
                input = "3";
            }
        }
        
        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "0")
            {
                input += "4";
                txtValue.Text += "4";

            }
            else
            {
                txtValue.Text = "4";
                input = "4";
            }
        }
        private void btnFive_Click(object sender, EventArgs e)
        {

            if (txtValue.Text != "0")
            {
                input += "5";
                txtValue.Text += "5";

            }
            else
            {
                txtValue.Text = "5";
                input = "5";
            }
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "0")
            {
                input += "6";
                txtValue.Text += "6";

            }
            else
            {
                txtValue.Text = "6";
                input = "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "0")
            {
                input += "7";
                txtValue.Text += "7";

            }
            else
            {
                txtValue.Text = "7";
                input = "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "0")
            {
                input += "8";
                txtValue.Text += "8";

            }
            else
            {
                txtValue.Text = "8";
                input = "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "0")
            {
                input += "9";
                txtValue.Text += "9";

            }
            else
            {
                txtValue.Text = "9";
                input = "9";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            funtion = "+";
            if (txtOperation.Text.Contains("+") && txtOperation.Text == "0")
            {
                txtOperation.Text = txtOperation.Text;
            }
            else
            {
                num1 = float.Parse(input);
                txtOperation.Text = txtValue.Text + funtion;
                txtValue.Text = "0";
                input = "0";
            }
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            funtion = "-";
            if (txtOperation.Text.Contains("-") && txtOperation.Text == "0")
            {
                txtOperation.Text = txtOperation.Text;

            }
            else
            {
                num1 = float.Parse(input);
                txtOperation.Text = txtValue.Text + funtion;
                txtValue.Text = "0";
                input = "0";
            }
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            funtion = "*";
            if (txtOperation.Text.Contains("*") && txtOperation.Text == "0")
            {
                txtOperation.Text = txtOperation.Text;

            }
            else
            {
                num1 = float.Parse(input);
                txtOperation.Text = txtValue.Text + funtion;
                txtValue.Text = "0";
                input = "0";
            }
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            funtion = "÷";
            if (txtOperation.Text.Contains("÷") && txtOperation.Text == "0")
            {
                txtOperation.Text = txtOperation.Text;

            }
            else
            {
                num1 = float.Parse(input);
                txtOperation.Text = txtValue.Text + funtion;
                txtValue.Text = "0";
                input = "0";
            }
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtOperation.Text += txtValue.Text + "=";
            num2 = float.Parse(input);

            if (funtion == "+")
            {
                //  txtHistory.Text = num1.ToString();
                this.txtValue.Text = (num1 + num2).ToString();
                num1 = float.Parse(txtValue.Text);
                
                input = num1.ToString();
                
                //  txtHistory.Text = num1.ToString();

            }
            else if (funtion == "-")
            {
                this.txtValue.Text = (num1 - num2).ToString();
                num1 = float.Parse(txtValue.Text);
                input = num1.ToString();
                //this.tetResult.Text = "";
            }
            else if (funtion == "*")
            {
                this.txtValue.Text = (num1 * num2).ToString();
                num1 = float.Parse(txtValue.Text);
                input = num1.ToString();
                //this.tetResult.Text = "";
            }
            else if (funtion == "÷")
            {

                if (num2 != 0)
                {
                    //  float result = num1/num2;
                    this.txtValue.Text = (num1 / num2).ToString();
                    num1 = float.Parse(txtValue.Text);
                    input = num1.ToString();
                }
                else
                {
                    txtValue.Text = "Can't divide by zero";
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
            txtOperation.Text = "";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            /*if (e.KeyChar == 46 && txtValue.Text.IndexOf('.') != -1)*/
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                return;
            }
        }
    }
    }

