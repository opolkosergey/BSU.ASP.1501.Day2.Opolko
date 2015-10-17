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
            if (precision >= 1 || precision <= 0)
                throw new ArgumentException();
            if (a < 0)
                throw new ArgumentException();
            if (power < 1)
                throw new ArgumentException();

            double possibleResult = 1;
            double intermediateResult = Math.Pow(possibleResult, power);

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
                mod = GetRemain(a, b);
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

        private static int GetRemain(int a, int b)
        {
            int quotient = a / b;
            return a - quotient * b;
        }
    }
}
