using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Artemisia
{
    interface ILuaSerializable
    {
        string ToLua(int indentLevel);
    }
}
