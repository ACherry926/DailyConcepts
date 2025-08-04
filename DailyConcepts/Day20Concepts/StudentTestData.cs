using System.Collections.Generic;

namespace Day20Concepts
{
    public class StudentTestData
    {
        public static List<int> GetNumbers()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            return numbers;
        }

        public static List<string> GetAlphabets()
        {
            List<string> datasource1 = new List<string>() { "A", "B", "C", "D" };
            return datasource1;
        }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
               new Student { Name = "Kim", Marks = 90 },
               new Student { Name = "John", Marks = 80 },
               new Student { Name = "Lee", Marks = 75 }
            };
            return students;
        }

        public static List<Student> GetStudentsData()
        {
            List<Student> students = new List<Student>()
            {
                new Student() {Id = 1, Name ="John"},
                new Student() {Id = 2, Name ="Kim"},
                new Student() {Id = 3, Name ="John"},
                new Student() {Id = 4, Name ="Mark"},
            };
            return students ;
        }

        public static List<Student> GetSubjects()
        {
            List<Student> students = new List<Student>
            {
                new Student {
                    Name = "Kim", Marks = 90,
                    Subject = new List<Subject> {
                        new Subject() {SubjectName = "Math" , SubjectMarks=75},
                        new Subject() {SubjectName = "English" , SubjectMarks=80 },
                        new Subject() {SubjectName = "Art" , SubjectMarks=86},
                        new Subject() {SubjectName = "History" , SubjectMarks=81}
                    } },
            new Student { Name = "John", Marks = 80,
                Subject = new List<Subject> {
                        new Subject() {SubjectName = "Math" , SubjectMarks=89},
                        new Subject() {SubjectName = "English" , SubjectMarks=91},
                        new Subject() {SubjectName = "Art" , SubjectMarks=90},
                        new Subject() {SubjectName = "History" , SubjectMarks=91}
                    } },
            new Student { Name = "Lee", Marks = 90,
                Subject = new List<Subject> {
                        new Subject() {SubjectName = "Math" , SubjectMarks=75 },
                        new Subject() {SubjectName = "English" , SubjectMarks=80 },
                        new Subject() {SubjectName = "Art" , SubjectMarks=60 },
                        new Subject() {SubjectName = "History" , SubjectMarks=91 }
                     } }
            };
            return students;
        }
    }
}
