using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    // Tiene que ser una clase estatica
    public static class MyExtensions
    {
        // this , el tipo de parametro
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },StringSplitOptions.RemoveEmptyEntries).Length;
        }

    }
}
