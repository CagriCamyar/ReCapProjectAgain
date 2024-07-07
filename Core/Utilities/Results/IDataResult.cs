using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public interface IDataResult<T> : IResult
    {
        public bool Success => throw new NotImplementedException();

        public string Message => throw new NotImplementedException();

        T Data { get; }
        }
    }
