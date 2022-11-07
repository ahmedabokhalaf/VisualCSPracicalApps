using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        public Font Form1Txt { set { textBox1.Font = value; } }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                form2.Form2Txt = textBox1.Text;
                form2.btnClicked += Changes_Done;
                form2.FormClosed += Changes_Done;
                form2.Show();
            }
            catch
            {
                MessageBox.Show("Please Close and Reopen","Reopen",MessageBoxButtons.OK);
            }
        }

        private void Changes_Done(object sender, EventArgs e)
        {
            if (form2.TxtUnderline && form2.TxtBold && form2.TxtItalic)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
            }
            else if (form2.TxtUnderline && form2.TxtBold)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Underline | FontStyle.Bold);
            }
            else if (form2.TxtBold && form2.TxtItalic)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Bold | FontStyle.Italic);
            }
            else if (form2.TxtUnderline && form2.TxtItalic)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Underline | FontStyle.Italic);
            }
            else if (form2.TxtBold)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Bold);
            }
            else if (form2.TxtItalic)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Italic);
            }
            else if (form2.TxtUnderline)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Underline);
            }
            
            textBox1.ForeColor = form2.TxtColor;
            textBox1.Font = form2.Font_Changed;
        }
    }
}
