using Core.CrossCuttingConcerns.Exceptions.Abstracts;

namespace Core.CrossCuttingConcerns.Exceptions.Types;

public class NotFoundException : Exception,IException
{
    public NotFoundException(string message) : base(message) { }
}
