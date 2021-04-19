using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter_7_projects
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool flag;
            int i;
            int start;
            int end;
            string buff;
            //============ Gather inputs ======================
            // Convert start from text to int
            flag = int.TryParse(txtStart.Text, out start);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtStart.Focus();
                return;
            }
            // Convert end from text to int
            flag = int.TryParse(txtEnd.Text, out end);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtEnd.Focus();
                return;
            }
            if (start >= end) // Reasonable values?
            {
                MessageBox.Show("Start less than end.", "Input Error");
                txtStart.Focus();
                return;
            }
            //============= Process and Display ==============
            i = start; // Initialize loop counter: condition 1
            while (i <= end) // Another iteration: condition 2
            {
                buff = string.Format("{0, 5}{1, 20}", i, i * i);
                lstOutput.Items.Add(buff);
                i++; // Change state of loop: condition 3
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStart.Clear();
            txtEnd.Clear();
            lstOutput.Items.Clear();
        }
    }
}
    
   
