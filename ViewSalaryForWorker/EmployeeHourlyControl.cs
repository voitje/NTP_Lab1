using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salary;

namespace ViewSalaryForWorker
{
    public partial class EmployeeHourlyControl : UserControl
    {
        public EmployeeHourlyControl()
        {
            InitializeComponent();
        }

        public EmployeeHourly Employee
        {
            set
            {
                if (value is EmployeeHourly employeeRate)
                {
                    textBox1.Text = employeeRate.WorkTime.ToString();
                    textBox2.Text = employeeRate.CostPerHour.ToString();
                }
            }
        }

        public uint WorkTime
        {
            get => uint.Parse(textBox1.Text);
            set => textBox1.Text = value.ToString();
        }

        public uint CostPerHour
        {
            get => uint.Parse(textBox2.Text);
            set => textBox2.Text = value.ToString();
        }

        public bool ReadOnly
        {
            set
            {
                textBox1.ReadOnly = value;
                textBox2.ReadOnly = value;
            }
        }
    }
}
