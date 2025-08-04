using System;
using System.Collections.Generic;
using System.Linq;

namespace Day20Concepts
{
    public class ContainsMethod
    {       
        public void ContainsOperatorExample()
        {
            List<string> students = GetStudentsNames();

            var isExist = students.AsEnumerable().Contains("Nitish");

            Console.WriteLine(isExist);
        }

        public void ContainsOperatorForQuerySyntax()
        {
            List<string> students = GetStudentsNames();

            var isExistUsingQuery = (from student in students
                                     select student).Contains("Simon");

            Console.WriteLine(isExistUsingQuery);
        }

        public void ContainsOperatorForQuerySyntaxExample()
        {
            List<Student> students = GetStudent();

            //var isExist = students.Contains(new Student() { Id = 1, Name = "Kim" }); //False

            var student = new Student() { Id=1, Name="Kim"};

            students.Add(student);

            var isExist = students.Contains(student);

            Console.WriteLine(isExist);
            Console.ReadLine();
        }

        public void ContainsOperatorForComparerExample()
        {
            List<Student> students = GetStudent();

            var comparer = new StudentComparer();

            var isExist = students.Contains(new Student() { Id = 1, Name = "Kim"},comparer);
        }

        public void ContainsOperatorForComparerQuerySyntax()
        {
            List<Student> students = GetStudent();

            var comparer = new StudentComparer();

            var querySyntax = (from student in students
                               select student).Contains(new Student() { Id = 1, Name = "Kim" }, comparer);

            Console.WriteLine(querySyntax);
        }

        private List<string> GetStudentsNames()
        {
            List<string> studentsNames = new List<string>() { "Kim", "Jacob", "Simon", "John" };
            return studentsNames;
        }

        private List<Student> GetStudent()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Id =1 , Name = "Kim"},
                new Student(){Id =2 , Name = "John"},
            };
            return students;
        }
    }
}
