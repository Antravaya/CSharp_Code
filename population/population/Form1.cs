using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void softwareSales()
        {
            listBox1.Items.Add("Days" + "\t" + "Approximate Population");
            outputListBoxResult();
        }

        private void outputListBoxResult()
        {
            int days = 1;
            double starting_Number_Of_Organisms = double.Parse(textBox1.Text);
            decimal average_Daily_Increase = decimal.Parse(textBox2.Text) / 100;
            double number_Of_Days_To_Multiply = double.Parse(textBox3.Text);
            double approximate_Population = starting_Number_Of_Organisms;

            while (days != decimal.Parse(textBox3.Text))
            {
                listBox1.Items.Add(days + "\t" + approximate_Population);
                approximate_Population++;
                days++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            softwareSales();
        }
    }
}
