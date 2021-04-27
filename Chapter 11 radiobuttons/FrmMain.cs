using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_11_radiobuttons

{
    public partial class FrmMain : Form
    {
        const int MALE = 1;
        const int FEMALE = 0;
        const int MUSHROOMS = 0;
        const int OLIVES = 1;
        const int SAUSAGE = 2;
        const int EXTRACHEESE = 3;
       

        public FrmMain()
        {
            InitializeComponent();
            rbFemale.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            int choice;
            int[] toppings = new int[4];
            if (rbMale.Checked == true)
            {
                choice = MALE;
            }
            else
            {
                choice = FEMALE;
            }
            Array.Clear(toppings, 0, toppings.Length);
            if (ckbMushroom.Checked == true)
            {
                toppings[MUSHROOMS] = 1;
            }
            if (ckbOlives.Checked == true)
            {
                toppings[OLIVES] = 1;
            }
            if (ckbSausage.Checked == true)
            {
                toppings[SAUSAGE] = 1;
            }
            if (ckbExtraCheese.Checked == true)
            {
                toppings[EXTRACHEESE] = 1;
            }


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSize.Items.Add("Small");
            cmbSize.Items.Add("Medium");
            cmbSize.Items.Add("Large");
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            string date = dtpDate.Value.ToShortDateString();
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            string time = dtpTime.Value.ToShortTimeString();
        }
    }
}
