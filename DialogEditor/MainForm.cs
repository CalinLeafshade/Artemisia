using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Artemisia.Dialogs;
using LuaSerialization;

namespace Artemisia
{
    public partial class MainForm : Form
    {
        Dialog activeDialog;
        bool unsaved = false;
        string _loadedFile = null;

        public string LoadedFile
        {
            get { return _loadedFile; }
            set { 
                _loadedFile = value;
                lblLoaded.Text = "Currently Loaded: " + (_loadedFile == null ? "UNSAVED" : Path.GetFileNameWithoutExtension(_loadedFile));
            }
        }
        List<TabPage> tabPages = new List<TabPage>();

        public MainForm()
        {
            InitializeComponent();
            foreach (TabPage tb in tabControl1.TabPages) tabPages.Add(tb);
            tabControl1.TabPages.Clear();
            dialogTreeViewer1.SelectionChanged += new EventHandler(dialogTreeViewer1_SelectionChanged);
            if (!String.IsNullOrEmpty(Properties.Settings.Default.LibraryFolder))
            {
                refreshLibrary();
            }
        }

        void refreshLibrary()
        {
            openLibrary(Properties.Settings.Default.LibraryFolder, true);
        }

        void newDialog()
        {
            if (unsaved && MessageBox.Show("The current dialog is unsaved. Are you sure want to make a new one?", "Are you sure?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
            }
            else
            {
                unsaved = true;
                setDialog(new Dialog());
                LoadedFile = null;
            }
        }

        void setDialog(Dialog d)
        {
            activeDialog = d;
            activeDialog.Change += new EventHandler(activeDialog_Change);
            dialogTreeViewer1.SetDialog(activeDialog);
        }


        Dialog dialogFromFile(string filename)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Dialog));
            TextReader tr = new StreamReader(filename);
            Dialog d = (Dialog)xml.Deserialize(tr);
            d.RestoreParentReferences();
            tr.Close();
            return d;
        }

        void open(string filename)
        {
            setDialog(dialogFromFile(filename));
            LoadedFile = filename;
            unsaved = false;
        }

        void open()
        {
            if (unsaved && MessageBox.Show("The current dialog is unsaved. Are you sure want to load a different one?", "Are you sure?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.DefaultExt = "xml";
                ofd.Filter = "Dialog XML files (*.xml)|*.xml";
                ofd.AddExtension = true;
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                ofd.ShowDialog();
                if (!String.IsNullOrEmpty(ofd.FileName))
                {
                    open(ofd.FileName);
                }
            }
        }

        void saveTo(string filename)
        {
            XmlSerializer xml = new XmlSerializer(activeDialog.GetType());
            TextWriter tw = new StreamWriter(filename);
            xml.Serialize(tw, activeDialog);
            tw.Close();
            unsaved = false;
            LoadedFile = filename;
            refreshLibrary();
        }

        void saveAs()
        {
            if (activeDialog == null)
            {
                MessageBox.Show("No dialog open");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "xml";
            sfd.Filter = "Dialog XML files (*.xml)|*.xml";
            sfd.AddExtension = true;
            sfd.ShowDialog();
            if (!String.IsNullOrEmpty(sfd.FileName))
            {
                saveTo(sfd.FileName);
            }
        }

        void activeDialog_Change(object sender, EventArgs e)
        {
            unsaved = true;
        }

        void dialogTreeViewer1_SelectionChanged(object sender, EventArgs e)
        {
            if (dialogTreeViewer1.SelectedNode != null)
            {
                prepareToolKit(dialogTreeViewer1.SelectedNode);
            }
        }

        private void prepareToolKit(DialogNode dialogNode)
        {
            tabControl1.TabPages.Clear();
            foreach (TabPage tp in tabPages)
            {
                foreach (string s in ((string)tp.Tag).Split(','))
                {
                    if ((int)dialogNode.NodeType == Int32.Parse(s))
                    {
                        tabControl1.TabPages.Add(tp);
                        break;
                    }
                } 
            }

            if (dialogNode.NodeType == DialogNodeType.Action)
            {
                var node = dialogTreeViewer1.SelectedNode as ActionNode;
                conditionalScriptBox.Text = node.Conditions;
                actionScriptBox.Text = node.Script;
            }
            else if (dialogNode.NodeType == DialogNodeType.Response)
            {
                var node = dialogTreeViewer1.SelectedNode as ResponseNode;
                conditionalScriptBox.Text = node.Conditions;
                txtResponse.Text = node.Text;
            }
        }


        private void newDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void openDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            fbd.ShowDialog();
            if (!String.IsNullOrEmpty(fbd.SelectedPath))
            {
                openLibrary(fbd.SelectedPath);
            }

        }


        private void openLibrary(string folder, bool silent = false)
        {
            Properties.Settings.Default.LibraryFolder = folder;
            Properties.Settings.Default.Save();
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Dialog));
                List<string> dialogs = new List<string>();
                string[] filePaths = Directory.GetFiles(folder, "*.xml");
                foreach (string file in filePaths)
                {
                    //xml.CanDeserialize(
                    using (var fs = new FileStream(file, FileMode.Open))
                    {
                        XmlReader xr = XmlReader.Create(fs);
                        if (xml.CanDeserialize(xr))
                        {
                            dialogs.Add(Path.GetFileNameWithoutExtension(file));
                        }
                        xr.Close();
                    }
                }
                libraryTreeView.Nodes.Clear();
                TreeNode tn = libraryTreeView.Nodes.Add("Dialogs");
                foreach (var s in dialogs)
                {
                    tn.Nodes.Add(s);
                }
            }
            catch (Exception ex)
            {
                if (!silent)
                    MessageBox.Show(ex.Message);
            }
        }

        private void conditionalScriptBox_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (dialogTreeViewer1.SelectedNode == null) return;
            if (dialogTreeViewer1.SelectedNode.NodeType == DialogNodeType.Action)
            {
                ActionNode an = dialogTreeViewer1.SelectedNode as ActionNode;
                if (an != null)
                    an.Conditions = conditionalScriptBox.Text;
            }
            else
            {
                ResponseNode rn = dialogTreeViewer1.SelectedNode as ResponseNode;
                if (rn != null)
                    rn.Conditions = conditionalScriptBox.Text;
            }
        }

        private void actionScriptBox_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            ActionNode an = dialogTreeViewer1.SelectedNode as ActionNode;
            if (an != null)
                an.Script = actionScriptBox.Text;
                
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void exportToLua(string source, string destFolder)
        {
            Dialog d = dialogFromFile(source);
            TextWriter tw = new StreamWriter(Path.Combine(destFolder, Path.GetFileNameWithoutExtension(source) + ".lua"));
            tw.Write(d.ToLua(0));
            tw.Close();
        }

        private void exportToLuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "lua";
            sfd.Filter = "Dialog XML files (*.xml)|*.xml";
            sfd.AddExtension = true;
            sfd.ShowDialog();
            if (!String.IsNullOrEmpty(sfd.FileName))
            {
                //TextWriter tw = new StreamWriter(sfd.FileName);
                //tw.Write(activeDialog.ToLua(0));
                //tw.Close();
                //MessageBox.Show("Success!");
                Stream s = new FileStream(sfd.FileName, FileMode.Create);
                LuaSerializer ls = new LuaSerializer(typeof(Dialog));
                ls.Serialize(activeDialog, s);
                s.Close();
            }
        }

        private void txtResponse_TextChanged(object sender, EventArgs e)
        {
            ResponseNode rn = dialogTreeViewer1.SelectedNode as ResponseNode;
            if (rn != null)
                rn.Text = txtResponse.Text;
        }

        private void txtLinkID_TextChanged(object sender, EventArgs e)
        {
            
            LinkNode rn = dialogTreeViewer1.SelectedNode as LinkNode;
            if (rn != null)
            {
                int id = 0;
                if (Int32.TryParse(txtLinkID.Text, out id))
                {
                    rn.LinkedID = id;
                }
                else
                {
                    rn.LinkedID = -1;
                }
            }
                
        }

        private void txtLinkID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void libraryTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text != "Dialogs")
            {
                string filename = Path.Combine(Properties.Settings.Default.LibraryFolder, e.Node.Text + ".xml");
                open(filename);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (!String.IsNullOrEmpty(Properties.Settings.Default.ExportFolder))
            {
                fbd.SelectedPath = Properties.Settings.Default.ExportFolder;
            }
            fbd.Description = "Select lua output folder";
            fbd.ShowDialog();
            if (!String.IsNullOrEmpty(fbd.SelectedPath))
            {
                Properties.Settings.Default.ExportFolder = fbd.SelectedPath;
                Properties.Settings.Default.Save();

                foreach (TreeNode n in libraryTreeView.TopNode.Nodes)
                {
                    exportToLua(Path.Combine(Properties.Settings.Default.LibraryFolder, n.Text + ".xml"), fbd.SelectedPath);
                }
            }
            MessageBox.Show("Success!");
        }

        private void saveDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LoadedFile))
            {
                saveAs();
            }
            else
            {
                saveTo(LoadedFile);
            }
        }

        bool treeviewHack = false;

        private void libraryTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Text == "Dialogs") e.Cancel = true;
            if (!treeviewHack)
            {
                treeviewHack = true;
                if (unsaved && MessageBox.Show("The current dialog is unsaved. Are you sure want to load a different one?", "Are you sure?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;

                }
                else
                {
                    unsaved = false;
                }
            }
            treeviewHack = false;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            open();
        }














    }
}
