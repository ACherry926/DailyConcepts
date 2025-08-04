using System;

namespace Day7Concepts
{
    class MethodHidingExamples
    {
        public void MethodHidingMethod()
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "Full Time";
            fullTimeEmployee.LastName = "Employee";
            fullTimeEmployee.PrintFullName();

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.FirstName = "Part Time";
            partTimeEmployee.LastName = "Employee";
            partTimeEmployee.PrintFullName();
            //((Hiding.Employee)PTE).PrintFullName();
            //PTE.PrintFullName();
        }
        public class Employee
        {
            public string FirstName;
            public string LastName;
            public void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
        }
        public class PartTimeEmployee : Employee
        {
            public new void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + " - Contractor ");
            }
        }
        public class FullTimeEmployee : Employee
        {

        }
    }
}
