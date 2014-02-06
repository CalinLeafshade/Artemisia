using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Artemisia.Dialogs
{
    [Serializable]
    public class ActionNode : DialogNode
    {

        string conditions = "return true";
        string script = "-- Action Node";

        public string Conditions
        {
            get { return conditions; }
            set { 
                conditions = value;
                OnChange();
            }
        }

        public string Script
        {
            get { return script; }
            set 
            { 
                script = value;
                OnChange();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - Action: {1}", Id, script.Split('\n')[0].TrimStart('-',' '));
        }

        public override string CanAddTo(DialogNode node)
        {
                return null;
        }

        [XmlIgnore]
        public override int ImageIndex
        {
            get { return 2; }
        }

        public override DialogNodeType NodeType
        {
            get { return DialogNodeType.Action; }
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
            sb.Append(new String(' ', indentLevel * 4)).Append("type = 'action',\n");
            sb.Append(new String(' ', indentLevel * 4)).Append("script = [[").Append(script).Append("]],\n");
            sb.Append(new String(' ', indentLevel * 4)).Append("condition = [[").Append(conditions).Append("]],\n");
            sb.Append(base.ToLua(indentLevel));
            indentLevel--;
            sb.Append(new String(' ', indentLevel * 4)).Append("}");
            return sb.ToString();
            
        }
    }
}
