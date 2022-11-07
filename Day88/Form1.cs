using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Day8
{
    public partial class Form1 : Form
    {
        Company_SDEntities context = new Company_SDEntities();
        public Form1()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Dnum";
            var depts = context.Departments.ToList();
            comboBox1.DataSource = depts;
            //foreach (var item in depts)
            //{
            //    comboBox1.Items.Add(item);
            //}
            //dataGridView1.DataSource = employeeServices.GetAllEmployees((int)comboBox1.SelectedValue);
            var emps = context.Employees
                .Where(e => e.Dno == (int)comboBox1.SelectedValue)
                .Select(e => new { e.SSN, e.Fname, e.Lname, e.Salary, e.Bdate }).ToList();
            dataGridView1.DataSource = emps;
            //foreach (var item in emps)
            //{
            //    dataGridView1.Rows.Add(item);
            //}
            context.Database.Log = log => Debug.WriteLine(log);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var emps = context.Employees
                .Where(em => em.Dno == (int)comboBox1.SelectedValue)
                .Select(em => new { em.SSN, em.Fname, em.Lname, em.Salary, em.Bdate }).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = emps;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                label6.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int ssn = random.Next(1, 500500);
            int salary = int.Parse(textBox3.Text.ToString());
            DateTime bdate = DateTime.Parse(dateTimePicker1.Value.ToString());
            var emp = new Employee
            {
                SSN = ssn,
                Fname = textBox1.Text.ToString(),
                Lname = textBox2.Text.ToString(),
                Salary = salary,
                Bdate = bdate,
                Dno = (int)comboBox1.SelectedValue,
            };
            context.Employees.Add(emp);
            context.SaveChanges();
            var emps = context.Employees
                .Where(em => em.Dno == (int)comboBox1.SelectedValue)
                .Select(em => new { em.SSN, em.Fname, em.Lname, em.Salary, em.Bdate }).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = emps;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int salary = int.Parse(textBox3.Text.ToString());
            DateTime bdate = DateTime.Parse(dateTimePicker1.Value.ToString());
            var emp = context.Employees.FirstOrDefault(em => em.SSN.ToString() == label6.Text.ToString());
            emp.Fname = textBox1.Text.ToString();
            emp.Lname = textBox2.Text.ToString();
            emp.Salary = salary;
            emp.Bdate = bdate;
            context.SaveChanges();
            var emps = context.Employees
                .Where(em => em.Dno == (int)comboBox1.SelectedValue)
                .Select(em => new { em.SSN, em.Fname, em.Lname, em.Salary, em.Bdate }).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = emps;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var emp = context.Employees.FirstOrDefault(em => em.SSN.ToString() == label6.Text.ToString());
            context.Employees.Remove(emp);
            context.SaveChanges();
            var emps = context.Employees
                .Where(em => em.Dno == (int)comboBox1.SelectedValue)
                .Select(em => new { em.SSN, em.Fname, em.Lname, em.Salary, em.Bdate }).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = emps;
        }
    }
}
