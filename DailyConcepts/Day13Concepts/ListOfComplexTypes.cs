using System;
using System.Collections.Generic;

namespace Day13Concepts
{
    class ListOfComplexTypes
    {
        public void ComplexTypes()
        {
            List<Customer> listCustomers = CustomerTestData.GetCustomers();

            Console.WriteLine("Before sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Salary);
            }

            //listCustomers.Sort();
            listCustomers.Reverse();
            Console.WriteLine("After sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Salary);
            }
        }

        public void ComplexTypesExample()
        {
            List<Customer> listCustomers = CustomerTestData.GetCustomers();

            Console.WriteLine("Before sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Salary);
            }

            //listCustomers.Sort();
            listCustomers.Reverse();
            Console.WriteLine("After sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Salary);
            }

            //CustomerSortByName sortByName = new CustomerSortByName();
            //listCustomers.Sort();
            //Console.WriteLine("sorting By Name");
            //foreach (Customer customer in listCustomers)
            //{
            //    Console.WriteLine(customer.Name);
            //}
        }

    }
}
