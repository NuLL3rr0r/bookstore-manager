namespace BookMiniVersion
{
    partial class frmSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSell));
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.txt6 = new System.Windows.Forms.MaskedTextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.MaskedTextBox();
            this.txt2 = new System.Windows.Forms.MaskedTextBox();
            this.dgvBase = new System.Windows.Forms.DataGridView();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ctxErase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuErase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuInsert = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
            this.ctxErase.SuspendLayout();
            this.ctxDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(12, 518);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(175, 34);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "»«“ê‘ ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate.ContextMenuStrip = this.ctxDate;
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(15, 436);
            this.txtDate.Mask = "0000/00/00";
            this.txtDate.Name = "txtDate";
            this.txtDate.PromptChar = '#';
            this.txtDate.Size = new System.Drawing.Size(283, 26);
            this.txtDate.TabIndex = 35;
            // 
            // txt6
            // 
            this.txt6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt6.Enabled = false;
            this.txt6.Location = new System.Drawing.Point(15, 477);
            this.txt6.Mask = "000";
            this.txt6.Name = "txt6";
            this.txt6.PromptChar = '#';
            this.txt6.Size = new System.Drawing.Size(283, 26);
            this.txt6.TabIndex = 37;
            // 
            // txt4
            // 
            this.txt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt4.Enabled = false;
            this.txt4.Location = new System.Drawing.Point(440, 474);
            this.txt4.MaxLength = 30;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(231, 26);
            this.txt4.TabIndex = 32;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(440, 395);
            this.txtCode.Mask = "00000";
            this.txtCode.Name = "txtCode";
            this.txtCode.PromptChar = '#';
            this.txtCode.Size = new System.Drawing.Size(231, 26);
            this.txtCode.TabIndex = 24;
            // 
            // txt2
            // 
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(440, 436);
            this.txt2.Mask = "00%";
            this.txt2.Name = "txt2";
            this.txt2.PromptChar = '#';
            this.txt2.Size = new System.Drawing.Size(231, 26);
            this.txt2.TabIndex = 28;
            // 
            // dgvBase
            // 
            this.dgvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBase.Location = new System.Drawing.Point(15, 12);
            this.dgvBase.Name = "dgvBase";
            this.dgvBase.ReadOnly = true;
            this.dgvBase.Size = new System.Drawing.Size(763, 363);
            this.dgvBase.TabIndex = 22;
            this.dgvBase.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBase_CellEnter);
            this.dgvBase.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvBase_RowsRemoved);
            // 
            // txt5
            // 
            this.txt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt5.Enabled = false;
            this.txt5.Location = new System.Drawing.Point(15, 394);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(283, 26);
            this.txt5.TabIndex = 33;
            // 
            // btnErase
            // 
            this.btnErase.Enabled = false;
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.Location = new System.Drawing.Point(216, 518);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(82, 34);
            this.btnErase.TabIndex = 42;
            this.btnErase.Text = "Õ–›";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(304, 518);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 34);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "ÊÌ—«Ì‘";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(407, 518);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 34);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "·€Ê";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(495, 518);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 34);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "–ŒÌ—Â";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(603, 518);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(175, 34);
            this.btnNew.TabIndex = 38;
            this.btnNew.Text = "ÃœÌœ";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(371, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = " ⁄œ«œ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(331, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = " «—ÌŒ ›—Ê‘";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(677, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "‘„«—Â Ì ›«ﬂ Ê—";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(734, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "ﬂœ ﬂ«·«";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(696, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "œ—’œ  Œ›Ì›";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(331, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "‰«„ „‘ —Ì";
            // 
            // ctxErase
            // 
            this.ctxErase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuErase,
            this.mnuEdit});
            this.ctxErase.Name = "ctxErase";
            this.ctxErase.Size = new System.Drawing.Size(130, 48);
            // 
            // mnuErase
            // 
            this.mnuErase.Enabled = false;
            this.mnuErase.Name = "mnuErase";
            this.mnuErase.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuErase.Size = new System.Drawing.Size(129, 22);
            this.mnuErase.Text = "Õ–›";
            this.mnuErase.Click += new System.EventHandler(this.mnuErase_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Enabled = false;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.mnuEdit.Size = new System.Drawing.Size(129, 22);
            this.mnuEdit.Text = "ÊÌ—«Ì‘";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // ctxDate
            // 
            this.ctxDate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInsert});
            this.ctxDate.Name = "ctxDate";
            this.ctxDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctxDate.Size = new System.Drawing.Size(198, 26);
            // 
            // mnuInsert
            // 
            this.mnuInsert.Name = "mnuInsert";
            this.mnuInsert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Space)));
            this.mnuInsert.Size = new System.Drawing.Size(197, 22);
            this.mnuInsert.Text = "œ—Ã  «—ÌŒ «„—Ê“";
            this.mnuInsert.Click += new System.EventHandler(this.mnuInsert_Click);
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 564);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.dgvBase);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSell";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "›«ﬂ Ê— ›—Ê‘";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
            this.ctxErase.ResumeLayout(false);
            this.ctxDate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.MaskedTextBox txt6;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.MaskedTextBox txtCode;
        private System.Windows.Forms.MaskedTextBox txt2;
        private System.Windows.Forms.DataGridView dgvBase;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip ctxErase;
        private System.Windows.Forms.ToolStripMenuItem mnuErase;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ContextMenuStrip ctxDate;
        private System.Windows.Forms.ToolStripMenuItem mnuInsert;
    }
}