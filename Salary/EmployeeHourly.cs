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

        //TODO: XML \ DONE
        /// <summary>
        /// Оплата за час
        /// </summary>
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
        public override int GetSalary
        {
            get
            {
                const int hoursPerDay = 24;
                return WorkTime / hoursPerDay * CostPerHour;
            }
        }

        //TODO: XML \ DONE
        /// <summary>
        /// Иницализация оплаты в час
        /// </summary>
        public EmployeeHourly(int workTime, int costPerHour)
            : base(workTime)
        {
            CostPerHour = costPerHour;
        }
    }
}
