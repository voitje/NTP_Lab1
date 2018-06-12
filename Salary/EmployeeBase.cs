using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    /// <summary>
    /// Зарплата
    /// </summary>
    [DataContract]
    public abstract class EmployeeBase
    {
        /// <summary>
        /// Время работы
        /// </summary>
        [DataMember]
        private uint _workTime;
        
        /// <summary>
        /// Время работы
        /// </summary>
        public uint WorkTime
        {
            get => _workTime;
            private set
            {
                //TODO: константой \ DONE
                const int maxHourInMonth = 372;
                //TODO: Заче эта переменная? \ DONE
                while (value >= maxHourInMonth || value == 0)
                {
                    Console.WriteLine(
                        "\nВведеное время работы больше допустимого значения (372) и не равно нулю" +
                        "\n Введите корректное значение");
                    value = uint.Parse(Console.ReadLine());
                }
                _workTime = value;
            }
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
        public abstract uint Payroll { get; }
        
        /// <summary>
        /// Тип зарплаты
        /// </summary>
        public abstract string Type { get; }    
    }
}
