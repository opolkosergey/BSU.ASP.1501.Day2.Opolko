using System;
using NUnit.Framework;
using Task4;

namespace Task1.Tests
{
    [TestFixture]
    public class MathMethodsTests
    {
        
        [TestCase(16, 2, 0.1)]
        [TestCase(25, 2, 0.1)]
        [TestCase(65.4, 3, 0.999)]
        [TestCase(10001, 4 , 0.99)]    
        [TestCase(0, 2, 0.1)]
        [TestCase(12, 2, 4, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [TestCase(12, 0, 0.1, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [TestCase(-12, 9, 0.4, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [TestCase(-12, 9, -4, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [TestCase(12, -9, 4, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [TestCase(12, 9, -4, ExpectedException = typeof(ArgumentOutOfRangeException))]
        public void RootByNewtonMethod_AbiggerThanZeroAndPositivePowerAndPrecisionBetweenZeroAnddOne_ValueReturned(double a, int power, double precision)
        {
            var methodResult = MathMethods.RootByNewtonMethod(a, power, precision);
            var expectedResult = Math.Pow(a, 1.0/power);
            Assert.AreEqual(expectedResult, methodResult, precision);
        }
    }
}
