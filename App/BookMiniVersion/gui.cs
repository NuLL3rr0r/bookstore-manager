using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using MSBabaei;

namespace BookMiniVersion
{
    public partial class frmMain : Form
    {
        private String path = String.Concat(Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar.ToString());
        private String msgTitle = "aofz";
        private String msgErrTitle = "Œÿ«Ì “„«‰ «Ã—«";
        private String errDb = "«„ﬂ«‰ œ” —”Ì »Â Å«Ìê«Â œ«œÂ Â« ÊÃÊœ ‰œ«—œ";
        private String fileDb;
        private String fileDbOrg = "lib.sql";


        public frmMain()
        {
            InitializeComponent();

            fileDb = String.Concat(path, fileDbOrg);

            if (!ChkFiles(fileDbOrg, errDb))
            {
                Environment.Exit(Environment.ExitCode);
            }

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

        public void doExit()
        {
            Application.Exit();
        }

        public void doAbout()
        {
            MessageBox.Show("Written by:\tM.S. Babaei\t\n\nace.of.zerosync@gmail.com", "aofz", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void doF2()
        {
            frmBase frm = new frmBase();
            frm.ShowDialog();
        }

        public void doF3()
        {
            frmBuy frm = new frmBuy();
            frm.ShowDialog();
        }

        public void doF4()
        {
            frmSell frm = new frmSell();
            frm.ShowDialog();
        }

        public void doF9()
        {
            frmPwChange frm = new frmPwChange();
            frm.ShowDialog();
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            doAbout();
        }

        private void btn_F2_Click(object sender, EventArgs e)
        {
            doF2();
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            doF3();
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            doF4();
        }

        private void btnF5_Click(object sender, EventArgs e)
        {

        }

        private void btnF6_Click(object sender, EventArgs e)
        {

        }

        private void btnF7_Click(object sender, EventArgs e)
        {

        }

        private void btnF8_Click(object sender, EventArgs e)
        {

        }

        private void btnF9_Click(object sender, EventArgs e)
        {
            doF9();
        }

        private void btnF10_Click(object sender, EventArgs e)
        {
            doExit();
        }

        private void F1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doAbout();
        }

        private void F2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doF2();
        }

        private void F3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doF3();
        }

        private void F4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doF4();
        }

        private void F5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void F6ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void F7ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void F8ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void F9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doF9();
        }

        private void F10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doExit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmPw frm = new frmPw();
            frm.ShowDialog();
        }
    }
}