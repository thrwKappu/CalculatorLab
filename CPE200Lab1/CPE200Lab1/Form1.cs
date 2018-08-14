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
           
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = value.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            value += float.Parse(lblDisplay.Text);
        }

        void clickbut(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lblDisplay.Text == "0" )
            {
                lblDisplay.Text = "";
            }
                if (lblDisplay.Text.Length <8)
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
            else if (previousoper == "x")
            {
                value *= float.Parse(lblDisplay.Text);
            }
            else if (previousoper == "÷")
            {
                value /= float.Parse(lblDisplay.Text);
            }

            previousoper = btn.Text;
        }
    }
}
