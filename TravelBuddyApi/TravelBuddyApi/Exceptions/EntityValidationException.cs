namespace TravelBuddyApi.Exceptions
{
    public class EntityValidationException : ApiException
    {
        public EntityValidationException(string title, string message) : base(title, message)
        {
        }
    }
}
