using System;

namespace OptionalParameter
{
    class NamedParameter
    {
        public void NamedParameters()
        {
            TestNamedParameters(1, 2);
            TestNamedParameters(1, number3: 2);
        }

        /// <summary>
        /// Named Parameters for Default
        /// </summary>
        public static void TestNamedParameters(int number1, int number2 = 10, int number3 = 20)
        {
            Console.WriteLine("number1 = " + number1);
            Console.WriteLine("number2 = " + number2);
            Console.WriteLine("number3 = " + number3);
        }
    }
}
