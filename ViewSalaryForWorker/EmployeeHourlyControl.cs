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
    /// <summary>
    ///  Контрол для почасовой зарплаты
    /// </summary>
    public partial class EmployeeHourlyControl : UserControl
    {
        /// <summary>
        ///  Конструктор контрола
        /// </summary>
        public EmployeeHourlyControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Свойство для создания объекта EmployeeBase
        /// </summary>
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
            //get => new EmployeeHourly(WorkTime, CostPerHour);
            get => SalaryFactory.GetSalary(TypeSalary.Hourly, WorkTime, CostPerHour);
        }

        /// <summary>
        ///  Свойство время работы
        /// </summary>
        private uint WorkTime
        {
            //TODO: Не должно дублироваться с заданием свойства в предметной области. \ DONE (все переделал)
            get => uint.Parse(textBox1.Text);
            set => textBox1.Text = value.ToString();
        }

        /// <summary>
        ///  Свойство оплаты в час
        /// </summary>
        private uint CostPerHour
        {
            get => uint.Parse(textBox2.Text);
            set => textBox2.Text = value.ToString();
        }

        /// <summary>
        ///  Свойство контрола только для чтения
        /// </summary>
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
