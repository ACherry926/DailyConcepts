using System;
using System.Collections.Generic;
using System.Linq;

namespace Day21Concepts
{
    public class SingleVsSingleOrDefault
    {
        public void SingleVsSingleOrDefaultExample()
        {
            List<int> numbers = new List<int>() { 1, 2, 3};

            var methodSyntax = numbers.Single();
            var methodSyntax1 = numbers.SingleOrDefault();
            var methodSyntax2 = numbers.Single(number => number > 15);
            var methodSyntax3 = numbers.SingleOrDefault(number => number > 15);

            var mixedQuery = (from number in numbers
                              where number > 15
                              select number).ToList();

            Console.WriteLine(methodSyntax);
        }
    }
}
