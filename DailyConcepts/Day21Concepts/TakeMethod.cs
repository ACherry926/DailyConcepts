using System;
using System.Collections.Generic;
using System.Linq;

namespace Day21Concepts
{
    public class TakeMethod
    {   
        /// <summary>
        /// Partitioning Operators
        /// </summary>
        public void MethodSyntaxWithIntegerExample()
        {
            List<int> numbers = GetNumbers();

            //var MethodSyntax = numbers.Take(5).ToArray();
            var MethodSyntax = numbers.Where(number => number > 3).Take(5).ToArray();

            Console.WriteLine(MethodSyntax);
        }

        public void QuerySyntaxWithIntegerExample()
        {
            List<int> numbers = GetNumbers();

            //var QuerySyntax =  (from n in numbers select n).Take(8).ToList();
            var QuerySyntax =  (from number in numbers 
                                where number > 3
                                select number).Take(8).ToList();

            Console.WriteLine(QuerySyntax);
        }

        public static List<int> GetNumbers()
        {
            int[] numbersArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numbersList = new List<int>(numbersArray);
            return numbersList;
        }
    }
}
