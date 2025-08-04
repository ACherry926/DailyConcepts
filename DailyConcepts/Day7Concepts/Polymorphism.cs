using System;

namespace Day7Concepts
{
    class PolymorphismExample
    {
        public void PolymorphismMethod()
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee employee in employees)
            {
                employee.PrintFullName();
            }

        }
        public class Employee
        {
            public string FirstName = "FirstName";
            public string LastName = "LastName";
            public virtual void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
        }
        public class PartTimeEmployee : Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + " - Part Time");
            }
        }
        public class FullTimeEmployee : Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + " - Full Time");
            }
        }
        public class TemporaryEmployee : Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + " - Temporary Time");
            }

        }

        public void MethodOverridingAndHidingExampleMethod()
        {
            BaseClass baseClass = new DerivedClass();
            baseClass.Print();

            BaseClass1 baseClass1 = new DerivedClass1();
            baseClass1.Print();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Print();
        }

        public class BaseClass
        {
            public virtual void Print()
            {
                Console.WriteLine("I am a Base Print Method");
            }
        }
        public class DerivedClass : BaseClass
        {
            public override void Print()
            {
                Console.WriteLine("I am a Derived class print Method");

            }
        }

        public class BaseClass1
        {
            public virtual void Print()
            {
                Console.WriteLine("I am a Base Print Method");
            }
        }
        public class DerivedClass1 : BaseClass1
        {
            public new void Print()
            {
                Console.WriteLine("I am a Derived class print Method");
            }
        }
    }
}
