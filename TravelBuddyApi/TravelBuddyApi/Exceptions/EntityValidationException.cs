using System.Net;

namespace TravelBuddyApi.Exceptions
{
    public class EntityValidationException : ApiException
    {
        public EntityValidationException(HttpStatusCode error, string message) : base(error, message)
        {
        }
    }
}
