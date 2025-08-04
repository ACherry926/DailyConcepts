using System;           

namespace ClassIntroduction
{
   class Customer
   {
        string firstName;
        string lastName;
        public Customer()
            : this("No FirstName Provided", "No LastName Provided")
        {
        }
        public Customer(string FirstName, string LastName)
        { 
            this.firstName = FirstName;
            this.lastName = LastName;
        }
        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}",this.firstName + " " + this.lastName);
        }
        ~Customer()
        {
            //Clean up code
        }
   }

    class Circle
    {
        float Pi = 3.141F;
        int Radius;
        public Circle(int Radius)
        {
            this.Radius = Radius;
        }
        public float CalculateArea()
        { 
            return this.Pi * this.Radius * this.Radius;
        }
    }

    class Circle1
    {
        static float Pi;
        int Radius;
        static Circle1()
        {
            Console.WriteLine("static Constructor called");
            Circle1.Pi = 3.141F;
        }
        public Circle1(int Radius)
        {
            Console.WriteLine("Instsnce Constructor called");
            this.Radius = Radius;
        }
        public float CalculateArea()
        {
            return Circle1.Pi * this.Radius * this.Radius;
        }
    }
}
