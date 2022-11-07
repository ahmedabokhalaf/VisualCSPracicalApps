using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                textBox2.Text = (distance / 1000).ToString();
            }
            else if (radioButton2.Checked)
            {
                textBox2.Text = (distance / 1609.344).ToString();
            }
            else if(radioButton3.Checked)
            {
                textBox2.Text = (distance * 1609.344).ToString();
            }
        }
    }
}
