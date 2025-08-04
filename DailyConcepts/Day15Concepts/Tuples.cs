using System;

namespace Day15Concepts
{
    class Tuples
    {
        /// <summary>
        /// Tuples
        /// </summary>
        public static Tuple<int, string, double> GetEmployeeDetails()
        {
            return new Tuple<int, string, double>(121, "Aravind", 30000);
        }

        /// <summary>
        /// Value Tuples
        /// </summary>
        public static (int, string, double) GetEmployeeDetailsWithValueTuples()
        {
            return (121, "Aravind", 30000);
        }

        /// <summary>
        /// Named Tuples
        /// </summary>
        public static (int EmpId, string EmpName, double Salary) GetEmployeeDetailsWithNamedTuples()
        {
            return (121, "Aravind", 30000);
        }

        public static void TuplesConcepts()
        {
            //Tuple<int, string, double> obj = new Tuple<int, string, double>(121, "Aravind", 30000);
            //var employee = Tuple.Create(121, "Aravind", 20000);

            var employee = GetEmployeeDetails();
            Console.WriteLine($"EmpId# {employee.Item1},{employee.Item2} has salary Rs :{employee.Item3} ");

            var employee1 = GetEmployeeDetailsWithValueTuples();
            Console.WriteLine($"EmpId# {employee1.Item1},{employee1.Item2} has salary Rs :{employee1.Item3} ");

            var employee2 = GetEmployeeDetailsWithNamedTuples();
            Console.WriteLine($"EmpId# {employee2.EmpId},{employee2.EmpName} has salary Rs :{employee2.Salary} ");
        }
    }
}
