using Core.CrossCuttingConcerns.Exceptions.Extensions;
using Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Microsoft.AspNetCore.Http;

namespace Core.CrossCuttingConcerns.Exceptions.GlobalExceptionHandling2
{
    public class ExceptionMiddlewareV2
    {


        private readonly RequestDelegate _next;
        public ExceptionMiddlewareV2(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {

                context.Response.ContentType = "application/json";
                if (exception is ValidationException)
                {


                    ProblemDetails val = ExceptionMapper.Map(exception.GetType(), (exception as ValidationException).Errors);
                    context.Response.StatusCode = val.Status;
                    await context.Response.WriteAsync((val as ValidationProblemDetails).AsJson());
                }
                else
                {
                    var val = ExceptionMapper.Map(exception.GetType(), exception.Message);
                    context.Response.StatusCode = val.Status;
                    await context.Response.WriteAsync(val.AsJson());
                }
            

            }
        }
    }
}
