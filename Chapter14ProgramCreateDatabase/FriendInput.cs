using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter14ProgramCreateDatabase
{
    public partial class FriendInput : Form
    {
        private string connectStr;
        clsDB myDB;
        clsFriend myData;
        public FriendInput()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int status;
            int flag;
            string sqlCommand;


            if (chkStatus.Checked == true)
                status = 1;
            else
                status = 0;

            myData = new clsFriend(connectStr);

            // Build UPDATE command
            sqlCommand = "UPDATE Friends SET " +
                         "FirstName = '" + txtFirstName.Text + "'," +
                         "LastName = '" + txtLastName.Text + "'," +
                         "Addr1 = '" + txtAddr1.Text + "'," +
                         "Addr2 = '" + txtAddr2.Text + "'," +
                         "City = '" + txtCity.Text + "'," +
                         "State = '" + txtState.Text.ToUpper() + "'," +
                         "Zip = '" + txtZip.Text + "'," +
                         "LastContact = '" + txtLastContact.Text + "'," +
                         "Status = " + status.ToString() +
                         " WHERE ID = " + txtFindRecordNumber.Text;
            try
            {
                flag = myData.ProcessCommand(sqlCommand);
                if (flag > 0)
                {
                    MessageBox.Show("Record updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update data.", "Process Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

