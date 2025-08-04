using System;
using System.Collections.Generic;
using System.Linq;

namespace Day21Concepts
{
    public class TakeWhileMethod
    {
        public void TakeWhileMethodExample()
        {
            List<int> numbers = TakeMethod.GetNumbers();

            //var methodSyntax = numbers.Take(5).ToArray();
            var methodSyntax = numbers.TakeWhile(number => number < 7).ToList();
           // var querySyntax = (from n in numbers select n).TakeWhile(x => x < 7).ToList();

            Console.WriteLine(methodSyntax);
        }
        
        public void TakeWhileMethodForMethodSyntax()
        {
            List<string> names = new List<string>() { "Kim", "John", "Mark", "Adam", "Nitish"};

           // var methodSyntax = names.TakeWhile((name, index) => name.Length > index).ToList();
            var querySyntax = (from n in names select n).TakeWhile((name, index) => name.Length > index).ToList();

            Console.WriteLine(querySyntax);
        }
    }
}
