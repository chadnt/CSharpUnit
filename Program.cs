using System;

namespace CSharpUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new WasRun("TestMethod");
            Console.WriteLine(test.HasRun);
            test.Run();
            Console.WriteLine(test.HasRun);
        }
    }
}
