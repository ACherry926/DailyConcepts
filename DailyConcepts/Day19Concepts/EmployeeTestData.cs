using System.Collections.Generic;

namespace Day19Concepts
{
    public class EmployeeTestData
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            {
                new Employee()
                {
                    Id = 3,
                    Email = "Smith@gmail.com",
                    Name = "Smith"
                };
                new Employee()
                {
                    Id = 2,
                    Email = "Thomas@gmail.com",
                    Name = "Thomas"
                };
                new Employee()
                {
                    Id = 1,
                    Email = "Allen@gmail.com",
                    Name = "Allen"
                };
                new Employee()
                {
                    Id = 4,
                    Email = "Anderoson@gmail.com",
                    Name = "Anderoson"
                };
            }
            return employees;
        }

        public static List<string> GetNames()
        {
            var dataSourceString = new List<string>()
            {
              "Smith",
              "Anderson",
              "Wright",
              "Mitchel",
              "Thomos",
              "Allen",
              "Evans",
              "Collins"
            };
            return dataSourceString;
        }

        public static List<int> GetNumbers()
        {
            var numbers = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };
            return numbers;
        }

        public static List<int> GetNumbersList()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            return numbers;
        }
    }
}
