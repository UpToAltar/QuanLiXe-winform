﻿namespace QuanLiXe
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.groupControlLogin = new DevExpress.XtraEditors.GroupControl();
            this.btnCancelLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkLogin = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditRegisterPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditRegisterUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textEditRegisterDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditRegisterPasswordConfirm = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnResetPass = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLogin)).BeginInit();
            this.groupControlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRegisterPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRegisterUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRegisterDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRegisterPasswordConfirm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlLogin
            // 
            this.groupControlLogin.Controls.Add(this.btnResetPass);
            this.groupControlLogin.Controls.Add(this.textEditRegisterPasswordConfirm);
            this.groupControlLogin.Controls.Add(this.labelControl5);
            this.groupControlLogin.Controls.Add(this.textEditRegisterDisplayName);
            this.groupControlLogin.Controls.Add(this.labelControl4);
            this.groupControlLogin.Controls.Add(this.pictureBox1);
            this.groupControlLogin.Controls.Add(this.btnCancelLogin);
            this.groupControlLogin.Controls.Add(this.btnRegister);
            this.groupControlLogin.Controls.Add(this.hyperlinkLogin);
            this.groupControlLogin.Controls.Add(this.labelControl3);
            this.groupControlLogin.Controls.Add(this.textEditRegisterPassword);
            this.groupControlLogin.Controls.Add(this.labelControl2);
            this.groupControlLogin.Controls.Add(this.textEditRegisterUserName);
            this.groupControlLogin.Controls.Add(this.labelControl1);
            this.groupControlLogin.Location = new System.Drawing.Point(45, 12);
            this.groupControlLogin.Name = "groupControlLogin";
            this.groupControlLogin.Size = new System.Drawing.Size(1081, 498);
            this.groupControlLogin.TabIndex = 1;
            this.groupControlLogin.Text = "Khai báo thông tin tài khoản";
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogin.Appearance.Options.UseFont = true;
            this.btnCancelLogin.Location = new System.Drawing.Point(881, 414);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(167, 47);
            this.btnCancelLogin.TabIndex = 2;
            this.btnCancelLogin.Text = "Thoát";
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Location = new System.Drawing.Point(661, 414);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(167, 47);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Đăng kí";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // hyperlinkLogin
            // 
            this.hyperlinkLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkLogin.Appearance.Options.UseFont = true;
            this.hyperlinkLogin.Location = new System.Drawing.Point(524, 422);
            this.hyperlinkLogin.Name = "hyperlinkLogin";
            this.hyperlinkLogin.Size = new System.Drawing.Size(97, 24);
            this.hyperlinkLogin.TabIndex = 5;
            this.hyperlinkLogin.Text = "Đăng nhập";
            this.hyperlinkLogin.Click += new System.EventHandler(this.hyperlinkLogin_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(326, 422);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(192, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Bạn đã có tài khoản ?";
            // 
            // textEditRegisterPassword
            // 
            this.textEditRegisterPassword.Location = new System.Drawing.Point(661, 246);
            this.textEditRegisterPassword.Name = "textEditRegisterPassword";
            this.textEditRegisterPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditRegisterPassword.Properties.Appearance.Options.UseFont = true;
            this.textEditRegisterPassword.Properties.UseSystemPasswordChar = true;
            this.textEditRegisterPassword.Size = new System.Drawing.Size(387, 34);
            this.textEditRegisterPassword.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(326, 246);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(132, 34);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // textEditRegisterUserName
            // 
            this.textEditRegisterUserName.Location = new System.Drawing.Point(661, 94);
            this.textEditRegisterUserName.Name = "textEditRegisterUserName";
            this.textEditRegisterUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditRegisterUserName.Properties.Appearance.Options.UseFont = true;
            this.textEditRegisterUserName.Size = new System.Drawing.Size(387, 34);
            this.textEditRegisterUserName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(326, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(210, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textEditRegisterDisplayName
            // 
            this.textEditRegisterDisplayName.Location = new System.Drawing.Point(661, 166);
            this.textEditRegisterDisplayName.Name = "textEditRegisterDisplayName";
            this.textEditRegisterDisplayName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditRegisterDisplayName.Properties.Appearance.Options.UseFont = true;
            this.textEditRegisterDisplayName.Size = new System.Drawing.Size(387, 34);
            this.textEditRegisterDisplayName.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(326, 169);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(167, 34);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Tên hiển thị";
            // 
            // textEditRegisterPasswordConfirm
            // 
            this.textEditRegisterPasswordConfirm.Location = new System.Drawing.Point(661, 325);
            this.textEditRegisterPasswordConfirm.Name = "textEditRegisterPasswordConfirm";
            this.textEditRegisterPasswordConfirm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditRegisterPasswordConfirm.Properties.Appearance.Options.UseFont = true;
            this.textEditRegisterPasswordConfirm.Properties.UseSystemPasswordChar = true;
            this.textEditRegisterPasswordConfirm.Size = new System.Drawing.Size(387, 34);
            this.textEditRegisterPasswordConfirm.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(326, 324);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(258, 34);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Nhập lại mật khẩu";
            // 
            // btnResetPass
            // 
            this.btnResetPass.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPass.Appearance.Options.UseFont = true;
            this.btnResetPass.Location = new System.Drawing.Point(90, 414);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(167, 47);
            this.btnResetPass.TabIndex = 12;
            this.btnResetPass.Text = "Đổi mật khẩu";
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 537);
            this.Controls.Add(this.groupControlLogin);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLogin)).EndInit();
            this.groupControlLogin.ResumeLayout(false);
            this.groupControlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRegisterPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRegisterUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRegisterDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRegisterPasswordConfirm.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlLogin;
        private DevExpress.XtraEditors.SimpleButton btnCancelLogin;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLogin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditRegisterPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditRegisterUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit textEditRegisterDisplayName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditRegisterPasswordConfirm;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnResetPass;
    }
}