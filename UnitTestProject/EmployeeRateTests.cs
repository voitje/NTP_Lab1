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
        /// Позитивное тестирование поля Type
        /// </summary>
        [Test]
        [TestCase((uint)150, (uint)10000, (uint)150, ExpectedResult = "По ставке и окладу",
            TestName = "Позитивное тестирование Type при  Salary 10000, WorkTime 100 и Rate 150")]
        [TestCase((uint)180, (uint)1000000, (uint)180, ExpectedResult = "По ставке и окладу",
            TestName = "Позитивное тестирование Type при Salary 1000000, WorkRime 180 и Rate 180")]
        public string EmployeeRateTypePositiveTest(uint workTime, uint salary, uint rate)
        {
            EmployeeRate employeeRate = new EmployeeRate(workTime, salary, rate);
            return employeeRate.Type;
        }

        /// <summary>
        /// Позитивное тестирование поля WorkTime
        /// </summary>
        [Test]
        [TestCase((uint)372, (uint)50000, (uint)150, ExpectedResult = (uint)372,
            TestName = "Позитивное тестирование WorkTime при 372")]
        [TestCase((uint)1, (uint)50000, (uint)180, ExpectedResult = (uint)1,
            TestName = "Позитивное тестирование WorkTime при 1")]
        public uint EmployeeRateWorktimePositiveTest(uint workTime, uint salary, uint rate)
        {
            EmployeeRate employeeRate = new EmployeeRate(workTime, salary, rate);
            return employeeRate.WorkTime;
        }

        /// <summary>
        /// Позитивное тестирование поля Salary
        /// </summary>
        [Test]
        [TestCase((uint)100, (uint)1, (uint)150, ExpectedResult = (uint)1,
            TestName = "Позитивное тестирование Salary при 1, WorkTime 100 и Rate 150")]
        [TestCase((uint)180, (uint)1000000, (uint)180, ExpectedResult = (uint)1000000,
            TestName = "Позитивное тестирование Salary при 1, WorkRime 180 и Rate 180")]
        public uint EmployeeRateSalaryPositiveTest(uint workTime, uint salary, uint rate)
        {
            EmployeeRate employeeRate = new EmployeeRate(workTime, salary, rate);
            return employeeRate.Salary;
        }

        /// <summary>
        /// Позитивное тестирование поля Rate
        /// </summary>
        [Test]
        [TestCase((uint)100, (uint)50000, (uint)1, ExpectedResult = (uint)1,
            TestName = "Позитивное тестирование Rate при 1, WorkTime 100 и Salary 50000")]
        [TestCase((uint)180, (uint)50000, (uint)372, ExpectedResult = (uint)372,
            TestName = "Позитивное тестирование Rate при 372, WorkRime 180 и Salary 50000")]
        public uint EmployeeRateRatePositiveTest(uint workTime, uint salary, uint rate)
        {
            EmployeeRate employeeRate = new EmployeeRate(workTime, salary, rate);
            return employeeRate.Rate;
        }

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
        /// Отрицательное тестирование поля Salary
        /// </summary>
        [Test]
        [TestCase((uint)150, (uint)0, (uint)150,
            TestName = "Отрицательное тестирование Salary при 0")]
        [TestCase((uint)180, (uint)1000001, (uint)180,
            TestName = "Отрицательное тестирование Salary при 0")]
        public void EmployeeRateSalaryNegativeTest(uint workTime, uint salary, uint rate)
        {
            Assert.That(() => new EmployeeRate(workTime, salary, rate), Throws.TypeOf<ArgumentException>());
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
            Assert.That(() => new EmployeeRate(workTime, salary, rate), Throws.TypeOf<ArgumentException>());
        }
    }
}
