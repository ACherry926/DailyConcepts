using System;
using System.Collections.Generic;
using System.Linq;

namespace Day21Concepts
{
    public class SkipMethod
    {
        public void SkipMethodExample()
        {
            List<int> numbers = GetNumbers();

            List<string> names = new List<string>() { "Kim", "John", "Mark", "Adam", "Nitish" };

            var methodSyntax = numbers.Skip(5).ToArray();
            var mixedSyntax = (from name in names 
                               select name).Skip(2).ToArray();
           
            Console.WriteLine(methodSyntax);
        }

        public void SkipMethodForWhereExample()
        {
            List<int> numbers = GetNumbers();

            var methodSyntax = numbers.Where(number => number > 4 ).Skip(5).ToArray();

            Console.WriteLine(methodSyntax);
        }

        public static List<int> GetNumbers()
        {
            int[] numbersArray = new int[] { 1, 2, 6, 7, 8, 9, 10, 3, 4, 5 };
            List<int> numbers = new List<int>(numbersArray);
            return numbers;
        }
    }
}
