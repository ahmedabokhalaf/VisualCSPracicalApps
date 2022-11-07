using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5
{
    public partial class Form2 : Form
    {
        List<Trainees> trainees;
        public Form2()
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
                new Trainees("Sayed", 01011110000, DateTime.Parse("3/3/1986")),
                new Trainees()
            };
            dataGridView1.DataSource = trainees;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                label4.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Value = (DateTime)row.Cells[3].Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{
            //    row.Cells[1].Value = textBox1.Text;
            //    row.Cells[2].Value = textBox2.Text;
            //    row.Cells[3].Value = dateTimePicker1.Value;
            //}
            for (int i = 0; i < trainees.Count; i++)
            {
                if (label4.Text.ToString() == trainees[i].ID.ToString())
                {
                    trainees[i].Name = textBox1.Text;
                    trainees[i].Phone = int.Parse(textBox2.Text);
                    
                    //CultureInfo cultureInfo = new CultureInfo("en-US");
                    //trainees[i].Birthdate = Convert.ToDateTime(dateTimePicker1.Value.ToString(), cultureInfo);
                    
                    //--------------------------------------

                    trainees[i].Birthdate = DateTime.Parse(dateTimePicker1.Value.ToString());

                    //--------------------------------------

                    //DateTime date;
                    //bool isSuccess=DateTime.TryParse(dateTimePicker1.Value.ToString(), out date);
                    //trainees[i].Birthdate = date;

                    //--------------------------------------

                    //trainees.Add(trainees[i]);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = trainees;
            //this.Close();
        }
    }
}
