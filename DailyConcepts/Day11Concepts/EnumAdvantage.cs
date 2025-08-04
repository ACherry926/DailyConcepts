using System;

namespace Day11Concepts
{
    /// <summary>
    /// Enums are strongly typed Constants 
    /// Readable / Maintainable
    /// </summary>
    public class EnumAdvantages
    {
        public void EnumAdvantageMethod()
        {
            Customer1[] customers = new Customer1[3];
            customers[0] = new Customer1
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            customers[1] = new Customer1
            {
                Name = "Mary",
                Gender = Gender.Female
            };
            customers[2] = new Customer1
            {
                Name = "Sam",
                Gender = Gender.UnKnown
            };
            foreach (Customer1 customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, customer.Gender);
            }
        }
        public string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.UnKnown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }

    }
    public enum Gender
    {
        UnKnown,
        Male,
        Female
    }

    public class Customer1
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
