﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Colour : IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
