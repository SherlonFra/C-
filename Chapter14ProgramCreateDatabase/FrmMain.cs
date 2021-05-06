using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Sql;
using System.Collections;
using System.Data.SqlClient;

namespace Chapter14ProgramCreateDatabase
{
    public partial class FrmMain : Form
    {
        private string dbName;
        public string whichServer;
        public string getConnectStr;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string getServerName
        {
            get
            {
                return whichServer;
            }
            set
            {
                whichServer = value;
            }
        }
        public string getDatabaseName
        {
            get
            {
                return dbName;
            }
            set
            {
                dbName = value;
            }
        }



        private void addNewFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuSelectServer_Click(object sender, EventArgs e)
        {
            {
                // Debug code set here:
                
                string whichServer = "DESKTOP-NVG7K5K\\SQLEXPRESS";
                string dbName = "Cards";
                string connectionString = "server=" + whichServer + ";integrated security=SSPI;database=" + dbName;
                
                frmServerSelect myServer = new frmServerSelect(this);
                myServer.ShowDialog();
                this.Text = "Database Management Subsystem: Server: " +
                whichServer + " Database: " + dbName;
                connectionString = "server=" + whichServer +
                ";integrated security=SSPI;database=" + dbName;
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuListFriends_Click(object sender, EventArgs e)
        {
            FrmReport myFriendReport = new FrmReport(this);
            myFriendReport.ShowDialog();
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            frmEditFriend editRec = new frmEditFriend(connectionString);
            editRec.ShowDialog();
        }
    }
}
