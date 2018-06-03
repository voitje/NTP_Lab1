using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    public abstract class Employee
    {
        /// <summary>
        /// Время работы
        /// </summary>
        private int _workTime;
        public int WorkTime
        {
            get
            {
                return _workTime;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Некорректное время работы");
                }
                _workTime = value;
            }
        }
        public abstract int GetSalary();
        public Employee(int workTime)
        {
            WorkTime = workTime;
        }
    }
}
