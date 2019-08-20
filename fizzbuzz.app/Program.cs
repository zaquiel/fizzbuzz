using fizzbuzz.core;
using System;
using System.Linq;

namespace fizzbuzz.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!!");
            while (true)
            {
                Console.WriteLine("Please, insert a number greater than 0 or 0 for exit:");
                var line = Console.ReadLine();

                if (int.TryParse(line, out int number))
                {
                    if (number == 0)
                    {
                        break;
                    }
                    else if (number > 0)
                    {
                        var result = FizzBuzzProcessor.GetResultComplete(number);                        
                        Console.WriteLine(string.Format("{0}{1}{0}",Environment.NewLine, result.Aggregate((x, y) => $"{x},{y}")));
                    }
                    else
                    {
                        Console.WriteLine($"{Environment.NewLine}The number must be greater than 0 or 0 for exit. Let's try again. {Environment.NewLine}");
                    }
                }
                else
                {
                    Console.WriteLine($"{Environment.NewLine}Please, insert a number. Let's try again. {Environment.NewLine}");
                }
            }

            Environment.Exit(0);
        }
    }
}
