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
        private uint _workTime;
        
        /// <summary>
        /// Время работы
        /// </summary>
        public uint WorkTime
        {
            get
            {
                return _workTime;
            }
            private set => _workTime = value;
        }

        /// <summary>
        /// Иницализация полей   
        /// </summary>
        protected EmployeeBase(uint workTime)
        {
            WorkTime = workTime;
        }

        /// <summary>
        /// Подсчет зарплаты
        /// </summary>
        public abstract uint GetSalary { get; }
        //TODO: XML \ DONE
        /// <summary>
        /// Тип зарплаты
        /// </summary>
        public abstract string Type { get; }    
    }
}
