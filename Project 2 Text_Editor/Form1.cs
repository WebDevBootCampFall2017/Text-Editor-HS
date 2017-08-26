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
        string _FileName = null;

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
            }
        }

        private void mnsSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (_FileName == null)
            {
                sfd.Filter = "Text Files .txt|*.txt";
                sfd.Title = "Save";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    rtxRichTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                    _FileName = sfd.FileName;
                    this.Text = sfd.FileName;
                }
            }
            else
            {
                rtxRichTextBox.SaveFile(_FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("file saved");
            }
        }

        private void mnsSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files .txt|*.txt";
            sfd.Title = "Save As";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                rtxRichTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sfd.FileName;
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

        private void mnsFind_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Unavailable in this version.","MsgBox");

        }
    }
}
