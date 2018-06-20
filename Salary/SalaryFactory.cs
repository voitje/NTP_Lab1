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
            EmployeeBase employeeBase = null;

            switch (key)
            {
                case TypeSalary.Hourly:
                    if (value.Length == 2)
                    {
                        employeeBase = new EmployeeHourly(value[0], value[1]);
                    }
                    break;
                case TypeSalary.Rate:
                    if (value.Length == 3)
                    {
                        employeeBase = new EmployeeRate(value[0], value[1], value[2]);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(key), key, null);
            }
            //TODO: Действительно ли должен вернуться null или правильнее будет кинуть исключение?
            if (employeeBase == null)
            {
                throw new ArgumentException("Ошибка ввода. Введите корректные значения");
            }
            else
            {
                return employeeBase;
            }
        }
    }
}