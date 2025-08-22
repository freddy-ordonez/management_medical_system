using Medical.Domain.Entities.ErrorModel;
using Microsoft.AspNetCore.Diagnostics;

namespace Medical.Api.Extensions
{
    public static class ExceptionMiddlewareExtension
    {

        public static void ConfigureExceptionHandler(this WebApplication app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.ContentType = "application/json";

                    var contextFeacture = context.Features.Get<IExceptionHandlerFeature>();

                    if (contextFeacture != null)
                    {
                        context.Response.StatusCode = contextFeacture.Error switch
                        {
                            _ => StatusCodes.Status500InternalServerError
                        };

                        await context.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeacture.Error.Message
                        }.ToString());
                    }
                });
            });
        }
    }
}
