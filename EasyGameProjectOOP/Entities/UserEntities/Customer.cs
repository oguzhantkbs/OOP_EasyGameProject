﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGameProjectOOP.Entities
{
    public class Customer :  User , IEntity
    {
        public string CardNumber { get; set; }
    }
}
