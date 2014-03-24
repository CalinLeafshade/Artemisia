using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using AluminumLua;
using AluminumLua.Executors;
using System.IO;

namespace Types
{
    public static class Utils
    {
        public static string StripScriptHeader(string value)
        {
            string t = Regex.Replace(value, @"^--\*.*\n?", String.Empty);
            Console.WriteLine("{0} - {1}",value,t);
            return t;
        }

        public static string GetScriptHeader(string value)
        {
            Match m = Regex.Match(value, @"^--\*(.*)\n?");
            if (m.Groups.Count > 1)
                return m.Groups[1].Value;
            else
                return "";
        }

        private static string artemisScriptValidator(Match m)
        {
            return String.Format("a{0}:say(\"{1}\")", m.Groups[1], m.Groups[2]);
        }

        public static string ValidateArtemisScript(string script)
        {
            try
            {
                script = "if false then " + Environment.NewLine + Regex.Replace(script, @"^\s*([A-Z]\w+):\s(.+)$", new MatchEvaluator(artemisScriptValidator), RegexOptions.Multiline) + Environment.NewLine + " end";
            }
            catch
            {
                return "Failed to parse script. Dunno why. This shouldn't happen.";
            }

            LuaContext lua = new LuaContext();
            lua.AddBasicLibrary();
            LuaParser p = new LuaParser(lua, new StringReader(script));
            try
            {
                p.Parse();
            }
            catch (LuaException ex)
            {
                return ex.Message;
            }
            return null;
        }
    }
}
