using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salary;

namespace ViewSalaryForWorker
{
    public partial class AddObjectForm : Form
    {
        public AddObjectForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var salary = comboBox1.Text;
            if (salary == "По часам")
            {
                label2.Text = "Оплата в час";
                textBox3.Visible = false;
                label3.Visible = false;
            }
            else
            {
                textBox3.Visible = true;
                label3.Visible = true;
                label2.Text = "Оклад";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // SalaryForWorkerForm salaryForWorker = new SalaryForWorkerForm();
            //salaryForWorker.Show();
            this.Close();
        }

        public EmployeeBase EmployeeBase { get; private set; }
        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Оплата в час")
            {
                EmployeeHourly employeeHourly = new EmployeeHourly();
                employeeHourly.WorkTime = Convert.ToInt32(textBox1.Text);
                employeeHourly.CostPerHour = Convert.ToInt32(textBox1.Text);
                //EmployeeBase = new EmployeeHourly(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
                EmployeeBase = employeeHourly;

            }
            else
            {
                EmployeeRate employeeRate = new EmployeeRate();
                employeeRate.WorkTime = Convert.ToInt32(textBox1.Text);
                employeeRate.Salary = Convert.ToInt32(textBox2.Text);
                employeeRate.Rate = Convert.ToInt32(textBox3.Text);
                //EmployeeBase = new EmployeeRate(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            }
            //salaryForWorker.ShowDialog();
            //list.Add(employeeHourly);
            // dataGridView1.DataSource = null;
            //dataGridView1.DataSource = list;
            this.Hide();
        }
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //}
    }

}

