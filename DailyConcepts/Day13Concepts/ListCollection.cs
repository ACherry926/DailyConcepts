using System;
using System.Collections.Generic;

namespace Day13Concepts
{
    class ListCollectionClass
    {
        public void DisplayCustomerData()
        {
            List<Customer> listCustomers = CustomerTestData.GetCustomers();
           
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0},Name = {1}, Salary {2}",c.Id,c.Name,c.Salary);
            }
        }
    }
}
