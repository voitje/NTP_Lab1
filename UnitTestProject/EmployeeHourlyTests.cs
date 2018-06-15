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
        /// Позитивное тестирование поля Type
        /// </summary>
        [Test]
        [TestCase((uint)150, (uint)1000, ExpectedResult = "Почасовая",
            TestName = "Позитивное тестирование Type")]
        [TestCase((uint)180, (uint)1000, ExpectedResult = "Почасовая",
            TestName = "Позитивное тестирование Type")]
        public string EmployeeHourlyTypePositiveTest(uint workTime, uint costPerHour)
        {
            EmployeeHourly employeeRate = new EmployeeHourly(workTime, costPerHour);
            return employeeRate.Type;
        }

        /// <summary>
        /// Позитивное тестирование поля WorkTime
        /// </summary>
        [Test]
        [TestCase((uint)1, (uint)1000, ExpectedResult = (uint)1,
            TestName = "Позитивное тестирование WorkTime при 1")]
        [TestCase((uint)372, (uint)1000, ExpectedResult = (uint)372,
            TestName = "Позитивное тестирование WorkTime при 372")]
        public uint EmployeeHourlyWorkTimePositiveTest(uint workTime, uint costPerHour)
        {
            EmployeeHourly employeeRate = new EmployeeHourly(workTime, costPerHour);
            return employeeRate.WorkTime;
        }

        /// <summary>
        /// Позитивное тестирование поля CostPerHour
        /// </summary>
        [Test]
        [TestCase((uint)180, (uint)1, ExpectedResult = (uint)1,
            TestName = "Позитивное тестирование CostPerHour при 1")]
        [TestCase((uint)180, (uint)1400, ExpectedResult = (uint)1400,
            TestName = "Позитивное тестирование CostPerHour при 1400")]
        public uint EmployeeHourlyCostPerHourPositiveTest(uint workTime, uint costPerHour)
        {
            EmployeeHourly employeeRate = new EmployeeHourly(workTime, costPerHour);
            return employeeRate.CostPerHour;
        }

        /// <summary>
        /// Отрицательное тестирование поля CostPerHour
        /// </summary>
        [Test]
        [TestCase((uint)180, (uint)0,
            TestName = "Отрицательное тестирование CostPerHour при 0")]
        [TestCase((uint)180, (uint)1401,
            TestName = "Отрицательное тестирование CostPerHour при 1401")]
        public void EmployeeHourlyCostPerHourNegativeTest(uint workTime, uint costPerHour)
        {
            Assert.That(() => new EmployeeHourly(workTime, costPerHour), Throws.TypeOf<ArgumentException>());
        }

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
            Assert.That(() => new EmployeeHourly(workTime, costPerHour), Throws.TypeOf<ArgumentException>());
        }
    }
}
