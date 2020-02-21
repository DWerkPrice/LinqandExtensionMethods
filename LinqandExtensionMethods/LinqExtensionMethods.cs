using System;
using System.Collections.Generic;
using System.Text;

namespace LinqandExtensionMethods
{
    static class LinqExtensionMethods
    {
        public static string Hello(this int i) {
            return $"Hello number {i}";
        }
    }
}
