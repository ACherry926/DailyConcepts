namespace Day9Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Interface();
            ExplictInterfaceExample();
            DefaultInterfaceExample();
            AbstractClass();
            MultipleClassInheritance();
            MultipleClassInheritanceUsingInterface();
        }

        public static void Interface()
        {
            InterfaceExamples interfaceExamples = new InterfaceExamples();
            interfaceExamples.InterfaceMethod();        
        }

        public static void ExplictInterfaceExample()
        {
            InterfaceExamples interfaceExamples = new InterfaceExamples();
            interfaceExamples.ExplictInterfaceExamplemethod();  
        }

        public static void DefaultInterfaceExample()
        {
            InterfaceExamples interfaceExamples = new InterfaceExamples();
            interfaceExamples.DefaultInterfaceExampleMethod();  
        }

        public static void AbstractClass()
        {
            AbstractClassExamples abstractClassExamples = new AbstractClassExamples();
            abstractClassExamples.AbstractClassmethod();    
        }

        public static void MultipleClassInheritance()
        {
            AbstractClassExamples abstractClassExamples1 = new AbstractClassExamples();
            abstractClassExamples1.MultipleClassInheritancemethod();   
        }

        public static void MultipleClassInheritanceUsingInterface()
        {
            AbstractClassExamples abstractClassExamples2 = new AbstractClassExamples();
            abstractClassExamples2.MultipleClassInheritanceUsingInterfaceMethod();
        }
    }
}
