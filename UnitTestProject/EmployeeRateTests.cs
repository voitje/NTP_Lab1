using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Salary;

namespace UnitTestProject
{
    /// <summary>
    /// Тестирования для EmployeeRateTests
    /// </summary>
    [TestFixture]
    public class EmployeeRateTests
    {
        /// <summary>
        /// Позитивное тестирование свойства Payroll и конструктора у класса EmployeeRate
        /// </summary>
        [Test]
        [TestCase((uint)100, (uint)50000, (uint)150, ExpectedResult = (uint)33333,
            TestName = "Позитивное тестирование Payroll при WorkTime 100, Salary 50000 и Rate 150")]
        [TestCase((uint)180, (uint)50000, (uint)180, ExpectedResult = (uint)50000,
            TestName = "Позитивное тестирование Payroll при WorkTime 180, Salary 50000 и Rate 180")]
        public uint EmployeeRatePositiveTest(uint workTime, uint salary, uint rate)
        {
            EmployeeRate employeeRate = new EmployeeRate(workTime, salary, rate);
            return employeeRate.Payroll;
        }

        /// <summary>
        /// Позитивное тестирование свойства Payroll и конструктора у класса EmployeeRate
        /// </summary>
        [Test]
        [TestCase((uint)0, (uint)0, (uint)0,
            TestName = "Отрицательное тестирование Payroll при WorkTime 0, Salary 0 и Rate 0")]
        [TestCase((uint)0, (uint)50000, (uint)180,
            TestName = "Отрицательное тестирование Payroll при WorkTime 0, Salary 50000 и Rate 180")]
        [TestCase((uint)180, (uint)0, (uint)180,
            TestName = "Отрицательное тестирование Payroll при WorkTime 180, Salary 0 и Rate 180")]
        [TestCase((uint)180, (uint)50000, (uint)0,
            TestName = "Отрицательное тестирование Payroll при WorkTime 180, Salary 50000 и Rate 0")]
        [TestCase((uint)373, (uint)1000001, (uint)373,
            TestName = "Отрицательное тестирование Payroll при WorkTime 373, Salary 1000001 и Rate 373")]
        [TestCase((uint)373, (uint)1000001, (uint)373,
            TestName = "Отрицательное тестирование Payroll при WorkTime 373, Salary 1000001 и Rate 373")]
        public void EmployeeRateNegativeTest(uint workTime, uint salary, uint rate)
        {
            Assert.That(() => new EmployeeRate(workTime, salary, rate), Throws.TypeOf<Exception>());
        }
    }
}
