using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Artemisia.Dialogs;

namespace Artemisia
{
    public class DialogTreeNode : TreeNode
    {
        DialogNode dialogNode;

        public DialogNode DialogNode
        {
            get { return dialogNode; }
            set { dialogNode = value; }
        }

        public DialogTreeNode(DialogNode dn, string text)
            : base(dn.ToString())
        {

            ImageIndex = SelectedImageIndex = dn.ImageIndex;
            DialogNode = dn;
            dn.Removed += new EventHandler(dn_Removed);
            dn.Change += new EventHandler(dn_Change);
        }

        void dn_Change(object sender, EventArgs e)
        {
            Text = dialogNode.ToString();
        }

        void dn_Removed(object sender, EventArgs e)
        {
            Console.WriteLine("lol");
            Parent.Nodes.Remove(this);
        }
    }
}
