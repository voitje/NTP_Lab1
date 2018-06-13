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

        private void SelectSalary_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }

        private void InputConfirmation_Click(object sender, EventArgs e)
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            EmployeeBase = null;
            this.Close();
        }

        public EmployeeBase EmployeeBase { get; private set; }

        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Оплата в час")
            {
                try
                {
                    EmployeeHourly employeeHourly =
                        new EmployeeHourly(Convert.ToUInt32(textBox1.Text),
                            Convert.ToUInt32(textBox2.Text));
                    EmployeeBase = employeeHourly;
                }

                catch (Exception)
                {
                    MessageBox.Show("Параметры должны быть больше 0 и время работы быть не больше 372, " +
                                    "а оплата в час не больше 1400", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    EmployeeRate employeeRate =
                        new EmployeeRate(Convert.ToUInt32(textBox1.Text),
                            Convert.ToUInt32(textBox2.Text),
                            Convert.ToUInt32(textBox3.Text));
                    EmployeeBase = employeeRate;
                }
                catch (Exception)
                {
                    MessageBox.Show("Параметры должны быть больше 0, время работы должно быть не больше 372, " +
                                    "оклад не больше 1000000 и норма работы не больше 372", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Hide();
        }
    }

}

