using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Salary
{
    public abstract class Employee
    {
        /// <summary>
        /// Имя работника
        /// </summary>
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Regex regex = new Regex("[А-ЯЁ][а-яё]");
                Match match = regex.Match(value);
                if (match.Success)
                {
                    _name = Name;
                }
            }
        }
        /// <summary>
        /// Фамилия работника
        /// </summary>
        private string _surname;
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Regex regex = new Regex("[А-ЯЁ][а-яё]");
                Match match = regex.Match(value);
                if (match.Success)
                {
                    _surname = value;
                }
            }
        }
        /// <summary>
        /// Время работы
        /// </summary>
        private int _workTime;
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
        public abstract int GetSalary();
        public Employee (string name, string surname, int workTime)
        {
            Name = name;
            Surname = surname;
            WorkTime = workTime;
        }
    }
}
    