using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Artemisia.Dialogs;

namespace Artemisia
{
    public partial class DialogTreeViewer : UserControl
    {

        public event EventHandler SelectionChanged;

        Dialog dialog;

        public DialogNode SelectedNode
        {
            get
            {
                if (treeView.SelectedNode != null)
                    return ((DialogTreeNode)treeView.SelectedNode).DialogNode;
                else
                    return null;
            }
        }

        public DialogTreeViewer()
        {
            InitializeComponent();
            treeView.DrawMode = TreeViewDrawMode.OwnerDrawText;
            treeView.ImageIndex = 0;
            treeView.MouseClick += new MouseEventHandler(treeView_MouseClick);
            treeView.AfterSelect += new TreeViewEventHandler(treeView_AfterSelect);
            treeView.DrawNode += new DrawTreeNodeEventHandler(treeView_DrawNode);
        }

        void treeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            Color nodeColor = Color.Black;

            DialogTreeNode dtn = e.Node as DialogTreeNode;
            switch (dtn.DialogNode.NodeType)
            {
                case DialogNodeType.Action:
                    nodeColor = Color.BlueViolet;
                    break;
                case DialogNodeType.Link:
                    LinkNode ln = dtn.DialogNode as LinkNode;
                    nodeColor = ln.IsLinkValid() ? Color.Green : Color.Red;
                    break;
                case DialogNodeType.Response:
                    nodeColor = Color.Goldenrod;
                    break;
                case DialogNodeType.Root:
                    nodeColor = Color.Black;
                    break;
            }
           

            TextRenderer.DrawText(e.Graphics,
                                  e.Node.Text,
                                  e.Node.NodeFont,
                                  e.Bounds,
                                  nodeColor,
                                  Color.Empty,
                                  TextFormatFlags.VerticalCenter);
        }

        void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            OnSelectionChanged();
        }

        public virtual void OnSelectionChanged()
        {
            if (SelectionChanged != null) SelectionChanged(this, EventArgs.Empty);
        }

        void treeView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                DialogTreeNode dtn = treeView.GetNodeAt(e.Location) as DialogTreeNode;
                foreach (var t in dtn.DialogNode.GetAcceptableChildren())
                {
                    switch (t)
                    {
                        case DialogNodeType.Link:
                            cm.MenuItems.Add(new MenuItem("Add Link Node", (o, ev) =>
                            {
                                var node = new LinkNode();
                                var reason = node.CanAddTo(dtn.DialogNode);
                                if (reason != null)
                                {
                                    MessageBox.Show(reason, "Error", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    dtn.DialogNode.AddNode(node);
                                    dtn.Nodes.Add(new DialogTreeNode(node, node.ToString()));
                                    dtn.Expand();
                                }
                            }));
                            break;
                        case DialogNodeType.Response:
                            cm.MenuItems.Add(new MenuItem("Add Reponse Node", (o, ev) =>
                            {
                                var node = new ResponseNode();
                                var reason = node.CanAddTo(dtn.DialogNode);
                                if (reason != null)
                                {
                                    MessageBox.Show(reason, "Error", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    dtn.DialogNode.AddNode(node);
                                    dtn.Nodes.Add(new DialogTreeNode(node, node.ToString()));
                                    dtn.Expand();
                                }
                            }));
                            break;
                        case DialogNodeType.Action:
                            cm.MenuItems.Add(new MenuItem("Add Action Node", (o, ev) =>
                            {
                                var node = new ActionNode();
                                var reason = node.CanAddTo(dtn.DialogNode);
                                if (reason != null)
                                {
                                    MessageBox.Show(reason, "Error", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    dtn.DialogNode.AddNode(node);
                                    dtn.Nodes.Add(new DialogTreeNode(node, node.ToString()));
                                    dtn.Expand();
                                }
                            }));
                            break;
                    }

                }
                cm.MenuItems.Add(new MenuItem("-"));
                cm.MenuItems.Add(new MenuItem("Delete Node", (o, ev) =>
                {
                    if (dtn.DialogNode.Nodes.Count == 0 || MessageBox.Show("This node has children. Are you sure you want to delete it?","Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        dtn.DialogNode.Parent.RemoveNode(dtn.DialogNode);
                })); 
                cm.Show(this, e.Location);
            }
        }



        public void SetDialog(Dialog d)
        {
            dialog = d;
            dialog.Change += new EventHandler(dialog_Change);
            buildTree();
        }

        void dialog_Change(object sender, EventArgs e)
        {
            treeView.Invalidate();
        }


        private void processNode(DialogTreeNode treeNode, DialogNode dialogNode)
        {
            foreach (DialogNode n in dialogNode.Nodes)
            {
                DialogTreeNode tn = new DialogTreeNode(n, n.ToString());
                treeNode.Nodes.Add(tn);
                processNode(tn, n);
                treeNode.Expand();
            }
        }

        private void buildTree()
        {
            treeView.Nodes.Clear();
            var rootNode = new DialogTreeNode(dialog.RootNode, dialog.RootNode.ToString());
            treeView.Nodes.Add(rootNode);
            processNode(rootNode, dialog.RootNode);
        }
    }
}
