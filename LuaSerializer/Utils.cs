using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuaSerialization
{
    public static class Utils
    {
        public static StringBuilder Indent(this StringBuilder sb, int count)
        {
            return sb.Append("".PadLeft(count * 4));
        }
    }
}
