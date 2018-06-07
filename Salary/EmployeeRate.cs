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
    public class EmployeeRate : Employee
    { //TODO: XML \ DONE
        /// <summary>
        /// Оклад
        /// </summary>
        private int _salary;
        //TODO: XML \ DONE
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
        //TODO: XML \ DONE
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
        /// //TODO: Лучше в свойство \ DONE
        public override int GetSalary
        {
            get
            {
                return _salary / _rate * WorkTime;
            }
            set { }
        }

        //TODO: XML \ DONE
        /// <summary>
        /// Иницализация ставки (норма работы в месяц) и оклада
        /// </summary>
        public EmployeeRate(int workTime, int salary, int rate)
            : base(workTime)
        {
            _salary = salary;
            _rate = rate;
        }

        public override string Type
        {
            get { return "По ставке и окладу"; }
        }
    }
}
