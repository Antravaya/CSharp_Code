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
    class Employee
    {
        private string _name;
        private int _idNumber;
        private string _dePartment;
        private string _position;


        public Employee(string name, int idNumber, string dePartment, string position)
        {
            _name = name;
            _idNumber = idNumber;
            _dePartment = dePartment;
            _position = position;
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int IDNumber
        {
            get { return _idNumber; }
            set { _idNumber = value; }
        }

        public string Department
        {
            get { return _dePartment; }
            set { _dePartment = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
