using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18Concepts.LinqOperators
{
    public class SelectMethod
    {
        private static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Tom", Email = "tom@gmail.com"},
                new Employee(){Id = 2, Name = "John", Email = "john@gmail.com"},
                new Employee(){Id = 3, Name = "mark", Email = "mark@gmail.com"},
                new Employee(){Id = 4, Name = "kim", Email = "kim@gmail.com"},
                new Employee(){Id = 5, Name = "Adam", Email = "adam@gmail.com"},
            };
            return employees;
        }

        public void QuerySyntaxWithComplexType()
        {
            List<Employee> employees = GetEmployees();

            var querySyntax = (from employee in employees
                              select employee).ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine($"Id = {employee.Id}, Name = {employee.Name}");
            }
        }

        public void MethodSyntaxWithComplexType()
        {
            List<Employee> employees = GetEmployees();

            var methodSyntax = employees.ToList();

            foreach (var employee in methodSyntax)
            {
                Console.WriteLine($"Id = {employee.Id}, Name = {employee.Name}, Email = {employee.Email}");
            }
        }

        /// <summary>
        /// Operations
        /// </summary>
        public void QuerySyntaxOperationWithComplexType()
        {
            List<Employee> employees = GetEmployees();

            var querySyntax = (from employee in employees
                               select employee.Id).ToList();
            //var querySyntax = (from employee in employees
            //                   select employee.Id.ToString).ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine($"Id = {employee}");
            }
        }

        public void MethodSyntaxOperationWithComplexType()
        {
            List<Employee> employees = GetEmployees();

            var methodSyntax = employees.Select (employee => employee.Name).ToList();

            foreach (var employee in methodSyntax)
            {
                Console.WriteLine($"Name = {employee}");
            }
        }

        public void SelectQuerySyntaxWithComplexType()
        {
            List<Employee> employees = GetEmployees();

            var selectQuerySyntax = (from employee in employees
                                     select new Employee()
                                     {
                                         Id = employee.Id,
                                         Email = employee.Email,
                                     }).ToList();
           

            foreach (var employee in selectQuerySyntax)
            {
                Console.WriteLine($"Id = {employee.Id}, Name = {employee.Name}, Email = {employee.Email}");
            }
        }

        public void MethodSyntaxWithSelectDataToOtherClasss()
        {
            List<Employee> employees = GetEmployees();

            var methodSyntax = employees.Select(employee => new Student()
                               {
                                   StudentId = employee.Id,
                                   StudentName = employee.Name,
                                   StudentEmail = employee.Email,
                               }).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine($"Id = {student.StudentId}, Name = {student.StudentName}, Email = {student.StudentEmail}");
            }
        }

        public void QuerySyntaxWithSelectDataToOtherClasss()
        {
            List<Employee> employees = GetEmployees();

            var querySyntax = (from employee in employees
                               select new Student()
                               {
                                   StudentId = employee.Id,
                                   StudentName = employee.Name,
                                   StudentEmail = employee.Email,
                               }).ToList();

            foreach (var student in querySyntax)
            {
                Console.WriteLine($"Id = {student.StudentId}, Name = {student.StudentName}, Email = {student.StudentEmail}");
            }
        }
    }
}
