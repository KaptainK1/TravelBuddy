namespace TravelBuddyApi.Exceptions
{
    public class ApiException : Exception
    {
        public Dictionary<string,string> ErrorDetails { get; set; }

        public ApiException(string title, string message) : base(message)
        {
            ErrorDetails = new Dictionary<string, string>();
            ErrorDetails["title"] = title;
            ErrorDetails["message"] = message;

        }
    }
}
