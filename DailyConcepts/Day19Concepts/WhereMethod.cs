using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19Concepts
{
    public class WhereMethod
    {
        public void WhereOperatorForQuerySyntax()
        {
            List<int> numbers = EmployeeTestData.GetNumbersList();

            var querySyntax = (from number in numbers
                               where number <= 5 || number > 9
                               select number).ToList();

            Console.WriteLine(querySyntax);
        }

        public void WhereOperatorForMethodSyntax()
        {
            List<int> numbers = EmployeeTestData.GetNumbersList();

            var methodSyntax = numbers.Where(number => number > 5).ToList();

            Console.WriteLine(methodSyntax);
        }

        public void WhereOperatorForQuerySyntaxStringExample()
        {
            List<string> names = GetNames();

            var querySyntax = (from name in names
                               where name == "Tom" || name.Length > 4
                               select name).ToList();

            Console.WriteLine(querySyntax);
        }

        public void WhereOperatorForMethodSyntaxStringExample()
        {
            List<string> names = GetNames();

            var methodSyntax = names.Where(name => name.Length > 5 || name == "Tom").ToList();

            Console.WriteLine(methodSyntax);
        }

        public void WhereOperatorForQuerySyntaxComplexExample()
        {
            List<Employee> employees = GetEmployees();

            var querySyntax = (from employee in employees
                               where employee.Programing.Count == 0
                               select employee).ToList();

            Console.WriteLine(querySyntax);
        }

        public void WhereOperatorForMethodSyntaxComplexExample()
        {
            List<Employee> employees = GetEmployees();

            var methodSyntax = employees.Where(employee => employee.Programing.Count > 3 || employee.Name == "Kim").ToList();

            Console.WriteLine(methodSyntax);
        }

        private static List<string> GetNames()
        {
            var names = new List<string>() { "Tom", "Harry", "Adam", "ponting", "sachin" };
            return names;
        }

        private static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1, Name = "Tom", Email = "tom@gmail.com", Programing = new List<Techs>{
                    new Techs(){Technology = "C#"},
                    new Techs(){Technology = "Java"},
                    new Techs(){Technology = ".Net"},
                    new Techs(){Technology = "PHP"},
                    new Techs(){Technology = "SQl"}
                    }
                },
                new Employee()
                {
                    Id = 2, Name = "John", Email = "john@gmail.com", Programing = new List<Techs>
                {
                    new Techs(){Technology = "C#"},
                    new Techs(){Technology = "Java"},
                    new Techs(){Technology = ".Net"}
                }
                },
                new Employee()
                {
                    Id = 3, Name = "Mark", Email = "mark@gmail.com", Programing = new List<Techs>
                {
                    new Techs(){Technology = "Linq"},
                    new Techs(){Technology = "MVC"},
                }
                },
                new Employee() { Id = 4, Name = "Kim", Email = "kim@gmail.com", Programing = new List<Techs>() },
                new Employee() { Id = 5, Name = "Adam", Email = "adam@gmail.com", Programing = new List<Techs>() }
            };
            return employees;
        }
    }
}
