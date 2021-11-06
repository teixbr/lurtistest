using LurtisTest.Common.Utils;
using System;

namespace LurtisTest.Common.Exceptions
{
    public class LTFindException : BaseException
    {
        public LTFindException() : base(ReadProperty.EXCEPTION_FIND) { }
        public LTFindException(Exception e) : base(ReadProperty.EXCEPTION_FIND, e) { }
    }
}
