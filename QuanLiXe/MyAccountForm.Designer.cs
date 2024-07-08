namespace QuanLiXe
{
    partial class MyAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccountForm));
            this.groupControlLogin = new DevExpress.XtraEditors.GroupControl();
            this.tbMyAccountPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbMyAccountUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbMyAccountDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbMyAccountImage = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tbMyAccountRole = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdateMyAccount = new DevExpress.XtraEditors.SimpleButton();
            this.btnResetPasswordMyAccount = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBoxMyAccount = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLogin)).BeginInit();
            this.groupControlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMyAccountPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMyAccountUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMyAccountDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMyAccountImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMyAccountRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlLogin
            // 
            this.groupControlLogin.Controls.Add(this.pictureBoxMyAccount);
            this.groupControlLogin.Controls.Add(this.btnResetPasswordMyAccount);
            this.groupControlLogin.Controls.Add(this.btnUpdateMyAccount);
            this.groupControlLogin.Controls.Add(this.tbMyAccountRole);
            this.groupControlLogin.Controls.Add(this.labelControl6);
            this.groupControlLogin.Controls.Add(this.tbMyAccountImage);
            this.groupControlLogin.Controls.Add(this.labelControl5);
            this.groupControlLogin.Controls.Add(this.tbMyAccountDisplayName);
            this.groupControlLogin.Controls.Add(this.labelControl3);
            this.groupControlLogin.Controls.Add(this.tbMyAccountPassword);
            this.groupControlLogin.Controls.Add(this.labelControl2);
            this.groupControlLogin.Controls.Add(this.tbMyAccountUserName);
            this.groupControlLogin.Controls.Add(this.labelControl1);
            this.groupControlLogin.Location = new System.Drawing.Point(12, 12);
            this.groupControlLogin.Name = "groupControlLogin";
            this.groupControlLogin.Size = new System.Drawing.Size(1183, 555);
            this.groupControlLogin.TabIndex = 1;
            this.groupControlLogin.Text = "Khai báo thông tin tài khoản";
            // 
            // tbMyAccountPassword
            // 
            this.tbMyAccountPassword.Location = new System.Drawing.Point(777, 135);
            this.tbMyAccountPassword.Name = "tbMyAccountPassword";
            this.tbMyAccountPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMyAccountPassword.Properties.Appearance.Options.UseFont = true;
            this.tbMyAccountPassword.Properties.ReadOnly = true;
            this.tbMyAccountPassword.Properties.UseSystemPasswordChar = true;
            this.tbMyAccountPassword.Size = new System.Drawing.Size(387, 34);
            this.tbMyAccountPassword.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(519, 134);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(132, 34);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // tbMyAccountUserName
            // 
            this.tbMyAccountUserName.Location = new System.Drawing.Point(777, 58);
            this.tbMyAccountUserName.Name = "tbMyAccountUserName";
            this.tbMyAccountUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMyAccountUserName.Properties.Appearance.Options.UseFont = true;
            this.tbMyAccountUserName.Size = new System.Drawing.Size(387, 34);
            this.tbMyAccountUserName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(519, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(210, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // tbMyAccountDisplayName
            // 
            this.tbMyAccountDisplayName.Location = new System.Drawing.Point(777, 214);
            this.tbMyAccountDisplayName.Name = "tbMyAccountDisplayName";
            this.tbMyAccountDisplayName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMyAccountDisplayName.Properties.Appearance.Options.UseFont = true;
            this.tbMyAccountDisplayName.Size = new System.Drawing.Size(387, 34);
            this.tbMyAccountDisplayName.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(519, 213);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(167, 34);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Tên hiển thị";
            // 
            // tbMyAccountImage
            // 
            this.tbMyAccountImage.Location = new System.Drawing.Point(777, 297);
            this.tbMyAccountImage.Name = "tbMyAccountImage";
            this.tbMyAccountImage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMyAccountImage.Properties.Appearance.Options.UseFont = true;
            this.tbMyAccountImage.Size = new System.Drawing.Size(387, 34);
            this.tbMyAccountImage.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(519, 297);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(218, 34);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Đường dẫn ảnh";
            // 
            // tbMyAccountRole
            // 
            this.tbMyAccountRole.Location = new System.Drawing.Point(777, 379);
            this.tbMyAccountRole.Name = "tbMyAccountRole";
            this.tbMyAccountRole.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMyAccountRole.Properties.Appearance.Options.UseFont = true;
            this.tbMyAccountRole.Properties.ReadOnly = true;
            this.tbMyAccountRole.Size = new System.Drawing.Size(387, 34);
            this.tbMyAccountRole.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(519, 379);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 33);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Vai trò";
            // 
            // btnUpdateMyAccount
            // 
            this.btnUpdateMyAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMyAccount.Appearance.Options.UseFont = true;
            this.btnUpdateMyAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateOwner.ImageOptions.SvgImage")));
            this.btnUpdateMyAccount.Location = new System.Drawing.Point(777, 459);
            this.btnUpdateMyAccount.Name = "btnUpdateMyAccount";
            this.btnUpdateMyAccount.Size = new System.Drawing.Size(171, 71);
            this.btnUpdateMyAccount.TabIndex = 14;
            this.btnUpdateMyAccount.Text = "Cập nhật";
            this.btnUpdateMyAccount.Click += new System.EventHandler(this.btnUpdateMyAccount_Click);
            // 
            // btnResetPasswordMyAccount
            // 
            this.btnResetPasswordMyAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPasswordMyAccount.Appearance.Options.UseFont = true;
            this.btnResetPasswordMyAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnResetPasswordMyAccount.Location = new System.Drawing.Point(954, 459);
            this.btnResetPasswordMyAccount.Name = "btnResetPasswordMyAccount";
            this.btnResetPasswordMyAccount.Size = new System.Drawing.Size(210, 71);
            this.btnResetPasswordMyAccount.TabIndex = 15;
            this.btnResetPasswordMyAccount.Text = "Đổi mật khẩu";
            this.btnResetPasswordMyAccount.Click += new System.EventHandler(this.btnResetPasswordMyAccount_Click);
            // 
            // pictureBoxMyAccount
            // 
            this.pictureBoxMyAccount.Location = new System.Drawing.Point(17, 58);
            this.pictureBoxMyAccount.Name = "pictureBoxMyAccount";
            this.pictureBoxMyAccount.Size = new System.Drawing.Size(487, 472);
            this.pictureBoxMyAccount.TabIndex = 16;
            this.pictureBoxMyAccount.TabStop = false;
            // 
            // MyAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 583);
            this.Controls.Add(this.groupControlLogin);
            this.Name = "MyAccountForm";
            this.Text = "Thông tin tài khoản cá nhân";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLogin)).EndInit();
            this.groupControlLogin.ResumeLayout(false);
            this.groupControlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMyAccountPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMyAccountUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMyAccountDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMyAccountImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMyAccountRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlLogin;
        private DevExpress.XtraEditors.TextEdit tbMyAccountRole;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit tbMyAccountImage;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tbMyAccountDisplayName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbMyAccountPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbMyAccountUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnResetPasswordMyAccount;
        private DevExpress.XtraEditors.SimpleButton btnUpdateMyAccount;
        private System.Windows.Forms.PictureBox pictureBoxMyAccount;
    }
}