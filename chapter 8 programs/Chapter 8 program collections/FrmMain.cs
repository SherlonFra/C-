using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_8_program_collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] days = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 31 };
            string[] weekDays = new string[] { "Monday", "Tuesday","Wednesday", "Thursday", "Friday", "Saturday","Sunday"};
            foreach (string str in weekDays)
            {
                lstTest.Items.Add(str);
            }
            foreach (int val in days)
            {
                lstTest.Items.Add(val.ToString());
            }
        }
    }
}
