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
            //TODO: А где ограничения с низу и верху?
            private set => _costPerHour = value;
        }
        
        /// <summary>
        /// Иницализация полей   
        /// </summary>
        public EmployeeHourly(uint workTime, uint costPerHour)
            : base (workTime)
        {
            CostPerHour = costPerHour;
        }

        //TODO: Название! Свойство должно быть существительным, а не действием.
        /// <summary>
        /// Подсчет зарплаты
        /// </summary>
        public override uint CalculateSalary
        {
            get => WorkTime  * CostPerHour;
        }

        /// <summary>
        /// Тип зарплаты
        /// </summary>
        public override string Type => "Почасовая";
    }
}
