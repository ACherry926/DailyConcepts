using System;

namespace Day8Concepts
{
    class ClassVsStructure
    {
        public void ClassVsStructuresMethod()
        {
            int number1 = 10;
            int number2 = number1;
            number2 = number2 + 1;

            Console.WriteLine("number1 = {0} && number2 = {1}", number1, number2);

            Customer customerOne = new Customer();
            customerOne.Id = 101;
            customerOne.Name = "Cherry";

            Customer customerTwo = customerOne;
            customerTwo.Name = "Cherry";
            Console.WriteLine("customerOne.Name = {0} && customerTwo.Name ={1}", customerOne.Name, customerTwo.Name);
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
