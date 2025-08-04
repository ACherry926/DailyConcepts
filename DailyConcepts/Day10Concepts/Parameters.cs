using System;

namespace Day10Concepts
{
    class Parameter
    {
        public void ParametersExample()
        {
            AddNumbers(10, 20, new object[] { 30, 40, 50 });
        }
        /// <summary>
        /// Parameter Array
        /// </summary>
        public void AddNumbers(int firstNumber, int secondNumber, params Object[] restOfNumbers)
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
