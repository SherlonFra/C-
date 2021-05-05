using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter13ErrorLog
{
    public partial class FrmMain : Form
    {
        string err;
        public FrmMain()
        {
            InitializeComponent();
            rbDivideBy0.Checked = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbDivideBy0.Checked == true)
                {
                    throw new System.DivideByZeroException();
                }
                else
                {
                    if (rbFileNotFound.Checked == true)
                    {
                        throw new System.IO.FileNotFoundException();
                    }
                    else
                    {
                        throw new System.OverflowException();
                    }
                }
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("DivideByZeroException thrown.",
                "Exception Error");
                err = "DivideByZeroException: " + ex.StackTrace;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("FileNotFoundException thrown.",
                "Exception Error");
                err = "FileNotFoundException" + ex.StackTrace;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("OverflowException thrown.",
                "Exception Error");
                err = "OverflowException" + ex.StackTrace;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Exception Error");
                err = ex.Message + " " + ex.StackTrace;
            }
            finally
            {
                clsErrorLog myErrLog = new clsErrorLog(err);
                myErrLog.PathName = Application.StartupPath;
                myErrLog.WriteErrorLog();
                txtErrorMsgs.Text = myErrLog.ReadErrorLog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
