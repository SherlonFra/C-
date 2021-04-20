using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter_8_programs
{
    public partial class FrmMain : Form
    {
        private const int MAXLETTERS = 26; // Symbolic constants
        private const int MAXCHARS = MAXLETTERS -1;
        private const int LETTERA = 65;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            char oneLetter;
            int index;
            int i;
            int length;
            int[] count = new int[MAXLETTERS];
            string input;
            string buff;
            length = txtInput.Text.Length;
            if (length == 0) // Anything to count??
            {
                MessageBox.Show("You need to enter some text.", "Missing Input");
                txtInput.Focus();
                return;
            }
            input = txtInput.Text;
            input = input.ToUpper();
            for (i = 0; i < input.Length; i++) // Examine all letters.
            {
                oneLetter = input[i]; // Get a character
                index = oneLetter - LETTERA; // Make into an index
                if (index < 0 || index > MAXCHARS) // A letter??
                    continue; // Nope.
                count[index]++; // Yep.
            }
            ListViewItem which;
            for (i = 0; i < MAXLETTERS; i++)
            {
                oneLetter = (char)(i + LETTERA);
                which = new ListViewItem(oneLetter.ToString());
                which.SubItems.Add(count[i].ToString());
                lsvOutput.Items.Add(which);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lsvOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
