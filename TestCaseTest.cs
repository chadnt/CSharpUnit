using System;
using System.Diagnostics;

namespace CSharpUnit
{
    class TestCaseTest : TestCase
    {
        public TestCaseTest(string testName)
        {
            this.testName = testName;
        }

        public void TestTemplateMethod()
        {
            test = new WasRun("TestMethod");
            test.Run();
            AssertTrue(nameof(TestTemplateMethod), "Setup TestMethod TearDown " == test.Log);
        }

        public void TestResult()
        {
            test = new WasRun("TestMethod");
            TestResult result = test.Run();
            AssertTrue(nameof(TestResult), "1 run, 0 failed" == result.Summary());
        }

        public void TestFailedResult()
        {
            test = new WasRun("TestBrokenMethod");
            TestResult result = test.Run();
            AssertTrue(nameof(TestFailedResult), "1 run, 1 failed" == result.Summary());
        }

        public void TestFailedResultFormatting()
        {
            var result = new TestResult();
            result.TestStarted();
            result.TestFailed();
            AssertTrue(nameof(TestFailedResultFormatting), "1 run, 1 failed" == result.Summary());

        }
    }
}