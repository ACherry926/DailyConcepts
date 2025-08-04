using System;

namespace Day15Concepts
{
    class DebugVsRelease
    {
        public void DebugVsReleaseExample()
        {
#if DEBUG
            Console.WriteLine(DateTime.Now);// this code only run in development
#endif

            Console.WriteLine("This is your Application");

            Method1();
        }

        static void Method1()
        {
            Method2();
        }
        static void Method2()
        {
            Method3();
        }
        static void Method3()
        {
            throw new Exception("Some Error");
        }
    }
}
