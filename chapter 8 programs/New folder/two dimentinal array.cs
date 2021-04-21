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
            bool flag;
            int number;
            int i;

            ListViewItem which;
            flag = int.TryParse(txtMax.Text, out number); // check input
            if (flag == false)
            {
                MessageBox.Show("Numeric data only.", "Input Error");
                txtMax.Focus();
                return;
            }
            if (number < 0) // Make sure it's positive
            {
                number = number * 1;
            }
            number++; // Do this because of N - 1 Rule
            int[,] myData = new int[number, 3]; // Define array
            for (i = 0; i < number; i++)
            {
                myData[i, 0] = i; // first column of table
                myData[i, 1] = i * i; // second column of table
                myData[i, 2] = i * i * i; // third column of table
            }
            for (i = 0; i < number; i++) // Now show it
            {
                which = new ListViewItem(myData[i, 0].ToString());
                which.SubItems.Add(myData[i, 1].ToString());
                which.SubItems.Add(myData[i, 2].ToString());
                lsvTable.Items.Add(which);
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
