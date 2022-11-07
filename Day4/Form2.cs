using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int cnt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //string Name = textBox1.Text.ToString();

            //if (Name.Length < 5)
            //{
            //    label5.Text = "Name must be at least 5 characters";
            //}
            //else { label5.Text = " "; cnt++; }

            //string Email = textBox2.Text.ToString();
            //if (Email.Contains('@'))
            //{
            //    label6.Text = " ";
            //    cnt++;
            //}
            //else { label6.Text = "Email must contain @"; }

            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                label7.Text = " ";
                cnt++;
            }
            else
            {
                label7.Text = "Choose at least one hoppy";
            }
            if (cnt >= 3)
            {
                label8.Text = "Thank you, Your Registration is Valid";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 5)
            {
                label5.Text = " ";
                cnt++;
            }
            else
            {
                label5.Text = "Name must be at least 5 characters";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains('@'))
            {
                label6.Text = "";
                cnt++;
            }
            else { label6.Text = "Email must contain @"; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
