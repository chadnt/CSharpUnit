using System.Reflection;

namespace CSharpUnit
{
    class TestCase
    {
        protected string testName;

        internal void Run()
        {
            MethodInfo method = this.GetType().GetMethod(testName);
            method.Invoke(this, null);
        }
    }
}