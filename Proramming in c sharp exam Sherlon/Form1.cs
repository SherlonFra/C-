using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Proramming_in_c_sharp_exam_Sherlon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection("Data Source = id=ibtcollege.mssql.somee.com;packet size=4096;user id=ibtcollege_SQLLogin_1;pwd=dd69kxzi3m;data source=ibtcollege.mssql.somee.com;persist security info=False;initial catalog=ibtcollege");

                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Contact(FirstName,LastName, Phone, Email) VALUES (@FirstName,@LastName,@Phone,@Email)", con);
                cmd.Parameters.AddWithValue("@FirstName", (txtfirst.Text));
                cmd.Parameters.AddWithValue("@LastName", txtlast.Text);
                cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);

                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("SELECT * FROM Contact", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                txtID.Text = "";
                txtfirst.Text = "";
                txtlast.Text = "";
                txtphone.Text = "";
                txtemail.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = id=ibtcollege.mssql.somee.com;packet size=4096;user id=ibtcollege_SQLLogin_1;pwd=dd69kxzi3m;data source=ibtcollege.mssql.somee.com;persist security info=False;initial catalog=ibtcollege");

                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Contact SET FirstName=@FirstName,LastName=@LastName, Phone=@Phone, Email=@Email WHERE ID=@ID)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@FirstName", txtfirst.Text);
                cmd.Parameters.AddWithValue("@LastName", txtlast.Text);
                cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);

                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("SELECT * FROM Contact", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                txtID.Text = "";
                txtfirst.Text = "";
                txtlast.Text = "";
                txtphone.Text = "";
                txtemail.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection("Data Source = id=ibtcollege.mssql.somee.com;packet size=4096;user id=ibtcollege_SQLLogin_1;pwd=dd69kxzi3m;data source=ibtcollege.mssql.somee.com;persist security info=False;initial catalog=ibtcollege");

                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE Contact WHERE ID=@ID)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@FirstName", txtfirst.Text);
                cmd.Parameters.AddWithValue("@LastName", txtlast.Text);
                cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);

                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("SELECT * FROM Contact", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                txtID.Text = "";
                txtfirst.Text = "";
                txtlast.Text = "";
                txtphone.Text = "";
                txtemail.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        private void btnsavetotext_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = id=ibtcollege.mssql.somee.com;packet size=4096;user id=ibtcollege_SQLLogin_1;pwd=dd69kxzi3m;data source=ibtcollege.mssql.somee.com;persist security info=False;initial catalog=ibtcollege");
                con.Open();
                TextWriter writer = new StreamWriter(@"C:\folder\DatabaseBackup_{TODAY’S DATE}.txt");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("-----------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Data Exported");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void linq()
        {
           

            SqlConnection con = new SqlConnection("Data Source = id = ibtcollege.mssql.somee.com; packet size = 4096; user id = ibtcollege_SQLLogin_1; pwd = dd69kxzi3m; data source = ibtcollege.mssql.somee.com; persist security info = False; initial catalog = ibtcollege");
             con.Open();
            {
              
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM ", con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                   
                }
                con.Close();
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (StreamReader sr = new StreamReader(@"c:\folder\DatabaseBackup_{TODAY’S DATE}.txt"))
                {
                    string line;

                
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

