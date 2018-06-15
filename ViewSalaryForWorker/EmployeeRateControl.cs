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
    public partial class EmployeeRateControl : UserControl
    {
        public EmployeeRateControl()
        {
            InitializeComponent();
        }

        public EmployeeBase EmployeeBase
        {
            set
            {
                if (value is EmployeeRate)
                {
                    //EmployeeRate employeeRate = new EmployeeRate(uint.Parse(textBox1.Text), uint.Parse(textBox2.Text), uint.Parse(textBox3.Text));
                    //EmployeeBase = employeeRate;
                    EmployeeRate employeeRate = new EmployeeRate(WorkTime, Salary, Rate);
                    EmployeeBase = employeeRate;
                }
            }
            get => EmployeeBase;
        }

        public uint WorkTime
        {
            get => uint.Parse(textBox1.Text);
            set => textBox1.Text = value.ToString();
        }

        public uint Salary
        {
            get => uint.Parse(textBox2.Text);
            set => textBox2.Text = value.ToString();
        }

        public uint Rate
        {
            get => uint.Parse(textBox3.Text);
            set => textBox3.Text = value.ToString();
        }

        public bool ReadOnly
        {
            set
            {
                textBox1.ReadOnly = value;
                textBox2.ReadOnly = value;
                textBox3.ReadOnly = value;
            }
        }
    }
}
