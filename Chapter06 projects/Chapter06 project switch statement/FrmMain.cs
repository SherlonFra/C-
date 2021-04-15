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
            int myDay;
            string msg = "Today is "; // Don't duplicate it 7 times
                                      // Make text into int
            flag = int.TryParse(txtDay.Text, out myDay);
            if (flag == false)
            {
                MessageBox.Show("Numeric only, 1 thru 7");
                txtDay.Focus(); // Send 'em back to try again
                return;
            }
            switch (myDay)
            {
                case 1:
                    lblResult.Text = msg + "Monday";
                    break;
                case 2:

                    lblResult.Text = msg + "Tuesday";
                    break;
                case 3:
                    lblResult.Text = msg + "Wednesday";
                    break;
                case 4:
                    lblResult.Text = msg + "Thursday";
                    break;
                case 5:
                    lblResult.Text = msg + "Friday";
                    break;
                case 6:
                    lblResult.Text = msg + "Saturday";
                    break;
                case 7:
                    lblResult.Text = msg + "Sunday";
                    break;
                default:
                    lblResult.Text = "You should never get here";
                    break;
            }
        }
    }
}
    
    

