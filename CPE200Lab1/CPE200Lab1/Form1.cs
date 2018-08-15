using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        float  value = 0, value2=0;
        string previousoper = "+";
        bool re = false;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text != "")
            lblDisplay.Text = lblDisplay.Text.Substring(0,lblDisplay.Text.Length - 1);
            if (lblDisplay.Text == "")
                lblDisplay.Text = "0";

        }   

        private void btnSign_Click(object sender, EventArgs e)
        {
             value = float.Parse(lblDisplay.Text);
            value *= -1;
            lblDisplay.Text = value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            previousoper = "+";
            value = 0;
            value2 = 0;
            re = false;
        }

        void clickbut(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((lblDisplay.Text == "0" || re)&& btn.Text != ".")
            {
                lblDisplay.Text = "";
            }
                if (lblDisplay.Text.Length <9)
            {
                lblDisplay.Text += btn.Text;
            }
            re = false;
        }
        void clickoper(object sender, EventArgs e)
        {
               Button btn = (Button)sender;
            if(!re)
            {
                value2 = float.Parse(lblDisplay.Text);
                if (previousoper == "+")
                {
                    value += value2;
                }
                else if (previousoper == "-")
                {
                    value -= value2;
                }
                else if (previousoper == "X")
                {
                    value *= value2;
                }
                else if (previousoper == "÷")
                {
                    value /= value2;
                }
                else if (previousoper == "%")
                {
                    value = (value / 100) * value2;
                }
            }
            
            if (btn.Text == "=")
            {
                if(!re)
                lblDisplay.Text = value.ToString();
            }
            else
            {
                lblDisplay.Text = value.ToString();
                previousoper = btn.Text;
            }
            re = true;

        }
    }
}
