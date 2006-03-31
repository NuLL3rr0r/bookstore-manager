namespace BookMiniVersion
{
    partial class frmPwChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPwChange));
            this.txtCurrentPw = new System.Windows.Forms.TextBox();
            this.txtNewPw = new System.Windows.Forms.TextBox();
            this.txtConfirmPw = new System.Windows.Forms.TextBox();
            this.lblCurrentPw = new System.Windows.Forms.Label();
            this.lblNewPw = new System.Windows.Forms.Label();
            this.lblConfirmPw = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCurrentPw
            // 
            this.txtCurrentPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPw.Location = new System.Drawing.Point(16, 17);
            this.txtCurrentPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentPw.Name = "txtCurrentPw";
            this.txtCurrentPw.Size = new System.Drawing.Size(132, 26);
            this.txtCurrentPw.TabIndex = 1;
            this.txtCurrentPw.UseSystemPasswordChar = true;
            // 
            // txtNewPw
            // 
            this.txtNewPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPw.Location = new System.Drawing.Point(16, 53);
            this.txtNewPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPw.Name = "txtNewPw";
            this.txtNewPw.Size = new System.Drawing.Size(132, 26);
            this.txtNewPw.TabIndex = 3;
            this.txtNewPw.UseSystemPasswordChar = true;
            // 
            // txtConfirmPw
            // 
            this.txtConfirmPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPw.Location = new System.Drawing.Point(16, 89);
            this.txtConfirmPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPw.Name = "txtConfirmPw";
            this.txtConfirmPw.Size = new System.Drawing.Size(132, 26);
            this.txtConfirmPw.TabIndex = 5;
            this.txtConfirmPw.UseSystemPasswordChar = true;
            // 
            // lblCurrentPw
            // 
            this.lblCurrentPw.AutoSize = true;
            this.lblCurrentPw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentPw.Location = new System.Drawing.Point(155, 20);
            this.lblCurrentPw.Name = "lblCurrentPw";
            this.lblCurrentPw.Size = new System.Drawing.Size(109, 20);
            this.lblCurrentPw.TabIndex = 0;
            this.lblCurrentPw.Text = "ﬂ·„Â ⁄»Ê— ›⁄·Ì";
            // 
            // lblNewPw
            // 
            this.lblNewPw.AutoSize = true;
            this.lblNewPw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNewPw.Location = new System.Drawing.Point(155, 56);
            this.lblNewPw.Name = "lblNewPw";
            this.lblNewPw.Size = new System.Drawing.Size(106, 20);
            this.lblNewPw.TabIndex = 2;
            this.lblNewPw.Text = "ﬂ·„Â ⁄»Ê— ÃœÌœ";
            // 
            // lblConfirmPw
            // 
            this.lblConfirmPw.AutoSize = true;
            this.lblConfirmPw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConfirmPw.Location = new System.Drawing.Point(155, 92);
            this.lblConfirmPw.Name = "lblConfirmPw";
            this.lblConfirmPw.Size = new System.Drawing.Size(101, 20);
            this.lblConfirmPw.TabIndex = 4;
            this.lblConfirmPw.Text = " «∆Ìœ ﬂ·„Â ⁄»Ê—";
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(150, 134);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(114, 30);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = " «∆Ìœ";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(16, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "·€Ê";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPwChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 176);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblConfirmPw);
            this.Controls.Add(this.lblNewPw);
            this.Controls.Add(this.lblCurrentPw);
            this.Controls.Add(this.txtConfirmPw);
            this.Controls.Add(this.txtNewPw);
            this.Controls.Add(this.txtCurrentPw);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPwChange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " €ÌÌ— ﬂ·„Â Ì ⁄»Ê—";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPwChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentPw;
        private System.Windows.Forms.TextBox txtNewPw;
        private System.Windows.Forms.TextBox txtConfirmPw;
        private System.Windows.Forms.Label lblCurrentPw;
        private System.Windows.Forms.Label lblNewPw;
        private System.Windows.Forms.Label lblConfirmPw;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}