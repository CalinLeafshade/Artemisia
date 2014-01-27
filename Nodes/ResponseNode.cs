using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Artemisia
{
    [Serializable]
    public class ResponseNode : DialogNode, ILuaSerializable
    {


        private string conditions = "return true";

        public string Conditions
        {
            get { return conditions; }
            set 
            { 
                conditions = value;
                OnChange();
            }
        }

        public override string GetConditions
        {
            get
            {
                return conditions;
            }
        }

        private string text = "Response";



        public string Text
        {
            get { return text; }
            set { text = value; OnChange(); }
        }

        public override string CanAddTo(DialogNode node)
        {
            foreach (DialogNode n in node.Nodes)
            {
                if (n.NodeType != DialogNodeType.Response)
                    return "A response node cannot be a sibling to a different type";
            }
            return base.CanAddTo(node);
        }

        public override DialogNodeType NodeType
        {
            get { return DialogNodeType.Response; }
        }

        public override int ImageIndex
        {
            get { return 3; }
        }

        public override DialogNodeType[] GetAcceptableChildren()
        {
            return new[] { DialogNodeType.Link, DialogNodeType.Action, DialogNodeType.Response };
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", Id, Text);
        }

        public override string ToLua(int indentLevel)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(new String(' ', indentLevel * 4)).AppendLine("{");
            indentLevel++;
            sb.Append(new String(' ', indentLevel * 4)).Append("type = 'response',\n");
            sb.Append(new String(' ', indentLevel * 4)).Append("text = [[").Append(text).Append("]],\n");
            sb.Append(new String(' ', indentLevel * 4)).Append("condition = [[").Append(conditions).Append("]],\n");
            sb.Append(base.ToLua(indentLevel));
            indentLevel--;
            sb.Append(new String(' ', indentLevel * 4)).Append("}");
            return sb.ToString();

        }
    }
}
