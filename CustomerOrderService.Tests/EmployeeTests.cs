using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService.Tests
{
    [TestFixture]
    public class EmployeeTests
    {
        public virtual Employee CreateEmployee()
        {
            return new Employee();
        }
        [TestCase]
        public void When_NameContainsIllegalChars_Expect_ContainsIllegalChars_ReturnsTrue()
        {
            Employee employee = CreateEmployee();
            employee.Name = "Da$ya";

            var result = employee.ContainsIllegalChars();

            Assert.IsTrue(result);
        }
        [TestCase]
        public void When_AgeGreaterAndEqualTo60_Expects_IsSeniorCitizeAsTrue()
        {
            Employee emp = new Employee();
            emp.Age = 60;

            bool result = emp.IsSeniorCitizen();

            Assert.That(result == true);
        }

        [TestCase(60, ExpectedResult = true)]
        [TestCase(40, ExpectedResult = false)]
        [TestCase(80, ExpectedResult = true)]
        [TestCase(90, ExpectedResult = true)]
        public bool When_AgeGreaterAndEqualTo60_Expects_IsSeniorCitizeAsTrue(int age)
        {
            Employee emp = new Employee();
            emp.Age = age;

            bool result = emp.IsSeniorCitizen();

            return result;
        }
        [TestCase(Author = "Michael")]
        public void When_AgeGreaterAndEqualTo60_Expects_IsSeniorCitizeAsTrue2()
        {
            Employee emp = new Employee();
            emp.Age = 60;

            bool result = emp.IsSeniorCitizen();

            Assert.That(result == true);
        }
        [TestCaseSource(typeof(StringArrayTestDataSource))]
        public void When_StringArrayAreEvenNumbers_Expects_IsStringArrayOfEvenNumbersAsTrue(string[] numbers)
        {
            Number number = new Number();

            bool result = number.IsStringArrayOfEvenNumbers(numbers);

            Assert.That(result == true);
        }
    }
}
