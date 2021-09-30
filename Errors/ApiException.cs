namespace JAP_Task_Backend.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode)
        {
            StatusCode = statusCode;
        }
        public ApiException(int statusCode, object data)
        {
            StatusCode = statusCode;
            Data = data;
        }

        public ApiException(int statusCode, string message, string details)
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
        public object Data { get; set; }
    }
}