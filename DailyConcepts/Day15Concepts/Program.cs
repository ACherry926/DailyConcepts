namespace Day15Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExpectionHandlingMethods();
            ExpectionTypesMethods();
            AsynchronousProgrammingExample();
            DebugVsReleaseMethod();
        }

        public static void ExpectionHandlingMethods()
        {
            ExpectionHandling expectionHandling = new ExpectionHandling();
            expectionHandling.ExpectionHandlingMethod();
        } 
        
        public static void ExpectionTypesMethods()
        {
            ExpectionTypes expectionTypes = new ExpectionTypes();
            expectionTypes.ExpectionTypesExample();
        }

        public static void AsynchronousProgrammingExample()
        {
            AsynchronousProgramming asynchronousProgramming = new AsynchronousProgramming();
            asynchronousProgramming.AsynchronousProgrammingMethod();
            Asynchronous.AsynchronousProgrammingMethod();
        }      
        
        public static void DebugVsReleaseMethod()
        {
            DebugVsRelease debugVsRelease = new DebugVsRelease();
            debugVsRelease.DebugVsReleaseExample();
        }
    }
}
