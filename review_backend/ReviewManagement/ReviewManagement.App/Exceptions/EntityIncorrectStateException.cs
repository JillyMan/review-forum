using System;

namespace ReviewManagement.App.Exceptions
{
    public class EntityIncorrectStateException : Exception
    {
        public EntityIncorrectStateException() : base("The requested resource is not in correct state")
        {
        }

        public EntityIncorrectStateException(string message) : base(message)
        {
        }

        public EntityIncorrectStateException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
