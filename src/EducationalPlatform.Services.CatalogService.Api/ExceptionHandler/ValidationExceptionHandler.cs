namespace EducationalPlatform.Services.CatalogService.Api.ExceptionHandler;

public class ValidationExceptionHandler(
    IProblemDetailsService problemDetailsService,
    ILogger<ValidationExceptionHandler> logger
) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        if (exception is not ValidationException validationException)
            return false;
        
        logger.LogError(exception, "An error occurred");

        httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
        var context = new ProblemDetailsContext
        {
            HttpContext = httpContext,
            Exception = exception,
            ProblemDetails = new ProblemDetails
            {
                Detail = "One or more validation errors occurred.",
                Status = StatusCodes.Status422UnprocessableEntity,
                Title = "Validation Error",
                Type = exception.GetType().Name
            }
        };

        var errors = validationException.Errors
            .GroupBy(vf => vf.PropertyName)
            .ToDictionary(
                g => g.Key.ToLowerInvariant(),
                g => g.Select(e => e.ErrorMessage).ToArray()
            );
        
        context.ProblemDetails.Extensions.TryAdd("errors", errors);
        
        return await problemDetailsService.TryWriteAsync(context);
    }
}