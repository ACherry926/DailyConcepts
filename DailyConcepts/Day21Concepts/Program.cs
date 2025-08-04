namespace Day21Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            TakeMethods();
            TakeWhileMethods();
            SkipMethods();
            SkipWhileMethods();
            FirstVsFirstOrDefaultMethods();
            LastVsLastOrDefaultMethodss();
        }

        public static void TakeMethods()
        {
            TakeMethod takeMethod = new TakeMethod();
            takeMethod.MethodSyntaxWithIntegerExample();
            takeMethod.QuerySyntaxWithIntegerExample();
        } 
        
        public static void TakeWhileMethods()
        {
            TakeWhileMethod takeWhileMethod = new TakeWhileMethod();
            takeWhileMethod.TakeWhileMethodExample();
            takeWhileMethod.TakeWhileMethodForMethodSyntax();
        }
        public static void SkipMethods()
        {
            SkipMethod skipMethod = new SkipMethod();
            skipMethod.SkipMethodExample();
            skipMethod.SkipMethodForWhereExample();
        }

        public static void SkipWhileMethods()
        {
            SkipWhileMethod skipWhileMethod = new SkipWhileMethod();
            skipWhileMethod.MethodSyntaxWithIntegerExample();
            skipWhileMethod.MethodSyntaxWithStringExample();
        }
        
        public static void FirstVsFirstOrDefaultMethods()
        {
            FirstVsFirstOrDefault firstVsFirstOrDefault = new FirstVsFirstOrDefault();
            firstVsFirstOrDefault.FirstExample();
            firstVsFirstOrDefault.FirstOrDefaultExample();
            firstVsFirstOrDefault.FirstVsFirstOrDefaultForStringExample();
        }
        
        public static void LastVsLastOrDefaultMethodss()
        {
            LastVsLastOrDefault lastVsLastOrDefault = new LastVsLastOrDefault();
            lastVsLastOrDefault.LastExample();
            lastVsLastOrDefault.LastOrDefaultExample();
        }
    }
}
