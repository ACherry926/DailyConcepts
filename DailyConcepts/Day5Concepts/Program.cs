using System;

namespace Day5Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            WhileLoop();
            DoWhileLoop();
            CoffeePurchaseExample();
            ForLoopExample();
            BreakExample();
            ContinueExample();
            EvenNumber(30);
            AddNumbers();
            PramsMethods();
            SimpleMethod();
            Calculate();
        }

        static void WhileLoop()
        {
            Console.WriteLine("please enter your Target?");
            int userTarget = int.Parse(Console.ReadLine());

            int currentNumber = 0;

            while (currentNumber <= userTarget)
            {
                Console.Write(currentNumber + " ");
                currentNumber = currentNumber + 2;                                  
            }
        }

        static void DoWhileLoop()
        {
            string UserChoice = string.Empty;
            do
            {
                Console.WriteLine("please enter your Target?");
                int UserTarget = int.Parse(Console.ReadLine());

                int currentNumber = 0;

                while (currentNumber <= UserTarget)
                {
                    Console.Write(currentNumber + " ");
                    currentNumber = currentNumber + 2;
                }
                do
                {
                    Console.WriteLine("Do you want to continue - YES or NO");
                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice, please say YES or NO");
                    }
                }
                while (UserChoice != "YES" && UserChoice != "NO");
            }
            while (UserChoice == "YES");
        }

        static void CoffeePurchaseExample()
        {
            int totalCoffeeCost = 0;
            string userDecision = string.Empty;
            do
            {
                int userChoice = -1;
                do
                {
                    Console.WriteLine("Please select your choice  : 1 - Small, 2 - Medium, 3 - Large");
                    userChoice = int.Parse(Console.ReadLine());
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
                }
                while (userChoice != 1 && userChoice != 2 && userChoice != 3);
                do
                {
                    Console.WriteLine("Do you want to buy another coffee - Yes or NO");
                    userDecision = Console.ReadLine().ToUpper();
                    if (userDecision != "YES" && userDecision != "NO")
                    {
                        Console.WriteLine("your choice {0} is invaild. Please try again...", userDecision);
                    }
                }
                while (userDecision != "YES" && userDecision != "NO");
            }
            while (userDecision.ToUpper() != "NO");
            Console.WriteLine("Thank yor for shopping with us");
            Console.WriteLine("Bill Amount = {0}", totalCoffeeCost);
        }

        static void ForLoopExample()
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine(numbers[index]);
            }

            int counter = 0;
            while (counter < numbers.Length)
            {
                Console.WriteLine(numbers[counter]);
                counter++;
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void BreakExample()
        {
            for (int number = 1; number <= 20; number++)
            {
                Console.WriteLine(number);
                if (number == 10)
                    break;
            }
        }

        static void ContinueExample()
        {
            for (int number = 1; number <= 20; number++)
            {
                if (number % 2 == 1)
                    continue;
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Instance Methods
        /// </summary>
        class Employee
        {
            public int Add(int firstName, int secondNumber)
            {
                return firstName + secondNumber;
            }
        }
        static void AddNumbers()
        {
            Employee employee = new Employee();
            int Sum = employee.Add(30, 20);
            Console.WriteLine("Sum = {0}", Sum);
        }
        

        public static void EvenNumber(int target)
        {
            int start = 0;
            while (start <= target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        public static void SimpleMethod(ref int number)
        {
            number = 154;
        }
        static void SimpleMethod()
        {
            int number1 = 0;
            SimpleMethod(ref number1);
            Console.WriteLine(number1);
        }

        public static void Calculate(int firstNumber, int seconNumber, out int Sum, out int Product)
        {
            Sum = firstNumber + seconNumber;
            Product = firstNumber * seconNumber;
        }
        static void Calculate()
        {
            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);
            Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);
        }

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements", Numbers.Length);
            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }
        }
        static void PramsMethods()
        {
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
            ParamsMethod(Numbers);
        }
    }
}
