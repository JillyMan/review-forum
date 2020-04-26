using System;

namespace AccessManagement.App.Exceptions
{
    public class UserAlreadyExistException : Exception
    {
        public UserAlreadyExistException() : base("The user with same login alredy exist.")
        {
        }

        public UserAlreadyExistException(string message) : base(message)
        {
        }

        public UserAlreadyExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
