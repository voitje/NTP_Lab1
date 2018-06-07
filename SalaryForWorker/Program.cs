using System;
//TODO: Не компилится из-за неправильно подключенного проекта
//TODO: Скорее всего вы его подключаете как сборку .dll а саму сборку не добавили в репозиторий.
//TODO: Выполните подключение не бинарником, а прямо проектом
using Salary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SalaryForWorker
{
    internal class Program
    {
        /// <summary>
        /// Консольный интерфейс зарплат
        /// </summary>
        static void Main(string[] args)
        {
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
                        //Объеденить в общий метод все считывания на проверку инта чтобы вылетала каждый раз когда неправильно присваеваешь

                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                            {
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
                                Console.WriteLine(employeeRate.GetSalary);
                                
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
                                Console.WriteLine(employeeHourly.GetSalary);

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

