using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Sql;
using System.Collections;
using System.Data.SqlClient;

namespace Chapter14ProgramCreateDatabase
{
    public partial class frmServerSelect : Form
    {
        private const int SYSTEMDBTYPES = 4;
        #region Windows stuff
        private FrmMain mdiParent;
        string serverToUse;

        public frmServerSelect(FrmMain me)
        {
            InitializeComponent();
            this.mdiParent = me; 
            string serverName;
            try
            {
                clsSqlServerList SqlSL = new clsSqlServerList();
                SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
                DataTable mySources = instance.GetDataSources();
                foreach (DataRow row in mySources.Rows)
                {
                    SqlSL = new clsSqlServerList();
                    serverName = row[0].ToString();
                    cmbServer.Items.Add(serverName);
                }
                cmbServer.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public frmServerSelect()
        {
            InitializeComponent();
        }

        private void frmServerSelect_Load(object sender, EventArgs e)
        {

        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            short i;

            serverToUse = "DESKTOP-NVG7K5K\\SQLEXPRESS";
            string conn = "Data Source=" + serverToUse +
            "; Integrated Security=True;";
            cmbDatabase.Visible = true;
            lblDb.Visible = true;
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(conn))
                {
                    sqlConn.Open();
                    DataTable tblDbs = sqlConn.GetSchema("Databases");
                    sqlConn.Close();
                    foreach (DataRow row in tblDbs.Rows)
                    {
                        i = (short)row.ItemArray[1];
                        if (i > SYSTEMDBTYPES)
                            cmbDatabase.Items.Add(row["database_name"].ToString());
                    }
                }
                cmbDatabase.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error occurred while reading database data: "
                + ex.Message);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.mdiParent.getServerName = cmbServer.SelectedItem.ToString();
            this.mdiParent.getDatabaseName = cmbDatabase.SelectedItem.ToString();
            Close();
        }
    }
}
#endregion