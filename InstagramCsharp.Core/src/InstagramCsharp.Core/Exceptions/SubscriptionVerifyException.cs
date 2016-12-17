using System;

namespace InstagramCSharp.Core.Exceptions
{
    public class SubscriptionVerifyException : Exception
    {
        public SubscriptionVerifyException(string message)
            : base(message) { }
    }
}
