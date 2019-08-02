using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salary;
            double.TryParse(textBox1.Text, out salary);
            int level;
            int.TryParse(textBox2.Text, out level);
            double combo = 0;
            if(level == 1)
            {
                combo = salary * 0.1;
            }else if(level >=2 && level <= 4)
            {
                combo = salary * 0.09;

            }
            else if(level >= 5 && level <= 7)
            {
                combo = salary * 0.07;

            }
            else if(level >= 8 && level <=10)
            {
                combo = salary * 0.05;

            }
            textBox3.Text = (combo + salary).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
