using System;

namespace Day10Concepts
{
    /// <summary>
    /// Convert.ToString() And ToString()
    /// convert.ToString() handles null, while ToString() doesn't and throws a Null reference exception
    /// </summary>
    class ConvertToString
    {
        public void ConvertToStringAndToString()
        {
            Customer customer = new Customer();
            string firstValue = Convert.ToString(customer);
            Console.WriteLine(firstValue);
        }
        public class Customer
        {
            public string Name { get; set; }
        }
    }
}
