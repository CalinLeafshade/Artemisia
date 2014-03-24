namespace Artemisia.InteractionEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRemoveInteractable = new System.Windows.Forms.Button();
            this.btnAddInteractable = new System.Windows.Forms.Button();
            this.lstInteractable = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.luaCondition = new Artemisia.LuaScriptBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMoveNameDown = new System.Windows.Forms.Button();
            this.btnMoveNameUp = new System.Windows.Forms.Button();
            this.btnNewName = new System.Windows.Forms.Button();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.txtScriptAlias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCloneInteraction = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtInteractionItem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbIconType = new System.Windows.Forms.ComboBox();
            this.txtInteractionName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.luaInteractionCondition = new Artemisia.LuaScriptBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.luaInteractionAction = new Artemisia.LuaScriptBox();
            this.btnMoveInteractionDown = new System.Windows.Forms.Button();
            this.btnMoveInteractionUp = new System.Windows.Forms.Button();
            this.btnNewInteraction = new System.Windows.Forms.Button();
            this.btnRemoveInteraction = new System.Windows.Forms.Button();
            this.lstInteractions = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnValidateAction = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luaCondition)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luaInteractionCondition)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luaInteractionAction)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCollectionToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCollectionToolStripMenuItem
            // 
            this.newCollectionToolStripMenuItem.Name = "newCollectionToolStripMenuItem";
            this.newCollectionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newCollectionToolStripMenuItem.Text = "New Collection";
            this.newCollectionToolStripMenuItem.Click += new System.EventHandler(this.newCollectionToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(785, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRemoveInteractable);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddInteractable);
            this.splitContainer1.Panel1.Controls.Add(this.lstInteractable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(785, 489);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnRemoveInteractable
            // 
            this.btnRemoveInteractable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveInteractable.Location = new System.Drawing.Point(134, 463);
            this.btnRemoveInteractable.Name = "btnRemoveInteractable";
            this.btnRemoveInteractable.Size = new System.Drawing.Size(74, 23);
            this.btnRemoveInteractable.TabIndex = 2;
            this.btnRemoveInteractable.Text = "Remove";
            this.btnRemoveInteractable.UseVisualStyleBackColor = true;
            this.btnRemoveInteractable.Click += new System.EventHandler(this.btnRemoveInteractable_Click);
            // 
            // btnAddInteractable
            // 
            this.btnAddInteractable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInteractable.Location = new System.Drawing.Point(3, 463);
            this.btnAddInteractable.Name = "btnAddInteractable";
            this.btnAddInteractable.Size = new System.Drawing.Size(125, 23);
            this.btnAddInteractable.TabIndex = 1;
            this.btnAddInteractable.Text = "Add";
            this.btnAddInteractable.UseVisualStyleBackColor = true;
            this.btnAddInteractable.Click += new System.EventHandler(this.btnAddInteractable_Click);
            // 
            // lstInteractable
            // 
            this.lstInteractable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInteractable.FormattingEnabled = true;
            this.lstInteractable.IntegralHeight = false;
            this.lstInteractable.Location = new System.Drawing.Point(3, 3);
            this.lstInteractable.Name = "lstInteractable";
            this.lstInteractable.Size = new System.Drawing.Size(205, 457);
            this.lstInteractable.TabIndex = 0;
            this.lstInteractable.SelectedIndexChanged += new System.EventHandler(this.lstInteractable_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnMoveNameDown);
            this.tabPage1.Controls.Add(this.btnMoveNameUp);
            this.tabPage1.Controls.Add(this.btnNewName);
            this.tabPage1.Controls.Add(this.btnRemoveName);
            this.tabPage1.Controls.Add(this.lstNames);
            this.tabPage1.Controls.Add(this.txtScriptAlias);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Names";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.luaCondition);
            this.groupBox1.Location = new System.Drawing.Point(11, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 271);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name Edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Condition:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(62, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(471, 20);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // luaCondition
            // 
            this.luaCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.luaCondition.AutoScrollMinSize = new System.Drawing.Size(131, 14);
            this.luaCondition.BackBrush = null;
            this.luaCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.luaCondition.CharHeight = 14;
            this.luaCondition.CharWidth = 8;
            this.luaCondition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.luaCondition.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.luaCondition.IsReplaceMode = false;
            this.luaCondition.Location = new System.Drawing.Point(62, 45);
            this.luaCondition.Name = "luaCondition";
            this.luaCondition.Paddings = new System.Windows.Forms.Padding(0);
            this.luaCondition.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.luaCondition.Size = new System.Drawing.Size(471, 220);
            this.luaCondition.TabIndex = 4;
            this.luaCondition.Text = "luaScriptBox1";
            this.luaCondition.Zoom = 100;
            this.luaCondition.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.luaCondition_TextChanged);
            this.luaCondition.Load += new System.EventHandler(this.luaCondition_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name List:";
            // 
            // btnMoveNameDown
            // 
            this.btnMoveNameDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveNameDown.Image = global::Artemisia.InteractionEditor.Properties.Resources.arrowDown;
            this.btnMoveNameDown.Location = new System.Drawing.Point(516, 71);
            this.btnMoveNameDown.Name = "btnMoveNameDown";
            this.btnMoveNameDown.Size = new System.Drawing.Size(38, 32);
            this.btnMoveNameDown.TabIndex = 9;
            this.btnMoveNameDown.UseVisualStyleBackColor = true;
            this.btnMoveNameDown.Click += new System.EventHandler(this.btnMoveNameDown_Click);
            // 
            // btnMoveNameUp
            // 
            this.btnMoveNameUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveNameUp.Image = global::Artemisia.InteractionEditor.Properties.Resources.arrowUp;
            this.btnMoveNameUp.Location = new System.Drawing.Point(516, 33);
            this.btnMoveNameUp.Name = "btnMoveNameUp";
            this.btnMoveNameUp.Size = new System.Drawing.Size(38, 32);
            this.btnMoveNameUp.TabIndex = 8;
            this.btnMoveNameUp.UseVisualStyleBackColor = true;
            this.btnMoveNameUp.Click += new System.EventHandler(this.btnMoveNameUp_Click);
            // 
            // btnNewName
            // 
            this.btnNewName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewName.Image = global::Artemisia.InteractionEditor.Properties.Resources.addDocument;
            this.btnNewName.Location = new System.Drawing.Point(516, 109);
            this.btnNewName.Name = "btnNewName";
            this.btnNewName.Size = new System.Drawing.Size(38, 32);
            this.btnNewName.TabIndex = 7;
            this.btnNewName.UseVisualStyleBackColor = true;
            this.btnNewName.Click += new System.EventHandler(this.btnNewName_Click);
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveName.Image = global::Artemisia.InteractionEditor.Properties.Resources.removeDocument;
            this.btnRemoveName.Location = new System.Drawing.Point(516, 147);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(38, 32);
            this.btnRemoveName.TabIndex = 6;
            this.btnRemoveName.UseVisualStyleBackColor = true;
            this.btnRemoveName.Click += new System.EventHandler(this.btnRemoveName_Click);
            // 
            // lstNames
            // 
            this.lstNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(73, 33);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(437, 147);
            this.lstNames.TabIndex = 3;
            this.lstNames.SelectedIndexChanged += new System.EventHandler(this.lstNames_SelectedIndexChanged);
            this.lstNames.SelectedValueChanged += new System.EventHandler(this.lstNames_SelectedValueChanged);
            // 
            // txtScriptAlias
            // 
            this.txtScriptAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScriptAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScriptAlias.Location = new System.Drawing.Point(73, 7);
            this.txtScriptAlias.Name = "txtScriptAlias";
            this.txtScriptAlias.Size = new System.Drawing.Size(477, 20);
            this.txtScriptAlias.TabIndex = 1;
            this.txtScriptAlias.TextChanged += new System.EventHandler(this.txtScriptAlias_TextChanged);
            this.txtScriptAlias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScriptAlias_KeyPress);
            this.txtScriptAlias.Leave += new System.EventHandler(this.txtScriptAlias_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Script Alias:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCloneInteraction);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.btnMoveInteractionDown);
            this.tabPage2.Controls.Add(this.btnMoveInteractionUp);
            this.tabPage2.Controls.Add(this.btnNewInteraction);
            this.tabPage2.Controls.Add(this.btnRemoveInteraction);
            this.tabPage2.Controls.Add(this.lstInteractions);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Interactions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCloneInteraction
            // 
            this.btnCloneInteraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloneInteraction.Image = ((System.Drawing.Image)(resources.GetObject("btnCloneInteraction.Image")));
            this.btnCloneInteraction.Location = new System.Drawing.Point(518, 159);
            this.btnCloneInteraction.Name = "btnCloneInteraction";
            this.btnCloneInteraction.Size = new System.Drawing.Size(38, 32);
            this.btnCloneInteraction.TabIndex = 15;
            this.btnCloneInteraction.UseVisualStyleBackColor = true;
            this.btnCloneInteraction.Click += new System.EventHandler(this.btnCloneInteraction_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(10, 199);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(546, 258);
            this.tabControl2.TabIndex = 14;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtInteractionItem);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.cmbIconType);
            this.tabPage5.Controls.Add(this.txtInteractionName);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(538, 232);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Properties";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtInteractionItem
            // 
            this.txtInteractionItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInteractionItem.Location = new System.Drawing.Point(62, 67);
            this.txtInteractionItem.Name = "txtInteractionItem";
            this.txtInteractionItem.Size = new System.Drawing.Size(470, 20);
            this.txtInteractionItem.TabIndex = 5;
            this.txtInteractionItem.TextChanged += new System.EventHandler(this.txtInteractionItem_TextChanged);
            this.txtInteractionItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInteractionItem_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Item";
            // 
            // cmbIconType
            // 
            this.cmbIconType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIconType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIconType.FormattingEnabled = true;
            this.cmbIconType.Items.AddRange(new object[] {
            "Not Sure about how to handle this yet"});
            this.cmbIconType.Location = new System.Drawing.Point(62, 40);
            this.cmbIconType.Name = "cmbIconType";
            this.cmbIconType.Size = new System.Drawing.Size(470, 21);
            this.cmbIconType.TabIndex = 3;
            this.cmbIconType.SelectionChangeCommitted += new System.EventHandler(this.cmbIconType_SelectionChangeCommitted);
            // 
            // txtInteractionName
            // 
            this.txtInteractionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInteractionName.Location = new System.Drawing.Point(62, 15);
            this.txtInteractionName.Name = "txtInteractionName";
            this.txtInteractionName.Size = new System.Drawing.Size(470, 20);
            this.txtInteractionName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtInteractionName, "Sets the tooltip in the verbcoin. Leave blank for a default value.");
            this.txtInteractionName.TextChanged += new System.EventHandler(this.txtInteractionName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tooltip";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.luaInteractionCondition);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(538, 232);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Condition";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // luaInteractionCondition
            // 
            this.luaInteractionCondition.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.luaInteractionCondition.BackBrush = null;
            this.luaInteractionCondition.CharHeight = 14;
            this.luaInteractionCondition.CharWidth = 8;
            this.luaInteractionCondition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.luaInteractionCondition.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.luaInteractionCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luaInteractionCondition.IsReplaceMode = false;
            this.luaInteractionCondition.Location = new System.Drawing.Point(3, 3);
            this.luaInteractionCondition.Name = "luaInteractionCondition";
            this.luaInteractionCondition.Paddings = new System.Windows.Forms.Padding(0);
            this.luaInteractionCondition.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.luaInteractionCondition.Size = new System.Drawing.Size(532, 226);
            this.luaInteractionCondition.TabIndex = 0;
            this.luaInteractionCondition.Zoom = 100;
            this.luaInteractionCondition.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.luaInteractionCondition_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnValidateAction);
            this.tabPage4.Controls.Add(this.luaInteractionAction);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(538, 232);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Action";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // luaInteractionAction
            // 
            this.luaInteractionAction.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.luaInteractionAction.BackBrush = null;
            this.luaInteractionAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.luaInteractionAction.CharHeight = 14;
            this.luaInteractionAction.CharWidth = 8;
            this.luaInteractionAction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.luaInteractionAction.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.luaInteractionAction.IsReplaceMode = false;
            this.luaInteractionAction.Location = new System.Drawing.Point(3, 3);
            this.luaInteractionAction.Name = "luaInteractionAction";
            this.luaInteractionAction.Paddings = new System.Windows.Forms.Padding(0);
            this.luaInteractionAction.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.luaInteractionAction.Size = new System.Drawing.Size(532, 197);
            this.luaInteractionAction.TabIndex = 0;
            this.luaInteractionAction.Zoom = 100;
            this.luaInteractionAction.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.luaInteractionAction_TextChanged);
            // 
            // btnMoveInteractionDown
            // 
            this.btnMoveInteractionDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveInteractionDown.Image = global::Artemisia.InteractionEditor.Properties.Resources.arrowDown;
            this.btnMoveInteractionDown.Location = new System.Drawing.Point(518, 45);
            this.btnMoveInteractionDown.Name = "btnMoveInteractionDown";
            this.btnMoveInteractionDown.Size = new System.Drawing.Size(38, 32);
            this.btnMoveInteractionDown.TabIndex = 13;
            this.btnMoveInteractionDown.UseVisualStyleBackColor = true;
            this.btnMoveInteractionDown.Click += new System.EventHandler(this.btnMoveInteractionDown_Click);
            // 
            // btnMoveInteractionUp
            // 
            this.btnMoveInteractionUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveInteractionUp.Image = global::Artemisia.InteractionEditor.Properties.Resources.arrowUp;
            this.btnMoveInteractionUp.Location = new System.Drawing.Point(518, 7);
            this.btnMoveInteractionUp.Name = "btnMoveInteractionUp";
            this.btnMoveInteractionUp.Size = new System.Drawing.Size(38, 32);
            this.btnMoveInteractionUp.TabIndex = 12;
            this.btnMoveInteractionUp.UseVisualStyleBackColor = true;
            this.btnMoveInteractionUp.Click += new System.EventHandler(this.btnMoveInteractionUp_Click);
            // 
            // btnNewInteraction
            // 
            this.btnNewInteraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewInteraction.Image = global::Artemisia.InteractionEditor.Properties.Resources.addDocument;
            this.btnNewInteraction.Location = new System.Drawing.Point(518, 83);
            this.btnNewInteraction.Name = "btnNewInteraction";
            this.btnNewInteraction.Size = new System.Drawing.Size(38, 32);
            this.btnNewInteraction.TabIndex = 11;
            this.btnNewInteraction.UseVisualStyleBackColor = true;
            this.btnNewInteraction.Click += new System.EventHandler(this.btnNewInteraction_Click);
            // 
            // btnRemoveInteraction
            // 
            this.btnRemoveInteraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveInteraction.Image = global::Artemisia.InteractionEditor.Properties.Resources.removeDocument;
            this.btnRemoveInteraction.Location = new System.Drawing.Point(518, 121);
            this.btnRemoveInteraction.Name = "btnRemoveInteraction";
            this.btnRemoveInteraction.Size = new System.Drawing.Size(38, 32);
            this.btnRemoveInteraction.TabIndex = 10;
            this.btnRemoveInteraction.UseVisualStyleBackColor = true;
            this.btnRemoveInteraction.Click += new System.EventHandler(this.btnRemoveInteraction_Click);
            // 
            // lstInteractions
            // 
            this.lstInteractions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInteractions.FormattingEnabled = true;
            this.lstInteractions.Location = new System.Drawing.Point(76, 7);
            this.lstInteractions.Name = "lstInteractions";
            this.lstInteractions.Size = new System.Drawing.Size(436, 186);
            this.lstInteractions.TabIndex = 1;
            this.lstInteractions.SelectedValueChanged += new System.EventHandler(this.lstInteractions_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Interactions";
            // 
            // btnValidateAction
            // 
            this.btnValidateAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnValidateAction.Location = new System.Drawing.Point(3, 206);
            this.btnValidateAction.Name = "btnValidateAction";
            this.btnValidateAction.Size = new System.Drawing.Size(199, 23);
            this.btnValidateAction.TabIndex = 1;
            this.btnValidateAction.Text = "Validate Script";
            this.btnValidateAction.UseVisualStyleBackColor = true;
            this.btnValidateAction.Click += new System.EventHandler(this.btnValidateAction_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 535);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Interaction Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luaCondition)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luaInteractionCondition)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luaInteractionAction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstInteractable;
        private System.Windows.Forms.ToolStripMenuItem newCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button btnRemoveInteractable;
        private System.Windows.Forms.Button btnAddInteractable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Label label3;
        private LuaScriptBox luaCondition;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.TextBox txtScriptAlias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNewName;
        private System.Windows.Forms.Button btnMoveNameUp;
        private System.Windows.Forms.Button btnMoveNameDown;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private LuaScriptBox luaInteractionCondition;
        private System.Windows.Forms.TabPage tabPage4;
        private LuaScriptBox luaInteractionAction;
        private System.Windows.Forms.Button btnMoveInteractionDown;
        private System.Windows.Forms.Button btnMoveInteractionUp;
        private System.Windows.Forms.Button btnNewInteraction;
        private System.Windows.Forms.Button btnRemoveInteraction;
        private System.Windows.Forms.ListBox lstInteractions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox cmbIconType;
        private System.Windows.Forms.TextBox txtInteractionName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCloneInteraction;
        private System.Windows.Forms.TextBox txtInteractionItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnValidateAction;
    }
}