using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18Concepts
{
    public class ExtensionMethods
    {
        public void ExtensionExampleForString() 
        {
            string name = "pragin";
            string result = name.ChangeFirstLetterCase();
            //string result = stringHelper.ChangeFirstLetterCase(stringName);

            Console.WriteLine(result);
        }

        public void ExtensionExampleForInteger()
        {
            List<int> numbers = LinqQueryMethods.GetNumbers();

            IEnumerable<int> EvenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (int evenNumber in  EvenNumbers)
            {
                Console.WriteLine(evenNumber);
            }
        }
    }
}
