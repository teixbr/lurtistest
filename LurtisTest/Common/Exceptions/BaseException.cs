using System;

namespace LurtisTest.Common.Exceptions
{
    [Serializable]
    public abstract class BaseException : Exception
    {
        public BaseException() { }
        public BaseException(string message) : base(message) { }
        public BaseException(string message, Exception e) : base(message, e) { }
    }
}
