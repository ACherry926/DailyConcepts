using System;
using System.Runtime.InteropServices;

namespace OptionalParameter
{
    class OptionalAttributes
    {
        public void OptionalAttribute()
        {
            AddNumbers(20, 30, new int[] { 56 });
        }
        /// <summary>
        /// Optional Attribute 
        /// </summary>        
        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int numbers in restOfNumbers)
                {
                    result += numbers;
                }
            }
            Console.WriteLine("Total = " + result.ToString());
        }
    }
}
