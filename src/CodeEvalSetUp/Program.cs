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
                var numbers = line.Split(' ');
                var firstNumber = int.Parse(numbers[0]);
                var secondNumber = int.Parse(numbers[1]);
                var total = int.Parse(numbers[2]);

                Console.WriteLine(
                    string.Join(" ",
                        Enumerable.Range(1, total)
                            .Select(n => n%(firstNumber*secondNumber) == 0
                                ? "FB"
                                : n%firstNumber == 0
                                    ? "F"
                                    : n%secondNumber == 0
                                        ? "B"
                                        : n.ToString())));
            }
        }
    }
}