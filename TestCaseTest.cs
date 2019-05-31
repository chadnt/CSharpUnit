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
            AssertTrue("Setup TestMethod TearDown " == test.Log);
        }

        public void TestResult()
        {
            test = new WasRun("TestMethod");
            TestResult result = test.Run();
            AssertTrue("1 run, 0 failed" == result.Summary);
        }

        public void TestFailedResult()
        {
            test = new WasRun("TestBrokenMethod");
            TestResult result = test.Run();
            AssertTrue("1 run, 1 failed" == result.Summary);
        }

        public void TestFailedResultFormatting()
        {
            var result = new TestResult();
            result.TestStarted();
            result.TestFailed("Foo");
            AssertTrue(1 == result.FailCount);
            AssertTrue(1 == result.RunCount);
            AssertTrue("1 run, 1 failed" == result.Summary);
            AssertTrue(result.FailedTests.Contains("Foo"));
        }

        public void TestSuite()
        {
            var suite = new TestSuite();
            suite.Add(new WasRun("TestMethod"));
            suite.Add(new WasRun("TestBrokenMethod"));
            var result = suite.Run();
            AssertTrue("2 run, 1 failed" == result.Summary);
        }
    }
}