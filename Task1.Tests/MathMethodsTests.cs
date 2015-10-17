using NUnit.Framework;
using Task4;

namespace Task1.Tests
{
    [TestFixture]
    public class MathMethodsTests
    {
        [TestCase(16, 2, 0, Result = 4)]
        [TestCase(25, 2, 0, Result = 5)]
        [TestCase(36, 2, 0, Result = 6)]
        [TestCase(0, 2, 0, Result = 0)]
        [ExpectedException("System.ArgumentException")]
        [TestCase(12, 2, 4, Result = 6)]
        [TestCase(12, 0, 0.1, Result = 6)]
        [TestCase(12, 0, 0.1, Result = 6)]
        [TestCase(-12, 9, 0.4, Result = 3)]
        [TestCase(-12, 9, -4, Result = 3)]
        [TestCase(12, -9, 4, Result = 3)]
        [TestCase(12, 9, -4, Result = 3)]
        public double RootByNewtonMethod_AbiggerThanZeroAndPositivePowerAndPrecisionBetweenZeroAnddOne_ValueReturned(double a, int power, double precision)
        {
            return MathMethods.RootByNewtonMethod(a, power, precision);
        }
    }
}
