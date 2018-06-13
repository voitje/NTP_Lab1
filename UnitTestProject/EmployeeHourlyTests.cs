using System;
using System.Security.Authentication.ExtendedProtection.Configuration;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Salary;

namespace UnitTestProject
{
    /// <summary>
    /// Тестирования для EmployeeHourlyTests
    /// </summary>
    [TestFixture]
    public class EmployeeHourlyTests
    {
        //TODO: Тестировать нужно ВСЮ публичную часть класса, а вы тестируете только Payroll
        /// <summary>
        /// Позитивное тестирование свойства Payroll и конструктора у класса EmployeeHourly
        /// </summary>
        [Test]
        [TestCase((uint)180, (uint)400, ExpectedResult = (uint)72000,
            TestName = "Позитивное тестирование Payroll при WorkTime 180 и CostPerHour 400")]
        [TestCase((uint)300, (uint)1000, ExpectedResult = (uint)300000,
            TestName = "Позитивное тестирование Payroll при WorkTime 300 и CostPerHour 1000")]
        public uint EmployeeHourlyPositiveTest(uint workTime, uint costPerHour)
        {
            EmployeeHourly employeeHourly = new EmployeeHourly(workTime, costPerHour);
            return employeeHourly.Payroll;
        }

        /// <summary>
        /// Позитивное тестирование свойства Payroll и конструктора у класса EmployeeHourly
        /// </summary>
        [Test]
        [TestCase((uint)0, (uint)0,
            TestName = "Отрицальное тестирование Payroll при WorkTime 0 и CostPerHour 0")]
        [TestCase((uint)0, (uint)1400,
            TestName = "Отрицальное тестирование Payroll при WorkTime 0 и CostPerHour 1400")]
        [TestCase((uint)180, (uint)0,
            TestName = "Отрицальное тестирование Payroll при WorkTime 0 и CostPerHour 0")]
        [TestCase((uint)373, (uint)1401,
            TestName = "Отрицательное тестирование Payroll при WorkTime 373 и CostPerHour 1401")]
        public void EmployeeHourlyNegativeTest(uint workTime, uint costPerHour)
        {
            Assert.That(() => new EmployeeHourly(workTime, costPerHour), Throws.TypeOf<Exception>());
        }
    }
}
