using System;

namespace Day15Concepts
{
    class MethodParameters
    {
        public static void Out()
        {
            int OutSideVar = 20;
            SomeFunction(out OutSideVar);

            Console.WriteLine( OutSideVar);
        }
        public static void SomeFunction(out int InsideVar)
        {
            InsideVar = 0;
            InsideVar = InsideVar + 10;
        }

        public static void Reff()
        {
            int OutSideVar = 30;
            SomeFunctions(ref OutSideVar);

            Console.WriteLine(OutSideVar);
        }
        public static void SomeFunctions(ref int InsideVar)
        {
            InsideVar = InsideVar + 10;
        }
    }
}
