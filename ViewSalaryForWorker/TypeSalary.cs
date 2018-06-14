using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ViewSalaryForWorker
{
    class TypeSalaryEnum
    {
        /// <summary>
        /// Перечисление сущностей
        /// </summary>
        public enum TypeSalary : byte
        {
            [Description("По часам")]
            Hourly,
            [Description("По окладу и ставке")]
            Rate,
        }

        /// <summary>
        /// Получить атрибут "Описание"
        /// </summary>
        public static string GetDescription(TypeSalaryEnum.TypeSalary value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {

                //TODO: Все операции под if - в скобочки \ DONE
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
