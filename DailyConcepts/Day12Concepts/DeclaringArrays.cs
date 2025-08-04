using System;

namespace Day12Concepts
{
    class DeclaringArraysConcept
    {
        public static void DeclaringArrayMethod()
        {
            string[] cars = new string[3] { "Volvo", "Bmw", "Ford" };

            int[] myNumbers = new int[3] { 10, 20, 30 };

            string[] cars1 = { "Volvo", "Bmw", "Ford" };

            int[] myNumbers1 = { 10, 20, 30 };

            string[] cars2 = new string[10];
            cars2[0] = "Volvo";
            cars2[1] = "Bmw";
            cars2[2] = "Ford";
            cars2[3] = "Toyota";
            Console.WriteLine(cars2);
        }
    }
}
