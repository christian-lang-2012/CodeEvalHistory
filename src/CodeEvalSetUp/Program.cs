using System;
using System.IO;
using System.Linq;

namespace CodeEvalSetUp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var line in File.ReadLines(args[0]))
            {
                Console.WriteLine(Convert.ToString(int.Parse(line), 2).Count(c => c == '1'));
            }
        }
    }
}