namespace QuanLiXe
{
    partial class OwnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExportExcelOwner = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewOwner = new DevExpress.XtraGrid.GridControl();
            this.gridViewOwner = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbOwnerPhoneNumer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOwnerAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteOwner = new DevExpress.XtraEditors.SimpleButton();
            this.btnReadOwner = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchOwner = new DevExpress.XtraEditors.SimpleButton();
            this.tbSearchOwner = new System.Windows.Forms.TextBox();
            this.btnUpdateOwner = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddOwner = new DevExpress.XtraEditors.SimpleButton();
            this.tbOwnerEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOwnerFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOwnerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExportExcelOwner);
            this.panelControl1.Controls.Add(this.dataGridViewOwner);
            this.panelControl1.Controls.Add(this.tbOwnerPhoneNumer);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.tbOwnerAddress);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.btnDeleteOwner);
            this.panelControl1.Controls.Add(this.btnReadOwner);
            this.panelControl1.Controls.Add(this.btnSearchOwner);
            this.panelControl1.Controls.Add(this.tbSearchOwner);
            this.panelControl1.Controls.Add(this.btnUpdateOwner);
            this.panelControl1.Controls.Add(this.btnAddOwner);
            this.panelControl1.Controls.Add(this.tbOwnerEmail);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.tbOwnerFullName);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.tbOwnerId);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(12, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1175, 669);
            this.panelControl1.TabIndex = 1;
            // 
            // btnExportExcelOwner
            // 
            this.btnExportExcelOwner.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcelOwner.Appearance.Options.UseFont = true;
            this.btnExportExcelOwner.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportExcelOwner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportExcelOwner.ImageOptions.SvgImage")));
            this.btnExportExcelOwner.Location = new System.Drawing.Point(1001, 31);
            this.btnExportExcelOwner.Name = "btnExportExcelOwner";
            this.btnExportExcelOwner.Size = new System.Drawing.Size(169, 71);
            this.btnExportExcelOwner.TabIndex = 18;
            this.btnExportExcelOwner.Text = "Xuất file";
            this.btnExportExcelOwner.Click += new System.EventHandler(this.btnExportExcelOwner_Click);
            // 
            // dataGridViewOwner
            // 
            this.dataGridViewOwner.Location = new System.Drawing.Point(5, 119);
            this.dataGridViewOwner.MainView = this.gridViewOwner;
            this.dataGridViewOwner.Name = "dataGridViewOwner";
            this.dataGridViewOwner.Size = new System.Drawing.Size(836, 520);
            this.dataGridViewOwner.TabIndex = 17;
            this.dataGridViewOwner.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOwner});
            // 
            // gridViewOwner
            // 
            this.gridViewOwner.GridControl = this.dataGridViewOwner;
            this.gridViewOwner.GroupPanelText = "Danh sách chủ xe";
            this.gridViewOwner.Name = "gridViewOwner";
            // 
            // tbOwnerPhoneNumer
            // 
            this.tbOwnerPhoneNumer.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOwnerPhoneNumer.Location = new System.Drawing.Point(852, 499);
            this.tbOwnerPhoneNumer.Name = "tbOwnerPhoneNumer";
            this.tbOwnerPhoneNumer.Size = new System.Drawing.Size(318, 35);
            this.tbOwnerPhoneNumer.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(847, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số điện thoại";
            // 
            // tbOwnerAddress
            // 
            this.tbOwnerAddress.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOwnerAddress.Location = new System.Drawing.Point(852, 401);
            this.tbOwnerAddress.Name = "tbOwnerAddress";
            this.tbOwnerAddress.Size = new System.Drawing.Size(318, 35);
            this.tbOwnerAddress.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(847, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Địa chỉ";
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOwner.Appearance.Options.UseFont = true;
            this.btnDeleteOwner.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeleteOwner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteOwner.ImageOptions.SvgImage")));
            this.btnDeleteOwner.Location = new System.Drawing.Point(833, 31);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(150, 71);
            this.btnDeleteOwner.TabIndex = 12;
            this.btnDeleteOwner.Text = "Xóa";
            this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_Click);
            // 
            // btnReadOwner
            // 
            this.btnReadOwner.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadOwner.Appearance.Options.UseFont = true;
            this.btnReadOwner.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReadOwner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReadOwner.ImageOptions.SvgImage")));
            this.btnReadOwner.Location = new System.Drawing.Point(665, 31);
            this.btnReadOwner.Name = "btnReadOwner";
            this.btnReadOwner.Size = new System.Drawing.Size(150, 71);
            this.btnReadOwner.TabIndex = 11;
            this.btnReadOwner.Text = "Xem";
            this.btnReadOwner.Click += new System.EventHandler(this.btnReadOwner_Click);
            // 
            // btnSearchOwner
            // 
            this.btnSearchOwner.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOwner.Appearance.Options.UseFont = true;
            this.btnSearchOwner.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearchOwner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearchOwner.ImageOptions.SvgImage")));
            this.btnSearchOwner.Location = new System.Drawing.Point(494, 31);
            this.btnSearchOwner.Name = "btnSearchOwner";
            this.btnSearchOwner.Size = new System.Drawing.Size(150, 71);
            this.btnSearchOwner.TabIndex = 10;
            this.btnSearchOwner.Text = "Tìm kiếm";
            this.btnSearchOwner.Click += new System.EventHandler(this.btnSearchOwner_Click);
            // 
            // tbSearchOwner
            // 
            this.tbSearchOwner.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchOwner.Location = new System.Drawing.Point(21, 51);
            this.tbSearchOwner.Name = "tbSearchOwner";
            this.tbSearchOwner.Size = new System.Drawing.Size(431, 35);
            this.tbSearchOwner.TabIndex = 9;
            // 
            // btnUpdateOwner
            // 
            this.btnUpdateOwner.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOwner.Appearance.Options.UseFont = true;
            this.btnUpdateOwner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateOwner.ImageOptions.SvgImage")));
            this.btnUpdateOwner.Location = new System.Drawing.Point(1020, 569);
            this.btnUpdateOwner.Name = "btnUpdateOwner";
            this.btnUpdateOwner.Size = new System.Drawing.Size(150, 71);
            this.btnUpdateOwner.TabIndex = 8;
            this.btnUpdateOwner.Text = "Cập nhật";
            this.btnUpdateOwner.Click += new System.EventHandler(this.btnUpdateOwner_Click);
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOwner.Appearance.Options.UseFont = true;
            this.btnAddOwner.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddOwner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddOwner.ImageOptions.SvgImage")));
            this.btnAddOwner.Location = new System.Drawing.Point(852, 569);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(150, 71);
            this.btnAddOwner.TabIndex = 7;
            this.btnAddOwner.Text = "Thêm";
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click_1);
            // 
            // tbOwnerEmail
            // 
            this.tbOwnerEmail.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOwnerEmail.Location = new System.Drawing.Point(852, 311);
            this.tbOwnerEmail.Name = "tbOwnerEmail";
            this.tbOwnerEmail.Size = new System.Drawing.Size(318, 35);
            this.tbOwnerEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(847, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // tbOwnerFullName
            // 
            this.tbOwnerFullName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOwnerFullName.Location = new System.Drawing.Point(852, 224);
            this.tbOwnerFullName.Name = "tbOwnerFullName";
            this.tbOwnerFullName.Size = new System.Drawing.Size(318, 35);
            this.tbOwnerFullName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(847, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đầy đủ";
            // 
            // tbOwnerId
            // 
            this.tbOwnerId.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOwnerId.Location = new System.Drawing.Point(852, 140);
            this.tbOwnerId.Name = "tbOwnerId";
            this.tbOwnerId.Size = new System.Drawing.Size(318, 35);
            this.tbOwnerId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(847, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 709);
            this.Controls.Add(this.panelControl1);
            this.Name = "OwnerForm";
            this.Text = "Chủ xe";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOwner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteOwner;
        private DevExpress.XtraEditors.SimpleButton btnReadOwner;
        private DevExpress.XtraEditors.SimpleButton btnSearchOwner;
        private System.Windows.Forms.TextBox tbSearchOwner;
        private DevExpress.XtraEditors.SimpleButton btnUpdateOwner;
        private DevExpress.XtraEditors.SimpleButton btnAddOwner;
        private System.Windows.Forms.TextBox tbOwnerEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOwnerFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOwnerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOwnerPhoneNumer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOwnerAddress;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl dataGridViewOwner;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOwner;
        private DevExpress.XtraEditors.SimpleButton btnExportExcelOwner;
    }
}