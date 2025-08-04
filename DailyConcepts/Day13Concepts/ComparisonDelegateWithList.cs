using System;
using System.Collections.Generic;

namespace Day13Concepts
{
    class ComparisonDelegateWithList
    {
        public void ComparisonDelegateWithListMethod()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            Console.WriteLine("Before Sorting");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
            }

            customers.Sort((x, y) => x.Id.CompareTo(y.Id));
            
            Console.WriteLine("After Sorting");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
            }
        }
    }
}
