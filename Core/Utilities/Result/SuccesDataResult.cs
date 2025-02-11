﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class SuccesDataResult<T> : DataResult<T>
    {
        
        public SuccesDataResult(T data , string messages) : base(data, true, messages)
        {

        }
        public SuccesDataResult(T data) : base(data, true)
        {

        }
        public SuccesDataResult(string messages) : base(default, true, messages)
        {

        }
        public SuccesDataResult() : base(default, true)
        {

        }
    }
}

