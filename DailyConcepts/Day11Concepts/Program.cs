using AssemblyOne;
using AssemblyTwo.ProtectedTypes;

namespace Day11Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            AccessModifier();
            Enums();
            EnumsAdvantages();
            EnumConcept();
            AssemblyConcepts();
        }

        public static void AccessModifier()
        {
            AccessModifierExample accessModifierExample = new AccessModifierExample();
            accessModifierExample.AccessModifiermethod();
        }

        public static void Enums()
        {
            EnumsClass enumsClass = new EnumsClass();
            enumsClass.EnumMethod();
        }

        public static void EnumsAdvantages()
        {
            EnumAdvantages enumAdvantages = new EnumAdvantages();
            enumAdvantages.EnumAdvantageMethod();
        }

        public static void EnumConcept()
        {
            EnumConceptsExample enumConceptsExample = new EnumConceptsExample();
            enumConceptsExample.EnumConceptMethod();
        }

        public static void AssemblyConcepts()
        {
            AssemblyOneClass11 assemblyOneClass11 = new AssemblyOneClass11();
            assemblyOneClass11.SampleMethod();

            PublicAccessTwo publicAccessTwo = new PublicAccessTwo();
            publicAccessTwo.Text();
        }
    }
}
