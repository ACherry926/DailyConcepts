using System;

namespace Day2Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            LocalVariable();
            GlobalVariable();
            MaxMinValue();
            FloatDoubleDecimal();
            FloatDoubleDecimalExamples();
        }

        /// <summary>
        /// Local Variable
        /// </summary>
        static void LocalVariable()
        {
            int number = 123;
            Console.WriteLine(number);

            string name = "savar";
            Console.WriteLine(name);
        }

        // Global Variable 
        static int number = 12;
        static string name = "savar1";
        static void GlobalVariable()
        {
            Console.WriteLine(number);
            Console.WriteLine(name);
        }

        static void MaxMinValue()
        {
            int number;
            long countryPopulation;

            int maxValueOfInt = 2147483645;
            long maxValueOfLong = 9223372036854775807;

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
        }

        static void FloatDoubleDecimal()
        {
            Console.WriteLine($"Size of float is {sizeof(float)}");
            Console.WriteLine($"Max value of float is {int.MaxValue}");
            Console.WriteLine($"Min value of float is {int.MinValue}\n");

            Console.WriteLine($"Size of double is {sizeof(double)}");
            Console.WriteLine($"Max value of double is {int.MaxValue}");
            Console.WriteLine($"Min value of double is {int.MinValue}\n");

            Console.WriteLine($"Size of float is {sizeof(decimal)}");
            Console.WriteLine($"Max value of float is {decimal.MaxValue}");
            Console.WriteLine($"Min value of float is {decimal.MinValue}\n");
        }

        static void FloatDoubleDecimalExamples()
        {
            float numberOne = 23.98f;
            Console.WriteLine(numberOne);
            double numberTwo = 23.98;
            Console.WriteLine(numberTwo);
            decimal numberThree = 23.98m;
            Console.WriteLine(numberThree);
            bool isvalid = false;
            Console.WriteLine(isvalid);
            char grade = 'a';
            Console.WriteLine(grade);
            string name = "welcome to savar technologies";
            Console.WriteLine(name);
            string password = "cherry@987";
            Console.WriteLine(password);
        }
    }
    /*
       variables :-
         Syntax   :- Datatype variableName = InitialingValue

         Types :-
         Local Variable
         Global variable

       DataTypes:-
       Types:- 
          ValueType => int, long, float, double, decimal, char, boolean, byte, struct, enum, etc
          Reference => string, object, Arrays, classes, Delegates, Interface, etc

          Syntax:-
          DataType VariableName:
          Examples:-
      */
}