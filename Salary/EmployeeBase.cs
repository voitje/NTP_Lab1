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
                const int maxHourInMonth = 372;
                while (value > maxHourInMonth || value <= 0)
                {
                    throw new ArgumentException(
                        "\nПараметры должны быть больше 0 и время работы быть не больше 372, " +
                        "\n Введите корректное значение");
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

        protected void CheckingData(int value, string textException, int border)
        {
            while ((int)value > border || (int)value <= 0)
            {
                throw new ArgumentException(textException);
            }
        }
    }
}
