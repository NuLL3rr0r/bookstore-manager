namespace BookMiniVersion
{
    partial class frmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.lblCode = new System.Windows.Forms.Label();
            this.lblLable = new System.Windows.Forms.Label();
            this.txtLable = new System.Windows.Forms.TextBox();
            this.dgvBase = new System.Windows.Forms.DataGridView();
            this.ctxErase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuErase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.MaskedTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
            this.ctxErase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Location = new System.Drawing.Point(730, 489);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(50, 20);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "ﬂœ ﬂ«·«";
            // 
            // lblLable
            // 
            this.lblLable.AutoSize = true;
            this.lblLable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLable.Location = new System.Drawing.Point(507, 489);
            this.lblLable.Name = "lblLable";
            this.lblLable.Size = new System.Drawing.Size(70, 20);
            this.lblLable.TabIndex = 3;
            this.lblLable.Text = "⁄‰Ê«‰ ﬂ«·«";
            // 
            // txtLable
            // 
            this.txtLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLable.Enabled = false;
            this.txtLable.Location = new System.Drawing.Point(12, 486);
            this.txtLable.MaxLength = 255;
            this.txtLable.Name = "txtLable";
            this.txtLable.Size = new System.Drawing.Size(489, 26);
            this.txtLable.TabIndex = 4;
            this.txtLable.TextChanged += new System.EventHandler(this.txtLable_TextChanged);
            // 
            // dgvBase
            // 
            this.dgvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBase.ContextMenuStrip = this.ctxErase;
            this.dgvBase.Location = new System.Drawing.Point(15, 12);
            this.dgvBase.Name = "dgvBase";
            this.dgvBase.ReadOnly = true;
            this.dgvBase.Size = new System.Drawing.Size(763, 457);
            this.dgvBase.TabIndex = 0;
            this.dgvBase.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBase_CellEnter);
            this.dgvBase.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvBase_RowsRemoved);
            // 
            // ctxErase
            // 
            this.ctxErase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuErase,
            this.mnuEdit});
            this.ctxErase.Name = "ctxErase";
            this.ctxErase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(603, 518);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(175, 34);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "ÃœÌœ";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(495, 518);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "–ŒÌ—Â";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(407, 518);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "·€Ê";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(15, 518);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(175, 34);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "»«“ê‘ ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(603, 486);
            this.txtCode.Mask = "00000";
            this.txtCode.Name = "txtCode";
            this.txtCode.PromptChar = '#';
            this.txtCode.Size = new System.Drawing.Size(121, 26);
            this.txtCode.TabIndex = 2;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(304, 518);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 34);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "ÊÌ—«Ì‘";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnErase
            // 
            this.btnErase.Enabled = false;
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.Location = new System.Drawing.Point(216, 518);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(82, 34);
            this.btnErase.TabIndex = 9;
            this.btnErase.Text = "Õ–›";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 564);
            this.ControlBox = false;
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvBase);
            this.Controls.Add(this.txtLable);
            this.Controls.Add(this.lblLable);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBase";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "«ÿ·«⁄«  Å«ÌÂ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
            this.ctxErase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblLable;
        private System.Windows.Forms.TextBox txtLable;
        private System.Windows.Forms.DataGridView dgvBase;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.MaskedTextBox txtCode;
        private System.Windows.Forms.ContextMenuStrip ctxErase;
        private System.Windows.Forms.ToolStripMenuItem mnuErase;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
    }
}