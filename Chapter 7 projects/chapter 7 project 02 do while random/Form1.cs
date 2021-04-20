using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter_7_project_02_do_while_random
{
    public partial class Form1 : Form
    {
        const int MAXITERATIONS = 200000; // Limit loop passes
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool flag;
            int counter; // Pass counter
            int max; // Max value for random number
            int last;
            int current;
            Random randomNumber = new Random();
            //========= Program Input Step ================
            flag = int.TryParse(txtMax.Text, out max);
            if (flag == false)
            {
                MessageBox.Show("Digit characters only.", "Input Error",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMax.Focus();
                return;
            }
            //======== Program Process Step ==============
            counter = 0;
            last = (int)randomNumber.Next(max);
            do
            {
                current = randomNumber.Next(max);
                if (last == current)

                {
                    break;
                }
                last = current;
                counter++;
            } while (counter < MAXITERATIONS);
            //========= Program Output Step ==============
            if (counter < MAXITERATIONS)
            {
                lblAnswer.Text = "It took " + counter.ToString() + " passes to match";
            }
            else
            {
                lblAnswer.Text = "No back-to-back match";
            }
        }
        //============ Program Termination Step ========
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
