using System;
using System.Collections.Generic;

namespace Day13Concepts
{
    class ListClassRanges
    {
        public void AddRangeExample()
        {
            List<CorporateCustomer> listCustomers = CustomerTestData.GetCorporateCustomer();

            CorporateCustomer customer4 = new CorporateCustomer()
            {
                Id = 119,
                Name = "TestClas",
                Salary = 3500,
                Type = "CorporateCustomer"
            };
            CorporateCustomer customer5 = new CorporateCustomer()
            {
                Id = 119,
                Name = "TestClas",
                Salary = 3500,
                Type = "CorporateCustomer"
            };

            List<CorporateCustomer> listCorporateCustomers = new List<CorporateCustomer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            listCustomers.AddRange(listCorporateCustomers);

            foreach (CorporateCustomer C in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", C.Id, C.Name, C.Salary, C.Type);
            }
        }

        public void GetRangeExample()
        {
            List<CorporateCustomer> listCustomers = CustomerTestData.GetCorporateCustomer();

            CorporateCustomer customer4 = new CorporateCustomer()
            {
                Id = 119,
                Name = "TestClas",
                Salary = 3500,
                Type = "CorporateCustomer"
            };
            CorporateCustomer customer5 = new CorporateCustomer()
            {
                Id = 119,
                Name = "TestClas",
                Salary = 3500,
                Type = "CorporateCustomer"
            };

            List<CorporateCustomer> listCorporateCustomers = new List<CorporateCustomer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            listCustomers.AddRange(listCorporateCustomers);

            List<CorporateCustomer> customers = listCustomers.GetRange(0, 3);
            //List<CorporateCustomer> customers = listCustomers.GetRange(3, 2);

            foreach (CorporateCustomer C in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", C.Id, C.Name, C.Salary, C.Type);
            }
        }

        public void InsertRangeExample()
        {
            List<CorporateCustomer> listCustomers = CustomerTestData.GetCorporateCustomer();

            CorporateCustomer customer4 = new CorporateCustomer()
            {
                Id = 119,
                Name = "TestClas",
                Salary = 3500,
                Type = "CorporateCustomer"
            };
            CorporateCustomer customer5 = new CorporateCustomer()
            {
                Id = 119,
                Name = "TestClas",
                Salary = 3500,
                Type = "CorporateCustomer"
            };
            CorporateCustomer customer6 = new CorporateCustomer()
            {
                Id = 159,
                Name = "TestClas",
                Salary = 3500,
                Type = "CorporateCustomer"
            };

            List<CorporateCustomer> listCorporateCustomers = new List<CorporateCustomer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);
            listCorporateCustomers.Add(customer6);

            listCustomers.InsertRange(0, listCorporateCustomers);
            //listCustomers.InsertRange(3, listCorporateCustomers);

            foreach (CorporateCustomer C in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", C.Id, C.Name, C.Salary, C.Type);
            }

        }

        public void RemoveRangeExample()
        {
            List<CorporateCustomer> listCustomers = CustomerTestData.GetCorporateCustomer();

            CorporateCustomer customer4 = new CorporateCustomer()
            {
                Id = 119,
                Name = "TestClas",
                Salary = 3500,
                Type = "CorporateCustomer"
            };
            CorporateCustomer customer5 = new CorporateCustomer()
            {
                Id = 119,
                Name = "TestClas",
                Salary = 3500,
                Type = "CorporateCustomer"
            };

            List<CorporateCustomer> listCorporateCustomers = new List<CorporateCustomer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            //listCustomers.InsertRange(0, listCorporateCustomers);
            listCustomers.InsertRange(3, listCorporateCustomers);

            //listCustomers.Remove(customer1);
            //listCustomers.RemoveAt(4);
            //listCustomers.RemoveAll(x => x.Type == "CorporateCustomer");
            listCustomers.RemoveRange(0, 3);

            foreach (CorporateCustomer C in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", C.Id, C.Name, C.Salary, C.Type);
            }
        }
    }
}

