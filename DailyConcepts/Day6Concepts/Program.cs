using System;
using employee = Day6Concepts.EmployeeManagement.v2;
using student = StudentManagement;
using Day6Concepts.EmployeeManagement.v2.Payrole;
using ClassIntroduction;

namespace Day6Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeDepartment();
            StudentDepartment();
            Payrole();
            Constructor();
            InstanceMembers();
            StaticMembers();
        }

        static void EmployeeDepartment()
        {
            employee.Department employeeDepartment = new employee.Department();
            employeeDepartment.DisplayDepartmentInfo();
        }

        static void StudentDepartment()
        {
            student.Department studentDepartment = new student.Department();
            studentDepartment.DisplayDepartmentInfo();
        }

        static void Payrole()
        {
            Payrole payrole = new Payrole();
            payrole.DisplayPayroleInfo();
        }

        static void Constructor()
        {
            Customer circle1 = new Customer();
            circle1.PrintFullName();
            Customer circle2 = new Customer("P", "T");
            circle2.PrintFullName();
        }

        static void InstanceMembers()
        {
            Circle circle1 = new Circle(5);
            float Area = circle1.CalculateArea();
            Console.WriteLine("Area = {0}", Area);
        }

        static void StaticMembers()
        {
            Circle1 circle1 = new Circle1(5);
            float Area = circle1.CalculateArea();
            Console.WriteLine("Area = {0}", Area);

            Circle1 circle2 = new Circle1(7);
            float Area1 = circle2.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);
        }

        /*
        class TestClass
        {
            
             NameSpaces?
             ------------------------
             Classes, Structers, Interfaces

             Syntax:-
             ------------------------
             namespace <NameSpaceName>
             {
               Classes
               Structers
               Interfaces
             }
            class TestClass
            {
            }
            struct Product
            {
            }
            interface IEmployee
            {
            }
            
        }
        */
    }
}
