using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] values = new string[,] {
                { "Susan Myers", "47899", "Accounting", "Vice President", },
                { "Mark Jones", "39119", "IT", "                   Programmer",},
                { "Joy Rogers", "81774 ", "Manufacturing", "Engineer",} };

            const int SIZE = 3;
            Employee[] items = new Employee[SIZE];

            employeeListBox.Items.Add("Name\t\tIdNumber\t\tDepartment\tPosition");

            for (int i = 0; i < SIZE; i++)
            {
                items[i] = new Employee(values[i, 0], int.Parse(values[i, 1]), values[i, 2], values[i,3]);

                employeeListBox.Items.Add(items[i].Name + "\t" + items[i].IDNumber + "\t\t" + items[i].Department + "\t" + items[i].Position);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
