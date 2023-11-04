using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace TravelBuddyApi.Exceptions
{
    public class GlobalExceptionHandlingMiddleware: IMiddleware
    {
        private readonly ILogger<GlobalExceptionHandlingMiddleware> _logger;
        public GlobalExceptionHandlingMiddleware(ILogger<GlobalExceptionHandlingMiddleware> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                _logger.LogInformation(GenerateRequestLog(context.Request));
                await next(context);
            }
            catch (ApiException e)
            {
                _logger.LogError($@"[{e.ErrorCode}] {e.Message}");
                var problem = new ProblemDetails()
                {
                    Status = e.ErrorCode,
                    Detail = e.Message,
                    Title = "An API Error occurred"
                };

                string errorJson = JsonSerializer.Serialize(problem);

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = e.ErrorCode;

                await context.Response.WriteAsync(errorJson);
            }
        }

        private string GenerateRequestLog(HttpRequest request)
        {
            return $"[{request.Method}] {request.Scheme}://{request.Host}{request.Path}";
        }
    }
}
