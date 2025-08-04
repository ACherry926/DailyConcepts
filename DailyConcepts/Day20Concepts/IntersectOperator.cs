using System;
using System.Collections.Generic;
using System.Linq;

namespace Day20Concepts
{
    public class IntersectOperator
    {
        public void IntersectOperatorExample()
        {
            List<string> datasource1 = StudentTestData.GetAlphabets();

            List<string> datasource2 = new List<string>() { "E", "F", "C", "D" };

            var methodSyntax = datasource1.Intersect(datasource2).ToList();

            Console.WriteLine(methodSyntax);
        }

        public void IntersectOperatorForMixedSyntax()
        {
            List<string> datasource1 = StudentTestData.GetAlphabets();

            List<string> datasource2 = new List<string>() { "E", "F", "C", "D" };

            var mixedSyntax = (from ch in datasource2
                               select ch).Intersect(datasource1).ToList();

            Console.WriteLine(mixedSyntax);
        }
        
        public void IntersectOperatorForMethoddSyntax()
        {
            List<Student> students = StudentTestData.GetStudentsData();

            List<Student> students2 = new List<Student>()
            {
                new Student() {Id = 1, Name ="John"},
                new Student() {Id = 2, Name ="Kim"},
                new Student() {Id = 3, Name ="John"},
                new Student() {Id = 5, Name ="Mark"},
                new Student() {Id = 6, Name ="Marsh"}
            };

            //var methodSyntax = students1.Select(s => new { s.Id, s.Name }).Intersect(students2.Select(s => new { s.Id, s.Name })).ToList();
              var methodSyntax = students.Intersect(students2, new StudentComparer()).ToList();

            Console.WriteLine(methodSyntax);
        }
    }
}
