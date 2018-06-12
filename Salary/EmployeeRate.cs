using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
            get
            {
                return _salary;
            }
            private set
            {//TODO: Константой \ DONE
                const int maxSalaryInMonth = 1000000;
//TODO: Зачем эта переменная? \ DONE
                while (value >= maxSalaryInMonth || value == 0)
                {
                    Console.WriteLine(
                        "\nВведеное время работы больше допустимого значения (1000000) и не равно нулю" +
                        "\n Введите корректное значение");
                    value = uint.Parse(Console.ReadLine());
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
            get
            {
                return _rate;
            }
            private set
            {//TODO: Константой \ DONE
                const int maxHourInMonth = 372;
//TODO: Зачем эта переменная? \ DONE
                while (value >= maxHourInMonth || value == 0)
                {
                    Console.WriteLine(
                        "\nВведеная норма работы больше допустимого значения (372) и не равно нулю" +
                        "\n Введите корректное значение");
                    value = uint.Parse(Console.ReadLine());
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
        public override uint Payroll
        {
            get
            {
                if (WorkTime == 0)
                {
                    return 0;
                }
                return (uint) ((decimal)_salary / _rate * WorkTime);
            }
        }
        /// <summary>
        /// Тип зарплаты
        /// </summary>
        public override string Type
        {
            get { return "По ставке и окладу"; }
        }
    }
}
