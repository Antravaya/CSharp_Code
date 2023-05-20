using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace worldSeriesChampions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> teamsList = new List<string>();
        List<int> yearList = new List<int>();
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            string countryName;
            StreamReader inputFile;
            StreamReader anotherInputFile;
            inputFile = File.OpenText("Teams.txt");
            anotherInputFile = File.OpenText("WorldSeriesWinners.txt");
            
            while (!inputFile.EndOfStream)
            {
                countryName = inputFile.ReadLine();
                countriesListBox.Items.Add(countryName);
            }


            string temp;
            temp = anotherInputFile.ReadLine();
            
            while(temp != null)
            {
                teamsList.Add(temp);
                temp = anotherInputFile.ReadLine();
                i++;
            }
        }

        private void countriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string teamNames = countriesListBox.SelectedItem.ToString();
            int num = 0;

            foreach (string anotherInputFile in teamsList)
            {
                if (anotherInputFile == teamNames)
                {
                    num++;
                }
            }

            label3.Text = teamNames + " has won " + num + " times from " + " through ";
        }
    }
}