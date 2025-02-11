﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public  class ColourValidator : AbstractValidator<Colour>
    {
        public ColourValidator()
        {
            RuleFor(p=> p.ColorName).MinimumLength(2);
            RuleFor(p=> p.ColorName).NotEmpty();
        }
    }
}
