using Microsoft.AspNetCore.Mvc;

namespace ReviewManagement.Api.Models.Responce
{
    public class ExceptionObjectResult : ObjectResult
    {
        public ExceptionObjectResult(CommonExceptionResponse value) : base(value)
        {
            StatusCode = value.Status;
        }
    }
}
