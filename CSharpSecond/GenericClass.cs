﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSecond
{
    internal class GenericClass<T>
    {
        public string   Name { get; set; }
        public T GenegicField { get; set; } 
    }
}