using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Artemisia
{
    [Serializable]
    public class LinkNode : DialogNode, ILuaSerializable
    {

        int linkedID = 0;

        public int LinkedID
        {
            get { return linkedID; }
            set 
            {
                if (value == Id)
                    value = -1;
                linkedID = value; 
                OnChange(); 
            }
        }
        public override string CanAddTo(DialogNode node)
        {
            if (node.Nodes.Count > 0)
                return "A link node cannot be a sibling";
            else
                return base.CanAddTo(node);
        }

        public bool IsLinkValid()
        {
            return Dialog.GetNodeByID(LinkedID) != null;
        }

        public override string ToString()
        {
            DialogNode node = Dialog.GetNodeByID(LinkedID);
            if (node != null) 
                return String.Format("{0} - Link to {1}", Id, node.ToString());
            else
                return String.Format("{0} - Link to Nowhere :(", Id);
        }

        public override int ImageIndex
        {
            get { return 1; }
        }

        public override DialogNodeType NodeType
        {
            get { return DialogNodeType.Link; }
        }



        public override DialogNodeType[] GetAcceptableChildren()
        {
            return new DialogNodeType[] { };
        }

        public override string ToLua(int indentLevel)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(new String(' ', indentLevel * 4)).AppendLine("{");
            indentLevel++;
            sb.Append(new String(' ', indentLevel * 4)).Append("type = 'link',\n");
            sb.Append(new String(' ', indentLevel * 4)).Append("link = ").Append(linkedID).Append(",\n");
            sb.Append(new String(' ', indentLevel * 4)).Append("id = ").Append(Id).Append(",\n");
            indentLevel--;
            sb.Append(new String(' ', indentLevel * 4)).Append("}");
            
            return sb.ToString();

        }
    }
}
