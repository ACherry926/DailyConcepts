using System;

namespace Day11Concepts
{
    /// <summary>
    /// Enums are strongly typed Constants 
    /// </summary>
    public class EnumsClass
    {
        public void EnumMethod()
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = 1
            };
            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = 2
            };
            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = 0
            };
            foreach(Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name , customer.Gender);
            }
        }

        public string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";

            }
        }

    }

    // 0 - UnKnown
    // 1 - Male
    // 2 - Female
    public class Customer
    { 
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
