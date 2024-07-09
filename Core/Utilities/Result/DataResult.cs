using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T data { get; }

        public DataResult(T data,bool succes, string messages) : base(succes, messages)
        {
            this.data = data;

        }

        public DataResult(T data, bool succes) : base(succes)
        {
            {
                this.data = data;

            }

        }


    }
}
