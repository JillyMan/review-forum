namespace ReviewManagement.Api.Models.Responce
{
    public class CommonExceptionResponse
    {
        public CommonExceptionResponse(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public int Status { get; private set; }

        public string Message { get; private set; }
    }
}
