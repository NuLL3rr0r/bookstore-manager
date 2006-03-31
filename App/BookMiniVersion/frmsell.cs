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
    public partial class frmSell : Form
    {
        private String operation = String.Empty;
        private String path = String.Concat(Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar.ToString());
        private String msgTitle = "aofz";
        private String msgErrTitle = "���� ���� ����";
        private String errDb = "����� ������ �� ����� ���� �� ���� �����";
        private String dBpw = "oNTM4r0Wc2PBek6s9JPM";
        private String sqlStr = "SELECT * FROM sell";
        private String fileDb;
        private String fileDbOrg = "lib.sql";
        private String cnnStr;

        private OleDbConnection cnn;
        private OleDbDataAdapter oda;
        private OleDbCommand cmd;
        private OleDbDataReader drr;
        private OleDbCommandBuilder ocb;

        private DataSet ds = new DataSet();

        public frmSell()
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
            oda.Fill(ds, "sell");
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

        private void RefreshTable()
        {
            dgvBase.DataSource = null;
            DataTable dt = new DataTable();
            DataRow dr;

            drr = cmd.ExecuteReader();

            dt.Columns.Add("����", Type.GetType("System.String"));
            dt.Columns.Add("�� ����", Type.GetType("System.String"));
            dt.Columns.Add("���� �����", Type.GetType("System.String"));
            dt.Columns.Add("����� � ������", Type.GetType("System.String"));
            dt.Columns.Add("��� �����", Type.GetType("System.String"));
            dt.Columns.Add("�����", Type.GetType("System.String"));
            dt.Columns.Add("����� ����", Type.GetType("System.String"));

            bool found = false;
            while (drr.Read())
            {
                dr = dt.NewRow();
                dr[0] = drr["ID"].ToString();
                dr[1] = drr["Code"].ToString();
                dr[2] = drr["pCost"].ToString();
                dr[3] = drr["FactNo"].ToString();
                dr[4] = drr["cName"].ToString();
                dr[5] = drr["QTY"].ToString();
                dr[6] = drr["dATE"].ToString();
                dt.Rows.Add(dr);
                found = true;
            }

            if (found)
            {
                dgvBase.DataSource = dt;
                /*                dgvBase.Columns[0].Width = 66;
                                dgvBase.Columns[1].Width = 77;
                                dgvBase.Columns[2].Width = 555;*/
                dgvBase.Sort(dgvBase.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                //MessageBox.Show("�� ����� ���� ���", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            drr.Close();
        }

        private void doErase()
        {
            DialogResult result = MessageBox.Show("��� ���� �� ��� ���� ���� ��� �� ����Ͽ", msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                drr = cmd.ExecuteReader();
                int id = -1;
                while (drr.Read())
                {
                    id++;
                    if (drr["ID"].ToString().Trim() == dgvBase.CurrentRow.Cells[0].Value.ToString().Trim())
                    {
                        DataTable dt = ds.Tables["sell"];
                        DataRow dr = dt.Rows[id];

                        dr.Delete();

                        oda.DeleteCommand = ocb.GetDeleteCommand();

                        if (oda.Update(ds, "sell") == 1)
                            ds.AcceptChanges();
                        else
                            ds.RejectChanges();
                        break;
                    }
                }
                drr.Close();
                RefreshTable();
            }
        }

        private void doEdit()
        {
            dgvBase.Enabled = false;
            btnNew.Enabled = false;
            btnReturn.Enabled = false;
            btnEdit.Enabled = false;
            btnErase.Enabled = false;
            mnuErase.Enabled = false;
            mnuEdit.Enabled = false;
            txtCode.Enabled = true;
            txtDate.Enabled = true;
            txt2.Enabled = true;
            txt4.Enabled = true;
            txt5.Enabled = true;
            txt6.Enabled = true;
            btnCancel.Enabled = true;
            txtCode.Text = dgvBase.CurrentRow.Cells[1].Value.ToString().Trim();
            txt2.Text = dgvBase.CurrentRow.Cells[2].Value.ToString().Trim();
            txt4.Text = dgvBase.CurrentRow.Cells[3].Value.ToString().Trim();
            txt5.Text = dgvBase.CurrentRow.Cells[4].Value.ToString().Trim();
            txt6.Text = dgvBase.CurrentRow.Cells[5].Value.ToString().Trim();
            txtDate.Text = dgvBase.CurrentRow.Cells[6].Value.ToString().Trim();
            txtCode.Focus();
            txtCode.SelectAll();
            operation = "update";
            btnSave.Enabled = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvBase.Enabled = false;
            btnNew.Enabled = false;
            btnReturn.Enabled = false;
            btnEdit.Enabled = false;
            btnErase.Enabled = false;
            mnuErase.Enabled = false;
            mnuEdit.Enabled = false;
            txtCode.Enabled = true;
            txtDate.Enabled = true;
            txt2.Enabled = true;
            txt4.Enabled = true;
            txt5.Enabled = true;
            txt6.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtCode.Focus();
            txtCode.SelectAll();
            operation = "insert";
        }

        private void mnuInsert_Click(object sender, EventArgs e)
        {
            txtDate.Text = DateProvider.ToPersian();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            doErase();
        }

        private void mnuErase_Click(object sender, EventArgs e)
        {
            doErase();
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            doEdit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            doEdit();
        }

        private void dgvBase_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnErase.Enabled = true;
            mnuErase.Enabled = true;
            mnuEdit.Enabled = true;
        }

        private void dgvBase_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            btnEdit.Enabled = false;
            btnErase.Enabled = false;
            mnuErase.Enabled = false;
            mnuEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id;
            DataTable dt;
            DataRow dr;

            switch (operation)
            {
                case "insert":
                    dt = new DataTable();

                    dt = new DataTable();

                    drr = cmd.ExecuteReader();
                    id = 0;
                    while (drr.Read())
                    {
                        id = Convert.ToInt32(drr["ID"]);
                    }

                    dt = ds.Tables["sell"];
                    dr = dt.NewRow();
                    dr["ID"] = (++id).ToString();
                    dr["Code"] = txtCode.Text.Trim();
                    dr["pCost"] = txt2.Text.Trim();
                    dr["FactNo"] = txt4.Text.Trim();
                    dr["cName"] = txt5.Text.Trim();
                    dr["QTY"] = txt6.Text.Trim();
                    dr["dATE"] = txtDate.Text.Trim();
                    dt.Rows.Add(dr);

                    oda.InsertCommand = ocb.GetInsertCommand();

                    if (oda.Update(ds, "sell") == 1)
                        ds.AcceptChanges();
                    else
                        ds.RejectChanges();

                    txtCode.Clear();
                    txtDate.Clear();
                    txt2.Clear();
                    txt4.Clear();
                    txt5.Clear();
                    txt6.Clear();
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    txtCode.Enabled = false;
                    txtDate.Enabled = false;
                    txt2.Enabled = false;
                    txt4.Enabled = false;
                    txt5.Enabled = false;
                    txt6.Enabled = false;
                    dgvBase.Enabled = true;
                    btnNew.Enabled = true;
                    btnReturn.Enabled = true;
                    drr.Close();
                    RefreshTable();
                    break;
                case "update":
                    DialogResult result = MessageBox.Show("��� ���� �� ��� ������� ���� ��� �� �����", msgTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            drr = cmd.ExecuteReader();
                            id = -1;
                            while (drr.Read())
                            {
                                id++;
                                if (drr["ID"].ToString().Trim() == dgvBase.CurrentRow.Cells[0].Value.ToString().Trim())
                                {
                                    dt = ds.Tables["sell"];
                                    dr = dt.Rows[id];
                                    dr.BeginEdit();
                                    dr["Code"] = txtCode.Text.Trim();
                                    dr["pCost"] = txt2.Text.Trim();
                                    dr["FactNo"] = txt4.Text.Trim();
                                    dr["cName"] = txt5.Text.Trim();
                                    dr["QTY"] = txt6.Text.Trim();
                                    dr["dATE"] = txtDate.Text.Trim();
                                    dr.EndEdit();

                                    oda.UpdateCommand = ocb.GetUpdateCommand();

                                    if (oda.Update(ds, "sell") == 1)
                                    {
                                        ds.AcceptChanges();
                                    }
                                    else
                                        ds.RejectChanges();

                                    txtCode.SelectAll();
                                    txtCode.Focus();
                                    break;
                                }
                            }

                            drr.Close();
                            RefreshTable();
                            txtCode.Clear();
                            txtDate.Clear();
                            txt2.Clear();
                            txt4.Clear();
                            txt5.Clear();
                            txt6.Clear();
                            btnSave.Enabled = false;
                            btnCancel.Enabled = false;
                            txtCode.Enabled = false;
                            txtDate.Enabled = false;
                            txt2.Enabled = false;
                            txt4.Enabled = false;
                            txt5.Enabled = false;
                            txt6.Enabled = false;
                            dgvBase.Enabled = true;
                            btnNew.Enabled = true;
                            btnReturn.Enabled = true;
                            break;
                        case DialogResult.No:
                            txtCode.Clear();
                            txtDate.Clear();
                            txt2.Clear();
                            txt4.Clear();
                            txt5.Clear();
                            txt6.Clear();
                            btnSave.Enabled = false;
                            btnCancel.Enabled = false;
                            txtCode.Enabled = false;
                            txtDate.Enabled = false;
                            txt2.Enabled = false;
                            txt4.Enabled = false;
                            txt5.Enabled = false;
                            txt6.Enabled = false;
                            dgvBase.Enabled = true;
                            btnNew.Enabled = true;
                            btnReturn.Enabled = true;
                            break;
                        case DialogResult.Cancel:
                            txtCode.SelectAll();
                            txtCode.Focus();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtDate.Clear();
            txt2.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtCode.Enabled = false;
            txtDate.Enabled = false;
            txt2.Enabled = false;
            txt4.Enabled = false;
            txt5.Enabled = false;
            txt6.Enabled = false;
            dgvBase.Enabled = true;
            btnNew.Enabled = true;
            btnReturn.Enabled = true;
            btnEdit.Enabled = true;
            btnErase.Enabled = true;
            mnuErase.Enabled = true;
            mnuEdit.Enabled = true;
        }

        private void frmSell_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}