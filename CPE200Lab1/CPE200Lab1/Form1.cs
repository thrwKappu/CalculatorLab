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
        float temp = 0, value = 0;
        string previousoper = "+";
        bool re = false;
        bool presi = false;
    
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
        }


        void clickbut(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((lblDisplay.Text == "0" || re)&& btn.Text != ".")
            {
                re = false;
                lblDisplay.Text = "";
            }
                if (lblDisplay.Text.Length <9)
            {
                lblDisplay.Text += btn.Text;
            }
        }
        void clickoper(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (previousoper == "+")
            {
                value+= float.Parse(lblDisplay.Text);
            }
            else if (previousoper == "-")
            {
                value -= float.Parse(lblDisplay.Text);
            }
            else if (previousoper == "X")
            {
                value *= float.Parse(lblDisplay.Text);
            }
            else if (previousoper == "÷")
            {
                value /= float.Parse(lblDisplay.Text);
            }
            else if (previousoper == "%")
            {
                if (value <= float.Parse(lblDisplay.Text))
                    value = (value / 100) * float.Parse(lblDisplay.Text);
                else value = (float.Parse(lblDisplay.Text) / 100) * value;
            }
            re = true;

            if (btn.Text == "=")
            {
                lblDisplay.Text = value.ToString();
                previousoper = "+";
                value = 0;

            }       
            else previousoper = btn.Text;
            
        }
    }
}
