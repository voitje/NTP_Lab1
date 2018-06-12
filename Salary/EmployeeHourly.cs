using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Salary
{
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
                //TODO: Константой
                int maxCostPerHour = 1400;
                //TODO: Зачем эта переменная?
                uint tempValue;
                while (value >= maxCostPerHour || value == 0)
                {
                    Console.WriteLine(
                        "\nВведеное время работы больше допустимого значения (1400) и не равно нулю" +
                        "\n Введите корректное значение");
                    tempValue = uint.Parse(Console.ReadLine());
                    value = tempValue;
                }
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
        public override uint Payroll
        {
            get => WorkTime  * CostPerHour;
        }

        /// <summary>
        /// Тип зарплаты
        /// </summary>
        public override string Type => "Почасовая";
    }
}
