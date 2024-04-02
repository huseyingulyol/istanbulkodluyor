using Core.CrossCuttingConcerns.Exceptions.Extensions;
using Core.CrossCuttingConcerns.Exceptions.GlobalExceptionHandling2;
using Core.CrossCuttingConcerns.Exceptions.Handlers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.GlobalExceptionHandling3
{
    public class ExceptionMiddlewareV3
    {


        private readonly RequestDelegate _next;
        public ExceptionMiddlewareV3(RequestDelegate next)
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
                var val = ExceptionMapper.Map(exception.GetType(), exception.Message);
                context.Response.StatusCode = val.Status;
                await context.Response.WriteAsync(val.AsJson());

            }
        }
    }
}
