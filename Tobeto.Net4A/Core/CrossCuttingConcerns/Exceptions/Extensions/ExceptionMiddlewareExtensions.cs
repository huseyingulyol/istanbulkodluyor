using Core.CrossCuttingConcerns.Exceptions.GlobalExceptionHandling1;
using Core.CrossCuttingConcerns.Exceptions.GlobalExceptionHandling2;
using Core.CrossCuttingConcerns.Exceptions.GlobalExceptionHandling3;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionMiddlewareExtensions(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddlewareV2>();
        }
    }
}
