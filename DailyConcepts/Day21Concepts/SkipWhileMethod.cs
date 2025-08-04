using System;
using System.Collections.Generic;
using System.Linq;

namespace Day21Concepts
{
    public class SkipWhileMethod
    {
        public void MethodSyntaxWithIntegerExample()
        {
            List<int> numbers = SkipMethod.GetNumbers();

            var methodSyntax = numbers.SkipWhile(number => number < 5).ToArray();

            var mixedSyntax = (from number in numbers select number).SkipWhile(number => number < 2).ToArray();

            Console.WriteLine(methodSyntax);
        }

        public void MethodSyntaxWithStringExample()
        {
            List<string> names = new List<string>() { "Kim", "John", "Mark", "Adam", "Nitish" };

            var methodSyntax = names.SkipWhile(x => x.Length < 4).ToList();

            var MixedSyntax =names.SkipWhile((value,  index) => value.Length > index).ToList();

            Console.WriteLine(methodSyntax);
        }
    }
}
