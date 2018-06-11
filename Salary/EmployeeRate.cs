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
            private set => _salary = value;
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
            private set => _rate = value;
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
        public override uint CalculateSalary
        {
            get
            {
                return (uint) ((decimal)_salary / _rate * WorkTime);
            }
            //TODO: Пустой set! \ DONE
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
