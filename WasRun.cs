using System;

namespace CSharpUnit
{
    class WasRun : TestCase
    {
        public WasRun(string testName)
        {
            this.testName = testName;
        }

        protected override void Setup()
        {
            HasRun = false;
            WasSetup = true;
        }

        public void TestMethod()
        {
            HasRun = true;
        }
    }
}