using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Artemisia.Dialogs
{
    [Serializable]
    public class Dialog
    {
        RootNode rootNode;
        int nextId = 0;

        Dictionary<int, DialogNode> nodesByID = new Dictionary<int, DialogNode>();

        public event EventHandler Change;

        public RootNode RootNode
        {
            get { return rootNode; }
            set { rootNode = value; }
        }

        public Dialog()
        {
            rootNode = new RootNode(this);
            nodesByID[0] = rootNode;
        }

        private void restoreParentage(DialogNode node)
        {
            nodesByID[node.Id] = node;
            node.Dialog = this;
            foreach (DialogNode dn in node.Nodes)
            {
                dn.Dialog = this;
                dn.Parent = node;
                nodesByID[dn.Id] = dn;
                restoreParentage(dn);
            }
        }

        public void RestoreParentReferences()
        {
            nodesByID.Clear();
            restoreParentage(RootNode);
        }

        public int GetNextID()
        {
            return ++nextId;
        }

        internal void OnNodesChange()
        {
            if (Change != null) Change(this, EventArgs.Empty);
        }

        internal void OnAddNode(DialogNode node)
        {
            nodesByID[node.Id] = node;
            node.Change += new EventHandler(node_Change);
        }

        void node_Change(object sender, EventArgs e)
        {
            OnNodesChange();
        }

        internal void OnRemoveNode(DialogNode node)
        {
            nodesByID.Remove(node.Id);
            foreach (DialogNode dn in node.Nodes)
            {
                OnRemoveNode(dn);
            }
        }

        public DialogNode GetNodeByID(int id)
        {
            if (nodesByID.ContainsKey(id))
            {
                return nodesByID[id];
            }
            else
            {
                return null;
            }
        }

        public virtual string ToLua(int indentLevel)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("return {");
            sb.AppendLine(RootNode.ToLua(indentLevel+1));
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
