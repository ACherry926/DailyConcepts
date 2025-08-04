using System;

namespace Day8Concepts
{
    class Structure
    {
        public void Structuresmethod()
        {
            //Constructor
            Customer customer = new Customer(101, "mark");
            customer.PrintDetails();
            //Default Constructor
            Customer customer1 = new Customer();
            customer1.Id = 120;
            customer1.Name = "john";
            customer1.PrintDetails();

            Customer customer2 = new Customer
            {
                Id = 106,
                Name = "Aravind"
            };
            customer2.PrintDetails();
        }
        public class Customer
        {
            private int _id;
            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public int Id
            {
                get
                {
                    return this._id;
                }
                set
                {
                    this._id = value;
                }
            }
            public Customer(int Id, string Name)
            {
                this.Id = Id;
                this.Name = Name;
            }

            public Customer()
            {
            }

            public void PrintDetails()
            {
                Console.WriteLine("Id = {0} && = {1}", this._id, this._name);
            }
        }
    }
}
