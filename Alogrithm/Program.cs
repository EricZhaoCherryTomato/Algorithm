using System;

namespace GCD
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine(Gcd(3, 6));
            Console.ReadKey(true);
        }

        public static int Gcd(int p, int q)
        {
            if (q == 0)
            {
                return p;
            }
            //3 divided by 7 is 0 with a remainder of 3
            var r = p % q;
            return Gcd(q, r);
        }
    }
}