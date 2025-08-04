using System;
using System.Collections.Generic;

namespace Day13Concepts
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class CorporateCustomer : Customer
    {
        public string Type { get; set; }
    }

    public class CustomerComparable : Customer, IComparable<CustomerComparable>
    {
        public int CompareTo(CustomerComparable other)
        {
           return this.Salary.CompareTo(other.Salary);
        }
    }

    public class CustomerSortByName : IComparer<CustomerComparable>
    {
        public int Compare(CustomerComparable x, CustomerComparable y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
