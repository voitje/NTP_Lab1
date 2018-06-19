using System;
using System.Runtime.Serialization;

namespace Salary
{
    /// <summary>
    /// Зарплата по ставке
    /// </summary>
    [DataContract]
    public class EmployeeRate : EmployeeBase
    { 
        /// <summary>
        /// Оклад
        /// </summary>
        [DataMember]
        private uint _salary;

        /// <summary>
        /// Оклад
        /// </summary>
        public uint Salary
        {
            get => _salary;
            private set
            {
                const int maxSalaryInMonth = 1000000;
                CheckingData((int)value, maxSalaryInMonth);
                _salary = value;
            }
        }
        /// <summary>
        /// Ставка (норма работы в месяц)
        /// </summary>
        [DataMember]
        private uint _rate;

        /// <summary>
        /// Ставка (норма работы в месяц)
        /// </summary>
        public  uint Rate
        {
            get => _rate;
            private set
            {
                const int maxHourInMonth = 372;
                CheckingData((int)value, maxHourInMonth);
                _rate = value;
            }
        }

        /// <summary>
        /// Иницализация полей   
        /// </summary>
        public EmployeeRate(uint workTime, uint salary, uint rate)
            : base(workTime)
        {
            Salary = salary;
            Rate = rate;
        }

        /// <summary>
        /// Подсчет зарплаты по ставке
        /// </summary>
        public override uint Payroll => (uint) ((decimal)_salary / _rate * WorkTime);

        /// <summary>
        /// Тип зарплаты
        /// </summary>
        public override string Type => "По ставке и окладу";
    }
}
