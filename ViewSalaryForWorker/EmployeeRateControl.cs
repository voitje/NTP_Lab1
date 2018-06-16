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
{//TODO: Везде ниже XML \ DONE
    /// <summary>
    ///  Контрол для зарплаты по окладу и ставке
    /// </summary>
    public partial class EmployeeRateControl : UserControl
    {
        /// <summary>
        ///  Конструктор контрола
        /// </summary>
        public EmployeeRateControl()
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
                if (value is EmployeeRate employeeRate)
                {
                    Salary = employeeRate.Salary;
                    Rate = employeeRate.Rate;
                }

            }
            //TODO: Падает на StackOverflowEx - потому что рекурсия. \ DONE
            get => new EmployeeRate(WorkTime, Salary, Rate);
        }

        //TODO: Нижё всё на Private set и XML \ DONE
        /// <summary>
        ///  Свойство время работы
        /// </summary>
        private uint WorkTime
        {
            get
            {
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
        ///  Свойство оклада
        /// </summary>
        private uint Salary
        {
            get
            {
                const int maxSalaryInMonth = 1000000;
                while (int.Parse(textBox2.Text) > maxSalaryInMonth || int.Parse(textBox2.Text) <= 0)
                {
                    throw new ArgumentException(
                        "\nПараметры должны быть больше 0," + "оклад не больше 1000000" +
                        "\n Введите корректное значение");
                }

                return uint.Parse(textBox2.Text);
            }
            set => textBox2.Text = value.ToString();
        }

        /// <summary>
        ///  Свойство ставки (нормы работы)
        /// </summary>
        private uint Rate
        {
            get
            {
                const int maxHourInMonth = 372;
                while (int.Parse(textBox3.Text) > maxHourInMonth || int.Parse(textBox3.Text) <= 0)
                {
                    throw new ArgumentException(
                        "\nПараметры должны быть больше 0, а норма работы не больше 372" +
                        "\n Введите корректное значение");
                }
                return uint.Parse(textBox3.Text);
            }
            set => textBox3.Text = value.ToString();
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
                textBox3.ReadOnly = value;
            }
        }
    }
}
