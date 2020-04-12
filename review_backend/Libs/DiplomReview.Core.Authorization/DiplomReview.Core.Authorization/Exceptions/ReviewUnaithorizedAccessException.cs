using System;

namespace DiplomReview.Core.Authorization.Exceptions
{
    public class ReviewUnaithorizedAccessException : Exception
    {
        public ReviewUnaithorizedAccessException() : base("You do not have permissions to access the resource.")
        {
        }

        public ReviewUnaithorizedAccessException(string message) : base(message)
        {
        }

        public ReviewUnaithorizedAccessException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
