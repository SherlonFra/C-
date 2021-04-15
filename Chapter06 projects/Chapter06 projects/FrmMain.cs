using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter06_projects
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag;
            int val;
            string output = "Number is even";
            // Convert from text to number
            flag = int.TryParse(txtNumber.Text, out val);
            if (flag == false)
            {
                MessageBox.Show("Not a number. Re-enter.");
                txtNumber.Clear();
                txtNumber.Focus();
                return;
            }
            // See if odd or even
            int day;
            day = val;
            if (day == 1)
            {
                day += 1; // Simulate doing Monday's stuff
            }
            else
            if (day == 2)
            {
                day += 2; // Simulate doing Tuesday's stuff
            }
            else
            if (day == 3)
            {
                day += 3; // Simulate doing Wednesday's stuff
            }
            else
            if (day == 4)
            {
                day += 4; // Simulate doing Thursday's stuff
            } else
            if (day == 5)
            {
            day += 5; // Simulate doing Friday's stuff
            } else
            if (day == 6)
            {
            day += 6; // Now Saturday's stuff
            } else
            if (day == 7)
            {
                day += 7; // Lastly Sunday's stuff
            }
            // Show result
            lblOutput.Text = output;
        }
    }
}
