using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace BookMiniVersion
{
    public partial class frmPwChange : Form
    {
        private String path = String.Concat(Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar.ToString());
        private String msgTitle = "aofz";
        private String msgErrTitle = "Œÿ«Ì “„«‰ «Ã—«";
        private String errDb = "«„ﬂ«‰ œ” —”Ì »Â Å«Ìê«Â œ«œÂ Â« ÊÃÊœ ‰œ«—œ";
        private String dBpw = "oNTM4r0Wc2PBek6s9JPM";
        private String sqlStr = "SELECT * FROM options";
        private String fileDb;
        private String fileDbOrg = "lib.sql";
        private String cnnStr;

        private OleDbConnection cnn;
        private OleDbDataAdapter oda;
        private OleDbCommand cmd;
        private OleDbDataReader drr;
        private OleDbCommandBuilder ocb;

        private DataSet ds = new DataSet();

        private string pw = System.String.Empty;

        public frmPwChange()
        {
            InitializeComponent();

            fileDb = String.Concat(path, fileDbOrg);
            cnnStr = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", fileDb, dBpw);

            if (!ChkFiles(fileDbOrg, errDb))
            {
                Environment.Exit(Environment.ExitCode);
            }

            cnn = new OleDbConnection(cnnStr);
            oda = new OleDbDataAdapter(sqlStr, cnn);
            cmd = new OleDbCommand(sqlStr, cnn);
            ocb = new OleDbCommandBuilder(oda);
            ocb.QuotePrefix = "[";
            ocb.QuoteSuffix = "]";

            cnn.Open();
            oda.Fill(ds, "options");
        }

        private bool ChkFiles(String file, String errMsg)
        {
            bool found = File.Exists(file);
            if (!found)
            {
                MessageBox.Show(String.Concat(errMsg, "\n\nDetails:\n", file, "\t...Not Found"), msgErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return found;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPwChange_Load(object sender, EventArgs e)
        {
            drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                pw = drr["pw"].ToString().Trim();
                break;
            }

            drr.Close();

            txtCurrentPw.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtCurrentPw.Text != pw)
            {
                MessageBox.Show("·ÿ›« ﬂ·„Â ⁄»Ê— ›⁄·Ì —« Ê«—œ ‰„«∆Ìœ", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCurrentPw.Focus();
                txtCurrentPw.SelectAll();
            }
            else
            {
                if (txtNewPw.Text != txtConfirmPw.Text)
                {
                    MessageBox.Show("·ÿ›« ﬂ·„Â Ì ⁄»Ê— ÃœÌœ —«  «∆Ìœ ‰„«∆Ìœ", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPw.Focus();
                    txtConfirmPw.SelectAll();
                }
                else
                {
                    drr = cmd.ExecuteReader();

                    while (drr.Read())
                    {
                        DataTable dt = ds.Tables["options"];
                        DataRow dr = dt.Rows[0];
                        dr.BeginEdit();
                        dr["pw"] = txtConfirmPw.Text.Trim();
                        dr.EndEdit();

                        oda.UpdateCommand = ocb.GetUpdateCommand();

                        if (oda.Update(ds, "options") == 1)
                        {
                            ds.AcceptChanges();
                        }
                        else
                            ds.RejectChanges();

                    }

                    drr.Close();

                    MessageBox.Show("ﬂ·„Â Ì ⁄»Ê— ÃœÌœ »« „Ê›ﬁÌ  Ã«Ìê“Ì‰ ‘œ", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}