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
            Log = nameof(Setup) + " ";
        }

        public void TestMethod()
        {
            Log = Log + nameof(TestMethod) + " ";
        }

        protected override void TearDown()
        {
            Log = Log + nameof(TearDown) + " ";
        }

        public void TestBrokenMethod()
        {
            throw new NotImplementedException();
        }
    }
}