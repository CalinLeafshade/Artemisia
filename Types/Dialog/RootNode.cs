﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Artemisia.Dialogs
{
    [Serializable]
    public class RootNode : DialogNode
    {

        public RootNode() { }

        public RootNode(Dialog d)
        {
            this.Dialog = d;
        }

        [XmlIgnore]
        public override int ImageIndex
        {
            get { return 0; }
        }

        
        public override DialogNodeType NodeType
        {
            get { return DialogNodeType.Root; }
        }

        public override DialogNodeType[] GetAcceptableChildren()
        {
            return new[] { DialogNodeType.Link, DialogNodeType.Action, DialogNodeType.Response };
        }

        public override string ToLua(int indentLevel)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(new String(' ', indentLevel * 4)).AppendLine("{");
            indentLevel++;
            sb.Append(new String(' ', indentLevel * 4)).Append("type = 'root',\n");
            sb.Append(base.ToLua(indentLevel));
            indentLevel--;
            sb.Append(new String(' ', indentLevel * 4)).Append("}");
            return sb.ToString();
        }
    }
}
