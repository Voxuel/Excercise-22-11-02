 using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise1102
{
    internal class TestGenerics
    {
        /// <summary>
        /// Compares 2 objects and returns true or false depending on what Equals() returns
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>true if both objeccts are equals</returns>
        internal bool Compare<T>(T x, T y)
        {
            return x.Equals(y);
        }
    }
}
