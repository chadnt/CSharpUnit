using System;
using System.Collections.Generic;

namespace CSharpUnit
{
    class TestSuite
    {
        private List<TestCase> testCases = new List<TestCase>();

        internal void Add(TestCase testcase)
        {
            testCases.Add(testcase);
        }

        internal void Run(TestResult result)
        {
            foreach (var test in testCases)
            {
                test.Run(result);
            }
        }

        internal TestResult Run()
        {
            var result = new TestResult();
            Run(result);

            return result;
        }
    }
}