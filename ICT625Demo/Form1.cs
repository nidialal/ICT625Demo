using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT625Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public string name(string fn, string ln)
        {
            return string.Concat(fn, ln);
        }

        public double mul()
        {
            double a = 3.00;
            double b = 6.3;

            double c = a * b;

            return c;
        }
        public int add(int a, int b)
        {
            return a + b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
