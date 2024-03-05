using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Mass_Index
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void BMICalculation()
        {
            double weight = int.Parse(textBox1.Text);
            double height = int.Parse(textBox2.Text);

            double BMI = weight * 703 / Math.Pow(height, 2);

            if (BMI > 18.5 && BMI < 25)
            {
                label3.Text = "BMI: " + BMI.ToString("n") + "\n" + "Status: Optimal Weight";
            }
            else if (BMI < 18.5)
            {
                label3.Text = "BMI: " + BMI.ToString("n") + "\n" + "Status: Underweight";
            }
            if (BMI > 25)
            {
                label3.Text = "BMI: " + BMI.ToString("n") + "\n" + "Status: Overweight";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BMICalculation();
        }
    }
}
