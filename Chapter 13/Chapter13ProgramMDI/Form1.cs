using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter13ProgramMDI
{
    public partial class form1 : Form
    {
        string selectFile;
        public form1()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Select file to open:";
            fileOpen.Filter = "(*.bin)|*.bin|(*.txt)|*.txt|All files(*.*) | *.* ";
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                selectFile = fileOpen.FileName;
            }
        }
    }
}
