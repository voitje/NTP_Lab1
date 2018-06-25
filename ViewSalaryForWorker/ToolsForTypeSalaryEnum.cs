using System.ComponentModel;
using System.Reflection;
using Salary;

namespace ViewSalaryForWorker
{
    /// <summary>
    /// Функции для TypeSalaryEnum
    /// </summary>
    public class ToolsForTypeSalaryEnum
    {
        /// <summary>
        /// Получить атрибут "Описание"
        /// </summary>
        public static string GetDescription(TypeSalary value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }

            return value.ToString();
        }
    }
}
