namespace Day8Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetSetPropertie();
            ReadWriteProperties();
            Structures();
            ClassVsStructures();
        }

        static void GetSetPropertie()
        {
            GetSetProperties getSetProperties = new GetSetProperties();
            getSetProperties.GetSetPropertiesMethod();
        }

        static void ReadWriteProperties()
        {
            GetSetProperties getSetProperties2 = new GetSetProperties();
            getSetProperties2.ReadWritePropertiesMethod();
        }

        public static void Structures()
        {
            Structure structure = new Structure();
            structure.Structuresmethod();
        }

        static void ClassVsStructures()
        {
            ClassVsStructure structure2 = new ClassVsStructure();
            structure2.ClassVsStructuresMethod(); 
        }
    }
}
