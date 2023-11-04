using System.Net;

namespace TravelBuddyApi.Exceptions
{
    public class ApiException : Exception
    {
        public Dictionary<int,string> ErrorDetails { get; set; }
        public int ErrorCode { get; set; }

        public ApiException(HttpStatusCode error, string message) : base(message)
        {
            this.ErrorCode = (int)error;
        }
    }
}
