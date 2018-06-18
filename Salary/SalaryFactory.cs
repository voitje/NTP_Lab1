using System;

namespace Salary
{
    /// <summary>
    ///  Фабрика класса EmployeeBase и наследников
    /// </summary>
    public abstract class SalaryFactory
    {
        /// <summary>
        /// Вернуть зарплату определённого типа
        /// </summary>
        public static EmployeeBase GetSalary(TypeSalary key,
            params uint[] value)
        {
            //TODO: Нужно валидировать передаваемые параметры
            EmployeeBase employeeBase;

            switch (key)
            {//TODO: Получается что инициализироваться будет одними и теми же параметрами value[0]?
                case TypeSalary.Hourly:
                    employeeBase = new EmployeeHourly(value[0],value[0]);
                    break;

                case TypeSalary.Rate:
                    employeeBase = new EmployeeRate(value[0], value[0], value[0]);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(key), key, null);
            }

            return employeeBase;
        }
    }
}