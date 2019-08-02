using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question4
{
    public partial class Form1 : Form
    {
        int car, color, model;
        double carprice, modprice, colorprice;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = listBox1.SelectedIndex;
            if(model == 0)
            {
                modprice = 100;
            }else if(model == 1)
            {
                modprice = 150;
            }
            else if(model == 2)
            {
                modprice = 200;
            }
            else if(model == 3)
            {
                modprice = 250;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            car = comboBox1.SelectedIndex;
            if (car == 0)
            {
                carprice = 100;
            }
            else if (car == 1)
            {
                carprice = 150;
            }
            else if (car == 2)
            {
                carprice = 200;
            }
            else if (car == 3)
            {
                carprice = 250;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (modprice + colorprice + carprice).ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = comboBox2.SelectedIndex;
            if (color == 0)
            {
                colorprice = 100;
            }
            else if (color == 1)
            {
                colorprice = 150;
            }
            else if (color == 2)
            {
                colorprice = 200;
            }
            else if (color == 3)
            {
                colorprice = 250;
            }
        }
    }
}
