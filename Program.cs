using System;

namespace CSharpUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            new TestCaseTest("TestTemplateMethod").Run();
            new TestCaseTest("TestResult").Run();
            new TestCaseTest("TestFailedResult").Run();
            new TestCaseTest("TestFailedResultFormatting").Run();
        }
    }
}
