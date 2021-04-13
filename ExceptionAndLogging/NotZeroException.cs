using System;

namespace ExceptionAndLogging
{
    [Serializable()]
    class NotZeroException : Exception
    {
        public static readonly string DefaultMessage = "The number is zero";
        public NotZeroException() : base(DefaultMessage)
        {

        }
    }
}
