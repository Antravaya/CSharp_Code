using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Property_Tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            property_Tax();
        }

        public void property_Tax()
        {
            double result;
            int propertyTax = int.Parse(textBox1.Text);
            result = propertyTax / 100 * 0.64;
            label2.Text = "Your Sales tax is " + result.ToString("c");
        }
    }
}
