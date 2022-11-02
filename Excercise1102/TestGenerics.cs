 using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise1102
{
    internal class TestGenerics
    {
        internal bool Compare<T>(T x, T y)
        {
            return x.Equals(y);
        }
    }
}
