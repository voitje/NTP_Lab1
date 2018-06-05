using System;
//TODO: Не компилится из-за неправильно подключенного проекта
using Salary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SalaryForWorker
{//TODO: Косяк c RSDN \ internal надо было указать?
    internal class Program
    {
        /// <summary>
        /// Консольный интерфейс зарплат
        /// </summary>
        static void Main(string[] args)
        {
            //TODO: Название \ DONE
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "\n------List of Person: Main Menu------" +
                    "\n1. Расчитать зарплату по ставке" +
                    "\n2. Расчитать зарплату по часам" +
                    "\n0. Выход" +
                     "\n------List of Person : Main Menu------");

                Console.WriteLine("\n\n\nChoose action (1-2):\n>");
                bool isError;
                do
                {
                    isError = false;
                    try
                    {
                        //TODO: Сейчас после ошибки во вводе пользователь должен начинать ввод заново - это не правильно - он мог 
                        //TODO: опечататься. Необходимо обрабатывать пользовательский ввод для каждого случая ввода. И просить ввести
                        //TODO: заново каждый раз на том же параметре \ DONE
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                            {
                                //TODO: Ниже много косяков c RSDN \ DONE
                                Console.WriteLine(
                                    "Введите норму часов в месяц");
                                int rate = int.Parse(Console.ReadLine());

                                Console.WriteLine(
                                    "Введите месячный оклад");
                                int salary = int.Parse(Console.ReadLine());

                                Console.WriteLine(
                                    "Введите время работы в месяц (в часах)");
                                int workTime = int.Parse(Console.ReadLine());

                                EmployeeRate employeeRate =
                                    new EmployeeRate(workTime, salary, rate);

                                Console.WriteLine("Зарплата за " + workTime +
                                                  " часов работы " + "c окладом "
                                                  + salary + " и ставкой "
                                                  + rate + 
                                                  " с учетом налога на доходы физических лиц:");
                                Console.WriteLine(employeeRate.GetSalary());

                                Console.WriteLine("Нажмите любую кнопку для продолжения работы");
                                Console.ReadKey();
                                break;
                            }
                            case 2:
                            {
                                Console.WriteLine(
                                    "Введите оплату за час работы");
                                int costPerHour = int.Parse(Console.ReadLine());

                                Console.WriteLine(
                                    "Введите время работы в месяц (в часах)");
                                int workTime = int.Parse(Console.ReadLine());

                                EmployeeHourly employeeHourly =
                                    new EmployeeHourly(workTime, costPerHour);

                                Console.WriteLine("Зарплата за " + workTime +
                                                  " часов работы " + "c " + costPerHour + " за час работы:");
                                Console.WriteLine(employeeHourly.GetSalary());

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
                        isError = true;
                    }
                } while (isError);
            }
        }
    }
}

