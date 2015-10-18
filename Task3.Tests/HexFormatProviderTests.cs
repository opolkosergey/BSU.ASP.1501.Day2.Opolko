using System;
using NUnit.Framework;
using Task3;

namespace Task3.Tests
{
    [TestFixture]
    public class HexFormatProviderTests
    {
        [TestCase(36254627, Result = "+0x22933A3")]
        [TestCase(2222, Result = "+0x8AE")]
        [TestCase(0, Result = "+0x0")]
        [TestCase(-123, Result = "-0x7B")]
        [TestCase(159, Result = "+0x9F")]
        public string Format_Test(int number)
        {
            IFormatProvider fp = new HexFormatProvider();
            return string.Format(fp, "{0:H}", number);
        }

        [TestCase(2222, "{0:X}", Result = "8AE")]
        [TestCase(159, "{0:X}", Result = "9F")]
        public string ParentFormat_Test(int number, string format)
        {
            IFormatProvider fp = new HexFormatProvider();
            return string.Format(fp, format, number);
        }
    }
}
