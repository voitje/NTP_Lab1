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

        public EmployeeBase EmployeeBase
        {
            set
            {
                WorkTime = value.WorkTime;
                if (value is EmployeeHourly employeeHourly)
                {
                    CostPerHour = employeeHourly.CostPerHour;
                }
            }
            get => new EmployeeHourly(WorkTime, CostPerHour);
        }
        //TODO:Все ниже private \ DONE
        //TODO:ArgumentEX для все Ex в библиотеки \ DONE
        private uint WorkTime
        {
            get => uint.Parse(textBox1.Text);
            set => textBox1.Text = value.ToString();
        }

        private uint CostPerHour
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
