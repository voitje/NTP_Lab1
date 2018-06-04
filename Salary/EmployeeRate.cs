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
    { //TODO: XML
        private int _salary;
 //TODO: XML
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
 //TODO: XML
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
        /// //TODO: Лучше в свойство
        public override int GetSalary()
        {
            //TODO: Можно совместить с return
            int salary = _salary / _rate * WorkTime;
            return salary;
        }
 //TODO: XML
        public EmployeeRate(int workTime, int salary, int rate)
            : base(workTime)
        {
            _salary = salary;
            _rate = rate;
        }
    }
}
