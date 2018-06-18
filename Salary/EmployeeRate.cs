using System;
using System.Runtime.Serialization;

namespace Salary
{
    //TODO: Слишком много кто знает o EmployeeRate, при увеличении числа наследников нужно будет в каждом месте дописывать
    //TODO: код. Такие места надо сокращать. Для этого есть шаблон проектирования Factory, позволяющий сгрупировать
    //TODO: порождение экземпляров наследников.
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
            {//TODO: Можно сократить дублирование - вынеся метод в базовый класс. \ DONE
                const int maxSalaryInMonth = 1000000;
                CheckingData((int)value, 
                    "\nПараметры должны быть больше 0, а оклад не больше 1000000" +
                    "\n Введите корректное значение", maxSalaryInMonth);
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
            {//TODO: Можно сократить дублирование - вынеся метод в базовый класс. \ DONE
                const int maxHourInMonth = 372;
                CheckingData((int)value,
                    "\nПараметры должны быть больше 0, а норма работы не больше 372" +
                    "\n Введите корректное значение", maxHourInMonth);
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
