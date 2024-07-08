namespace QuanLiXe
{
    partial class AutomakerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomakerForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExportExcelAutomaker = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewAutomaker = new DevExpress.XtraGrid.GridControl();
            this.gridViewAutomaker = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnViewVehiclesOfAutoMaker = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteAutomaker = new DevExpress.XtraEditors.SimpleButton();
            this.btnReadAutomaker = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchAutomaker = new DevExpress.XtraEditors.SimpleButton();
            this.tbSearchAutomaker = new System.Windows.Forms.TextBox();
            this.btnUpdateAutomaker = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddAutomaker = new DevExpress.XtraEditors.SimpleButton();
            this.tbAutomakerIcon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAutomakerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAutomakerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutomaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAutomaker)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExportExcelAutomaker);
            this.panelControl1.Controls.Add(this.dataGridViewAutomaker);
            this.panelControl1.Controls.Add(this.btnViewVehiclesOfAutoMaker);
            this.panelControl1.Controls.Add(this.btnDeleteAutomaker);
            this.panelControl1.Controls.Add(this.btnReadAutomaker);
            this.panelControl1.Controls.Add(this.btnSearchAutomaker);
            this.panelControl1.Controls.Add(this.tbSearchAutomaker);
            this.panelControl1.Controls.Add(this.btnUpdateAutomaker);
            this.panelControl1.Controls.Add(this.btnAddAutomaker);
            this.panelControl1.Controls.Add(this.tbAutomakerIcon);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.tbAutomakerName);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.tbAutomakerId);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(16, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1174, 649);
            this.panelControl1.TabIndex = 0;
            // 
            // btnExportExcelAutomaker
            // 
            this.btnExportExcelAutomaker.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcelAutomaker.Appearance.Options.UseFont = true;
            this.btnExportExcelAutomaker.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportExcelAutomaker.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportExcelAutomaker.ImageOptions.SvgImage")));
            this.btnExportExcelAutomaker.Location = new System.Drawing.Point(981, 36);
            this.btnExportExcelAutomaker.Name = "btnExportExcelAutomaker";
            this.btnExportExcelAutomaker.Size = new System.Drawing.Size(169, 71);
            this.btnExportExcelAutomaker.TabIndex = 19;
            this.btnExportExcelAutomaker.Text = "Xuất file";
            this.btnExportExcelAutomaker.Click += new System.EventHandler(this.btnExportExcelAutomaker_Click);
            // 
            // dataGridViewAutomaker
            // 
            this.dataGridViewAutomaker.Location = new System.Drawing.Point(18, 114);
            this.dataGridViewAutomaker.MainView = this.gridViewAutomaker;
            this.dataGridViewAutomaker.Name = "dataGridViewAutomaker";
            this.dataGridViewAutomaker.Size = new System.Drawing.Size(769, 530);
            this.dataGridViewAutomaker.TabIndex = 14;
            this.dataGridViewAutomaker.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAutomaker});
            // 
            // gridViewAutomaker
            // 
            this.gridViewAutomaker.GridControl = this.dataGridViewAutomaker;
            this.gridViewAutomaker.GroupPanelText = "Danh sách hãng xe";
            this.gridViewAutomaker.Name = "gridViewAutomaker";
            // 
            // btnViewVehiclesOfAutoMaker
            // 
            this.btnViewVehiclesOfAutoMaker.AllowDrop = true;
            this.btnViewVehiclesOfAutoMaker.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewVehiclesOfAutoMaker.Appearance.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnViewVehiclesOfAutoMaker.Appearance.Options.UseFont = true;
            this.btnViewVehiclesOfAutoMaker.Appearance.Options.UseForeColor = true;
            this.btnViewVehiclesOfAutoMaker.AutoWidthInLayoutControl = true;
            this.btnViewVehiclesOfAutoMaker.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnViewVehiclesOfAutoMaker.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnViewVehiclesOfAutoMaker.ImageOptions.SvgImage")));
            this.btnViewVehiclesOfAutoMaker.Location = new System.Drawing.Point(832, 573);
            this.btnViewVehiclesOfAutoMaker.Name = "btnViewVehiclesOfAutoMaker";
            this.btnViewVehiclesOfAutoMaker.Padding = new System.Windows.Forms.Padding(10);
            this.btnViewVehiclesOfAutoMaker.ShowToolTips = false;
            this.btnViewVehiclesOfAutoMaker.Size = new System.Drawing.Size(318, 71);
            this.btnViewVehiclesOfAutoMaker.TabIndex = 13;
            this.btnViewVehiclesOfAutoMaker.Text = "Xe thuộc hãng xe ";
            this.btnViewVehiclesOfAutoMaker.Click += new System.EventHandler(this.btnViewVehiclesOfAutoMaker_Click);
            // 
            // btnDeleteAutomaker
            // 
            this.btnDeleteAutomaker.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAutomaker.Appearance.Options.UseFont = true;
            this.btnDeleteAutomaker.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeleteAutomaker.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteAutomaker.ImageOptions.SvgImage")));
            this.btnDeleteAutomaker.Location = new System.Drawing.Point(810, 36);
            this.btnDeleteAutomaker.Name = "btnDeleteAutomaker";
            this.btnDeleteAutomaker.Size = new System.Drawing.Size(150, 71);
            this.btnDeleteAutomaker.TabIndex = 12;
            this.btnDeleteAutomaker.Text = "Xóa";
            this.btnDeleteAutomaker.Click += new System.EventHandler(this.btnDeleteAutomaker_Click);
            // 
            // btnReadAutomaker
            // 
            this.btnReadAutomaker.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadAutomaker.Appearance.Options.UseFont = true;
            this.btnReadAutomaker.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReadAutomaker.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReadAutomaker.ImageOptions.SvgImage")));
            this.btnReadAutomaker.Location = new System.Drawing.Point(637, 36);
            this.btnReadAutomaker.Name = "btnReadAutomaker";
            this.btnReadAutomaker.Size = new System.Drawing.Size(150, 71);
            this.btnReadAutomaker.TabIndex = 11;
            this.btnReadAutomaker.Text = "Xem";
            this.btnReadAutomaker.Click += new System.EventHandler(this.btnReadAutomaker_Click);
            // 
            // btnSearchAutomaker
            // 
            this.btnSearchAutomaker.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAutomaker.Appearance.Options.UseFont = true;
            this.btnSearchAutomaker.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearchAutomaker.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearchAutomaker.ImageOptions.SvgImage")));
            this.btnSearchAutomaker.Location = new System.Drawing.Point(463, 36);
            this.btnSearchAutomaker.Name = "btnSearchAutomaker";
            this.btnSearchAutomaker.Size = new System.Drawing.Size(150, 71);
            this.btnSearchAutomaker.TabIndex = 10;
            this.btnSearchAutomaker.Text = "Tìm kiếm";
            this.btnSearchAutomaker.Click += new System.EventHandler(this.btnSearchAutomaker_Click);
            // 
            // tbSearchAutomaker
            // 
            this.tbSearchAutomaker.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchAutomaker.Location = new System.Drawing.Point(18, 56);
            this.tbSearchAutomaker.Name = "tbSearchAutomaker";
            this.tbSearchAutomaker.Size = new System.Drawing.Size(420, 35);
            this.tbSearchAutomaker.TabIndex = 9;
            // 
            // btnUpdateAutomaker
            // 
            this.btnUpdateAutomaker.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAutomaker.Appearance.Options.UseFont = true;
            this.btnUpdateAutomaker.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateAutomaker.ImageOptions.SvgImage")));
            this.btnUpdateAutomaker.Location = new System.Drawing.Point(1000, 481);
            this.btnUpdateAutomaker.Name = "btnUpdateAutomaker";
            this.btnUpdateAutomaker.Size = new System.Drawing.Size(150, 71);
            this.btnUpdateAutomaker.TabIndex = 8;
            this.btnUpdateAutomaker.Text = "Cập nhật";
            this.btnUpdateAutomaker.Click += new System.EventHandler(this.btnUpdateAutomaker_Click);
            // 
            // btnAddAutomaker
            // 
            this.btnAddAutomaker.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAutomaker.Appearance.Options.UseFont = true;
            this.btnAddAutomaker.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddAutomaker.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddAutomaker.ImageOptions.SvgImage")));
            this.btnAddAutomaker.Location = new System.Drawing.Point(832, 481);
            this.btnAddAutomaker.Name = "btnAddAutomaker";
            this.btnAddAutomaker.Size = new System.Drawing.Size(150, 71);
            this.btnAddAutomaker.TabIndex = 7;
            this.btnAddAutomaker.Text = "Thêm";
            this.btnAddAutomaker.Click += new System.EventHandler(this.btnAddAutomaker_Click);
            // 
            // tbAutomakerIcon
            // 
            this.tbAutomakerIcon.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAutomakerIcon.Location = new System.Drawing.Point(832, 416);
            this.tbAutomakerIcon.Name = "tbAutomakerIcon";
            this.tbAutomakerIcon.Size = new System.Drawing.Size(318, 35);
            this.tbAutomakerIcon.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(827, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đường dẫn ảnh biểu tượng";
            // 
            // tbAutomakerName
            // 
            this.tbAutomakerName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAutomakerName.Location = new System.Drawing.Point(832, 293);
            this.tbAutomakerName.Name = "tbAutomakerName";
            this.tbAutomakerName.Size = new System.Drawing.Size(318, 35);
            this.tbAutomakerName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(827, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên hãng xe";
            // 
            // tbAutomakerId
            // 
            this.tbAutomakerId.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAutomakerId.Location = new System.Drawing.Point(832, 179);
            this.tbAutomakerId.Name = "tbAutomakerId";
            this.tbAutomakerId.Size = new System.Drawing.Size(318, 35);
            this.tbAutomakerId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(827, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // AutomakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 673);
            this.Controls.Add(this.panelControl1);
            this.Name = "AutomakerForm";
            this.Text = "Hãng xe";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutomaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAutomaker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox tbAutomakerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAutomakerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAutomakerIcon;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnAddAutomaker;
        private DevExpress.XtraEditors.SimpleButton btnUpdateAutomaker;
        private DevExpress.XtraEditors.SimpleButton btnSearchAutomaker;
        private System.Windows.Forms.TextBox tbSearchAutomaker;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAutomaker;
        private DevExpress.XtraEditors.SimpleButton btnReadAutomaker;
        private DevExpress.XtraEditors.SimpleButton btnViewVehiclesOfAutoMaker;
        private DevExpress.XtraGrid.GridControl dataGridViewAutomaker;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAutomaker;
        private DevExpress.XtraEditors.SimpleButton btnExportExcelAutomaker;
    }
}