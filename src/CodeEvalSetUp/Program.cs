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
                {
                    continue;
                }

                var words = line.Split(' ');
                Console.WriteLine(string.Join(" ", words.Reverse()));
            }
        }
    }
}