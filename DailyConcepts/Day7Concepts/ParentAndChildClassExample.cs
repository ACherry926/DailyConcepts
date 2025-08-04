using System;

namespace Day7Concepts
{
    class EmployeeExampleClass
    {
        public void EmployeeExampleMethod()
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "pragim";
            fullTimeEmployee.LastName = "Tech";
            fullTimeEmployee.YearlySalary = 50000;
            fullTimeEmployee.PrintFullName();

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.FirstName = "Part";
            partTimeEmployee.LastName = "Time";
            partTimeEmployee.PrintFullName();
        }
        public class Employee
        {
            public string FirstName;
            public string LastName;
            public string Email;
            public void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
        }
        public class FullTimeEmployee : Employee
        {
            public float YearlySalary;
        }
        public class PartTimeEmployee : Employee
        {
            public float HalflySalary;
        }

        public void ParentAndChildClassMethod()
        {
            ChildClass childClass = new ChildClass();
        }
        public class ParentClass
        {
            public ParentClass()
            {
                Console.WriteLine("ParentClass Construcor called");
            }
            public ParentClass(string Message)
            {
                Console.WriteLine(Message);
            }

        }
        public class ChildClass : ParentClass
        {
            public ChildClass() : base("Derived class Controlling parent Class")
            {
                Console.WriteLine("ChildClass Constructor called");
            }
        }
    }
}
