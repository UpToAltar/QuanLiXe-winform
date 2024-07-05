namespace QuanLiXe
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridViewAccount = new DevExpress.XtraGrid.GridControl();
            this.gridViewAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbAccountRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAccountPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new DevExpress.XtraEditors.SimpleButton();
            this.btnReadAccount = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchAccount = new DevExpress.XtraEditors.SimpleButton();
            this.tbSearchAccount = new System.Windows.Forms.TextBox();
            this.btnUpdateAccount = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddAccount = new DevExpress.XtraEditors.SimpleButton();
            this.tbAccountDisplayName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAccountUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAccountId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportExcelAccount = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExportExcelAccount);
            this.panelControl1.Controls.Add(this.dataGridViewAccount);
            this.panelControl1.Controls.Add(this.tbAccountRole);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.tbAccountPassword);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.btnDeleteAccount);
            this.panelControl1.Controls.Add(this.btnReadAccount);
            this.panelControl1.Controls.Add(this.btnSearchAccount);
            this.panelControl1.Controls.Add(this.tbSearchAccount);
            this.panelControl1.Controls.Add(this.btnUpdateAccount);
            this.panelControl1.Controls.Add(this.btnAddAccount);
            this.panelControl1.Controls.Add(this.tbAccountDisplayName);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.tbAccountUserName);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.tbAccountId);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(12, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1177, 669);
            this.panelControl1.TabIndex = 2;
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.Location = new System.Drawing.Point(5, 108);
            this.dataGridViewAccount.MainView = this.gridViewAccount;
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.Size = new System.Drawing.Size(810, 531);
            this.dataGridViewAccount.TabIndex = 17;
            this.dataGridViewAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAccount});
            // 
            // gridViewAccount
            // 
            this.gridViewAccount.GridControl = this.dataGridViewAccount;
            this.gridViewAccount.GroupPanelText = "Danh sách tài khoản";
            this.gridViewAccount.Name = "gridViewAccount";
            // 
            // tbAccountRole
            // 
            this.tbAccountRole.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountRole.FormattingEnabled = true;
            this.tbAccountRole.Location = new System.Drawing.Point(852, 501);
            this.tbAccountRole.Name = "tbAccountRole";
            this.tbAccountRole.Size = new System.Drawing.Size(317, 36);
            this.tbAccountRole.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(847, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Vai trò";
            // 
            // tbAccountPassword
            // 
            this.tbAccountPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountPassword.Location = new System.Drawing.Point(852, 403);
            this.tbAccountPassword.Name = "tbAccountPassword";
            this.tbAccountPassword.Size = new System.Drawing.Size(318, 35);
            this.tbAccountPassword.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(847, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mật khẩu";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Appearance.Options.UseFont = true;
            this.btnDeleteAccount.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeleteAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteAccount.ImageOptions.SvgImage")));
            this.btnDeleteAccount.Location = new System.Drawing.Point(833, 31);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(150, 71);
            this.btnDeleteAccount.TabIndex = 12;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnReadAccount
            // 
            this.btnReadAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadAccount.Appearance.Options.UseFont = true;
            this.btnReadAccount.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReadAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReadAccount.ImageOptions.SvgImage")));
            this.btnReadAccount.Location = new System.Drawing.Point(665, 31);
            this.btnReadAccount.Name = "btnReadAccount";
            this.btnReadAccount.Size = new System.Drawing.Size(150, 71);
            this.btnReadAccount.TabIndex = 11;
            this.btnReadAccount.Text = "Xem";
            this.btnReadAccount.Click += new System.EventHandler(this.btnReadAccount_Click);
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAccount.Appearance.Options.UseFont = true;
            this.btnSearchAccount.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearchAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearchAccount.ImageOptions.SvgImage")));
            this.btnSearchAccount.Location = new System.Drawing.Point(486, 31);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(150, 71);
            this.btnSearchAccount.TabIndex = 10;
            this.btnSearchAccount.Text = "Tìm kiếm";
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearchAccount_Click);
            // 
            // tbSearchAccount
            // 
            this.tbSearchAccount.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchAccount.Location = new System.Drawing.Point(5, 51);
            this.tbSearchAccount.Name = "tbSearchAccount";
            this.tbSearchAccount.Size = new System.Drawing.Size(450, 35);
            this.tbSearchAccount.TabIndex = 9;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccount.Appearance.Options.UseFont = true;
            this.btnUpdateAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateAccount.ImageOptions.SvgImage")));
            this.btnUpdateAccount.Location = new System.Drawing.Point(1020, 571);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(150, 71);
            this.btnUpdateAccount.TabIndex = 8;
            this.btnUpdateAccount.Text = "Cập nhật";
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Appearance.Options.UseFont = true;
            this.btnAddAccount.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddAccount.ImageOptions.SvgImage")));
            this.btnAddAccount.Location = new System.Drawing.Point(852, 571);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(150, 71);
            this.btnAddAccount.TabIndex = 7;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // tbAccountDisplayName
            // 
            this.tbAccountDisplayName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountDisplayName.Location = new System.Drawing.Point(852, 313);
            this.tbAccountDisplayName.Name = "tbAccountDisplayName";
            this.tbAccountDisplayName.Size = new System.Drawing.Size(318, 35);
            this.tbAccountDisplayName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(847, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên hiển thị";
            // 
            // tbAccountUserName
            // 
            this.tbAccountUserName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountUserName.Location = new System.Drawing.Point(852, 226);
            this.tbAccountUserName.Name = "tbAccountUserName";
            this.tbAccountUserName.Size = new System.Drawing.Size(318, 35);
            this.tbAccountUserName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(847, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhập";
            // 
            // tbAccountId
            // 
            this.tbAccountId.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountId.Location = new System.Drawing.Point(852, 142);
            this.tbAccountId.Name = "tbAccountId";
            this.tbAccountId.Size = new System.Drawing.Size(318, 35);
            this.tbAccountId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(847, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // btnExportExcelAccount
            // 
            this.btnExportExcelAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcelAccount.Appearance.Options.UseFont = true;
            this.btnExportExcelAccount.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportExcelAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportExcelAutomaker.ImageOptions.SvgImage")));
            this.btnExportExcelAccount.Location = new System.Drawing.Point(1001, 31);
            this.btnExportExcelAccount.Name = "btnExportExcelAccount";
            this.btnExportExcelAccount.Size = new System.Drawing.Size(169, 71);
            this.btnExportExcelAccount.TabIndex = 20;
            this.btnExportExcelAccount.Text = "Xuất file";
            this.btnExportExcelAccount.Click += new System.EventHandler(this.btnExportExcelAccount_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 686);
            this.Controls.Add(this.panelControl1);
            this.Name = "AccountForm";
            this.Text = "Trang quản trị tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAccountPassword;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAccount;
        private DevExpress.XtraEditors.SimpleButton btnReadAccount;
        private DevExpress.XtraEditors.SimpleButton btnSearchAccount;
        private System.Windows.Forms.TextBox tbSearchAccount;
        private DevExpress.XtraEditors.SimpleButton btnUpdateAccount;
        private DevExpress.XtraEditors.SimpleButton btnAddAccount;
        private System.Windows.Forms.TextBox tbAccountDisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAccountUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAccountId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tbAccountRole;
        private DevExpress.XtraGrid.GridControl dataGridViewAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAccount;
        private DevExpress.XtraEditors.SimpleButton btnExportExcelAccount;
    }
}