using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter11Trycatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int exp1 = 0;
            int exp2 = 5;
            int result;
        

#if DEBUG
            MessageBox.Show("exp1 = " + exp1.ToString());
#endif
            try
            {
                result = exp2 / exp1;
                MessageBox.Show("Never get here");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Divide by zero error.", "Exception Thrown");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception Thrown");
            }
            finally
            {
                MessageBox.Show("In finally");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
