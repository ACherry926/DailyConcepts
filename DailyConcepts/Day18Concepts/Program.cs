using Day18Concepts.LinqOperators;

namespace Day18Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinqQueryMethod();
            ExtensionMethod();
            SelectMethods();
            SelectManyMethods();
        }

        public static void LinqQueryMethod()
        {
            LinqQueryMethods linqQueryMethods = new LinqQueryMethods();
            linqQueryMethods.LinqQueryForQuerySyntax();
            linqQueryMethods.LinqQueryForMethodSyntax();
            linqQueryMethods.LinqQueryForMixedSyntax();
        }

        public static void ExtensionMethod()
        {
            ExtensionMethods extensionMethods = new ExtensionMethods();
            extensionMethods.ExtensionExampleForString();
            extensionMethods.ExtensionExampleForInteger();
        }

        public static void SelectMethods()
        {
            SelectMethod selectMethod = new SelectMethod();
            selectMethod.QuerySyntaxWithComplexType();
            selectMethod.MethodSyntaxWithComplexType();
            selectMethod.QuerySyntaxOperationWithComplexType();
            selectMethod.MethodSyntaxOperationWithComplexType();
            selectMethod.SelectQuerySyntaxWithComplexType();
            selectMethod.MethodSyntaxWithSelectDataToOtherClasss();
            selectMethod.QuerySyntaxWithSelectDataToOtherClasss();
        }
        
        public static void SelectManyMethods()
        {
            SelectManyMethod selectManyMethod = new SelectManyMethod();
            selectManyMethod.QuerySyntaxWithSelectManyMethod();
            selectManyMethod.MethodSyntaxWithSelectManyMethod();
            selectManyMethod.SelectManyMethodForMethodSyntax();
            selectManyMethod.SelectManyMethodForQuerySyntax();
        }
    }
}
