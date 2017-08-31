using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Find size:433,85


namespace Project_2_Text_Editor
{
    public partial class frmFind : Form
    {
        int TextIndex;
        string TextToFind;
        public frmFind()

        {
            InitializeComponent();
            
        }
        

        private void btnFind_Click(object sender, EventArgs e)
        {
            //retrieve text from the richtextbox in the Main form.
            Form f = Application.OpenForms["frmTextEditor"];
            string textfromTE = ((frmTextEditor)f).rtxRichTextBox.Text;
            TextToFind = txtFind.Text;
          

            TextIndex = textfromTE.IndexOf(TextToFind);

            if (TextIndex <0)
            {
                MessageBox.Show("Can't Find the text: " + TextToFind);
            }
            else if(TextToFind.Length == 0)
            {
                MessageBox.Show("Please Enter a text");
            }
            else
            {
                ((frmTextEditor)f).Focus();
                ((frmTextEditor)f).rtxRichTextBox.SelectionStart = TextIndex;
                ((frmTextEditor)f).rtxRichTextBox.SelectionLength = TextToFind.Length;
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string ReplaceToText = txtReplace.Text;
            Form f = Application.OpenForms["frmTextEditor"];
            ((frmTextEditor)f).rtxRichTextBox.Text = ((frmTextEditor)f).rtxRichTextBox.Text.Replace(((frmTextEditor)f).rtxRichTextBox.Text.Substring(TextIndex,TextToFind.Length), ReplaceToText);
        }

        private void btnCancelFind_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFind_Click(this, new EventArgs());
            }
        }
    }
}
