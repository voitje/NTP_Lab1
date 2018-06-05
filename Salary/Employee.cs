using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{//TODO: Косяк c RSDN \ DONE (если я понял что abstract и public местами поменять)
 //TODO: XML \ DONE
    /// <summary>
    /// Зарплата
    /// </summary>
    abstract public class Employee
    {
        /// <summary>
        /// Время работы
        /// </summary>
        private int _workTime;

        //TODO: XML \ DONE
        /// <summary>
        /// Время работы
        /// </summary>
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
        //TODO: XML \ DONE
        /// <summary>
        /// Подсчет зарплаты
        /// </summary>
        //TODO: Дложно быть свойством \ DONE
        public abstract int GetSalary { get; }
        //TODO: XML \ DONE
        //TODO: Можно заменить модификатор доступа на protected \ DONE
        /// <summary>
        /// Иницализация рабочего времени
        /// </summary>
        protected Employee(int workTime)
        {
            WorkTime = workTime;
        }
    }
}
