using System;

namespace Day1Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLineExamples();
            WriteLineExamplesCodeOptimise();
            WriteLineExample();
            VariableExample();
            StringConcatenationReadLine();
            Interpolation();
            PlaceHolderSyntax();
            ReadExample();
        }

        static void WriteLineExamples()
        {
            int number = 12345;
            string name = "Savar Technologies";
            Console.WriteLine(number);
            Console.WriteLine(name);
        }

        static void WriteLineExamplesCodeOptimise()
        {
            Console.WriteLine(12345);
            Console.WriteLine("Savar Technologies");
        }

        static void WriteLineExample()
        {
            Console.WriteLine("Savar");
            Console.WriteLine("Technologies");

            Console.WriteLine("--------");

            Console.Write("Savar");
            Console.WriteLine("Technologies");
            Console.WriteLine("Hello");
        }

        static void VariableExample()
        {
            int userNumber = 1234;
            Console.WriteLine(userNumber);

            string userName = "savar";
            Console.WriteLine(userName);
        }

        static void StringConcatenationReadLine()
        {
            Console.WriteLine("Please Enter FirstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter LastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter FirstName is " + firstName + " and LastName is " + lastName);
        }

        static void Interpolation()
        {
            Console.WriteLine("Please Enter FirstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter LastName");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Enter FirstName is {firstName} and LastName is {lastName} ");
        }

        static void PlaceHolderSyntax()
        {
            Console.WriteLine("Please Enter FirstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter LastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter FirstName is {0} and LastName is {1} ", firstName, lastName);
        }

        static void ReadExample()
        {
            Console.WriteLine("please enter Character");
            int value = Console.Read();
            Console.WriteLine(value);
        }
    }
    /* 
        WriteLine => It will print the next output into the next line
        Write     => It will print the output into the same Line

        ReadLine  => ReadLine Method is used to Read the Group of Charcters from the i/p stream
                         and it read string value
        Read      => Read Method is used to Read the Single Character from the i/p stream
                         It Reads ASCi Value of character
                         It returs integer value
    */
}
