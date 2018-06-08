using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    /// <summary>
    /// Зарплата по ставке
    /// </summary>
    public class EmployeeRate : EmployeeBase
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
                    throw new Exception("Некорректная норма часов");
                }
                _rate = value;
            }
        }
        /// <summary>
        /// Подсчет зарплаты по ставке
        /// </summary>
        public override int GetSalary
        {
            get
            {
                return _salary / _rate * WorkTime;
            }
            set { }
        }
        /// <summary>
        /// Тип зарплаты
        /// </summary>
        public override string Type
        {
            get { return "По ставке и окладу"; }
        }
    }
}
