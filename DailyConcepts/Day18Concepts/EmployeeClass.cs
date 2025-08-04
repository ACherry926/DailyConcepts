using System.Collections.Generic;

namespace Day18Concepts
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
    }

    public class EmployeeClass : Employee
    {
        public List<string> Programming {  get; set; }  
    }
}
