using System;
using System.Diagnostics;


namespace Task4
{
    public static class MathMethods
    {
        /// <summary>
        /// Method of calculating the root of the n-th degree among the Newton method with a given accuracy
        /// </summary>
        /// <param name="a">The number under the root</param>
        /// <param name="power">The degree of root</param>
        /// <param name="precision">Necessary accuracy of calculation</param>
        /// <returns></returns>
        public static double RootByNewtonMethod(double a, int power, double precision)
        {
            if (precision > 1 || precision < 1E-16)
                throw new ArgumentOutOfRangeException();
            if (a < 0)
                throw new ArgumentOutOfRangeException();
            if (Math.Abs(a) < precision)
                return 0;
            if (power <= 0)
                throw new ArgumentOutOfRangeException();

            double possibleResult = 1.0;
            var intermediateResult = Math.Pow(possibleResult, power);

            while (Math.Abs(a - intermediateResult) > precision)
            {
                possibleResult = ((power - 1) * possibleResult + a / Math.Pow(possibleResult, power - 1)) / power;
                intermediateResult = Math.Pow(possibleResult, power);
            }
            return possibleResult;
        }

        public static int GcdByEvklidMethod(out long ticks, int a, int b)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var result = Gcd(a, b);
            watch.Stop();
            ticks = watch.ElapsedTicks;
            return result;
        }

        public static int GcdByEvklidMethod(out long ticks, int a, int b, int c)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var result = Gcd(a, b, c);
            watch.Stop();
            ticks = watch.ElapsedTicks;
            return result;
        }

        public static int GcdByEvklidMethod(out long ticks, params int[] valuesInts)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var result = Gcd(valuesInts);
            watch.Stop();
            ticks = watch.ElapsedTicks;
            return result;
        }

        public static int GcdBySteinMethod(out long ticks, int a, int b)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var result = BinaryGcd(a, b);
            watch.Stop();
            ticks = watch.ElapsedTicks;
            return result;
        }

        public static int GcdBySteinMethod(out long ticks, int a, int b, int c)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var result = BinaryGcd(a, b, c);
            watch.Stop();
            ticks = watch.ElapsedTicks;
            return result;
        }

        public static int GcdBySteinMethod(out long ticks, params int[] valuesInts)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var result = BinaryGcd(valuesInts);
            watch.Stop();
            ticks = watch.ElapsedTicks;
            return result;
        }

        #region Private methods
        private static int BinaryGcd(int a, int b)
        {
            if (a < 0) a *= -1;
            if (b < 0) b *= -1;

            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;

            if (a == 1) return 1;
            if (b == 1) return 1;

            if (a % 2 == 0 && b % 2 == 0)
                return 2 * BinaryGcd(a / 2, b / 2);

            if (a % 2 == 0 && b % 2 == 1)
                return BinaryGcd(a / 2, b);

            if (a % 2 == 1 && b % 2 == 0)
                return BinaryGcd(a, b / 2);

            if (a % 2 == 1 && b % 2 == 1 && b > a)
                return BinaryGcd((b - a) / 2, a);

            return BinaryGcd((a - b) / 2, b);
        }

        private static int BinaryGcd(params int[] valuesInts)
        {
            int gcd = BinaryGcd(valuesInts[0], valuesInts[1]);

            for (int i = 2; i < valuesInts.Length; i++)
            {
                gcd = BinaryGcd(valuesInts[i], gcd);
            }

            return Math.Abs(gcd);
        }

        private static int Gcd(int a, int b)
        {
            if (a == 0 || b == 0)
                throw new ArgumentException();

            if (a < b)
            {
                int c = a;
                a = b;
                b = c;
            }

            int mod = 0;
            do
            {
                mod = a % b;
                a = b;
                b = mod;
            } while (mod != 0);

            return Math.Abs(a);
        }

        private static int Gcd(params int[] valuesInts)
        {
            int gcd = Gcd(valuesInts[0], valuesInts[1]);

            for (int i = 2; i < valuesInts.Length; i++)
            {
                gcd = Gcd(valuesInts[i], gcd);
            }

            return Math.Abs(gcd);
        }

        #endregion
    }
}
