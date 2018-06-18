using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Salary
{
    //TODO: Слишком много кто знает o EmployeeHourly, при увеличении числа наследников нужно будет в каждом месте дописывать
    //TODO: код. Такие места надо сокращать. Для этого есть шаблон проектирования Factory, позволяющий сгрупировать
    //TODO: порождение экземпляров наследников.
    /// <summary>
    /// Зарплата по часам
    /// </summary>
    [DataContract]
    public class EmployeeHourly : EmployeeBase
    {
        /// <summary>
        /// Оплата за час
        /// </summary>
        [DataMember]
        private uint _costPerHour;

        /// <summary>
        /// Оплата за час
        /// </summary>
        public uint CostPerHour
        {
            get => _costPerHour;
            private set
            {
                //TODO: Можно сократить дублирование - вынеся метод в базовый класс. \ DONE
                const int maxCostPerHour = 1400;
                CheckingData((int)value,
                    "\nПараметры должны быть больше 0, оплата в час не больше 1400" +
                    "\n Введите корректное значение", maxCostPerHour);
                _costPerHour = value;
            }
        }
        
        /// <summary>
        /// Иницализация полей   
        /// </summary>
        public EmployeeHourly(uint workTime, uint costPerHour)
            : base (workTime)
        {
            CostPerHour = costPerHour;
        }

        /// <summary>
        /// Подсчет зарплаты
        /// </summary>
        public override uint Payroll => WorkTime  * CostPerHour;

        /// <summary>
        /// Тип зарплаты
        /// </summary>
        public override string Type => "Почасовая";
    }
}
