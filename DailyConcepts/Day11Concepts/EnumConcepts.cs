using System;

namespace Day11Concepts
{
    public class EnumConceptsExample
    {
        public void EnumConceptMethod()
        {
            Gender[] Values = (Gender[])Enum.GetValues(typeof(Gender));

            foreach (Gender value in Values)
            { 
                Console.WriteLine((short)value);
            }

            string[] Names = Enum.GetNames(typeof(Gender));

            foreach (string Name in Names)
            { 
                Console.WriteLine(Name);
            }
        }
    }
}
public enum Gender : short
{
    Unknown,
    Male,
    Female
}

