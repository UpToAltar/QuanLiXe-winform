namespace QuanLiXe
{
    partial class ResetPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassForm));
            this.groupControlLogin = new DevExpress.XtraEditors.GroupControl();
            this.textEditResetOldPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkLogin = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditResetNewPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditResetUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditResetNewPassConfirm = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLogin)).BeginInit();
            this.groupControlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResetOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResetNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResetUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResetNewPassConfirm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlLogin
            // 
            this.groupControlLogin.Controls.Add(this.textEditResetNewPassConfirm);
            this.groupControlLogin.Controls.Add(this.labelControl5);
            this.groupControlLogin.Controls.Add(this.textEditResetOldPass);
            this.groupControlLogin.Controls.Add(this.labelControl4);
            this.groupControlLogin.Controls.Add(this.pictureBox1);
            this.groupControlLogin.Controls.Add(this.btnCancelLogin);
            this.groupControlLogin.Controls.Add(this.btnReset);
            this.groupControlLogin.Controls.Add(this.hyperlinkLogin);
            this.groupControlLogin.Controls.Add(this.labelControl3);
            this.groupControlLogin.Controls.Add(this.textEditResetNewPass);
            this.groupControlLogin.Controls.Add(this.labelControl2);
            this.groupControlLogin.Controls.Add(this.textEditResetUserName);
            this.groupControlLogin.Controls.Add(this.labelControl1);
            this.groupControlLogin.Location = new System.Drawing.Point(22, 12);
            this.groupControlLogin.Name = "groupControlLogin";
            this.groupControlLogin.Size = new System.Drawing.Size(1081, 490);
            this.groupControlLogin.TabIndex = 2;
            this.groupControlLogin.Text = "Khai báo thông tin tài khoản";
            // 
            // textEditResetOldPass
            // 
            this.textEditResetOldPass.Location = new System.Drawing.Point(661, 166);
            this.textEditResetOldPass.Name = "textEditResetOldPass";
            this.textEditResetOldPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditResetOldPass.Properties.Appearance.Options.UseFont = true;
            this.textEditResetOldPass.Size = new System.Drawing.Size(387, 34);
            this.textEditResetOldPass.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(326, 165);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(173, 34);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Mật khẩu cũ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogin.Appearance.Options.UseFont = true;
            this.btnCancelLogin.Location = new System.Drawing.Point(881, 407);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(167, 47);
            this.btnCancelLogin.TabIndex = 2;
            this.btnCancelLogin.Text = "Thoát";
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.Location = new System.Drawing.Point(661, 407);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(167, 47);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Đổi mật khẩu";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // hyperlinkLogin
            // 
            this.hyperlinkLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkLogin.Appearance.Options.UseFont = true;
            this.hyperlinkLogin.Location = new System.Drawing.Point(524, 419);
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
            this.labelControl3.Location = new System.Drawing.Point(326, 419);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(192, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Bạn đã có tài khoản ?";
            // 
            // textEditResetNewPass
            // 
            this.textEditResetNewPass.Location = new System.Drawing.Point(661, 242);
            this.textEditResetNewPass.Name = "textEditResetNewPass";
            this.textEditResetNewPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditResetNewPass.Properties.Appearance.Options.UseFont = true;
            this.textEditResetNewPass.Properties.UseSystemPasswordChar = true;
            this.textEditResetNewPass.Size = new System.Drawing.Size(387, 34);
            this.textEditResetNewPass.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(326, 241);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(193, 34);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu mới";
            // 
            // textEditResetUserName
            // 
            this.textEditResetUserName.Location = new System.Drawing.Point(661, 94);
            this.textEditResetUserName.Name = "textEditResetUserName";
            this.textEditResetUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditResetUserName.Properties.Appearance.Options.UseFont = true;
            this.textEditResetUserName.Size = new System.Drawing.Size(387, 34);
            this.textEditResetUserName.TabIndex = 1;
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
            // textEditResetNewPassConfirm
            // 
            this.textEditResetNewPassConfirm.Location = new System.Drawing.Point(661, 321);
            this.textEditResetNewPassConfirm.Name = "textEditResetNewPassConfirm";
            this.textEditResetNewPassConfirm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditResetNewPassConfirm.Properties.Appearance.Options.UseFont = true;
            this.textEditResetNewPassConfirm.Properties.UseSystemPasswordChar = true;
            this.textEditResetNewPassConfirm.Size = new System.Drawing.Size(387, 34);
            this.textEditResetNewPassConfirm.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(326, 320);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(319, 34);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Nhập lại mật khẩu mới";
            // 
            // ResetPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 530);
            this.Controls.Add(this.groupControlLogin);
            this.Name = "ResetPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResetPassForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLogin)).EndInit();
            this.groupControlLogin.ResumeLayout(false);
            this.groupControlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResetOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResetNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResetUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResetNewPassConfirm.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlLogin;
        private DevExpress.XtraEditors.TextEdit textEditResetOldPass;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnCancelLogin;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLogin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditResetNewPass;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditResetUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditResetNewPassConfirm;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}