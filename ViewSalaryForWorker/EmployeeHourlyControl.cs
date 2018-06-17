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
            get => new EmployeeHourly(WorkTime, CostPerHour);
        }

        /// <summary>
        ///  Свойство время работы
        /// </summary>
        private uint WorkTime
        {
            get
            {
                //TODO: Не должно дублироваться с заданием свойства в предметной области.
                const int maxHourInMonth = 372;
                while (int.Parse(textBox1.Text) > maxHourInMonth || int.Parse(textBox1.Text) <= 0)
                {
                    throw new ArgumentException(
                        "\nПараметры должны быть больше 0 и время работы быть не больше 372, " +
                        "\n Введите корректное значение");
                }
               return uint.Parse(textBox1.Text); 
            }
            set => textBox1.Text = value.ToString();
        }

        /// <summary>
        ///  Свойство оплаты в час
        /// </summary>
        private uint CostPerHour
        {
            get
            {
                //TODO: Не должно дублироваться с заданием свойства в предметной области.
                const int maxCostPerHour = 1400;
                while (int.Parse(textBox2.Text) > maxCostPerHour || int.Parse(textBox2.Text) <= 0)
                {
                    throw new ArgumentException(
                        "\nПараметры должны быть больше 0 " + "а оплата в час не больше 1400" +
                        "\n Введите корректное значение");
                }
                return uint.Parse(textBox2.Text);
            }
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
