using System;

namespace CSharpUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            new TestCaseTest("TestRunning").Run();
            new TestCaseTest("TestSetup").Run();
        }
    }
}
