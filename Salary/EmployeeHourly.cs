using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    /// <summary>
    /// Зарплата по часам
    /// </summary>
    public class EmployeeHourly : Employee
    {
        /// <summary>
        /// Оплата за час
        /// </summary>
        private int _costPerHour;
        public int CostPerHour
        {
            get
            {
                return _costPerHour;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Некорректная оплата за час");
                }
                _costPerHour = value;
            }
        }
        /// <summary>
        /// Подсчет зарплаты
        /// </summary>
        public override int GetSalary()
        {
            const int hoursPerDay = 24;
            int salary = WorkTime / hoursPerDay * CostPerHour;
            return salary;
        }
        public EmployeeHourly(int workTime, int costPerHour)
            : base(workTime)
        {
            CostPerHour = costPerHour;
        }
    }
}
