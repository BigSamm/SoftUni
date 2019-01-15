using System;

namespace CustomLinkedListTests
{
    public class ExpectedExceptionAttribute : Attribute
    {
        public ExpectedExceptionAttribute(Type exceptionType)
        {
            this.ExceptionType = exceptionType;
        }

        public Type ExceptionType { get; private set; }
    }
}