namespace Day7Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeExampleInheritance();
            MethodHidingExample();
            Polymorphism();
            MethodOverridingAndHidingExample();
            ParentAndChildClassExample();
        }

        static void EmployeeExampleInheritance()
        {
            EmployeeExampleClass employeeExampleClass = new EmployeeExampleClass();
            employeeExampleClass.EmployeeExampleMethod();
        }

        static void ParentAndChildClassExample()
        {
            EmployeeExampleClass employeeExampleClass1 = new EmployeeExampleClass();
            employeeExampleClass1.ParentAndChildClassMethod();   
        }

        static void MethodHidingExample()
        {
            MethodHidingExamples methodHidingExamples = new MethodHidingExamples();
            methodHidingExamples.MethodHidingMethod();
        }

       public  static void Polymorphism()
       {
            PolymorphismExample polymorphismExample = new PolymorphismExample();
            polymorphismExample.PolymorphismMethod();
       }

        /// <summary>
        /// Method OverRiding vs Method Hiding
        /// </summary>
        public static void MethodOverridingAndHidingExample()
        {
            PolymorphismExample polymorphismExample1 = new PolymorphismExample();
            polymorphismExample1.MethodOverridingAndHidingExampleMethod();
        }
    }
}
