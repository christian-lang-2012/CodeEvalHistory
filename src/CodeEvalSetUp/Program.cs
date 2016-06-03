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
                if (string.IsNullOrEmpty(line))
                    continue;

                var sum = line.Select(n => int.Parse(n.ToString())).Sum();
                Console.WriteLine(sum);
            }
        }
    }
}