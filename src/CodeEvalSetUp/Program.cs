using System;
using System.Linq;

namespace CodeEvalSetUp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var primeNumbers =
                Enumerable.Range(1, 999).Select(n => IsPrime(n) ? n : 1).OrderByDescending(p => p).ToList();
            foreach (var primeNumber in primeNumbers)
            {
                var reverse = primeNumber.ToString().Reverse();
                var reverseString = string.Join("", reverse);
                if (string.IsNullOrEmpty(reverseString) || primeNumber.ToString() != reverseString)
                {
                    continue;
                }
                Console.WriteLine(primeNumber);
                break;
            }

            Console.ReadLine();
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