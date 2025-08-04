using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19Concepts
{
    public class ReverseMethod
    {
        public void ReverseMethodForQuerySyntax() 
        {
            List<int> numbers = EmployeeTestData.GetNumbersList();

            var querySyntax =(from number in numbers
                              select number).Reverse();

            foreach (int number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void ReverseMethodForMethodSyntax()
        {
            List<int> numbers = EmployeeTestData.GetNumbersList();

            numbers.Reverse();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void ReverseMethodForSystemCollectionsGeneric()
        {
            List<string> names = new List<string>() { "Mark", "John", "Adam", "Umar", "Bob"};

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("================");
        }

        public void ReverseMethodForAsEnumerable()
        {
            List<string> names = new List<string>() { "Mark", "John", "Adam", "Umar", "Bob" };

            //var reversed = names.AsEnumerable().Reverse();
            var reversed = names.AsQueryable().Reverse();

            foreach (var name in reversed)
            {
                Console.WriteLine(name);
            }
        }
    }
}
