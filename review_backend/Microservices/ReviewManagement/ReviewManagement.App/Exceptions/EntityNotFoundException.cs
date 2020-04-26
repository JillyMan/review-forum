using System;

namespace ReviewManagement.App.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException() : base("The requested resource is not found")
        {
        }

        public EntityNotFoundException(string message) : base(message)
        {
        }

        public EntityNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
