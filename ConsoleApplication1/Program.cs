using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class HexFormatProvider : IFormatProvider, ICustomFormatter
    {
        private readonly IFormatProvider _parentProvider;

        private static readonly string[] hexSymbols = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split();

        #region Constructors
        public HexFormatProvider() : this(CultureInfo.CurrentCulture) { }
        public HexFormatProvider(IFormatProvider parent)
        {
            _parentProvider = parent;
        }
        #endregion

        #region Public Methods

        public object GetFormat(Type formatType)
        {
            return formatType == typeof(ICustomFormatter) ? this : _parentProvider.GetFormat(formatType);
        } 

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg == null || format != "H")
                return string.Format(_parentProvider, $"{{0:{format}}}", arg);

            if (arg is int)
            {
                var number = (int)arg;
                char sign = '+';
                if (number < 0)
                {
                    number *= -1;
                    sign = '-';
                }

                var result = new StringBuilder();

                do
                {
                    var ch = number % 16;
                    result.Append(hexSymbols[ch]);
                    number /= 16;
                } while (number > 0);

                return sign + "0x" + new string(result.ToString().Reverse().ToArray());
            }

            throw new ArgumentException("Wrong argument type. Argument name: " + nameof(arg));
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFormatProvider fp = new HexFormatProvider();
            Console.WriteLine(string.Format(fp, "{0:X}", 12399999925322325347));
            Console.ReadKey();
        }
    }
}
