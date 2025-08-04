using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass1 : AssemblyOneClass1
    {
        public void Print()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            // Internal Assembly 
            // Console.WriteLine(A1.ID);
            // A1.ID = 101;
            base.Name = "Aravind";

            //Protected Internal
            AssemblyTwoClass1 A2 = new AssemblyTwoClass1();
            A2.Name = "Aravind";
        }
    }
}
