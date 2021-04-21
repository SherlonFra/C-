using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08ProgramArrayList
{
    public partial class FrmMain : Form
    {
        System.Collections.ArrayList names = new System.Collections.ArrayList();
     

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length != 0)
            {
                names.Add(txtName.Text); // Add new name
                txtName.Clear(); // Clear it out
                txtName.Focus(); // Get ready for another name
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Input Error");
                return;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            foreach (string str in names)
            {
                lstNames.Items.Add(str);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
