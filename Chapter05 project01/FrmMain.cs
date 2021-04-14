using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05_project01
{
    public partial class FrmMain : Form
    {



        public FrmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                bool flag;
                int index;
                int start;
                int howMany;
                string temp;
                lblIndexOf.Text = "";
                // Find length
                txtLength.Text = txtInput.Text.Length.ToString();
                // Change cases
                txtToUpper.Text = txtInput.Text.ToUpper();
                txtToLower.Text = txtInput.Text.ToLower();
                // Index of
                index = txtInput.Text.IndexOf(txtSearchChar.Text, 0);
                lblIndexOf.Text = "txtInput.Text.IndexOf(\"" + txtSearchChar.Text +
                "\",0) = ";
                txtSearchIndex.Text = index.ToString();
                //LastIndexOf
                index = txtInput.Text.LastIndexOf(txtLastChar.Text);
            lblLastIndexOf.Text = "txtInput.Text.LastIndexOf(\"" + txtLastChar.Text + "\") = ";
                
                txtLastIndexOf.Text = index.ToString();
                // Substring
                flag = int.TryParse(txtStartIndex.Text, out start);
                if (flag == false)
                {
                    MessageBox.Show("Improper numeric input. Re-enter.");
                    txtStartIndex.Focus();
                    return;
                }
                flag = int.TryParse(txtEndIndex.Text, out howMany);
                if (flag == false)
                {
                    MessageBox.Show("Improper numeric input. Re-enter.");
                    txtEndIndex.Focus();
                    return;
                }
                lblSubstring.Text = "txtInput.Text.Substring(" + start.ToString() + ", " +
                howMany.ToString() + ") = ";
                txtSubstringResult.Text = txtInput.Text.Substring(start, howMany);
                // Remove
                temp = txtInput.Text;
                index = temp.IndexOf(txtRemove.Text);
                if (index > 0)
                {
                    txtRemoveResult.Text = temp.Remove(index, txtRemove.Text.Length);
            }
            // Replace
            temp = txtInput.Text;
            txtReplaceResult.Text = temp.Replace(txtReplaceChars.Text, txtReplaceWith.
           Text);
        }

    }
}