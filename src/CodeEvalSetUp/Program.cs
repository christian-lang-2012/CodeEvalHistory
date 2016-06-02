using System;
using System.IO;
using System.Linq;

namespace CodeEvalSetUp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var oddNumbers = Enumerable.Range(1, 99).Select(x => x%2 == 1 ? x.ToString() : "");
            foreach (var oddNumber in oddNumbers)
            {
                Console.WriteLine(oddNumber);
            }
        }
    }
}