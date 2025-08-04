using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19Concepts
{
    public class OffTypeMethod
    {
        public void OffTypeOperatorForQuerySyntax()
        {
            List<object> dataSource = GetDataSource();

            var querySyntax = (from data in dataSource
                               where  data is string
                               select data).ToList();

            Console.WriteLine(querySyntax);
        } 
        
        public void OffTypeOperatorForMethodSyntax()
        {
            List<object> dataSource = GetDataSource();

            var methodSyntax = dataSource.OfType<string>().Where(name => name.Length > 3).ToList();
            //var methodSyntax = dataSource.OfType<int>().ToList();

            Console.WriteLine(methodSyntax);
        }

        private static List<object> GetDataSource()
        {
            var dataSource = new List<object> { "Adam", "Harry", "kim", "john", 1, 2, 3, 4, 5 };
            return dataSource;
        }
    }
}
