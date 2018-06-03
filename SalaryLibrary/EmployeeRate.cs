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
        private int _salary;
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
        public override int GetSalary()
        {
            int salary = _salary / _rate * WorkTime;
            return salary;
        }
        public EmployeeRate (string name, string surname, int workTime, int salary, int rate)
            : base(name, surname, workTime)
        {
            _salary = salary;
            _rate = rate;
        }
    }
}
