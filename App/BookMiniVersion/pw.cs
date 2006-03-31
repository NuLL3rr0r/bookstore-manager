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
    public partial class frmPw : Form
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

        public frmPw()
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

        private void txtPw_TextChanged(object sender, EventArgs e)
        {
            if (txtPw.Text == pw)
                this.Close();
        }

        private void frmPw_Load(object sender, EventArgs e)
        {
            drr = cmd.ExecuteReader();

            while (drr.Read())
            {
                pw = drr["pw"].ToString().Trim();
                break;
            }

            drr.Close();
            if (pw == String.Empty)
                this.Close();
        }

        private void nULLToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}