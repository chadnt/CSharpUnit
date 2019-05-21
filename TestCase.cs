using System;
using System.Reflection;

namespace CSharpUnit
{
    class TestCase
    {
        protected string testName;
        protected TestCase test;

        public bool HasRun { get; set; }
        public bool WasSetup { get; set;}

        internal void Run()
        {
            Setup();
            MethodInfo method = this.GetType().GetMethod(testName);
            method.Invoke(this, null);
        }

        protected virtual void Setup() { }

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