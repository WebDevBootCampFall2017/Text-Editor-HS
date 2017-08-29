using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2_Text_Editor
{
    public partial class frmTextEditor : Form
    {
        string AppName = "Text Editor";
        string _FileName = null;
        bool isSaved = false;

        public frmTextEditor()
        {
            InitializeComponent();
        }


        //Open a File
        private void mnsOpenFile_Click(object sender, EventArgs e)
        {
            string line;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files .txt|*.txt";
            ofd.Title = "Open File";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtxRichTextBox.Text = "";
                StreamReader sr = new StreamReader(ofd.FileName);
                while ((line = sr.ReadLine()) != null)
                {
                    rtxRichTextBox.Text += line + Environment.NewLine;
                }
                sr.Close();
                _FileName = ofd.FileName;
                this.Text = Path.GetFileName(_FileName) + " - " + AppName;
            }
        }

        private void mnsSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (_FileName == null)
            {
                sfd.Filter = "Text Files|*.txt";
                sfd.Title = "Save";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    isSaved = true;
                    rtxRichTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                    _FileName = sfd.FileName;
                    this.Text = Path.GetFileName(sfd.FileName) + " - " + AppName;
                }
            }
            else
            {
                isSaved = true;
                rtxRichTextBox.SaveFile(_FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("File Saved!!", "Title");
            }
        }

        private void mnsSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt";
            sfd.Title = "Save As";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                isSaved = true;
                rtxRichTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                this.Text = Path.GetFileName(sfd.FileName) + " - " + AppName;
            }
        }


        //WordWrap
        private void mnsWordWrap_Click(object sender, EventArgs e)
        {
            if (mnsWordWrap.Checked)
            {
                rtxRichTextBox.WordWrap = true;
            }
            else
            {
                rtxRichTextBox.WordWrap = false;
            }
        }

        //Find
        private void mnsFind_Click(object sender, EventArgs e)
        {
            frmFind formFind = new frmFind();
            formFind.Height = 85;
            formFind.Text = "Find";

            formFind.btnReplace.Visible = false;
            formFind.lblReplace.Visible = false;
            formFind.txtReplace.Visible = false;
            formFind.ShowDialog();
        }

        //Replace
        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFind formFind = new frmFind();
            formFind.Height = 112;
            formFind.Text = "Find and Replace";
            formFind.ShowDialog();

            formFind.btnReplace.Visible = true;
            formFind.lblReplace.Visible = true;
            formFind.txtReplace.Visible = true;

        }

        //Default Theme
        private void defultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxRichTextBox.BackColor = SystemColors.Window;
            rtxRichTextBox.ForeColor = SystemColors.WindowText;
            menuStrip.BackColor = SystemColors.Control;
            menuStrip.ForeColor = SystemColors.ControlText;

        }

        //Matrix Theme
        private void matrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxRichTextBox.BackColor = Color.Black;
            rtxRichTextBox.ForeColor = Color.Green;
            menuStrip.BackColor = Color.Black;
            menuStrip.ForeColor = Color.Green;
        }

        //Popup * sign in the title when text changed.
        public void rtxRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_FileName != null)
            {
                isSaved = false;
                this.Text = Path.GetFileName(_FileName) + "- *" + AppName;
            }
        }

        //checking to save before exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtxRichTextBox.Text.Length <= 0)
            {
                this.Close();
            }
             else if  (isSaved == false)
            {
                DialogResult dr = MessageBox.Show("Do you want to save changes?", AppName, MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Text Files|*.txt";
                    sfd.Title = "Save As";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        isSaved = true;
                        rtxRichTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                        this.Text = Path.GetFileName(sfd.FileName) + " - " + AppName;
                    }
                }
                else if (dr == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
    }
}
