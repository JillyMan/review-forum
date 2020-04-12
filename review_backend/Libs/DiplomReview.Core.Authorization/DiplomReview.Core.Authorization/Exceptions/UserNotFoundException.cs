using System;

namespace DiplomReview.Core.Authorization.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base("The user was not found")
        {
        }

        public UserNotFoundException(string message) : base(message)
        {
        }

        public UserNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
