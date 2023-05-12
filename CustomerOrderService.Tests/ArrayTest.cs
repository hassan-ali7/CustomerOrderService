using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService.Tests
{
    [TestFixture]
    public class ArrayTest
    {
        [TestCase(new int[] { 2, 4, 6 })]
        public void When_AllNumberAreEven_Expects_AreAllNumbersEvenAsTrue(int[] numbers)
        {
            Number number = new Number();

            bool result = number.AreAllNumbersEven(numbers);

            Assert.That(result,Is.EqualTo(true));
        }
    }
}
