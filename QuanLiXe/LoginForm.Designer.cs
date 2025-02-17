﻿namespace QuanLiXe
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.groupControlLogin = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnResetPass = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLogin)).BeginInit();
            this.groupControlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlLogin
            // 
            this.groupControlLogin.Controls.Add(this.labelControl6);
            this.groupControlLogin.Controls.Add(this.labelControl5);
            this.groupControlLogin.Controls.Add(this.btnResetPass);
            this.groupControlLogin.Controls.Add(this.btnCancelLogin);
            this.groupControlLogin.Controls.Add(this.labelControl4);
            this.groupControlLogin.Controls.Add(this.btnLogin);
            this.groupControlLogin.Controls.Add(this.hyperlinkLabelControl1);
            this.groupControlLogin.Controls.Add(this.labelControl3);
            this.groupControlLogin.Controls.Add(this.textEditPassword);
            this.groupControlLogin.Controls.Add(this.labelControl2);
            this.groupControlLogin.Controls.Add(this.textEditUserName);
            this.groupControlLogin.Controls.Add(this.labelControl1);
            this.groupControlLogin.Location = new System.Drawing.Point(33, 12);
            this.groupControlLogin.Name = "groupControlLogin";
            this.groupControlLogin.Size = new System.Drawing.Size(1069, 362);
            this.groupControlLogin.TabIndex = 0;
            this.groupControlLogin.Text = "Khai báo thông tin tài khoản";
            this.groupControlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControlLogin_Paint);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(638, 188);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(17, 33);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "*";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(638, 111);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(17, 33);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "*";
            // 
            // btnResetPass
            // 
            this.btnResetPass.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPass.Appearance.Options.UseFont = true;
            this.btnResetPass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetPass.ImageOptions.SvgImage")));
            this.btnResetPass.Location = new System.Drawing.Point(48, 279);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(195, 58);
            this.btnResetPass.TabIndex = 7;
            this.btnResetPass.Text = "Đổi mật khẩu";
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogin.Appearance.Options.UseFont = true;
            this.btnCancelLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelLogin.ImageOptions.SvgImage")));
            this.btnCancelLogin.Location = new System.Drawing.Point(881, 279);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(167, 58);
            this.btnCancelLogin.TabIndex = 4;
            this.btnCancelLogin.Text = "Thoát";
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl4.ImageOptions.Image")));
            this.labelControl4.Location = new System.Drawing.Point(33, 46);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(225, 225);
            this.labelControl4.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.Location = new System.Drawing.Point(661, 279);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(167, 58);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkLabelControl1.Appearance.Options.UseFont = true;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(542, 300);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(73, 24);
            this.hyperlinkLabelControl1.TabIndex = 5;
            this.hyperlinkLabelControl1.Text = "Đăng ký";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(323, 300);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(213, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Bạn chưa có tài khoản ?";
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(661, 185);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPassword.Properties.Appearance.Options.UseFont = true;
            this.textEditPassword.Properties.UseSystemPasswordChar = true;
            this.textEditPassword.Size = new System.Drawing.Size(387, 34);
            this.textEditPassword.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(326, 184);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(132, 34);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // textEditUserName
            // 
            this.textEditUserName.Location = new System.Drawing.Point(661, 108);
            this.textEditUserName.Name = "textEditUserName";
            this.textEditUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditUserName.Properties.Appearance.Options.UseFont = true;
            this.textEditUserName.Size = new System.Drawing.Size(387, 34);
            this.textEditUserName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(326, 107);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(210, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 388);
            this.Controls.Add(this.groupControlLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLogin)).EndInit();
            this.groupControlLogin.ResumeLayout(false);
            this.groupControlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlLogin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnResetPass;
        public DevExpress.XtraEditors.SimpleButton btnCancelLogin;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}

