using System;
using System.Collections.Generic;

namespace Day14Concepts
{
    class GenericStack
    {
        public void GenericStackMethod()
        {
            var stack = new Stack<string>();
            stack.Push("Product1");
            stack.Push("Product2");
            stack.Push("Product3");

            var popedItem = stack.Pop();

            var peakedValue = stack.Peek();

            stack.Clear();
            //undo.redo
            Console.ReadKey();
        }
    }
}
