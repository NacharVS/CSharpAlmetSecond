using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSecond.Other
{
    internal class GenericClass
    {
        delegate R delegateOne<T, R>(T objectq);
        public string Name { get; set; }

    }
}
