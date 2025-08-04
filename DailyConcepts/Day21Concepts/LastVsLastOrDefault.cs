using System;
using System.Collections.Generic;
using System.Linq;

namespace Day21Concepts
{
    public class LastVsLastOrDefault
    {
        public void LastExample()
        {
            List<int> numbers = GetNumbers();   

            var methodSyntax = numbers.Last();
            var methodSyntax1 = numbers.Where(number => number > 5).Last();
            //var methodSyntax2 = numbers.Last(x => x > 15);

            var mixedQuery = (from number in numbers
                              where number > 15
                              select number).ToList();

            Console.WriteLine(methodSyntax);
        }

        public void LastOrDefaultExample()
        {
            List<int> numbers = GetNumbers();

            var methodSyntax = numbers.LastOrDefault();
            var methodSyntax1 = numbers.Where(number => number > 5).LastOrDefault();
            var methodSyntax3 = numbers.LastOrDefault(number => number > 15);

            var mixedQuery = (from number in numbers
                              where number > 15
                              select number).LastOrDefault();

            Console.WriteLine(methodSyntax);
        }

        public static List<int> GetNumbers()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return numbers;
        }
    }
}
