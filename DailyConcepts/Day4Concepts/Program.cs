using System;

namespace Day4Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperators();
            CompraisonOperators();
            ConditionalOperators();
            TernaryOperators();
            TernaryOperator();
            IfStatement();
            SwitchCase();
            SwitchCases();
            CoffeePurchaseExample();
            IfCondition();
            NullCoalescingOperator();
        }

        /// <summary>
        /// Arithmetic Operators like (=, +, -, *, /, %)
        /// </summary>
        static void ArithmeticOperators()
        {
            int numerator = 10;
            int denominator = 2;
            int result = numerator / denominator;
            Console.WriteLine("Result = {0}", result);
        }

        /// <summary>
        ///  Compraison Operators ( ==, !=, >, >=,<, <=)
        /// </summary>
        static void CompraisonOperators()
        {
            int number = 10;
            if (number == 10)
            {
            }
        }

        /// <summary>
        /// conditional operator (&& , ||)
        /// </summary>
        static void ConditionalOperators()
        {
            int firstNumber = 10;
            int secondNumber = 22;
            if (firstNumber == 10 || secondNumber == 13)
            {
                Console.WriteLine("Hello");
            }
        }

        /// <summary>
        /// Ternary operator (?:)
        /// </summary>
        static void TernaryOperators()
        {
            int number = 10;
            bool isNumber10;
            if (number == 15)
            {
                isNumber10 = true;
            }
            else
            {
                isNumber10 = false;
            }
            Console.WriteLine("Number ==10 is {0}", isNumber10);
        }

        static void TernaryOperator()
        {
            int number = 10;
            bool isNumber10 = number == 15 ? true : false;
            Console.WriteLine("Number ==10 is {0}", isNumber10);
        }

        /*
         if statement and if else statement
         (number != 1 && number != 2)
         Difference between &&  and &  --- || and |
         && True True, & true False // || true true , | true
        */
        static void IfCondition()
        {
            Console.WriteLine("please enter a number");
            int number = int.Parse(Console.ReadLine());
            if (number == 10 && number == 30)
            {
                Console.WriteLine("your num is 10 or 30");
            }
            if (number == 10 & number == 30)
            {
                Console.WriteLine("your num is 10 or 30");
            }
            if (number == 10 || number == 30)
            {

            }
            if (number == 10 | number == 30)
            {

            }
        }

        static void IfStatement()
        {
            Console.WriteLine("please enter a number");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("your num is one");
            }
            else if (number == 2)
            {
                Console.WriteLine("your num is two");
            }
            else
            {
                Console.WriteLine("your number is not 1 and 2");
            }
        }

        static void SwitchCase()
        {
            Console.WriteLine(" Please enter a number");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10:
                    Console.WriteLine("your number is 10");
                    break;
                case 20:
                    Console.WriteLine("your number is 20");
                    break;
                case 30:
                    Console.WriteLine("your number is 30");
                    break;
                default:
                    Console.WriteLine("your number is 10 20 & 30");
                    break;
            }
        }

        static void SwitchCases()
        {
            Console.WriteLine(" Please enter a number");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("your number is {0}", number);
                    break;
                default:
                    Console.WriteLine("your number is 10 ,20 & 30");
                    break;
            }
        }

        static void CoffeePurchaseExample()
        {
            int totalCoffeeCost = 0;
        Start:
            Console.WriteLine("Please select your choice  : 1 - Small, 2 - Medium, 3 - Large");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    totalCoffeeCost += 1;
                    break;
                case 2:
                    totalCoffeeCost += 2;
                    break;
                case 3:
                    totalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("your choice {0} is invalid", userChoice);
                    break;
            }
        Decide:
            Console.WriteLine("Do you want to buy another coffe - Yes or NO");
            string userDecision = Console.ReadLine();

            switch (userDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("your choice {0} is invaild. Please try again...", userDecision);
                    goto Decide;
            }
            Console.WriteLine("Thank yor for shopping with us");
            Console.WriteLine("Bill Amount = {0}", totalCoffeeCost);
        }

        /// <summary>
        /// Null coalescing operator
        /// Coalescing operator returns the first non_null value from chain
        /// </summary>
        static void NullCoalescingOperator()
        {
            string firstString = null;
            string secondString = null;
            string thirdString = "thirdString";
            string fourthString = "fourthString";

            string finalString = firstString ?? secondString ?? thirdString ?? fourthString;
            Console.WriteLine(finalString);
        }
    }
}
