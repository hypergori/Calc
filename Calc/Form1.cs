using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String addNumber = "1";
            display.Text = display.Text + addNumber;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String addNumber = "+";
            display.Text = display.Text + addNumber;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Expression ex = new Expression(display.Text);
            try
            {
                display.Text = ex.Evaluate().ToString();

            }
            catch (Exception)
            {
                //ignore
            } }

        private void button13_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            display.Text = display.Text + btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
