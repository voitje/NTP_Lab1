using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{//TODO: Косяк c RSDN
 //TODO: XML
    public abstract class Employee
    {
        /// <summary>
        /// Время работы
        /// </summary>
        private int _workTime;

 //TODO: XML
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
 //TODO: XML
        //TODO: Дложно быть свойством
        public abstract int GetSalary();
 //TODO: XML
        //TODO: Можно заменить модификатор доступа на protected
        public Employee(int workTime)
        {
            WorkTime = workTime;
        }
    }
}
