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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsFile,
            this.mnsEdit,
            this.mnsView,
            this.mnsAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsFile
            // 
            this.mnsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsOpenFile,
            this.mnsSave,
            this.mnsSaveAs});
            this.mnsFile.Name = "mnsFile";
            this.mnsFile.Size = new System.Drawing.Size(37, 20);
            this.mnsFile.Text = "File";
            // 
            // mnsOpenFile
            // 
            this.mnsOpenFile.Name = "mnsOpenFile";
            this.mnsOpenFile.Size = new System.Drawing.Size(152, 22);
            this.mnsOpenFile.Text = "Open File";
            this.mnsOpenFile.Click += new System.EventHandler(this.mnsOpenFile_Click);
            // 
            // mnsSave
            // 
            this.mnsSave.Name = "mnsSave";
            this.mnsSave.Size = new System.Drawing.Size(152, 22);
            this.mnsSave.Text = "Save";
            this.mnsSave.Click += new System.EventHandler(this.mnsSave_Click);
            // 
            // mnsSaveAs
            // 
            this.mnsSaveAs.Name = "mnsSaveAs";
            this.mnsSaveAs.Size = new System.Drawing.Size(152, 22);
            this.mnsSaveAs.Text = "Save As";
            this.mnsSaveAs.Click += new System.EventHandler(this.mnsSaveAs_Click);
            // 
            // mnsEdit
            // 
            this.mnsEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsFind});
            this.mnsEdit.Name = "mnsEdit";
            this.mnsEdit.Size = new System.Drawing.Size(39, 20);
            this.mnsEdit.Text = "Edit";
            // 
            // mnsFind
            // 
            this.mnsFind.Name = "mnsFind";
            this.mnsFind.Size = new System.Drawing.Size(152, 22);
            this.mnsFind.Text = "Find";
            this.mnsFind.Click += new System.EventHandler(this.mnsFind_Click);
            // 
            // mnsView
            // 
            this.mnsView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsWordWrap});
            this.mnsView.Name = "mnsView";
            this.mnsView.Size = new System.Drawing.Size(44, 20);
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
            // mnsAbout
            // 
            this.mnsAbout.Name = "mnsAbout";
            this.mnsAbout.Size = new System.Drawing.Size(52, 20);
            this.mnsAbout.Text = "About";
            // 
            // rtxRichTextBox
            // 
            this.rtxRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxRichTextBox.Location = new System.Drawing.Point(0, 24);
            this.rtxRichTextBox.Name = "rtxRichTextBox";
            this.rtxRichTextBox.Size = new System.Drawing.Size(660, 355);
            this.rtxRichTextBox.TabIndex = 2;
            this.rtxRichTextBox.Text = "";
            // 
            // frmTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 379);
            this.Controls.Add(this.rtxRichTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTextEditor";
            this.Text = "Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsFile;
        private System.Windows.Forms.ToolStripMenuItem mnsOpenFile;
        private System.Windows.Forms.ToolStripMenuItem mnsSave;
        private System.Windows.Forms.ToolStripMenuItem mnsEdit;
        private System.Windows.Forms.ToolStripMenuItem mnsView;
        private System.Windows.Forms.ToolStripMenuItem mnsSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnsFind;
        private System.Windows.Forms.ToolStripMenuItem mnsWordWrap;
        private System.Windows.Forms.ToolStripMenuItem mnsAbout;
        private System.Windows.Forms.RichTextBox rtxRichTextBox;
    }
}

