namespace Day19Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            WhereMethods();
            OffTypeMethods();
            OrderByMethods();
            OrderByDescendings();
            ReverseMethods();
        }

        public static void WhereMethods()
        {
            WhereMethod whereMethod = new WhereMethod();
            whereMethod.WhereOperatorForQuerySyntax();
            whereMethod.WhereOperatorForMethodSyntax();
            whereMethod.WhereOperatorForQuerySyntaxStringExample();
            whereMethod.WhereOperatorForMethodSyntaxStringExample();
            whereMethod.WhereOperatorForQuerySyntaxComplexExample();
            whereMethod.WhereOperatorForMethodSyntaxComplexExample();
        }

        public static void OffTypeMethods()
        {
            OffTypeMethod offTypeMethod = new OffTypeMethod();
            offTypeMethod.OffTypeOperatorForQuerySyntax();
            offTypeMethod.OffTypeOperatorForMethodSyntax();
        }

        public static void OrderByMethods()
        {
            OrderBy orderBy = new OrderBy();
            orderBy.QuerySyntaxExample();
            orderBy.MethodSyntaxExample();
            orderBy.SortedOrderForMethodSyntax();
            orderBy.SortedOrderForQuerySyntax();
            orderBy.NonSortedForOrderByQuerySyntax();
            orderBy.NonSortedForOrderByMethodSyntax();
        }
        
        public static void OrderByDescendings()
        {
            OrderByDescending orderByMethod = new OrderByDescending();
            orderByMethod.MethodSyntaxExample();
            orderByMethod.QuerySyntaxExample();
            orderByMethod.SortedOrderForMethodSyntax();
            orderByMethod.SortedOrderForQuerySyntax();
            orderByMethod.NonSortedOrderForMethodSyntax();
            orderByMethod.NonSortedOrderForQuerySyntax();
        }
        
        public static void ReverseMethods()
        {
            ReverseMethod reverseMethod = new ReverseMethod();
            reverseMethod.ReverseMethodForQuerySyntax();
            reverseMethod.ReverseMethodForMethodSyntax();
            reverseMethod.ReverseMethodForSystemCollectionsGeneric();
            reverseMethod.ReverseMethodForAsEnumerable();
        }
    }
}
