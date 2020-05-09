using System;

namespace ReviewManagement.App.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base("The requested resource is not found")
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
