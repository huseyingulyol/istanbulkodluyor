using Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;
using Core.CrossCuttingConcerns.Exceptions.Types;

namespace Core.CrossCuttingConcerns.Exceptions.GlobalExceptionHandling2
{
    public static class ExceptionMapper
    {
        private static readonly Dictionary<Type, Func<object, ProblemDetails>> _mappings = new Dictionary<Type, Func<object, ProblemDetails>>
        {
            { typeof(NotFoundException), (message) => new NotFoundProblemDetails(message.ToString()) },
            { typeof(BusinessException), (message) => new BusinessProblemDetails(message.ToString()) },
            { typeof(AuthorizationException), (message) => new AuthorizationProblemDetails(message.ToString()) },
            { typeof(ValidationException), (message) => new ValidationProblemDetails((List<ValidationExceptionModel>)message) }

        };

        public static ProblemDetails Map(Type exceptionType, object message)
        {
            if (_mappings.TryGetValue(exceptionType, out var factory))
            {
                return factory(message);

            }
            return new InternalServerErrorProblemDetails("problemdetails is not found");
        }
    }
}
