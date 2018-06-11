﻿using System;
//TODO: Не компилится из-за неправильно подключенного проекта
//TODO: Скорее всего вы его подключаете как сборку .dll а саму сборку не добавили в репозиторий.
//TODO: Выполните подключение не бинарником, а прямо проектом
using Salary;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SalaryForWorker
{
    internal class Program
    {
        /// <summary>
        /// Проверка на правильный ввод
        /// </summary>
        static uint CheckValidation(string inputInformation)
        {
            Console.WriteLine(inputInformation);
            //BUG: Падает при некорректном вводе. \ FIX
            uint element;
            //TODO: Неправильно использовать int для поля, где должно лежать беззнаковое значение \ DONE
            while (!uint.TryParse(Console.ReadLine(), out element))
            {

                Console.WriteLine("Введите целое число");
            }
            return element;
        }

        /// <summary>
        /// Консольный интерфейс зарплат
        /// </summary>
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "\n------Main Menu------" +
                    "\n1. Расчитать зарплату по ставке" +
                    "\n2. Расчитать зарплату по часам" +
                    "\n0. Выход" +
                    "\n------Main Menu------");

                Console.WriteLine("\n\n\nChoose action (1-2):\n>");
                //TODO: Сейчас после ошибки во вводе пользователь должен начинать ввод заново - это не правильно - он мог 
                //TODO: опечататься. Необходимо обрабатывать пользовательский ввод для каждого случая ввода. И просить ввести
                //TODO: заново каждый раз на том же параметре 
                //TODO: Не работает, при вводе некорректного параметра программа завершится с исключением. \ DONE

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                    {
                        EmployeeRate employeeRate = 
                            new EmployeeRate(CheckValidation("Введите время работы в месяц (в часах)"),
                            CheckValidation("Введите месячный оклад"), 
                                CheckValidation("Введите норму часов в месяц"));

                        Console.WriteLine("Зарплата за " + employeeRate.WorkTime +
                                          " часов работы " + "c окладом "
                                          + employeeRate.Salary + " и с нормой в "
                                          + employeeRate.Rate +
                                          " часов с учетом налога на доходы физических лиц:");
                        Console.WriteLine(employeeRate.GetSalary);

                        Console.WriteLine("Нажмите любую кнопку для продолжения работы");
                        Console.ReadKey();
                        break;
                    }
                    case 2:
                    {
                        EmployeeHourly employeeHourly = 
                            new EmployeeHourly(CheckValidation("Введите время работы в месяц (в часах)"),
                            CheckValidation("Введите оплату за час работы"));

                        Console.WriteLine("Зарплата за " + employeeHourly.WorkTime +
                                          " часов работы " + "c " + employeeHourly.CostPerHour + " за час работы:");
                        Console.WriteLine(employeeHourly.GetSalary);

                        Console.WriteLine("Нажмите любую кнопку для продолжения работы");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}

