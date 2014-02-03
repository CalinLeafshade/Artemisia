using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Collections;
using System.Xml.Serialization;

namespace LuaSerialization
{

    public enum CaseType { Leave, CamelCaseStartLower }

    public class LuaSerializer
    {

        Type type;
        List<object> seen;
        CaseType caseType = CaseType.CamelCaseStartLower;

        public LuaSerializer(Type type)
        {
            this.type = type;
        }

        private string objectToLua(object obj, int indentLevel)
        {

            Type t = obj.GetType();
            if (t == typeof(Int32) ||
                t == typeof(float) ||
                t == typeof(Double) )
            {
                  return obj.ToString();
            }
            else if (t == typeof(Boolean))
            {
                return (bool)obj ? "true" : "false";
            }
            else if (t.IsEnum || t == typeof(String))
            {
                return "[[" + obj.ToString() + "]]";
            }
            else if (obj is IEnumerable)
            {
                IEnumerable ie = obj as IEnumerable;
                StringBuilder sb = new StringBuilder();
                sb.Append("{");
                foreach (object o in ie)
                {
                    sb.AppendLine();
                    sb.Indent(indentLevel).Append(objectToLua(o, indentLevel + 1)).AppendLine(",");
                }
                sb.Indent(indentLevel - 1).Append("}");
                return sb.ToString();
            }
            else if (t.IsSerializable)
            {
                if (seen.Contains(obj))
                {
                    throw new Exception("Circular reference detected");
                }
                else
                {
                    seen.Add(obj);
                }
                var props = t.GetProperties();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("{");
                sb.Indent(indentLevel - 1).Append("objectType = [[").Append(t.Name).AppendLine("]],");
                foreach (var p in props)
                {
                    if (!p.IsDefined(typeof(XmlIgnoreAttribute), true))
                    {
                        String name = p.Name;
                        if (caseType == CaseType.CamelCaseStartLower)
                        {
                            name = name.Substring(0, 1).ToLower() + name.Substring(1);
                        }
                        sb.Indent(indentLevel).Append(name).Append(" = ").Append(objectToLua(p.GetValue(obj, null), indentLevel + 1)).AppendLine(",");
                    }
                }
                sb.Indent(indentLevel - 1).Append("}");
                return sb.ToString();
            }
            else
            {
                throw new SerializationException("Can't serialize this type");
            }

        
        }

        public void Serialize(object obj, Stream stream)
        {
            if (obj == null)
                throw new NullReferenceException("Object cannot be null");
            if (stream == null)
                throw new NullReferenceException("Stream cannot be null");
            seen = new List<object>();
            String lua = "return " + objectToLua(obj,1);
            TextWriter tw = new StreamWriter(stream);
            tw.Write(lua);
            tw.Flush();
        }
    }
}
