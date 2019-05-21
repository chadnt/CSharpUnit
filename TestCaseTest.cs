using System;
using System.Diagnostics;
using System.Reflection;

namespace CSharpUnit
{
    class TestCaseTest : TestCase
    {
        public TestCaseTest(string testName)
        {
            this.testName = testName;
        }
        
        protected override void Setup()
        {
            test = new WasRun("TestMethod");
        }

        public void TestRunning()
        {
            test.Run();
            AssertTrue(MethodBase.GetCurrentMethod().Name, test.HasRun);
        }

        public void TestSetup()
        {
            test.Run();
            AssertTrue(MethodBase.GetCurrentMethod().Name, test.WasSetup);
        }
    }
}