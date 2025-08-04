using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19Concepts
{
    public class OrderByDescending
    {
        public void MethodSyntaxExample()
        {
            List<int> numbers = EmployeeTestData.GetNumbers();

            var methodSyntax = numbers.OrderByDescending(number => number).ToList();
            //var methodSyntax = dataSourceInt.Where(num => num > 10).OrderByDescending(number => number).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void QuerySyntaxExample()
        {
            List<int> numbers = EmployeeTestData.GetNumbers();

            var querySyntax = (from number in numbers
                               where number > 20
                               orderby number descending
                               select number).ToList();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void SortedOrderForMethodSyntax()
        {
            List<string> names = EmployeeTestData.GetNames();

            var methodSyntax = names.OrderByDescending(name => name).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void SortedOrderForQuerySyntax()
        {
            List<string> names = EmployeeTestData.GetNames();

            var querySyntax = (from name in names
                               orderby name descending
                               select name).ToList();

            foreach (var name in querySyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void NonSortedOrderForMethodSyntax()
        {
            List<Employee> employees = EmployeeTestData.GetEmployees();

            var methodSyntax = employees.OrderByDescending(employee => employee.Name).ToList();

            foreach (var employee in methodSyntax)
            {
                Console.WriteLine($"{employee.Id}, name = {employee.Name}, Email = {employee.Email}");
            }
        }

        public void NonSortedOrderForQuerySyntax()
        {
            List<Employee> employees = EmployeeTestData.GetEmployees();

            var querySyntax = (from employee in employees
                               orderby employee.Id descending
                               select employee).ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine($"{employee.Id}, name = {employee.Name}, Email = {employee.Email}");
            }
        }
    }
}
