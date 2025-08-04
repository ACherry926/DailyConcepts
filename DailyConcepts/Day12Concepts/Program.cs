namespace Day12Concepts
{
    public  class Program
    {
        static void Main(string[] args)
        {
            CommonExceptionInArray();
            GenericsConcept();
        }
        public static void CommonExceptionInArray()
        {
            CommonExceptionInArraysConcept commonExceptionInArrays = new CommonExceptionInArraysConcept();
            commonExceptionInArrays.CommonExceptionInArraysExample();
        }

        public static void GenericsConcept()
        {
            GenericsConcept genericsConcept = new GenericsConcept();
            genericsConcept.GenericsExample();
        }
    }
}
