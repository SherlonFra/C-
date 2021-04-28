using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter12ProgramQuickSort
{
    public partial class FrmMain : Form
    {
        private const int MAXVAL = 1000; 
        private int[] data; 
        private int number; 
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            clsSort mySort = new clsSort(data);
            mySort.quickSort(0, data.Length - 1); 
            for (i = 0; i < data.Length; i++) 
            {
                lstSorted.Items.Add(data[i].ToString());
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            bool flag;
            int i;
            flag = int.TryParse(txtNumber.Text, out number);
            if (flag == false)
            {
                MessageBox.Show("Enter whole digits only.", "Input Error");
                txtNumber.Focus();
                return;
            }
            #if MYDEBUG
            Random rnd = new Random(number); // For testing purposes
            #else
            Random rnd = new Random();
            #endif
            data = new int[number];
            lstOutput.Items.Clear(); 
            lstSorted.Items.Clear();
            for (i = 0; i < data.Length; i++) 
            {
                data[i] = rnd.Next(MAXVAL);
                lstOutput.Items.Add(data[i].ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
