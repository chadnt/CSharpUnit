using System;
using System.Reflection;

namespace CSharpUnit
{
    class TestCase
    {
        protected string testName;
        protected TestCase test;
        public string Log { get; protected set; }

        internal void Run(TestResult result)
        {
            result.TestStarted();
            MethodInfo method = GetType().GetMethod(testName);
            try
            {
                Setup();
                method?.Invoke(this, null);
            }
            catch (Exception)
            {
                result.TestFailed(method.Name);
            }
            finally
            {
                TearDown();
            }
        }

        internal TestResult Run()
        {
            var result = new TestResult();
            Run(result);

            return result;
        }

        protected virtual void Setup() { }

        protected virtual void TearDown() { }

        protected void AssertTrue(bool state)
        {
            if(!state)
            {
                throw new TestFailException();
            }
        }
    }
}