using System;

namespace Day15Concepts
{
    class ExpectionTypes
    {
        public void ExpectionTypesExample()
        {
            try
            {
                Console.WriteLine(Divide(2, 7));
            }
            catch (NumDenoEqualException ex)
            {
                Console.WriteLine(1);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero is not poosible, Corrected to 1");
                Console.WriteLine(Arthimetic(10, 1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you");
            }
        }

        private static int Arthimetic (int number1, int number2)
        {
            try
            {
                int value = Divide(number1, number2);
                return value;
            }
            catch (Exception ex)
            {
                //throw new Exception("Something Happen" + ex.Message);
                throw ex;
            }
        }

        private static int Divide(int number1, int number2)
        {
            if ((number1 < 0)  || (number2 < 0))
            {
                throw new Exception("Negative Numbers or not Allowed");
            }
            if (number1 == number2)
            {
                throw new NumDenoEqualException("Numerator and Denomenator are same");
            }
            int number3 = (number1 / number2);
            return number3;
        }

        public class NumDenoEqualException : Exception
        {
            public NumDenoEqualException(string message) : base(message)
            {

            }
        }
    }
}
