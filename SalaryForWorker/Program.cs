﻿using System;
using Salary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SalaryForWorker
{
    class Program
    {
        /// <summary>
        /// Консольный интерфейс зарплат
        /// </summary>
        static void Main(string[] args)
        {
            string name = "Ivan";
            string surname = "Ivanov";
            bool key = true;
            while (key)
            {
                Console.Clear();
                Console.WriteLine(
                    "\n------List of Person: Main Menu------" +
                    "\n1. Расчитать зарплату по ставке" +
                    "\n2. Расчитать зарплату по часам" +
                    "\n0. Выход" +
                     "\n------List of Person : Main Menu------");

                Console.WriteLine("\n\n\nChoose action (1-2):\n>");
                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            {
                                int workTime;
                                int salary;
                                int rate;
                                Console.WriteLine(
                                    "Введите норму часов в месяц");
                                rate = int.Parse(Console.ReadLine());
                                Console.WriteLine(
                                    "Введите месячный оклад");
                                salary = int.Parse(Console.ReadLine());
                                Console.WriteLine(
                                    "Введите время работы в месяц (в часах)");
                                workTime = int.Parse(Console.ReadLine());
                                EmployeeRate EmployeeRate =
                                    new EmployeeRate(name, surname, workTime, salary, rate);
                                Console.WriteLine("Зарплата за " + workTime +
                                    " часов работы " + "c окладом " + salary + " и ставкой "
                                    + rate + " с учетом налога на доходы физических лиц:");
                                Console.WriteLine(EmployeeRate.GetSalary());
                                Console.WriteLine("Нажмите любую кнопку для продолжения работы");
                                Console.ReadKey();
                                break;
                            }
                        case 2:
                            {
                                int workTime;
                                int costPerHour;
                                Console.WriteLine(
                                    "Введите оплату за час работы");
                                costPerHour = int.Parse(Console.ReadLine());
                                Console.WriteLine(
                                    "Введите время работы в месяц (в часах)");
                                workTime = int.Parse(Console.ReadLine());
                                EmployeeHourly EmployeeHourly =
                                    new EmployeeHourly(name, surname, workTime, costPerHour);
                                Console.WriteLine("Зарплата за " + workTime +
                                    " часов работы " + "c " + costPerHour + " за час работы:");
                                Console.WriteLine(EmployeeHourly.GetSalary());
                                Console.WriteLine("Нажмите любую кнопку для продолжения работы");
                                Console.ReadKey();
                                break;
                            }
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.ReadKey();
                }
            }
        }
    }
}

