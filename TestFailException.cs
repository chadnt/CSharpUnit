using System;

namespace CSharpUnit
{
    public class TestFailException : Exception
    {   
        public TestFailException() { }
        public TestFailException(string message) : base(message) { }
        public TestFailException(string message, System.Exception inner) : base(message, inner) { }
        protected TestFailException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}