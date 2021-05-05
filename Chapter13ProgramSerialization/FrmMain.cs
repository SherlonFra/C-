using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Chapter13ProgramSerialization
{
    public partial class FrmMain : Form
    {
        clsSerial myFriend = new clsSerial();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            int flag;
            MoveTextToClass(myFriend); 
            flag = myFriend.SerializeFriend(myFriend);
            if (flag == 1)
            {
                MessageBox.Show("Data Serialized successfully", "Data Write");
            }
            else
            {
                MessageBox.Show("Serialization failure", "Data Error");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            clsSerial newFriend = new clsSerial();
            newFriend = newFriend.DeserializeFriend();
            lstOutput.Items.Clear();
            lstOutput.Items.Add(newFriend.Name);
            lstOutput.Items.Add(newFriend.Email);
            lstOutput.Items.Add(newFriend.Status.ToString());
        }

        private void MoveTextToClass(clsSerial obj)
        {
            bool flag;
            int val;
            obj.Name = txtName.Text;
            obj.Email = txtEmail.Text;
            flag = int.TryParse(txtStatus.Text, out val);
            if (flag == false)
            {
                MessageBox.Show("Must be 1 or 0", "Input Error");
                txtStatus.Focus();
                return;
            }
            obj.Status = val;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
