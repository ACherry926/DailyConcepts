namespace Day20Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //QuantifierOperationMethods();
            //AnyMethods();
            //ContainsMethods();
            DistinctOperators();
            //ExceptOperators();
            //IntersectOperators();
            //UnionOperator();
        }

        public static void QuantifierOperationMethods()
        {
            QuantifierOperations quantifierOperations = new QuantifierOperations();
            //quantifierOperations.AllMethodForQueryExample();
            //quantifierOperations.AllMethodForQuerySyntax();
            quantifierOperations.FilterDataWithAllMethodForQuerySyntax();
            quantifierOperations.FilterDataWithAllMethodForMethodSyntax();
        } 

        public static void AnyMethods()
        {
            AnyMethod anyMethod = new AnyMethod();
            anyMethod.AnyMethodExample();
            anyMethod.AnyMethodForComplexExample();
            anyMethod.AnyMethodForQuerySyntax();
            anyMethod.FilterDataWithAnyMethodForQuerySyntax();
            anyMethod.FilterDataWithAnyMethodForMethodSyntax();
        }
        public static void ContainsMethods()
        {
            ContainsMethod containsMethod = new ContainsMethod();
            containsMethod.ContainsOperatorExample();
            containsMethod.ContainsOperatorForQuerySyntax();
            containsMethod.ContainsOperatorForQuerySyntaxExample();
            containsMethod.ContainsOperatorForComparerExample();
            containsMethod.ContainsOperatorForComparerQuerySyntax();
        }

        public static void DistinctOperators()
        {
            DistinctOperator distinctOperator = new DistinctOperator();
            distinctOperator.DistinctOperatorForQuerySyntax();
            distinctOperator.DistinctOperatorForMethodSyntax();
            distinctOperator.DistinctOperatorForIEquatableExample();
            distinctOperator.DistinctOperatorForIEqualitycomparerExample();
        }

        public static void ExceptOperators()
        {
            ExceptOperator exceptOperator = new ExceptOperator();
            exceptOperator.ExceptOperatorExample();
            exceptOperator.ExceptOperatorForMethodSyntax();
            exceptOperator.ExceptOperatorForQuerySyntax();
        }
        
        public static void IntersectOperators()
        {
            IntersectOperator intersectOperator = new IntersectOperator();
            intersectOperator.IntersectOperatorExample();
            intersectOperator.IntersectOperatorForMixedSyntax();
            intersectOperator.IntersectOperatorForMethoddSyntax();
        } 
        
        public static void UnionOperator()
        {
            unionOperator unionOperator = new unionOperator();
            unionOperator.unionOperatorExample();
            unionOperator.unionOperatorForMethodSyntax();
        }
    }
}
