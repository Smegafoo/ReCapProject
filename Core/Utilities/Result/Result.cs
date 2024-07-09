using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        public bool succes { get; }

        public string messages { get; }

        public Result(bool succes, string message) : this(succes)
        {
            messages = message;
        }

        public Result(bool succes)
        {
            this.succes = succes;
        }
    }
}
