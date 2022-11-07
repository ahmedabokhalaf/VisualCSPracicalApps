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
    public partial class Form1 : Form
    {
        List<Trainees> trainees;
        List<Trainees> labTrainees;
        List<Trainees> Lab1;
        List<Trainees> Lab2;
        List<Trainees> Lab3;
        int id = 0;
        public Form1()
        {
            InitializeComponent();
            trainees = new List<Trainees>()
            {
                new Trainees("Ahmed", 01123476811, DateTime.Parse("11/6/1997")),
                new Trainees("Aly", 01200100011, DateTime.Parse("15/7/1997")),
                new Trainees("Mohamed", 01114567834, DateTime.Parse("18/9/1997")),
                new Trainees("Mahmoud", 01023232322, DateTime.Parse("22/1/1997")),
                new Trainees("Hasan", 01512121212, DateTime.Parse("3/6/2000")),
                new Trainees("Emad", 01022222222, DateTime.Parse("10/6/1988")),
                new Trainees("Amr", 01033330000, DateTime.Parse("3/3/1986")),
                new Trainees("Mostafa", 01000003333, DateTime.Parse("3/3/1986")),
                new Trainees("Sayed", 01011110000, DateTime.Parse("3/3/1986"))
            };
            checkedListBox1.Items.AddRange(trainees.ToArray());
            comboBox1.Items.AddRange(new string[] { "Lab1", "Lab2", "Lab3" });
            comboBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            labTrainees = new List<Trainees>();
            foreach (Trainees item in checkedListBox1.CheckedItems)
            {
                labTrainees.Add(item);
            }
            checkedListBox2.Items.AddRange(labTrainees.ToArray());
            
            RemoveCheckedItem(checkedListBox1);
            
            if (comboBox1.SelectedIndex == 0)
            {
                Lab1 = labTrainees;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Lab2 = labTrainees;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Lab3 = labTrainees;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labTrainees = new List<Trainees>();
            foreach(Trainees item in checkedListBox1.Items)
            {
                labTrainees.Add(item);
            }
            RemoveAllItems(checkedListBox1);
            checkedListBox2.Items.AddRange(labTrainees.ToArray());
            if (comboBox1.SelectedIndex == 0)
            {
                Lab1 = labTrainees;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Lab2 = labTrainees;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Lab3 = labTrainees;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trainees = new List<Trainees>();
            foreach (Trainees item in checkedListBox2.CheckedItems)
            {
                trainees.Add(item);
            }
            RemoveCheckedItem(checkedListBox2);
            checkedListBox1.Items.AddRange(trainees.ToArray());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            trainees = new List<Trainees>();
            foreach (Trainees item in checkedListBox2.Items)
            {
                trainees.Add(item);
            }
            RemoveAllItems(checkedListBox2);
            checkedListBox1.Items.AddRange(trainees.ToArray());
            if (comboBox1.SelectedIndex == 0)
            {
                trainees = labTrainees;
                Lab1 = null;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                trainees = labTrainees;
                Lab2 = null;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                trainees = labTrainees;
                Lab3 = null;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0 && Lab1!=null)
            {
                checkedListBox2.Items.AddRange(Lab1.ToArray());
            }
            else if (comboBox1.SelectedIndex == 1 && Lab2 != null)
            {
                checkedListBox2.Items.AddRange(Lab2.ToArray());
            }
            else if (comboBox1.SelectedIndex == 2 && Lab3 != null)
            {
                checkedListBox2.Items.AddRange(Lab3.ToArray());
            }
        }
        public void RemoveCheckedItem(CheckedListBox clb)
        {
            for (int i = clb.Items.Count - 1; i >= 0; i--)
            {
                if (clb.GetItemChecked(i))
                {
                    clb.Items.Remove(clb.Items[i]);
                }
            }
        }
        public void RemoveAllItems(CheckedListBox clb)
        {
            for (int i = clb.Items.Count - 1; i >= 0; i--)
            {
                clb.Items.Remove(clb.Items[i]);
            }
        }
    }
}
