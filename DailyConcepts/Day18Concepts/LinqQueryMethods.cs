using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18Concepts
{
    public class LinqQueryMethods
    {
        public static List<int> GetNumbers()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return numbers;
        }

        public void LinqQueryForQuerySyntax()
        {
            // DataSource
            List<int> numbers = GetNumbers();

            //Query
            var querySyntax = from number in numbers
                              where number > 2
                              select number;

            //Execution
            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("......................");
        }

        public void LinqQueryForMethodSyntax()
        {
            // DataSource
            List<int> numbers = GetNumbers();

            //MethodSyntax
            var methodSyntax = numbers.Where(obj => obj > 2);

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("......................");
        }

        public void LinqQueryForMixedSyntax()
        {
            // DataSource
            List<int> numbers = GetNumbers();

            //Mixed Syntax
            var mixedSyntax = (from number in numbers 
                               select number).Max();

            Console.WriteLine("Max value = " + mixedSyntax);
        }
    }
}
