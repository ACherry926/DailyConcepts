using System.Collections.Generic;

namespace Day19Concepts
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Techs> Programing { get; set; }
    }

    public class Techs
    {
        public string Technology { get; set; }
    }
}
