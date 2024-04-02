using Core.CrossCuttingConcerns.Exceptions.Abstracts;

namespace Core.CrossCuttingConcerns.Exceptions.Types;

public class AuthorizationException : Exception,IException
{
    public AuthorizationException(string message)
        : base(message) { }
}
