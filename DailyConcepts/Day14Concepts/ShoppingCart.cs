using System;
using System.Collections.Generic;

namespace Day14Concepts
{
    class ShoppingCart
    {
        //undo means Remove the item from cart which is added lost
        //redo means which item is removed last it will add again
        Stack<string> cart = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();

        public void Add(string productName)
        {
            cart.Push(productName);
        }

        public void Undo()
        {
            var item = cart.Pop();
            redoStack.Push(item);
        }

        public void Redo()
        {
            var item = redoStack .Pop();
            cart.Push(item);
        }

        public void ViewCart()
        {
            foreach(var item in cart)
            {
                Console.WriteLine("\t" + item);
            }
        }
    }
}
