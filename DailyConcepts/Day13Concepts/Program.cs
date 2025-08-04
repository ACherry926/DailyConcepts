namespace Day13Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListCollection();
            ListClassFunction();
            AddRangeExamples();
            ListOfSimpleType();
            ListOfComplexType();
            ComparisonDelegateWithListMethod();
        }
        public static void ListCollection()
        {
            ListCollectionClass collectionClass = new ListCollectionClass();
            collectionClass.DisplayCustomerData();
        }
        public static void ListClassFunction()
        {
            ListClassFunctions classFunctions = new ListClassFunctions();
            classFunctions.ContainsFunction();
            classFunctions.FindFunction();
            classFunctions.ExistsFunction();
            classFunctions.FindLastFunction();
            classFunctions.FindAllFunction();
            classFunctions.FindIndexFunction();
            classFunctions.FindLastIndexFunction();
            classFunctions.ConvertAnArrayToList();
            classFunctions.ConvertAnArrayToArray();
            classFunctions.ConvertAnArrayToDictionary();
        }

        public static void AddRangeExamples()
        {
            ListClassRanges classRanges = new ListClassRanges();
            classRanges.AddRangeExample();
            classRanges.GetRangeExample();
            classRanges.InsertRangeExample();
            classRanges.RemoveRangeExample();
        }

        public static void ListOfSimpleType()
        {
            ListOfSimpleTypes listOfSimpleTypes = new ListOfSimpleTypes();
            listOfSimpleTypes.ListOfSimpleTypesMethods();
            listOfSimpleTypes.AlphabetSortingMethods();
        }

        public static void ListOfComplexType()
        {
            ListOfComplexTypes listOfComplexTypes  = new ListOfComplexTypes();
            listOfComplexTypes.ComplexTypes();
            listOfComplexTypes.ComplexTypesExample();
        }

        public static void ComparisonDelegateWithListMethod()
        {
            ComparisonDelegateWithList comparisonDelegateWithList = new ComparisonDelegateWithList();
            comparisonDelegateWithList.ComparisonDelegateWithListMethod();
        }
    }
}
