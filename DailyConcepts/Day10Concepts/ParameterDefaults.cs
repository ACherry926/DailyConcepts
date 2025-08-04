using System;

namespace Day10Concepts
{
    class ParameterDefault
    {
        public void ParameterDefaults()
        {
            AddNumbers(10, 20, new int[] { 60, 80 });
        }

        /// <summary>
        /// Parameter Defaults
        /// </summary>
        public void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers = null)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int numbers in restOfNumbers)
                {
                    result += numbers;
                }
            }
            Console.WriteLine("Sum = " + result);
        }
    }
}
