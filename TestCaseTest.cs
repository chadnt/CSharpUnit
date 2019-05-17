using System.Diagnostics;

namespace CSharpUnit
{
    class TestCaseTest : TestCase
    {
        public TestCaseTest(string testName)
        {
            this.testName = testName;
        }

        public void TestRunning()
        {
            var test = new WasRun("TestMethod");
            Debug.Assert(!test.HasRun);
            test.Run();
            Debug.Assert(test.HasRun);
        }
    }
}