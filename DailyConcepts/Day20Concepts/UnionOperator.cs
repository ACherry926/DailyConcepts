using System;
using System.Collections.Generic;
using System.Linq;

namespace Day20Concepts
{
    public class unionOperator
    {
        public void unionOperatorExample()
        {
            List<string> datasource1 = StudentTestData.GetAlphabets(); 

            List<string> datasource2 = new List<string>() { "E", "F", "C", "D" };

            var methodSyntax = datasource1.Union(datasource2).ToList();

            Console.WriteLine(methodSyntax);
        }

        public void unionOperatorForMethodSyntax()
        {
            List<Student> students = StudentTestData.GetStudentsData();

            List<Student> students1 = new List<Student>()
            {
                new Student() {Id = 1, Name ="John"},
                new Student() {Id = 2, Name ="Kim"},
                new Student() {Id = 3, Name ="John"},
                new Student() {Id = 5, Name ="Mark"},
                new Student() {Id = 6, Name ="Marsh"}
            };

            //var MethodSyntax = students1.Union(students2).ToList();
            var MethodSyntax = students.Union(students1, new StudentComparer()).ToList();

            Console.WriteLine(MethodSyntax);
        }
    }
}
