﻿using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business.BusinessRules
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics) {
                if (!logic.succes)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
