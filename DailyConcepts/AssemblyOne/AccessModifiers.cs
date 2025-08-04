using System;

namespace AssemblyOne
{
    /// <summary>
    /// Internal members are only Accessble in that Assembly itself
    /// </summary>
    /// <summary>
    /// Protected Internal members are Accessble in any another Assembly And within Derived class
    /// </summary>
    public class AssemblyOneClass1
    {
        internal int Id = 101;
        protected internal string Name = "Aravind";
    }
    public class AssemblyOneClass11
    {
        public void SampleMethod()
        {
            AssemblyOneClass1 assemblyOneClass1 = new AssemblyOneClass1();
            Console.WriteLine(assemblyOneClass1.Id);
            Console.WriteLine(assemblyOneClass1.Name);
        }
    }    
}
