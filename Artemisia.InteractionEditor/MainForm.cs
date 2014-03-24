using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Types.Interaction;
using System.Xml.Serialization;
using System.IO;

namespace Artemisia.InteractionEditor
{
    public partial class MainForm : Form
    {

        private string lastLoaded = null;

        private InteractableCollection activeCollection;


        public InteractableCollection ActiveCollection
        {
            get { return activeCollection; }
            set { 
                activeCollection = value;
                updateControls();
            }
        }

        public MainForm()
        {
            InitializeComponent();
            cmbIconType.Items.Clear();
            foreach (var i in Enum.GetValues(typeof(Interaction.InteractionType)))
            {
                cmbIconType.Items.Add(i);
            }
            cmbIconType.SelectedIndex = 0;
            cmbIconType_SelectionChangeCommitted(this, EventArgs.Empty);
            ActiveCollection = new InteractableCollection();

        }

        private void updateInteractableList()
        {
            lstInteractable.DataSource = activeCollection;
            lstInteractable.DisplayMember = "ScriptAlias";
        }

        private void updateInteractionTab()
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            if (i != null)
            {
                lstInteractions.DataSource = i.Interactions;
                //lstInteractions.DisplayMember = "Text";
                onSelectInteraction();
            }
            else
            {
                lstInteractions.DataSource = null;
                onSelectInteraction();
            }
        }

        private void onSelectInteraction()
        {
            Interaction i = lstInteractions.SelectedItem as Interaction;
            Interactable interactable = lstInteractable.SelectedItem as Interactable;
            if (i != null && interactable != null)
            {
                txtInteractionName.Enabled = true;
                luaInteractionAction.Enabled = true;
                luaInteractionCondition.Enabled = true;
                txtInteractionName.Text = i.ToolTipText;
                luaInteractionAction.Text = i.Action;
                luaInteractionCondition.Text = i.Condition;
                txtInteractionItem.Text = i.CustomItem;
                cmbIconType.SelectedIndex = (int)i.Type;
                cmbIconType.Enabled = true;
                Interaction.InteractionType t = (Interaction.InteractionType)cmbIconType.SelectedItem;
                txtInteractionItem.Enabled = t == Interaction.InteractionType.Item;
            }
            else
            {
                txtInteractionItem.Text = "";
                txtInteractionItem.Enabled = false;
                cmbIconType.Enabled = false;
                txtInteractionName.Text = "";
                txtInteractionName.Enabled = false;
                luaInteractionAction.Enabled = false;
                luaInteractionCondition.Enabled = false;
            }
        }

