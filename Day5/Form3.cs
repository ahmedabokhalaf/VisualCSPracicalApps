using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5
{
    public partial class Form3 : Form
    {
        Rectangle rec;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                rec = new Rectangle(e.X, e.Y, 50, 50);
                Graphics gr = CreateGraphics();
                gr.FillRectangle(Brushes.White, rec);
            }
            else if (radioButton2.Checked)
            {
                rec = new Rectangle(e.X, e.Y, 10, 10);
                Graphics gr = CreateGraphics();
                gr.FillRectangle(Brushes.Black, rec);
            }
        }
    }
}
