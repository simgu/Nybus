﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nybus;

namespace Messages
{
    public class ReverseStringCommand : ICommand
    {
        public string Value { get; set; }
    }
}
