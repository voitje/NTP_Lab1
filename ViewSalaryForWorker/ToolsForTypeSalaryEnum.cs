﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ViewSalaryForWorker
{
    //TODO: XML \ DONE
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
            else
            {
                return value.ToString();
            }
        }
    }
}
