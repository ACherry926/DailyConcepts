using System;

namespace Day15Concepts
{
    class ExpectionHandling
    {
        public void ExpectionHandlingMethod()
        {
            int numberOne = 0;
            int numberTwo = 0;

            Console.WriteLine("Enter num1");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            try
            {
                int output = numberOne / numberTwo;
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is happened please contact Support");
            }
            Console.ReadLine();

        }
    }
}
