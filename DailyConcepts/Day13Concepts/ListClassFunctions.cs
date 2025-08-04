using System;
using System.Collections.Generic;
using System.Linq;

namespace Day13Concepts
{
    class ListClassFunctions
    {
        public void ContainsFunction()
        {
            List<Customer> customer = CustomerTestData.GetCustomers();
            Customer customer3 = new Customer()
            {
                Id = 101,
                Name = "TestClass",
                Salary = 5700
            };

            if (customer.Contains(customer3))
            {
                Console.WriteLine("customer3 object exits in list");
            }
            else
            {
                Console.WriteLine("customer3 object notexits in list");
            }
        }

        public void ExistsFunction()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            if (customers.Exists(customer => customer.Name.StartsWith("T")))
            {
                Console.WriteLine("customer3 object exits in list");
            }
            else
            {
                Console.WriteLine("customer3 object notexits in list");
            }
        }

        public void FindFunction()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            Customer c = customers.Find(customer => customer.Salary > 5000);
            Console.WriteLine("ID = {0},Name = {1}, Salary {2}", c.Id, c.Name, c.Salary);
        }

        public void FindLastFunction()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            Customer c = customers.FindLast(customer => customer.Salary > 5000);
            Console.WriteLine("ID = {0},Name = {1}, Salary {2}", c.Id, c.Name, c.Salary);
        }

        public void FindAllFunction()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            List<Customer> cutomers = customers.FindAll(customer => customer.Salary > 5000);
            foreach (Customer customer in cutomers)
            {
                Console.WriteLine("ID = {0},Name = {1}, Salary {2}", customer.Id, customer.Name, customer.Salary);
            }
        }

        public void FindIndexFunction()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            int index = customers.FindIndex(customer => customer.Salary > 5000);
            Console.WriteLine("Index = " + index);
        }

        public void FindLastIndexFunction()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            int index = customers.FindLastIndex(customer => customer.Salary > 5000);
            Console.WriteLine("Index = " + index);
        }

        public void ConvertAnArrayToList()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            List<Customer> customer = customers.ToList();
            foreach (Customer customers1 in customer)
            {
                Console.WriteLine("ID = {0},Name = {1}, Salary {2}", customers1.Id, customers1.Name, customers1.Salary);
            };
        }

        public void ConvertAnArrayToArray()
        {
            List<Customer> customers1 = CustomerTestData.GetCustomers();

            Customer[] customers = customers1.ToArray();

            foreach (Customer customer in customers1)
            {
                Console.WriteLine("ID = {0},Name = {1}, Salary {2}", customer.Id, customer.Name, customer.Salary);
            };
        }

        public void ConvertAnArrayToDictionary()
        {
            List<Customer> customers = CustomerTestData.GetCustomers();

            Dictionary<int, Customer> dictionary = customers.ToDictionary(x => x.Id);

            foreach (KeyValuePair<int, Customer> kvp in dictionary)
            {
                Console.WriteLine("Key = " + kvp.Key);
                Customer customer = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.Id, customer.Name, customer.Salary);
            }
        }
    }
}
