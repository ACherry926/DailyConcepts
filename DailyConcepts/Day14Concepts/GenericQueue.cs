using System;
using System.Collections.Generic;

namespace Day14Concepts
{
    class GenericQueue
    {
        public void GenericQueueMethod()
        {
            //Queue is nothing but Queue(Queue means collecting data 1,2,3,4 and sending data to queue wise 1,2,3,4)
            var queue = new Queue<string>();
            queue.Enqueue("Task1");
            queue.Enqueue("Task2");
            queue.Enqueue("Task3");

            var task = queue.Dequeue();

            var peekedItask = queue.Peek();

            queue.Clear();
            Console.WriteLine();

        }
    }
}
