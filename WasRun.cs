using System;

namespace CSharpUnit
{
    class WasRun : TestCase
    {
        public WasRun(string testName)
        {
            this.testName = testName;
        }

        public bool HasRun { get; private set; }

        public void TestMethod()
        {
            this.HasRun = true;
        }
    }
}