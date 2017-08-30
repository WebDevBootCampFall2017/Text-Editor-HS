namespace Project_2_Text_Editor
{
    partial class frmFind
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
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblFind = new System.Windows.Forms.Label();
            this.btnCancelFind = new System.Windows.Forms.Button();
            this.lblReplace = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.AcceptsTab = true;
            this.txtFind.Location = new System.Drawing.Point(47, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(186, 22);
            this.txtFind.TabIndex = 0;
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(239, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(80, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(12, 17);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(29, 12);
            this.lblFind.TabIndex = 2;
            this.lblFind.Text = "Find:";
            // 
            // btnCancelFind
            // 
            this.btnCancelFind.Location = new System.Drawing.Point(325, 12);
            this.btnCancelFind.Name = "btnCancelFind";
            this.btnCancelFind.Size = new System.Drawing.Size(80, 23);
            this.btnCancelFind.TabIndex = 3;
            this.btnCancelFind.Text = "Cancel";
            this.btnCancelFind.UseVisualStyleBackColor = true;
            this.btnCancelFind.Click += new System.EventHandler(this.btnCancelFind_Click);
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(12, 45);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(68, 12);
            this.lblReplace.TabIndex = 4;
            this.lblReplace.Text = "Replace with:";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(86, 40);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(147, 22);
            this.txtReplace.TabIndex = 5;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(239, 40);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(166, 23);
            this.btnReplace.TabIndex = 6;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 73);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.btnCancelFind);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(433, 124);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(433, 85);
            this.Name = "frmFind";
            this.ShowIcon = false;
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnCancelFind;
        public System.Windows.Forms.Label lblReplace;
        public System.Windows.Forms.TextBox txtReplace;
        public System.Windows.Forms.Button btnReplace;
    }
}