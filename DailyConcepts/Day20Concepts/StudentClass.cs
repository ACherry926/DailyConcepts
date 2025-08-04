using System.Collections.Generic;

namespace Day20Concepts
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public List<Subject> Subject { get; set; }
    }

    public class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectMarks { get; set; }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student xStudent, Student yStudent)
        {
            if (ReferenceEquals(xStudent, yStudent))
            {
                return true;
            }
            if (ReferenceEquals(xStudent, null) || object.ReferenceEquals(yStudent,null))
            {
                return false;
            }
            return xStudent.Id == yStudent.Id && xStudent.Name == yStudent.Name;
        }

        public int GetHashCode(Student student)
        {
            if (object.ReferenceEquals(student, null))
            {
                return 0;
            }

            int idHashCode = student.Id.GetHashCode();
            int nameHashCode = student.Name == null ? 0 : student.Name.GetHashCode();

            return idHashCode ^ nameHashCode;
        }
    }
}
