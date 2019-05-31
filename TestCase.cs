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
            try
            {
                Setup();
                MethodInfo method = GetType().GetMethod(testName);
                method?.Invoke(this, null);
            }
            catch (Exception)
            {
                result.TestFailed();
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

        protected void Pass(string testName)
        {
            Console.Write(testName);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Pass");
            Console.ResetColor();
        }

        protected void Fail(string testName)
        {
            Console.Write(testName);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" Fail");
            Console.ResetColor();
        }

        protected void AssertTrue(string testName, bool state)
        {
            if(state)
            {
                Pass(testName);
            }
            else
            {
                Fail(testName);
            }
        }
    }
}