        private void updateNamesTab()
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            if (i != null)
            {
                txtScriptAlias.Enabled = true;
                txtScriptAlias.Text = i.ScriptAlias;
                lstNames.Enabled = true;
                luaCondition.Enabled = false;
                lstNames.DataSource = i.Names;
                onSelectName();
            }
            else
            {
                txtScriptAlias.Text = "";
                txtScriptAlias.Enabled = false;
                lstNames.Enabled = false;
                lstNames.DataSource = null;
                txtName.Text = "";
                txtName.Enabled = false;
                luaCondition.Text = "";
                luaCondition.Enabled = false;
            }
        }

        private void onSelectName()
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            InteractableName name = lstNames.SelectedItem as InteractableName;
            if (name != null && i != null)
            {
                txtName.Text = name.Name;
                txtName.Enabled = true;
                luaCondition.Enabled = true;
                luaCondition.Text = name.Condition;
            }
            else
            {
                luaCondition.Text = "";
                luaCondition.Enabled = false;
                txtName.Text = "";
                txtName.Enabled = true;
            }
        }


        void updateControls()
        {
            updateInteractableList();
            updateNamesTab();
            updateInteractionTab();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void luaCondition_Load(object sender, EventArgs e)
        {

        }



        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lstNames.Focused)
                return;
            onSelectName();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            InteractableName name = lstNames.SelectedItem as InteractableName;
            if (name != null)
            {
                name.Name = txtName.Text;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {

        }

        private void luaCondition_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            InteractableName name = lstNames.SelectedItem as InteractableName;
            if (name != null)
            {
                name.Condition = luaCondition.Text;
            }
        }

        private void txtScriptAlias_TextChanged(object sender, EventArgs e)
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            if (i != null)
            {
                i.ScriptAlias = txtScriptAlias.Text;
            }
        }

        private void btnAddInteractable_Click(object sender, EventArgs e)
        {
            ActiveCollection.Add(Interactable.Default());
            updateNamesTab();
            updateInteractionTab();
        }

        private void txtScriptAlias_Leave(object sender, EventArgs e)
        {
            if (txtScriptAlias.Text == "")
            {
                MessageBox.Show("Script alias cannot be blank.");
                txtScriptAlias.Focus();
            }
        }

        private void btnNewName_Click(object sender, EventArgs e)
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            if (i != null)
            {
                InteractableName name = new InteractableName();
                i.Names.Add(name);
                onSelectName();
            }
        }

        private void btnRemoveName_Click(object sender, EventArgs e)
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            InteractableName name = lstNames.SelectedItem as InteractableName;
            if (i != null && name != null)
            {
                var answer = MessageBox.Show("Are you sure you want to remove this name?", "Are you sure?", MessageBoxButtons.YesNo);
                if (answer == System.Windows.Forms.DialogResult.Yes)
                {
                    i.Names.Remove(name);
                    onSelectName();
                }
            }
        }

        private void btnMoveNameUp_Click(object sender, EventArgs e)
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            InteractableName name = lstNames.SelectedItem as InteractableName;
            if (i != null && name != null)
            {
                int index = lstNames.SelectedIndex;
                if (index > 0)
                {
                    i.Names[index] = i.Names[index - 1];
                    i.Names[index - 1] = name;
                    lstNames.SelectedIndex = index - 1;
                }
            }
        }

        private void btnMoveNameDown_Click(object sender, EventArgs e)
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            InteractableName name = lstNames.SelectedItem as InteractableName;
            if (i != null && name != null)
            {
                int index = lstNames.SelectedIndex;
                if (index < lstNames.Items.Count - 1)
                {
                    i.Names[index] = i.Names[index + 1];
                    i.Names[index + 1] = name;
                    lstNames.SelectedIndex = index + 1;
                }
            }
        }

        private void txtScriptAlias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar)) // only allow letters
                e.Handled = true;
        }


        private void txtInteractionName_TextChanged(object sender, EventArgs e)
        {
            Interaction i = lstInteractions.SelectedItem as Interaction;
            Interactable interactable = lstInteractable.SelectedItem as Interactable;
            if (i != null & interactable != null)
            {
                i.ToolTipText = txtInteractionName.Text;
            }
        }

        private void btnMoveInteractionUp_Click(object sender, EventArgs e)
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            Interaction action = lstInteractions.SelectedItem as Interaction;
            if (i != null && action != null)
            {
                int index = lstInteractions.SelectedIndex;
                if (index > 0)
                {
                    i.Interactions[index] = i.Interactions[index - 1];
                    i.Interactions[index - 1] = action;
                    lstInteractions.SelectedIndex = index - 1;
                }
            }
        }

        private void btnMoveInteractionDown_Click(object sender, EventArgs e)
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            Interaction action = lstInteractions.SelectedItem as Interaction;
            if (i != null && action != null)
            {
                int index = lstInteractions.SelectedIndex;
                if (index < lstInteractions.Items.Count - 1)
                {
                    i.Interactions[index] = i.Interactions[index + 1];
                    i.Interactions[index + 1] = action;
                    lstInteractions.SelectedIndex = index + 1;
                }
            }
        }

        private void btnNewInteraction_Click(object sender, EventArgs e)
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            if (i != null)
            {
                if (lstInteractions.SelectedIndex > -1)
                {
                    i.Interactions.Insert(lstInteractions.SelectedIndex, Interaction.Default());
                    lstInteractions.SelectedIndex--;
                }
                else
                    i.Interactions.Add(Interaction.Default());
                onSelectInteraction();
            }
        }

        private void btnRemoveInteraction_Click(object sender, EventArgs e)
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            Interaction action = lstInteractions.SelectedItem as Interaction; 
            if (i != null && action != null)
            {
                var answer = MessageBox.Show("Are you sure you want to remove this interaction?", "Are you sure?", MessageBoxButtons.YesNo);
                if (answer == System.Windows.Forms.DialogResult.Yes)
                {
                    i.Interactions.Remove(action);
                    onSelectInteraction();
                }
            }
        }

        private void btnRemoveInteractable_Click(object sender, EventArgs e)
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            activeCollection.Remove(i);
            updateControls();
        }

        private void newCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure you want to start a new collection?\r\nYour current project will be lost.", "Are you sure?", MessageBoxButtons.YesNo);
            if (answer == System.Windows.Forms.DialogResult.Yes)
            {
                lastLoaded = null;
                ActiveCollection = new InteractableCollection();
            }
        }

        private void lstInteractable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstInteractable.Focused)
            {
                updateControls();
            }
        }

        private void lstInteractions_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstInteractions.Focused)
            {
                onSelectInteraction();
            }
        }

        private void lstNames_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstNames.Focused)
            {
                onSelectName();
            }
        }

        private void btnCloneInteraction_Click(object sender, EventArgs e)
        {
            Interactable i = lstInteractable.SelectedItem as Interactable;
            Interaction action = lstInteractions.SelectedItem as Interaction;
            if (i != null && action != null)
            {
                Interaction cloned = (Interaction)action.Clone();
                i.Interactions.Insert(lstInteractions.SelectedIndex, cloned);
                lstInteractions.SelectedIndex--;
                onSelectInteraction();
            }
        }

        private void cmbIconType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Interaction.InteractionType t = (Interaction.InteractionType)cmbIconType.SelectedItem;
            txtInteractionItem.Enabled = t == Interaction.InteractionType.Item;
            Interaction action = lstInteractions.SelectedItem as Interaction;
            if (action != null)
            {
                action.Type = t;
                txtInteractionItem.Text = action.CustomItem;
            }
        }

        private void luaInteractionAction_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            Interaction action = lstInteractions.SelectedItem as Interaction;
            if (action != null)
                action.Action = luaInteractionAction.Text;
        }

        private void luaInteractionCondition_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            Interaction action = lstInteractions.SelectedItem as Interaction;
            if (action != null)
                action.Condition = luaInteractionCondition.Text;
        }

        private void txtInteractionItem_TextChanged(object sender, EventArgs e)
        {
            Interaction action = lstInteractions.SelectedItem as Interaction;
            if (action != null)
                action.CustomItem = txtInteractionItem.Text;
        }

        private void txtInteractionItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar)) // only allow letters
                e.Handled = true;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files|*.xml";
            ofd.Multiselect = false;
            ofd.ShowDialog();
            if (!String.IsNullOrEmpty(ofd.FileName))
            {
                lastLoaded = ofd.FileName;
                XmlSerializer xml = new XmlSerializer(typeof(InteractableCollection));
                using (TextReader tw = new StreamReader(lastLoaded))
                {
                    ActiveCollection = (InteractableCollection)xml.Deserialize(tw);
                    tw.Close();
                }
            }
        }

        void saveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Files|*.xml";
            sfd.ShowDialog();
            if (!String.IsNullOrEmpty(sfd.FileName))
                saveTo(sfd.FileName);
        }

        void saveTo(string filename)
        {
            XmlSerializer xml = new XmlSerializer(typeof(InteractableCollection));
            using (TextWriter tw = new StreamWriter(filename))
            {
                xml.Serialize(tw,ActiveCollection);
                tw.Close();
            }
            lastLoaded = filename;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lastLoaded == null)
                saveAs();
            else
                saveTo(lastLoaded);

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void btnValidateAction_Click(object sender, EventArgs e)
        {
            string error = Types.Utils.ValidateArtemisScript(luaInteractionAction.Text);
            if (error != null)
            {
                MessageBox.Show(error);
            }
            else
            {
                MessageBox.Show("No errors.");
            }
        }

      


    }
}
