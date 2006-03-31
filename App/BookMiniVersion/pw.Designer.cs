namespace BookMiniVersion
{
    partial class frmPw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPw));
            this.txtPw = new System.Windows.Forms.TextBox();
            this.ctxMnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nULLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPw
            // 
            this.txtPw.ContextMenuStrip = this.ctxMnu;
            this.txtPw.Location = new System.Drawing.Point(12, 12);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(100, 20);
            this.txtPw.TabIndex = 0;
            this.txtPw.UseSystemPasswordChar = true;
            this.txtPw.TextChanged += new System.EventHandler(this.txtPw_TextChanged);
            // 
            // ctxMnu
            // 
            this.ctxMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nULLToolStripMenuItem});
            this.ctxMnu.Name = "ctxMnu";
            this.ctxMnu.Size = new System.Drawing.Size(139, 26);
            // 
            // nULLToolStripMenuItem
            // 
            this.nULLToolStripMenuItem.Name = "nULLToolStripMenuItem";
            this.nULLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.nULLToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.nULLToolStripMenuItem.Text = "NULL";
            this.nULLToolStripMenuItem.Click += new System.EventHandler(this.nULLToolStripMenuItem_Click);
            // 
            // frmPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(123, 46);
            this.ControlBox = false;
            this.Controls.Add(this.txtPw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPw";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ﬂ·„Â Ì ⁄»Ê—";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPw_Load);
            this.ctxMnu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.ContextMenuStrip ctxMnu;
        private System.Windows.Forms.ToolStripMenuItem nULLToolStripMenuItem;
    }
}