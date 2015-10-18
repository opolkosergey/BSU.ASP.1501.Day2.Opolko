using System;
using NUnit.Framework;

namespace Task4.Tests
{
    [TestFixture]
    class MathMethodsTests
    {
        [TestCase(null, 0, 4, ExpectedException = typeof(ArgumentException))]
        [TestCase(null, 4, 0, ExpectedException = typeof(ArgumentException))]
        [TestCase(null, 0, 0, ExpectedException = typeof(ArgumentException))]
        [TestCase(null, 1071, 462, Result = 21)]
        [TestCase(null, -1071, 462, Result = 21)]
        [TestCase(null, 1071, -462, Result = 21)]
        [TestCase(null, -1071, -462, Result = 21)]
        [TestCase(null, -462, -1071, Result = 21)]
        [TestCase(null, -462, 1071, Result = 21)]
        
        public int GcdByEvklidMethod__ValueReturned(out long ticks, int a, int b)
        {
            return MathMethods.GcdByEvklidMethod(out ticks, a, b);
        }

        [TestCase(null, 0, 4, 146, ExpectedException = typeof(ArgumentException))]
        [TestCase(null, 4, 0, -146, ExpectedException = typeof(ArgumentException))]
        [TestCase(null, 0, 0, 146, ExpectedException = typeof(ArgumentException))]
        [TestCase(null, 1071, 462, 147, Result = 21)]
        [TestCase(null, -1071, 462, -147, Result = 21)]
        [TestCase(null, 1071, -462, 147, Result = 21)]
        [TestCase(null, -1071, -462, -147, Result = 21)]

        public int GcdByEvklidMethod__ValueReturned(out long ticks, int a, int b, int c)
        {
            return MathMethods.GcdByEvklidMethod(out ticks, a, b, c);
        }

        [TestCase(null, 2, 4, 144, 0, ExpectedException = typeof(ArgumentException))]
        [TestCase(null, 4, 0, -146 ,24, ExpectedException = typeof(ArgumentException))]
        [TestCase(null, 6, 26, 146, 0, ExpectedException = typeof(ArgumentException))]
        [TestCase(null, 1071, 462, 147,63, Result = 21)]
        [TestCase(null, 63, 147, 462,1071, Result = 21)]
        [TestCase(null, -1071,63,7, 462,-7, -147, Result = 7)]
        [TestCase(null, 1071, -462, 147, -63, Result = 21)]
        [TestCase(null, -63, -1071,-42, -462, -147, Result = 21)]

        public int GcdByEvklidMethod__ValueReturned(out long ticks, params int[] values)
        {
            return MathMethods.GcdByEvklidMethod(out ticks, values);
        }


        [TestCase(null, 1071, 462, Result = 21)]
        [TestCase(null, -1071, 462, Result = 21)]
        [TestCase(null, 1071, -462, Result = 21)]
        [TestCase(null, -1071, -462, Result = 21)]
        [TestCase(null, -462, -1071, Result = 21)]
        [TestCase(null, -462, 1071, Result = 21)]
        
        public int GcdBySteinMethod__ValueReturned(out long ticks, int a, int b)
        {
            return MathMethods.GcdBySteinMethod(out ticks, a, b);
        }

        [TestCase(null, 1071, 462, 147, Result = 21)]
        [TestCase(null, -1071, 462, -147, Result = 21)]
        [TestCase(null, 1071, -462, 147, Result = 21)]
        [TestCase(null, -1071, -462, -147, Result = 21)]
        public int GcdBySteinMethod__ValueReturned(out long ticks, int a, int b, int c)
        {
            return MathMethods.GcdBySteinMethod(out ticks, a, b,c);
        }

        [TestCase(null, 1071, 462, 147,63, Result = 21)]
        [TestCase(null, 63, 147, 462,1071, Result = 21)]
        [TestCase(null, -1071,63,7, 462,-7, -147, Result = 7)]
        [TestCase(null, 1071, -462, 147, -63, Result = 21)]
        [TestCase(null, -63, -1071,-42, -462, -147, Result = 21)]
        public int GcdBySteinMethod__ValueReturned(out long ticks, params int[] values)
        {
            return MathMethods.GcdBySteinMethod(out ticks, values);
        }
    }
}
