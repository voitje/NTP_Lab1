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
    public class EmployeeHourly : EmployeeBase
    {
        /// <summary>
        /// Оплата за час
        /// </summary>
        private int _costPerHour;

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
            set { }
        }
        /// <summary>
        /// Тип зарплаты
        /// </summary>
        public override string Type
        {
            get { return "Почасовая"; }
        }
    }
}
