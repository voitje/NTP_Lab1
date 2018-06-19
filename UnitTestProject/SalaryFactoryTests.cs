using NUnit.Framework;
using Salary;

namespace UnitTestProject
{
    [TestFixture]
    public class SalaryFactoryTests
    {
        [Test]
        [TestCase(TypeSalary.Hourly, (uint)140, (uint)400, TestName = "Проверка корректного возвращения зарплаты по часам")]
        [TestCase(TypeSalary.Rate, (uint)180, (uint)100000, (uint)180, TestName = "Проверка корректного возвращения зарплаты по ставке и окладу")]
        public void GetSalary(TypeSalary key,
            params uint[] value)
        {
            switch (key)
            {
                case TypeSalary.Hourly:
                {
                    EmployeeBase salary = SalaryFactory.GetSalary(TypeSalary.Hourly, 140, 400);
                    EmployeeHourly result = salary as EmployeeHourly;
                    Assert.AreSame(salary, result);
                    break;
                }
                case TypeSalary.Rate:
                {
                    EmployeeBase salary = SalaryFactory.GetSalary(TypeSalary.Rate, 180, 100000, 180);
                    EmployeeRate result = salary as EmployeeRate;
                    Assert.AreSame(salary, result);
                    break;
                }
            }
        }
    }
}
