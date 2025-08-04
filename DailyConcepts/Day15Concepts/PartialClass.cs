using System;

namespace Day15Concepts
{
    class PartialClass
    {
        public static void PartialClassExample()
        {
            HelloClass hello = new HelloClass();
            hello.HelloUniverse();
            hello.HelloWorld();
        }
    }

    public partial class HelloClass
    {
        public void HelloWorld() => Console.WriteLine("Hello World");
    }
    
    public partial class HelloClass
    {
        public void HelloUniverse() => Console.WriteLine("Hello universe");
    }
}
