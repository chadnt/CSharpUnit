using System;
using System.Reflection;

namespace CSharpUnit
{
    class WasRun
    {
        private string testName;

        public WasRun(string testName)
        {
            this.testName = testName;
        }

        public bool HasRun { get; private set; }

        internal void Run()
        {
            MethodInfo method = this.GetType().GetMethod(testName);
            method.Invoke(this, null);
        }

        public void TestMethod()
        {
            this.HasRun = true;
        }
    }
}