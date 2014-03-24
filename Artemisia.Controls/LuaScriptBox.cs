using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FastColoredTextBoxNS;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Artemisia
{
    public class LuaScriptBox : FastColoredTextBox
    {

        TextStyle brownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Regular);
        TextStyle greenStyle = new TextStyle(Brushes.DarkSeaGreen, null, FontStyle.Regular);
        TextStyle blueStyle = new TextStyle(Brushes.DarkBlue, null, FontStyle.Regular);
        TextStyle greyStyle = new TextStyle(Brushes.DarkGray, null, FontStyle.Regular);
        TextStyle[] speakerStyles = new TextStyle[] {
            new TextStyle(Brushes.Blue, null, FontStyle.Bold),
            new TextStyle(Brushes.DeepPink, null, FontStyle.Bold),
            new TextStyle(Brushes.DodgerBlue, null, FontStyle.Bold), 
            new TextStyle(Brushes.Green, null, FontStyle.Bold),
            new TextStyle(Brushes.OrangeRed, null, FontStyle.Bold)
        };
        TextStyle speechStyle = new TextStyle(Brushes.Black, null, FontStyle.Regular);

        string[] keywords = { "if","then","end", "return", "and", "or", "local", "for", "while", "in", "do", "else", "ipairs", "pairs" };

        public LuaScriptBox()
        {
        
        }

        string[] getSpeakers()
        {
            List<String> speakers = new List<string>();
            var mc = Regex.Matches(Text, @"^\s*[A-Z]\w*:", RegexOptions.Multiline);
            foreach (Match m in mc)
            {
                string name = m.Value.Trim();
                name = name.Substring(0, name.Length - 1);
                if (!speakers.Contains(name))
                    speakers.Add(name);
            }
            return speakers.ToArray();
        }

        protected override void OnTextChanged(TextChangedEventArgs args)
        {
            base.OnTextChanged(args);
            ClearStylesBuffer();
            
            this.Range.ClearStyle(greenStyle, greyStyle, brownStyle, blueStyle, speechStyle);
            foreach (var s in speakerStyles)
            {
                this.Range.ClearStyle(s);
                AddStyle(s);
            }
            AddStyle(speechStyle);
            var speakers = getSpeakers();
            
            for (int i = 0; i < speakers.Length; i++)
            {
                Range.SetStyle(speakerStyles[i%speakerStyles.Length], @"^\s*" +  speakers[i] + ":", System.Text.RegularExpressions.RegexOptions.Multiline);    
            }
            Range.SetStyle(speechStyle, @"^\s*[A-Z]\w*: .+$", System.Text.RegularExpressions.RegexOptions.Multiline);
            this.Range.SetStyle(greyStyle, @"--.*");
            this.Range.SetStyle(blueStyle, @"([""'])(?:(?=(\\?))\2.)*?\1");
            string keywordsRegex = "";
            for (int i = 0; i < keywords.Length; i++)
			{
                if (i < keywords.Length - 1)
                    keywordsRegex += @"\b" + keywords[i] + @"\b|";
                else
                    keywordsRegex += @"\b" + keywords[i] + @"\b";
			}
            this.Range.SetStyle(brownStyle, keywordsRegex);
            this.Range.SetStyle(greenStyle, @"[\d\(\)\+\-\*\/\=]");
            this.Range.SetStyle(greenStyle, @"(true\b|false\b)");
            
        }
    }
}
