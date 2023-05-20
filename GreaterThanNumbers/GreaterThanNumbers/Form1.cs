using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreaterThanNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }        
        
        private void outputAnswer_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void enterAnswer_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);

            if (num1 > num2)
            {
                outputAnswer.Text = num1 + " is greater than " + num2;
            }
            else
            {
                outputAnswer.Text = num1 + " is less than " + num2;
            }

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
