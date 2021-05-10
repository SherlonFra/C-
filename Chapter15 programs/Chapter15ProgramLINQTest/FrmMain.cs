using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chapter15ProgramLINQTest
{
    public partial class FrmMain : Form
    {
        private const int MAXNUM = 100;
        static List<int> numbers = new List<int>(); 


        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateRandomValues();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int lo;
            int hi;
            lstOutput.Items.Clear();
            SetTheLimits(out lo, out hi);
            DoLINQQuery(lo, hi);
        }

        private void DoLINQQuery(int lo, int hi)
        {
            var query = from p in numbers 
                        where p > lo && p < hi
                        select p;
            foreach (var val in query) 
            {
                lstOutput.Items.Add(val.ToString());
            }
        }

        private void SetTheLimits(out int lo, out int hi)
        {
            bool flag = int.TryParse(txtLow.Text, out lo); 
            if (flag == false)
            {
                MessageBox.Show("Numeric only, 0 to 100", "Input Error");
                txtLow.Focus();
            }
            flag = int.TryParse(txtHi.Text, out hi);
            if (flag == false)
            {
                MessageBox.Show("Numeric only, 0 to 100", "Input Error");
                txtHi.Focus();
            }
        }

        private void GenerateRandomValues()
        {
            int temp;
            DateTime current = DateTime.Now;
            Random rnd = new Random((int)current.Ticks);
            for (int i = 0; i < MAXNUM; i++) 
            {
                temp = rnd.Next(MAXNUM);
                numbers.Add(temp); 
                lstFull.Items.Add(temp.ToString());
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
