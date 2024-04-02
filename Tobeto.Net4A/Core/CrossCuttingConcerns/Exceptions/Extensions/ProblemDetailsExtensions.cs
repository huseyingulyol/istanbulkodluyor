using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

namespace Core.CrossCuttingConcerns.Exceptions.Extensions
{
    internal static class ProblemDetailsExtensions
    {
        public static string AsJson<TProblemDetail>(this TProblemDetail details) 
            where TProblemDetail : ProblemDetails  => JsonSerializer.Serialize(details);
    }
}
