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
                label2.Text = "Оклад (норма)";
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
            EmployeeBase = null;
            this.Close();
        }

        public EmployeeBase EmployeeBase { get; private set; }
        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Оплата в час")
            {
                EmployeeHourly employeeHourly = 
                    new EmployeeHourly(Convert.ToUInt32(textBox1.Text), 
                        Convert.ToUInt32(textBox2.Text));
                EmployeeBase = employeeHourly;

            }
            else
            {
                EmployeeRate employeeRate = 
                    new EmployeeRate(Convert.ToUInt32(textBox1.Text), 
                        Convert.ToUInt32(textBox2.Text),
                        Convert.ToUInt32(textBox3.Text));
                EmployeeBase = employeeRate;
            }
            this.Hide();
        }
    }

}

