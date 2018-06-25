using System;
using Salary;

namespace SalaryForWorker
{
    internal static class Program
    {
        /// <summary>
        /// Проверка на правильный ввод
        /// </summary>
        static uint CheckValidation(string inputInformation)
        {
            Console.WriteLine(inputInformation);
            uint element;
            while (!uint.TryParse(Console.ReadLine(), out element))
            {
                Console.WriteLine("Введите целое, положительное число");
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

                Console.WriteLine("\n\n\nВыберите действие (1-2):\n>");
                
                switch (CheckValidation("Нажатая цифра с клавиатуры соответствует выбранному действию"))
                {
                    case 1:
                    {
                        EmployeeRate employeeRate = 
                            new EmployeeRate(CheckValidation("Введите время работы в месяц (в часах)"), 
                                CheckValidation("Введите месячный оклад"), 
                                CheckValidation("Введите норму часов в месяц"));
                        Console.WriteLine($"Зарплата за {employeeRate.WorkTime}" +
                                          $" часов работы   c окладом {employeeRate.Salary}" +
                                          $" и с нормой в {employeeRate.Rate} часов " +
                                          $"с учетом налога на доходы физических лиц:");
                        Console.WriteLine(employeeRate.Payroll);

                        Console.WriteLine("Нажмите любую кнопку для продолжения работы");
                        Console.ReadKey();
                        break;
                    }
                    case 2:
                    {
                        EmployeeHourly employeeHourly = 
                            new EmployeeHourly(CheckValidation("Введите время работы в месяц (в часах)"),
                            CheckValidation("Введите оплату за час работы"));

                        Console.WriteLine($"Зарплата за {employeeHourly.WorkTime}" +
                                          $" часов работы c {employeeHourly.CostPerHour} за час работы:");
                        Console.WriteLine(employeeHourly.Payroll);

                        Console.WriteLine("Нажмите любую кнопку для продолжения работы");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}

