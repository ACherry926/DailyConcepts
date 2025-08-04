using System.Collections.Generic;

namespace Day13Concepts
{
    public class CustomerTestData
    {
        public static List<Customer> GetCustomers()
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Test",
                Salary = 5000,
            };
            Customer customer2 = new Customer()
            {
                Id = 105,
                Name = "TestObj",
                Salary = 5400
            };
            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "TestClas",
                Salary = 5700
            };
            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            return listCustomers;
        }

        public static List<CorporateCustomer> GetCorporateCustomer()
        {
            CorporateCustomer customer1 = new CorporateCustomer()
            {
                Id = 101,
                Name = "Test",
                Salary = 5000,
                Type = "RetailCustomer"
            };
            CorporateCustomer customer2 = new CorporateCustomer()
            {
                Id = 110,
                Name = "TestObj",
                Salary = 6500,
                Type = "RetailCustomer"
            };
            CorporateCustomer customer3 = new CorporateCustomer()
            {
                Id = 119,
                Name = "TestClass",
                Salary = 3500,
                Type = "RetailCustomer"
            };

            List<CorporateCustomer> listCustomers = new List<CorporateCustomer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);
          
            return listCustomers;
        }
    }
}
