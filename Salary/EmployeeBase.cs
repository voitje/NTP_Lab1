using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    //TODO: Правильнее бы в наследниках было зайдействовать конструктор на set параметров, а в самих полях сделать set 
    //TODO: приватным
    /// <summary>
    /// Зарплата
    /// </summary>
    public abstract class EmployeeBase
    {
        /// <summary>
        /// Время работы
        /// </summary>
        private int _workTime;
        
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
        //TODO: Название!
        /// <summary>
        /// Подсчет зарплаты
        /// </summary>
        public abstract int GetSalary { get; set; }

        /// <summary>
        /// Тип зарплаты
        /// </summary>
        public abstract string Type { get; }
    }
}
