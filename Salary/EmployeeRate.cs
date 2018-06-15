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
                while (value > maxSalaryInMonth || value == 0)
                {//TODO \ DONE
                    throw new ArgumentException(
                        "\nПараметры должны быть больше 0, время работы должно быть не больше 372, " +
                        "оклад не больше 1000000 и норма работы не больше 372" +
                        "\n Введите корректное значение");
                }
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
                while (value > maxHourInMonth || value == 0)
                {
                    //TODO: \ DONE
                    throw new ArgumentException(
                        "\nПараметры должны быть больше 0, время работы должно быть не больше 372, " +
                        "оклад не больше 1000000 и норма работы не больше 372" +
                        "\n Введите корректное значение");
                }
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
