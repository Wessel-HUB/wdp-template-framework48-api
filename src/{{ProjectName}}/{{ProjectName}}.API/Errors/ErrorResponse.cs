namespace __ProjectName__.API.Errors
{
    public class ErrorResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public string TraceId { get; set; }
    }
}