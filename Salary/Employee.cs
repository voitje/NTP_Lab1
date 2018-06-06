﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    //TODO: Косяк c RSDN \ DONE (если я понял что abstract и public местами поменять) \ Не верно, верните обратно
    //TODO: Почитайте - как в RSDN должны называться базовые классы
    /// <summary>
    /// Зарплата
    /// </summary>
    abstract public class Employee
    {
        /// <summary>
        /// Время работы
        /// </summary>
        private int _workTime;

        /// <summary>
        /// Время работы
        /// </summary>
        public int WorkTime
        {
            get
            {
                return _workTime;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Некорректное время работы");
                }
                _workTime = value;
            }
        }

        /// <summary>
        /// Подсчет зарплаты
        /// </summary>
        //TODO: Не должно быть с названием "Get"
        public abstract int GetSalary { get; }

        /// <summary>
        /// Иницализация рабочего времени
        /// </summary>
        protected Employee(int workTime)
        {
            WorkTime = workTime;
        }
    }
}
