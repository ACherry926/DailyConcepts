using System;
using System.Text;

namespace Day10Concepts
{
    class StringAndStringBuilder
    {
        public void StringAndStringBuilderExample()
        {
            StringBuilder sb = new StringBuilder(" C# ");
            sb.Append(" Video ");
            sb.Append(" Tutorial ");
            sb.Append(" for ");
            sb.Append(" Beginners ");
            Console.WriteLine(sb.ToString());
        }
    }
}
