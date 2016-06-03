using System;

namespace CodeEvalSetUp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var total = 0;
            var primeTotal = 0;
            for (var i = 0; primeTotal <= 1000; i++)
            {
                if (!IsPrime(i)) continue;
                total += i;
                primeTotal++;
            }

            Console.WriteLine(total);
        }

        public static bool IsPrime(int number)
        {
            var boundary = Math.Floor(Math.Sqrt(number));

            switch (number)
            {
                case 1:
                    return false;
                case 2:
                    return true;
            }

            for (var i = 2; i <= boundary; ++i)
            {
                if (number%i == 0) return false;
            }

            return true;
        }
    }
}