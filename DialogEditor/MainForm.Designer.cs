namespace Artemisia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToLuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.libraryTreeView = new System.Windows.Forms.TreeView();
            this.dialogSplitContainer = new System.Windows.Forms.SplitContainer();
            this.lblLoaded = new System.Windows.Forms.Label();
            this.dialogTreeViewer1 = new Artemisia.DialogTreeViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.conditionalScriptBox = new Artemisia.LuaScriptBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.actionScriptBox = new Artemisia.LuaScriptBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtLinkID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dialogSplitContainer)).BeginInit();
            this.dialogSplitContainer.Panel1.SuspendLayout();
            this.dialogSplitContainer.Panel2.SuspendLayout();
            this.dialogSplitContainer.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionalScriptBox)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionScriptBox)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDialogToolStripMenuItem,
            this.openDialogToolStripMenuItem,
            this.toolStripMenuItem4,
            this.saveDialogToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exportToLuaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // newDialogToolStripMenuItem
            // 
            this.newDialogToolStripMenuItem.Name = "newDialogToolStripMenuItem";
            this.newDialogToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.newDialogToolStripMenuItem.Text = "New";
            this.newDialogToolStripMenuItem.Click += new System.EventHandler(this.newDialogToolStripMenuItem_Click);
            // 
            // openDialogToolStripMenuItem
            // 
            this.openDialogToolStripMenuItem.Name = "openDialogToolStripMenuItem";
            this.openDialogToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openDialogToolStripMenuItem.Text = "Open Library";
            this.openDialogToolStripMenuItem.Click += new System.EventHandler(this.openDialogToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem4.Text = "Open Dialog";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // saveDialogToolStripMenuItem
            // 
            this.saveDialogToolStripMenuItem.Name = "saveDialogToolStripMenuItem";
            this.saveDialogToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.saveDialogToolStripMenuItem.Text = "Save";
            this.saveDialogToolStripMenuItem.Click += new System.EventHandler(this.saveDialogToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 6);
            // 
            // exportToLuaToolStripMenuItem
            // 
            this.exportToLuaToolStripMenuItem.Name = "exportToLuaToolStripMenuItem";
            this.exportToLuaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.exportToLuaToolStripMenuItem.Text = "Export to Lua";
            this.exportToLuaToolStripMenuItem.Click += new System.EventHandler(this.exportToLuaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem3.Text = "Export whole library to Lua";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.libraryTreeView);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.dialogSplitContainer);
            this.mainSplitContainer.Size = new System.Drawing.Size(1037, 501);
            this.mainSplitContainer.SplitterDistance = 196;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // libraryTreeView
            // 
            this.libraryTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryTreeView.Location = new System.Drawing.Point(0, 0);
            this.libraryTreeView.Name = "libraryTreeView";
            this.libraryTreeView.Size = new System.Drawing.Size(196, 501);
            this.libraryTreeView.TabIndex = 0;
            this.libraryTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.libraryTreeView_BeforeSelect);
            this.libraryTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.libraryTreeView_AfterSelect);
            // 
            // dialogSplitContainer
            // 
            this.dialogSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.dialogSplitContainer.Name = "dialogSplitContainer";
            this.dialogSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // dialogSplitContainer.Panel1
            // 
            this.dialogSplitContainer.Panel1.Controls.Add(this.lblLoaded);
            this.dialogSplitContainer.Panel1.Controls.Add(this.dialogTreeViewer1);
            // 
            // dialogSplitContainer.Panel2
            // 
            this.dialogSplitContainer.Panel2.Controls.Add(this.tabControl1);
            this.dialogSplitContainer.Size = new System.Drawing.Size(837, 501);
            this.dialogSplitContainer.SplitterDistance = 229;
            this.dialogSplitContainer.TabIndex = 2;
            // 
            // lblLoaded
            // 
            this.lblLoaded.AutoSize = true;
            this.lblLoaded.Location = new System.Drawing.Point(12, 9);
            this.lblLoaded.Name = "lblLoaded";
            this.lblLoaded.Size = new System.Drawing.Size(93, 13);
            this.lblLoaded.TabIndex = 1;
            this.lblLoaded.Text = "Currently Loaded: ";
            // 
            // dialogTreeViewer1
            // 
            this.dialogTreeViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogTreeViewer1.Location = new System.Drawing.Point(0, 28);
            this.dialogTreeViewer1.Name = "dialogTreeViewer1";
            this.dialogTreeViewer1.Size = new System.Drawing.Size(837, 201);
            this.dialogTreeViewer1.TabIndex = 0;
            this.dialogTreeViewer1.SelectionChanged += new System.EventHandler(this.dialogTreeViewer1_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 268);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(829, 242);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = "1,3";
            this.tabPage3.Text = "Conditions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.conditionalScriptBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(829, 242);
            this.panel5.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(438, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(383, 230);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // conditionalScriptBox
            // 
            this.conditionalScriptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionalScriptBox.AutoScrollMinSize = new System.Drawing.Size(131, 14);
            this.conditionalScriptBox.BackBrush = null;
            this.conditionalScriptBox.CharHeight = 14;
            this.conditionalScriptBox.CharWidth = 8;
            this.conditionalScriptBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.conditionalScriptBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.conditionalScriptBox.IsReplaceMode = false;
            this.conditionalScriptBox.Location = new System.Drawing.Point(8, 5);
            this.conditionalScriptBox.Name = "conditionalScriptBox";
            this.conditionalScriptBox.Paddings = new System.Windows.Forms.Padding(0);
            this.conditionalScriptBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.conditionalScriptBox.Size = new System.Drawing.Size(424, 233);
            this.conditionalScriptBox.TabIndex = 4;
            this.conditionalScriptBox.Text = "luaScriptBox1";
            this.conditionalScriptBox.Zoom = 100;
            this.conditionalScriptBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.conditionalScriptBox_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.actionScriptBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(829, 242);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Tag = "1";
            this.tabPage4.Text = "Actions";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // actionScriptBox
            // 
            this.actionScriptBox.AutoScrollMinSize = new System.Drawing.Size(106, 14);
            this.actionScriptBox.BackBrush = null;
            this.actionScriptBox.CharHeight = 14;
            this.actionScriptBox.CharWidth = 8;
            this.actionScriptBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.actionScriptBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.actionScriptBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionScriptBox.IsReplaceMode = false;
            this.actionScriptBox.Location = new System.Drawing.Point(0, 0);
            this.actionScriptBox.Name = "actionScriptBox";
            this.actionScriptBox.Paddings = new System.Windows.Forms.Padding(0);
            this.actionScriptBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.actionScriptBox.Size = new System.Drawing.Size(829, 242);
            this.actionScriptBox.TabIndex = 0;
            this.actionScriptBox.Text = "luaScriptBox1";
            this.actionScriptBox.Zoom = 100;
            this.actionScriptBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.actionScriptBox_TextChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtLinkID);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(829, 242);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Tag = "2";
            this.tabPage5.Text = "Link";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtLinkID
            // 
            this.txtLinkID.Location = new System.Drawing.Point(66, 19);
            this.txtLinkID.Name = "txtLinkID";
            this.txtLinkID.Size = new System.Drawing.Size(100, 20);
            this.txtLinkID.TabIndex = 1;
            this.txtLinkID.Text = "0";
            this.txtLinkID.TextChanged += new System.EventHandler(this.txtLinkID_TextChanged);
            this.txtLinkID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLinkID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Link ID";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.panel3);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(829, 242);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Tag = "3";
            this.tabPage6.Text = "Response";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtResponse);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 236);
            this.panel3.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(76, 12);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(714, 20);
            this.txtResponse.TabIndex = 1;
            this.txtResponse.Text = "Response Text";
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Response";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 525);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Artemisia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.dialogSplitContainer.Panel1.ResumeLayout(false);
            this.dialogSplitContainer.Panel1.PerformLayout();
            this.dialogSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dialogSplitContainer)).EndInit();
            this.dialogSplitContainer.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionalScriptBox)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actionScriptBox)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToLuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TreeView libraryTreeView;
        private System.Windows.Forms.SplitContainer dialogSplitContainer;
        private DialogTreeViewer dialogTreeViewer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private LuaScriptBox conditionalScriptBox;
        private System.Windows.Forms.TabPage tabPage4;
        private LuaScriptBox actionScriptBox;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtLinkID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label lblLoaded;
    }
}