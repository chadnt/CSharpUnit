using System;

namespace CSharpUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            var suite = new TestSuite();
            suite.Add(new TestCaseTest("TestTemplateMethod"));
            suite.Add(new TestCaseTest("TestResult"));
            suite.Add(new TestCaseTest("TestFailedResult"));
            suite.Add(new TestCaseTest("TestFailedResultFormatting"));
            suite.Add(new TestCaseTest("TestSuite"));
            var result = suite.Run();
            Display(result);
        }

        private static void Display(TestResult result)
        {
            Console.WriteLine(result.Summary);
            Console.ForegroundColor = ConsoleColor.Red;
            foreach(var test in result.FailedTests)
            {
                Console.WriteLine(test);
            }
            Console.ResetColor();
        }
    }
}
