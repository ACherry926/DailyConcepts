using System;
using System.Threading;
using System.Threading.Tasks;

namespace Day15Concepts
{
    class AsynchronousProgramming
    {
        public void AsynchronousProgrammingMethod()
        {
            //Thread task1 = new Thread(new ThreadStart(Fun1));
            Task task1 = new Task(Function1); //Do not have thread Affinity
            //Thread task2 = new Thread(new ThreadStart(Fun2));
            Task task2 = new Task(Function2);

            task1.Start(); // starts executing Fun1 paralley
            task2.Start(); // starts executing Fun2 paralley

            Console.WriteLine("Hello"); //executing main paralley
            Console.ReadLine();
        }

        static void Function1()
        {
            for (int number = 0; number < 100000; number++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Function 1 :-" + number);
            }
        }

        static void Function2()
        {
            for (int number = 0; number < 100000; number++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Function 2 :-" + number);
            }
        }
    }

    class Asynchronous
    {
        public static void AsynchronousProgrammingMethod()
        {
            Function1();
            Function2();
            Console.WriteLine("Hello"); //executing main paralley
            Console.ReadLine();
        }

        static async void Function1()
        {
            for (int number = 0; number < 100000; number++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Function 1 :-" + number);
            }
        }

        static async void Function2()
        {
            for (int number = 0; number < 100000; number++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Function 2 :-" + number);
            }
        }
    }
}
