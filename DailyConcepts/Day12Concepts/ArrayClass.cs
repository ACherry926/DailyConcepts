using System;

namespace Day12Concepts
{
    class ArrayClassConcept
    {
        public void ArrayClassExample()
        {
            string[] months = new string[]
            {
                "January",
                "February",
                "March",
                "April"
            };
            Array.Reverse(months);

            foreach (var month in months)
            {
                Console.WriteLine(month);
            }

            Array.Sort(months);
            Console.WriteLine("\nThe sorted order of given months: \n");
            foreach (var month in months)
            {
                Console.WriteLine(month);
            }

            bool isMarchExist = Array.Exists(months, x => x == "March");
            Console.WriteLine($"\n IsMarch Exist: {isMarchExist}");
        }
    }
}
