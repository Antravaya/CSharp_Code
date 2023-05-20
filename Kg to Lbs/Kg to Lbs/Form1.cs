using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kg_to_Lbs
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void Kg_to_Lbs()
        {
            int kg = Convert.ToInt32(textBox1.Text);

            double lbs = Convert.ToDouble(kg * 2.2);

            result.Text = "Your result is " + lbs;
        }

        public void Lbs_to_Kg()
        {
            int lbs = Convert.ToInt32(textBox2.Text);

            double kg = Convert.ToDouble(lbs / 2.2);

            result.Text = "Your result is " + Math.Round(kg, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kg_to_Lbs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lbs_to_Kg();
        }
    }
}
