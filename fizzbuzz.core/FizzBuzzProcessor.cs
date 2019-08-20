using System;
using System.Linq;

namespace fizzbuzz.core
{
    public class FizzBuzzProcessor
    {        
        public FizzBuzzProcessor(){ }

        public static string[] GetResultComplete(int number)
        {                        
            var numbers = Enumerable.Range(1, number).Select(x => GetResultSimple(x)).ToArray<string>();
            return numbers;
        }

        public static string GetResultSimple(int number)
        {                                    

            if ((number%3 == 0) && (number%5 == 0))
            {
                return "fizzbuzz";
            }
            else if (number%3 == 0)
            {
                return "fizz";
            }
            else if (number%5 == 0)
            {
                return "buzz";
            }
            else
            {
                return number.ToString();
            }            
        }                
    }
}
