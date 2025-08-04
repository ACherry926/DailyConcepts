using System;
using System.Collections.Generic;
using System.Linq;

namespace Day20Concepts
{
    public class QuantifierOperations
    {
        public void AllMethodForQueryExample()
        {
            List<Student> students = StudentTestData.GetStudents();

            var query = students.All(student => student.Marks > 80);

            Console.WriteLine(query);
        }

        public void AllMethodForQuerySyntax()
        {
            List<Student> students = StudentTestData.GetStudents();

            var querySyntax = (from student in students
                               select student).All(student => student.Marks > 70);
            Console.WriteLine(querySyntax);
        }

        public void FilterDataWithAllMethodForQuerySyntax()
        {

            List<Student> students = StudentTestData.GetSubjects(); 

            // Corrected method calls and casing
            var querySyntax = (from student in students
                               where student.Subject.All(x => x.SubjectMarks > 70)
                               select student).ToList();

            // Print the filtered students
            foreach (var student in querySyntax) 
            { 
                Console.WriteLine("Name: " + student.Name + ", Marks: " + student.Marks); 
                foreach (var subject in student.Subject) 
                { 
                    Console.WriteLine(" Subject: " + subject.SubjectName + ", Marks: " + subject.SubjectMarks); 
                } 
            }
            Console.WriteLine(querySyntax);
        }

        public void FilterDataWithAllMethodForMethodSyntax()
        {
            List<Student> students = StudentTestData.GetSubjects();

            // Corrected method calls and casing
            var methodSyntax = students.Where(student => student.Subject.All(subject => subject.SubjectMarks > 70)).Select(std => std).ToList();

            // Print the filtered students
            foreach (var student in methodSyntax)
            {
                Console.WriteLine("Name: " + student.Name + ", Marks: " + student.Marks);
                foreach (var subject in student.Subject)
                {
                    Console.WriteLine(" Subject: " + subject.SubjectName + ", Marks: " + subject.SubjectMarks);
                }
            }
            Console.WriteLine(methodSyntax);
        }
    }
}



