using System.Windows.Forms;
using Salary;

namespace ViewSalaryForWorker
{
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
            get => SalaryFactory.GetSalary(TypeSalary.Rate, WorkTime, Salary, Rate);
        }

        /// <summary>
        ///  Свойство время работы
        /// </summary>
        private uint WorkTime
        {
            get => uint.Parse(WorkTimeTextBox.Text);
            set => WorkTimeTextBox.Text = value.ToString();
        }

        /// <summary>
        ///  Свойство оклада
        /// </summary>
        private uint Salary
        {
            get => uint.Parse(SalaryTextBox.Text);
            set => SalaryTextBox.Text = value.ToString();
        }

        /// <summary>
        ///  Свойство ставки (нормы работы)
        /// </summary>
        private uint Rate
        {
            get => uint.Parse(RateTextBox.Text);
            set => RateTextBox.Text = value.ToString();
        }

        /// <summary>
        ///  Свойство контрола только для чтения
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                WorkTimeTextBox.ReadOnly = value;
                SalaryTextBox.ReadOnly = value;
                RateTextBox.ReadOnly = value;
            }
        }
    }
}
