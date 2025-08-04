using System;
using System.Collections.Generic;
using System.Linq;

namespace Day20Concepts
{
    public class DistinctOperator
    {      
        public void DistinctOperatorForMethodSyntax()
        {
            List<int> numbers = GetNumbers();

            var methodSyntax = numbers.Distinct().ToList();

            Console.WriteLine(methodSyntax);
        }

        public void DistinctOperatorForQuerySyntax()
        {
            List<int> numbers = GetNumbers();

            var querySyntax = (from number in numbers
                               select number).Distinct().ToList();

            Console.WriteLine(querySyntax);
        }

        public void DistinctOperatorForIEquatableExample()
        {
            List<Student> students = GetStudents();

            var methodSyntax = students.Distinct().ToList();

            Console.WriteLine(methodSyntax);
        }

        public void DistinctOperatorForIEqualitycomparerExample()
        {
            List<Student> students = GetStudents();

            var methodSyntax = students.Distinct(new StudentComparer()).ToList();

            Console.WriteLine(methodSyntax);
        }

        public class Student : IEquatable<Student>
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public bool Equals(Student other)
            {
                if (object.ReferenceEquals(other, null))
                {
                    return false;
                }

                if (object.ReferenceEquals(this, other))
                {
                    return true;
                }

                return Id.Equals(other.Id) && Name.Equals(other.Name);
            }

            public override int GetHashCode()
            {
                int idHashCode = Id.GetHashCode();
                int nameHashCode = Name.GetHashCode();

                return idHashCode ^ nameHashCode;
            }
        }

        public class StudentComparer : IEqualityComparer<Student>
        {
            public bool Equals(Student student, Student student1)
            {
                return student.Id.Equals(student1.Id) && student.Name.Equals(student1.Name);
            }

            public int GetHashCode(Student student)
            {
                int idHashCode = student.Id.GetHashCode();
                int nameHashCode = student.Name.GetHashCode();

                return idHashCode ^ nameHashCode;
            }
        }

        private List<int> GetNumbers()
        {
            var numbers = new List<int> { 1, 2, 3, 1, 2, 3, 4, 3, 5, 5 };
            return numbers;
        }

        private List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
               new Student() { Id = 1, Name = "Jhon" },
               new Student() { Id = 2, Name = "kim"},
               new Student() { Id = 1, Name = "Jhon"},
               new Student() { Id = 4, Name = "Mark"},
            };
            return students;
        }
    }
}
