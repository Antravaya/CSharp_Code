using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_CardIdentifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "This is a Joker card.";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "This is a Jack of Diamond.";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "This is a Ace of Hearts.";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "This is a Six of Clubs";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "This is a Two of Spades";
        }
    }
}
