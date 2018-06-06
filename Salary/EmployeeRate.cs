using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    /// <summary>
    /// Зарплата по ставке
    /// </summary>
    public class EmployeeRate : Employee
    { 
        /// <summary>
        /// Оклад
        /// </summary>
        private int _salary;

        /// <summary>
        /// Оклад
        /// </summary>
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Некорректный оклад");
                }
                _salary = value;
            }
        }
        /// <summary>
        /// Ставка (норма работы в месяц)
        /// </summary>
        private int _rate;

        /// <summary>
        /// Ставка (норма работы в месяц)
        /// </summary>
        public int Rate
        {
            get
            {
                return _rate;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Некорректная ставка");
                }
                _rate = value;
            }
        }
        /// <summary>
        /// Подсчет зарплаты по ставке
        /// </summary>
        public override int GetSalary => _salary / _rate * WorkTime;

        /// <summary>
        /// Иницализация ставки (норма работы в месяц) и оклада
        /// </summary>
        public EmployeeRate(int workTime, int salary, int rate)
            : base(workTime)
        {
            _salary = salary;
            _rate = rate;
        }
    }
}
