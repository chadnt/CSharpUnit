using System;
using System.Collections.Generic;

namespace CSharpUnit
{
    class TestResult
    {
        public List<string> FailedTests { get; } = new List<string>();
        internal int FailCount { get; private set; }
        internal int RunCount { get; private set; }

        internal string Summary => $"{RunCount} run, {FailCount} failed";

        internal void TestFailed(string testName)
        {
            FailCount += 1;
            FailedTests.Add(testName);
        }

        internal void TestStarted()
        {
            RunCount += 1;
        }
    }
}