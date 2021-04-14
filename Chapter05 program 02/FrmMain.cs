using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05_program_02
{
    public partial class FrmMain : Form
    {
        private void FrmMain_Load(object sender, EventArgs e)
        {
            int days;
            DateTime myTime = new DateTime();
            myTime = DateTime.Now;
            DateTime newYears = new DateTime(myTime.Year, 12, 31);
            txtCompleteDateAndTime.Text = myTime.ToString("f");
            txtLongDate.Text = myTime.ToString("D");
            txtShortDate.Text = myTime.ToString("d");
            txtGeneralDateAndTime.Text = myTime.ToString("g");
            txtLongTime.Text = myTime.ToString("T");
            txtShortTime.Text = myTime.ToString("t");
            days = newYears.DayOfYear - myTime.DayOfYear;
            txtDaysToNewYears.Text = days.ToString();
        }

        private void UpdateTimeInfo()
        {
            int days;
            DateTime myTime = new DateTime();
            myTime = DateTime.Now;
            DateTime newYears = new DateTime(myTime.Year, 12, 31);
            txtCompleteDateAndTime.Text = myTime.ToString("f");
            txtLongDate.Text = myTime.ToString("D");
            txtShortDate.Text = myTime.ToString("d");
            txtGeneralDateAndTime.Text = myTime.ToString("g");
            txtLongTime.Text = myTime.ToString("T");
            txtShortTime.Text = myTime.ToString("t");
            days = newYears.DayOfYear-myTime.DayOfYear;
            txtDaysToNewYears.Text = days.ToString();
        }

        private void UpdateTimeInfo(int year, int month, int day)
        {
            int days;
            DateTime myTime = new DateTime(year, month, day);
            DateTime newYears = new DateTime(year, 12, 31);
            txtCompleteDateAndTime.Text = myTime.ToString("f");
            txtLongDate.Text = myTime.ToString("D");
            txtShortDate.Text = myTime.ToString("d");
            txtGeneralDateAndTime.Text = myTime.ToString("g");
            txtLongTime.Text = myTime.ToString("T");
            txtShortTime.Text = myTime.ToString("t");
            days = newYears.DayOfYear - myTime.DayOfYear;
            txtDaysToNewYears.Text = days.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            UpdateTimeInfo();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateTimeInfo(1999,12,25);
        }
    }
}
