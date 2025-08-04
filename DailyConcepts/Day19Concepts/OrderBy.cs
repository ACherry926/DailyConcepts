using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19Concepts
{
    public class OrderBy
    {
        public void QuerySyntaxExample()
        {
            List<int> numbers = EmployeeTestData.GetNumbers();

            var querySyntax = (from number  in numbers
                               where number > 10
                               orderby number
                               select number).ToList();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void MethodSyntaxExample()
        {
            List<int> numbers = EmployeeTestData.GetNumbers();

            var methodSyntax = numbers.Where(number => number > 10).OrderBy(number => number).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void SortedOrderForMethodSyntax()
        {
            List<string> names = EmployeeTestData.GetNames();

            var methodSyntax = names.OrderBy(name => name).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }
        
        public void SortedOrderForQuerySyntax()
        {
            List<string> names = EmployeeTestData.GetNames();

            var querySyntax = (from name in names
                               where name.Length > 6
                              orderby name
                              select name).ToList();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void NonSortedForOrderByQuerySyntax()
        {
            List<Employee> employees = EmployeeTestData.GetEmployees();

            var querySyntax = (from employee in employees
                               where employee.Id > 2
                               orderby employee.Name
                               select employee).ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine(employee);
            }
        }

        public void NonSortedForOrderByMethodSyntax()
        {
            List<Employee> employees = EmployeeTestData.GetEmployees();

            var methodSyntax = employees.OrderBy(employee => employee.Name).ToList();

            foreach (var employee in methodSyntax)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
