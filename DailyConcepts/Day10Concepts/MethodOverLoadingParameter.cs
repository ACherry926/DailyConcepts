using System;

namespace OptionalParameter
{
    class MethodOverLoading
    {
        public void MethodOverLoadingParameter()
        {
            AddNumbers(10, 20, new int[] { 30, 40 });
        }

        /// <summary>
        /// Method OverLoading Parameter
        /// </summary>
        public void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber, null);
        }
        public void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers)
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
