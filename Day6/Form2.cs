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
    public partial class Form2 : Form
    {
        public event EventHandler btnClicked;
        public Form2()
        {
            InitializeComponent();
        }
        #region Properties that should executed on control in form1
        public string Form2Txt { get; set; }
        public bool TxtBold { get { return /*label3.*/Font.Bold; } }
        public bool TxtItalic { get { return /*label3.*/Font.Italic; } }
        public bool TxtUnderline { get { return /*label3.*/Font.Underline; } }
        public Color TxtColor { get { return label3.ForeColor; } }
        public Font Font_Changed 
        { 
            get 
            {
                return label3.Font; 
            } 
        }
        #endregion

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name.ToString());
            }
            label3.Text = Form2Txt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Font = new Font(comboBox1.Text, label3.Font.Size);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                label3.Font = new Font(comboBox1.Font.FontFamily, float.Parse(numericUpDown1.Value.ToString()));
            }
            catch
            {
                MessageBox.Show("Not Allowed to be Zero");
            }
        }

        //private void checkBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked)
        //    {
        //        label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Bold);
        //    }
        //    else
        //    {
        //        label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size);
        //    }

        //    if (checkBox2.Checked)
        //    {
        //        label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Italic);
        //    }
        //    else
        //    {
        //        label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size);
        //    }

        //    if (checkBox3.Checked)
        //    {
        //        label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Underline);
        //    }
        //    else
        //    {
        //        label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size);
        //    }
        //}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Bold);
            }
            else
            {
                label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Italic);
            }
            else
            {
                label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Underline);
            }
            else
            {
                label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = colorDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                label3.ForeColor = colorDialog1.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnClicked != null)
                btnClicked(this, new EventArgs());
        }
        
    }
}
