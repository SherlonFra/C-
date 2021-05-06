using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Chapter14ProgramCreateDatabase
{
    public partial class FrmReport : Form
    {
        private FrmMain mdiParent;
        private string connectString;
        private string serverName;
        private string databaseName;
        private Button btnNew;
        private string sql;
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {

        }

        public FrmReport(FrmMain me)
        {
            InitializeComponent();
            this.mdiParent = me;
            serverName = me.getServerName;
            databaseName = me.getDatabaseName;
            connectString = me.getConnectStr;


            sql = "SELECT * FROM " + databaseName + ".sys.tables";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(sql, conn);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader[0].Equals("sysdiagrams"))  // Don't want system stuff here
                        {
                            continue;
                        }

                        lstTables.Items.Add(myReader[0]);

                    }
                    myReader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    DataSet myDataSet = new DataSet();
                    SqlDataAdapter myAdapter = new SqlDataAdapter(txtQuery.Text, conn);
                    myAdapter.Fill(myDataSet);
                    dgvFriends.AutoGenerateColumns = true;
                    dgvFriends.DataSource = myDataSet.Tables[0];
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lstTables_DoubleClick(object sender, EventArgs e)
        {
            txtQuery.Text += " " + lstTables.SelectedItem;  // Need the space for query string
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtQuery.Text = "SELECT * FROM ";
            dgvFriends.DataSource = null;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }
    }
}
