using System;

namespace Day7Concepts
{
    public class MethodOverLoading 
    {
        public void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
        }
        public void Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine("Sum ={0}", firstNumber + secondNumber);
        }
        public void Add(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
        {
            Console.WriteLine("Sum ={0}", firstNumber + secondNumber);
        }

        public int M1(int x, int y)
        {
            return x;
        }
        public string M1(int x, int y , int z)
        {
            return (x + y + z).ToString();
        }
    }
}
