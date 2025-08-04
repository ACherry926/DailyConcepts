using System;

namespace Day12Concepts
{
    class GenericsConcept
    {
        public void GenericsExample()
        {
            bool Equal = Calculator<int>.AreEqual(10, 10);

            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        public class Calculator<T>
        {
            public static bool AreEqual(T Value1, T Value2)
            {
                return Value1.Equals(Value2);
            }
        }
    }
}
