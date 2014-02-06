using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FastColoredTextBoxNS;
using System.Drawing;

namespace Artemisia
{
    class LuaScriptBox : FastColoredTextBox
    {
        TextStyle brownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Regular);
        TextStyle greenStyle = new TextStyle(Brushes.DarkSeaGreen, null, FontStyle.Regular);
        TextStyle blueStyle = new TextStyle(Brushes.DarkBlue, null, FontStyle.Regular);
        TextStyle greyStyle = new TextStyle(Brushes.DarkGray, null, FontStyle.Regular);
        TextStyle speakerStyle = new TextStyle(Brushes.Blue, null, FontStyle.Bold);
        TextStyle speechStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);

        string[] keywords = { "if","then","end", "return", "and", "or", "local", "for", "while", "in", "do", "else", "ipairs", "pairs" };

        public LuaScriptBox()
        {
        
        }

        protected override void OnTextChanged(TextChangedEventArgs args)
        {
            base.OnTextChanged(args);
            this.Range.ClearStyle(greenStyle, greyStyle, brownStyle, blueStyle, speakerStyle, speechStyle);
            Range.SetStyle(speakerStyle, @"^\s+[A-Z]\w*:", System.Text.RegularExpressions.RegexOptions.Multiline);
            Range.SetStyle(speechStyle, @"^\s+[A-Z]\w*: .+$", System.Text.RegularExpressions.RegexOptions.Multiline);
            this.Range.SetStyle(blueStyle, @"([""'])(?:(?=(\\?))\2.)*?\1");
            this.Range.SetStyle(greyStyle, @"--.*");
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
