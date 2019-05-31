using System;

namespace CSharpUnit
{
    class TestResult
    {
        private int runCount = 0;
        private int failCount = 0;

        internal string Summary()
        {
            return $"{runCount} run, {failCount} failed";
        }

        internal void TestFailed()
        {
            failCount += 1;
        }

        internal void TestStarted()
        {
            runCount += 1;
        }
    }
}