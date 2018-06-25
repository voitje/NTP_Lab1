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
            get => SalaryFactory.GetSalary(TypeSalary.Hourly, WorkTime, CostPerHour);
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
        ///  Свойство оплаты в час
        /// </summary>
        private uint CostPerHour
        {
            get => uint.Parse(CostPerHourTextBox.Text);
            set => CostPerHourTextBox.Text = value.ToString();
        }

        /// <summary>
        ///  Свойство контрола только для чтения
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                WorkTimeTextBox.ReadOnly = value;
                CostPerHourTextBox.ReadOnly = value;
            }
        }
    }
}
