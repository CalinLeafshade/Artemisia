using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Artemisia
{
    [Serializable]
    public enum DialogNodeType { Root, Action, Link, Response };

    [XmlInclude(typeof(LinkNode))]
    [XmlInclude(typeof(ResponseNode))]
    [XmlInclude(typeof(RootNode))]
    [XmlInclude(typeof(ActionNode))]
    [Serializable]
    public abstract class DialogNode : ILuaSerializable
    {
        private Dialog dialog;
        private DialogNode parent;

        [XmlIgnore]
        public Dialog Dialog
        {
            get { return dialog; }
            set { dialog = value; }
        }

        [XmlIgnore]
        public DialogNode Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        public virtual string GetConditions
        {
            get
            {
                return "true";
            }
        }

        List<DialogNode> nodes = new List<DialogNode>();

        public event EventHandler Removed;
        public event EventHandler Change;

        public abstract DialogNodeType[] GetAcceptableChildren();
        public abstract DialogNodeType NodeType { get; }

        public List<DialogNode> Nodes
        {
            get { return nodes; }
            set { nodes = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [XmlIgnore]
        public abstract int ImageIndex { get; }

        public virtual void OnChange()
        {
            if (Change != null) Change(this, EventArgs.Empty);
        }

        public virtual void AddNode(DialogNode node)
        {
            nodes.Add(node);
            node.id = dialog.GetNextID();
            node.parent = this;
            node.dialog = this.dialog;
            dialog.OnAddNode(node);
            dialog.OnNodesChange();
        }

        public void RemoveNode(DialogNode node)
        {
            if (node.nodes.Count > 0 && MessageBox.Show("This node has children. Are you sure you want to remove it?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            nodes.Remove(node);
            node.OnRemove();
            dialog.OnRemoveNode(node);
            dialog.OnNodesChange();
        }

        public virtual string CanAddTo(DialogNode node)
        {
            return null;
        }

        public virtual void OnRemove()
        {
            if (Removed != null) Removed(this, EventArgs.Empty);
        }

        public override string ToString()
        {
            return String.Format("{0} - Root", Id);
        }

        public virtual string ToLua(int indentLevel)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(new String(' ', indentLevel * 4)).AppendLine("id = " + Id + ",");
            foreach(var dn in Nodes)
            {
                sb.AppendLine(dn.ToLua(indentLevel) + ",");
            }
            return sb.ToString();
        }
    }
}
