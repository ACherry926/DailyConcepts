using System;
using System.Collections.Generic;
using System.Linq;

namespace Day20Concepts
{
    public class AnyMethod
    {
        public void AnyMethodExample()
        {
            List<int> numbers = StudentTestData.GetNumbers();

            var isAvailable = numbers.Any();

            Console.WriteLine(isAvailable);
        }

        public void AnyMethodForComplexExample()
        {
            List<Student> students = StudentTestData.GetStudents();

            var methodSyntax = students.Any(student => student.Marks > 96);

            Console.WriteLine(methodSyntax);
        }

        public void AnyMethodForQuerySyntax()
        {
            List<Student> students = StudentTestData.GetStudents();

            var querySyntax = (from student in students
                               select student).Any(student => student.Marks > 90);

            Console.WriteLine(querySyntax);
        }

        public void FilterDataWithAnyMethodForQuerySyntax()
        {
            List<Student> students = StudentTestData.GetSubjects();

            // Corrected method calls and casing

            var querySyntax = (from student in students
                               where student.Subject.Any(subject => subject.SubjectMarks > 91)
                               select student.Name).ToList();

            Console.WriteLine(querySyntax);
        }

        public void FilterDataWithAnyMethodForMethodSyntax()
        {
            List<Student> students = StudentTestData.GetSubjects();

            // Corrected method call
            var methodSyntax = students.Where(student => student.Subject.Any(subject => subject.SubjectMarks > 91)).Select(std => std.Name).ToList();

            Console.WriteLine(methodSyntax);
        }
    }
}
