using LurtisTest.Common.Utils;
using System;

namespace LurtisTest.Common.Exceptions
{
    public class LTSQLServerHandlerException : BaseException
    {
        public LTSQLServerHandlerException() : base(ReadProperty.EXCEPTION_HANDLER) { }
        public LTSQLServerHandlerException(Exception e) : base(ReadProperty.EXCEPTION_HANDLER, e) { }
    }
}
