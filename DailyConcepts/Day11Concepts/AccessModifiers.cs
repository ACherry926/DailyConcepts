using System;

namespace Day11Concepts
{
    class AccessModifierExample
    {
        public void AccessModifiermethod()
        {
            Customer modifiers = new Customer();
            Console.WriteLine(modifiers.Id);
        }

        /// <summary>
        /// Public members will be accessble in Anyware
        /// private memebers are accessble in same class Itself
        /// Default Access modifiers for Type Member is Private
        /// </summary>
        public class Customer
        {
            private int _id;
            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }
            protected string Name;
        }

        /// <summary>
        /// Protected members are accessble in derived class
        /// </summary>
        public class CorporateCustomer : Customer
        {
            public void PrintName()
            {
                CorporateCustomer corporateCustomer = new CorporateCustomer();
                corporateCustomer.Name = "Aravind";
                corporateCustomer.Id = 1;
                //base.Name = CC.Name;
                //this.Name = CC.Name;
            }

        }
    }
}
