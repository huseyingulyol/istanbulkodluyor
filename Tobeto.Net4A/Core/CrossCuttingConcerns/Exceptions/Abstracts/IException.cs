using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.Abstracts
{
    public interface IException
    {
        public string Message { get; }
        
    }
}
