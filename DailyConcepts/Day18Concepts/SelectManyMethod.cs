using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18Concepts.LinqOperators
{
    public class SelectManyMethod
    {
        private static List<EmployeeClass> GetEmployees()
        {
            List<EmployeeClass> employees = new List<EmployeeClass>()
            {
                new EmployeeClass(){Id = 1, Name = "Tom", Email = "tom@gmail.com",Programming = new List<string>(){"c#" , "PHP" , "JAVA"}},
                new EmployeeClass(){Id = 2, Name = "kim", Email = "kim@gmail.com",Programming = new List<string>(){"MVC" , "Linq" , "JAVA"}},
                new EmployeeClass(){Id = 3, Name = "harry", Email = "harry@gmail.com",Programming = new List<string>(){"c#" , "VB" , "SQL"}},
            };
            return employees;
        }

        public void QuerySyntaxWithSelectManyMethod() 
        { 
            List<string> names = new List<string>() { "Nitish" , "Kaushik" };

            var queryMethod = (from name in names
                               from character in name
                               select character).ToList();
            Console.WriteLine();
        }

        public void MethodSyntaxWithSelectManyMethod()
        {
            List<string> names = new List<string>() { "Nitish", "Kaushik" };

            var methodResult = names.SelectMany(name => name).ToList();

            Console.WriteLine();
        }

        public void SelectManyMethodForMethodSyntax()
        {
            List<EmployeeClass> employees = GetEmployees();

            var MethodSyntax = employees.SelectMany(employee => employee.Programming).ToList();

            foreach (var employee in MethodSyntax)
            {
                Console.WriteLine("Programming - " + employee);
            }
        }

        public void SelectManyMethodForQuerySyntax()
        {
            List<EmployeeClass> employees = GetEmployees();

            var querySyntax = (from employee in employees
                               from skill in employee.Programming
                               select skill).ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine("Programming - " + employee);
            }
        }
    }
}
