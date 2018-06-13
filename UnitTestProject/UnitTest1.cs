using System;
using System.Security.Authentication.ExtendedProtection.Configuration;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Salary;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        [TestCase((uint)180,(uint)400, ExpectedResult = (uint)72000, TestName = "Тестирование Payroll при WorkTime 180 и CostPerHour 400")]
        [TestCase((uint)300,(uint)1000, ExpectedResult = (uint)300000, TestName = "Тестирование Payroll при WorkTime 300 и CostPerHour 1000")]
        public uint EmployeeHourlyPositiveTest(uint value, uint value1)
        {
            EmployeeHourly employeeHourly = new EmployeeHourly(value,value1);
            return employeeHourly.Payroll;
        }

        [Test]
        [TestCase((uint)0, (uint)0, TestName = "Отрицальное тестирование Payroll при WorkTime 0 и CostPerHour 0")]
        [TestCase(uint.MaxValue, uint.MaxValue, TestName = "Тестирование Payroll при WorkTime int.MaxValue и CostPerHour int.MaxValue")]
        public void EmployeeHourlyNegativeTest(uint value, uint value1)
        {
            Assert.That(() => new EmployeeHourly(value, value1), Throws.TypeOf<ArgumentException>());
        }
    }
}
