using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter03program01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            decimal operand1;
            decimal operand2;
            decimal answer;
            // Input Step
            // Check first input...
            flag = decimal.TryParse(txtOperand1.Text, out operand1);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand1.Focus();
                return;
            }
            // Check second input...
            flag = decimal.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
            }
            // Process Step
            answer = (2 + operand1) * (operand2 + 5);
            // Display Step
            txtResult.Text = operand1.ToString() + " divided by " +
            operand2.ToString() +
            " equals " + answer.ToString();
            txtResult.Visible = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
