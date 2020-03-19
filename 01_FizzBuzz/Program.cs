using System;
using System.Collections.Generic;

namespace _01_FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<string> MillNumbers(List<int> numbers)
        {
            List<string> results = new List<string>();

            foreach (int number in numbers)
            {
                if (number % 7 == 0)
                {
                    results.Add("Buzzinga");
                }
                else if (number % 3 == 0 && number % 5 == 0
                    || number.ToString().Contains("53") || number.ToString().Contains("35"))
                {
                    results.Add("FizzBuzz");
                }
                else if (number % 5 == 0 || number.ToString().Contains("5"))
                {
                    results.Add("Buzz");
                }
                else if (number % 3 == 0)
                {
                    results.Add("Fizz");
                }
                else
                {
                    results.Add(number.ToString());
                }

            }

            return results;
        }


    }
}
