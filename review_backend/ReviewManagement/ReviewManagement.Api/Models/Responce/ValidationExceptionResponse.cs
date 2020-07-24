using System.Collections.Generic;
using System.Net;

namespace ReviewManagement.Api.Models.Responce
{
    public class ValidationExceptionResponse : CommonExceptionResponse
    {
        public IList<string> Errors { get; }

        public ValidationExceptionResponse(IList<string> errors, string message) :
            base((int)HttpStatusCode.BadRequest, message)
        {
            Errors = errors;
        }
    }
}
