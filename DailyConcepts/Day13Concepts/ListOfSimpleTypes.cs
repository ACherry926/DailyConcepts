using System;
using System.Collections.Generic;

namespace Day13Concepts
{
    class ListOfSimpleTypes
    {
        public void ListOfSimpleTypesMethods()
        {
            List<int> numbers = new List<int>() { 1,8,5,2,6,9,4,2,3};

            Console.WriteLine("Numbers Before Sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();

            Console.WriteLine("Numbers After Sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse(); 
            Console.WriteLine("Numbers in Decending Order");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void AlphabetSortingMethods()
        {
            List<string> alphabets = new List<string>() { "A", "F", "U", "Q", "W" };
            Console.WriteLine("Alphabets before Sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Sort();

            Console.WriteLine("Alphabets After Sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Reverse();
            Console.WriteLine("Alphabets in Decending Order");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }
        }
    }
}
