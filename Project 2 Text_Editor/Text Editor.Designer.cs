namespace Project_2_Text_Editor
{
    partial class frmTextEditor
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnsFind = new System.Windows.Forms.ToolStripMenuItem();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsFile,
            this.mnsEdit,
            this.mnsView,
            this.mnsAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(660, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // mnsFile
            // 
            this.mnsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsOpenFile,
            this.mnsSave,
            this.mnsSaveAs,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.mnsFile.Name = "mnsFile";
            this.mnsFile.Size = new System.Drawing.Size(38, 20);
            this.mnsFile.Text = "File";
            // 
            // mnsOpenFile
            // 
            this.mnsOpenFile.Name = "mnsOpenFile";
            this.mnsOpenFile.Size = new System.Drawing.Size(128, 22);
            this.mnsOpenFile.Text = "Open File";
            this.mnsOpenFile.Click += new System.EventHandler(this.mnsOpenFile_Click);
            // 
            // mnsSave
            // 
            this.mnsSave.Name = "mnsSave";
            this.mnsSave.Size = new System.Drawing.Size(128, 22);
            this.mnsSave.Text = "Save";
            this.mnsSave.Click += new System.EventHandler(this.mnsSave_Click);
            // 
            // mnsSaveAs
            // 
            this.mnsSaveAs.Name = "mnsSaveAs";
            this.mnsSaveAs.Size = new System.Drawing.Size(128, 22);
            this.mnsSaveAs.Text = "Save As";
            this.mnsSaveAs.Click += new System.EventHandler(this.mnsSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnsEdit
            // 
            this.mnsEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.toolStripMenuItem2,
            this.mnsFind,
            this.findAndReplaceToolStripMenuItem});
            this.mnsEdit.Name = "mnsEdit";
            this.mnsEdit.Size = new System.Drawing.Size(41, 20);
            this.mnsEdit.Text = "Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(169, 6);
            // 
            // mnsFind
            // 
            this.mnsFind.Name = "mnsFind";
            this.mnsFind.Size = new System.Drawing.Size(172, 22);
            this.mnsFind.Text = "Find";
            this.mnsFind.Click += new System.EventHandler(this.mnsFind_Click);
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.findAndReplaceToolStripMenuItem.Text = "Find and Replace";
            this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
            // 
            // mnsView
            // 
            this.mnsView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsWordWrap,
            this.themeToolStripMenuItem});
            this.mnsView.Name = "mnsView";
            this.mnsView.Size = new System.Drawing.Size(46, 20);
            this.mnsView.Text = "View";
            // 
            // mnsWordWrap
            // 
            this.mnsWordWrap.Checked = true;
            this.mnsWordWrap.CheckOnClick = true;
            this.mnsWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnsWordWrap.Name = "mnsWordWrap";
            this.mnsWordWrap.Size = new System.Drawing.Size(152, 22);
            this.mnsWordWrap.Text = "Word Wrap";
            this.mnsWordWrap.Click += new System.EventHandler(this.mnsWordWrap_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defultToolStripMenuItem,
            this.matrixToolStripMenuItem,
            this.pinkyToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // defultToolStripMenuItem
            // 
            this.defultToolStripMenuItem.Name = "defultToolStripMenuItem";
            this.defultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.defultToolStripMenuItem.Text = "Default";
            this.defultToolStripMenuItem.Click += new System.EventHandler(this.defultToolStripMenuItem_Click);
            // 
            // matrixToolStripMenuItem
            // 
            this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
            this.matrixToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.matrixToolStripMenuItem.Text = "Matrix";
            this.matrixToolStripMenuItem.Click += new System.EventHandler(this.matrixToolStripMenuItem_Click);
            // 
            // pinkyToolStripMenuItem
            // 
            this.pinkyToolStripMenuItem.Name = "pinkyToolStripMenuItem";
            this.pinkyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pinkyToolStripMenuItem.Text = "Pinky";
            this.pinkyToolStripMenuItem.Click += new System.EventHandler(this.pinkyToolStripMenuItem_Click);
            // 
            // mnsAbout
            // 
            this.mnsAbout.Name = "mnsAbout";
            this.mnsAbout.Size = new System.Drawing.Size(54, 20);
            this.mnsAbout.Text = "About";
            this.mnsAbout.Click += new System.EventHandler(this.mnsAbout_Click);
            // 
            // rtxRichTextBox
            // 
            this.rtxRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxRichTextBox.Location = new System.Drawing.Point(0, 24);
            this.rtxRichTextBox.Name = "rtxRichTextBox";
            this.rtxRichTextBox.Size = new System.Drawing.Size(660, 326);
            this.rtxRichTextBox.TabIndex = 2;
            this.rtxRichTextBox.Text = "";
            this.rtxRichTextBox.TextChanged += new System.EventHandler(this.rtxRichTextBox_TextChanged);
            this.rtxRichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxRichTextBox_KeyDown);
            // 
            // frmTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 350);
            this.Controls.Add(this.rtxRichTextBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmTextEditor";
            this.Text = "Text Editor";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnsFile;
        private System.Windows.Forms.ToolStripMenuItem mnsOpenFile;
        private System.Windows.Forms.ToolStripMenuItem mnsSave;
        private System.Windows.Forms.ToolStripMenuItem mnsEdit;
        private System.Windows.Forms.ToolStripMenuItem mnsView;
        private System.Windows.Forms.ToolStripMenuItem mnsSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnsFind;
        private System.Windows.Forms.ToolStripMenuItem mnsWordWrap;
        private System.Windows.Forms.ToolStripMenuItem mnsAbout;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinkyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
        public System.Windows.Forms.RichTextBox rtxRichTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

