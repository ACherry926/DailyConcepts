using System;
using System.Collections.Generic;
using System.Linq;

namespace Day20Concepts
{
    public class ExceptOperator
    {
        public void ExceptOperatorExample()
        {
            List<string> datasource1 = StudentTestData.GetAlphabets();

            List<string> datasource2 = new List<string>() { "E", "F", "C", "D" };

            var methodSyntax = datasource1.Except(datasource2).ToList();

            Console.WriteLine(methodSyntax);
        }

        public void ExceptOperatorForMethodSyntax()
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

            //var MethodSyntax = students.Select(s => s.Name).Except(students1.Select(s => s.Name)).ToList();
            var MethodSyntax = students.Except(students1).ToList();
            //var MethodSyntax = students.Except(students1, new StudentComparer()).ToList();

            Console.WriteLine(MethodSyntax);
        }

        public void ExceptOperatorForQuerySyntax()
        {
            List<Student> students = StudentTestData.GetStudentsData();

            List<Student> students1 = new List<Student>()
            {
                new Student() {Id = 1, Name ="John"},
                new Student() {Id = 7, Name ="Kim"},
                new Student() {Id = 3, Name ="John"},
                new Student() {Id = 5, Name ="Mark"},
                new Student() {Id = 6, Name ="Marsh"}
            };

            var querySyntax =(from  student in students
                              select student).Except(students1, new StudentComparer()).ToList();

            Console.WriteLine(querySyntax);
        }
    }
}
