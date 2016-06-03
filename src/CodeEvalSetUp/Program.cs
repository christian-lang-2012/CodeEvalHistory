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
                var characters = line.Split(' ');
                var lastIndex = int.Parse(characters.Last());
                var index = characters.Length - lastIndex - 1;
                if (index < 1 || index > characters.Length - 1)
                {
                    continue;
                }
                Console.WriteLine(characters[index]);
            }
        }
    }
}