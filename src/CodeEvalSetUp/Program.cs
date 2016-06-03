using System;
using System.IO;
using System.Linq;

namespace CodeEvalSetUp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nums = (from line in File.ReadLines(args[0]) where !string.IsNullOrEmpty(line) select int.Parse(line)).ToList();
            Console.WriteLine(nums.Sum());
        }
    }
}