namespace QuanLiXe
{
    partial class frmActivityHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivityHistory));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterActivityHistory = new DevExpress.XtraEditors.SimpleButton();
            this.tbActivityHistoryUserName = new System.Windows.Forms.TextBox();
            this.cboActitityHistoryActionType = new System.Windows.Forms.ComboBox();
            this.btnReadActivityHistory = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportExcelVehicles = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewActivityHistory = new DevExpress.XtraGrid.GridControl();
            this.gridViewActivityHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivityHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivityHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnFilterActivityHistory);
            this.panelControl1.Controls.Add(this.tbActivityHistoryUserName);
            this.panelControl1.Controls.Add(this.cboActitityHistoryActionType);
            this.panelControl1.Controls.Add(this.btnReadActivityHistory);
            this.panelControl1.Controls.Add(this.btnExportExcelVehicles);
            this.panelControl1.Controls.Add(this.dataGridViewActivityHistory);
            this.panelControl1.Location = new System.Drawing.Point(23, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1359, 669);
            this.panelControl1.TabIndex = 3;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên người thực hiện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Loại hành động";
            // 
            // btnFilterActivityHistory
            // 
            this.btnFilterActivityHistory.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterActivityHistory.Appearance.Options.UseFont = true;
            this.btnFilterActivityHistory.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnFilterActivityHistory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFilterActivityHistory.ImageOptions.SvgImage")));
            this.btnFilterActivityHistory.Location = new System.Drawing.Point(812, 26);
            this.btnFilterActivityHistory.Name = "btnFilterActivityHistory";
            this.btnFilterActivityHistory.Size = new System.Drawing.Size(150, 71);
            this.btnFilterActivityHistory.TabIndex = 3;
            this.btnFilterActivityHistory.Text = "Lọc";
            this.btnFilterActivityHistory.Click += new System.EventHandler(this.btnFilterActivityHistory_Click);
            // 
            // tbActivityHistoryUserName
            // 
            this.tbActivityHistoryUserName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActivityHistoryUserName.Location = new System.Drawing.Point(399, 61);
            this.tbActivityHistoryUserName.Name = "tbActivityHistoryUserName";
            this.tbActivityHistoryUserName.Size = new System.Drawing.Size(387, 35);
            this.tbActivityHistoryUserName.TabIndex = 1;
            // 
            // cboActitityHistoryActionType
            // 
            this.cboActitityHistoryActionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboActitityHistoryActionType.DropDownHeight = 100;
            this.cboActitityHistoryActionType.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActitityHistoryActionType.FormattingEnabled = true;
            this.cboActitityHistoryActionType.IntegralHeight = false;
            this.cboActitityHistoryActionType.Location = new System.Drawing.Point(0, 61);
            this.cboActitityHistoryActionType.Name = "cboActitityHistoryActionType";
            this.cboActitityHistoryActionType.Size = new System.Drawing.Size(363, 36);
            this.cboActitityHistoryActionType.TabIndex = 2;
            // 
            // btnReadActivityHistory
            // 
            this.btnReadActivityHistory.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadActivityHistory.Appearance.Options.UseFont = true;
            this.btnReadActivityHistory.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReadActivityHistory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReadActivityHistory.ImageOptions.SvgImage")));
            this.btnReadActivityHistory.Location = new System.Drawing.Point(968, 26);
            this.btnReadActivityHistory.Name = "btnReadActivityHistory";
            this.btnReadActivityHistory.Size = new System.Drawing.Size(150, 71);
            this.btnReadActivityHistory.TabIndex = 14;
            this.btnReadActivityHistory.Text = "Xem";
            this.btnReadActivityHistory.Click += new System.EventHandler(this.btnReadActivityHistory_Click);
            // 
            // btnExportExcelVehicles
            // 
            this.btnExportExcelVehicles.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcelVehicles.Appearance.Options.UseFont = true;
            this.btnExportExcelVehicles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportExcelVehicles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportExcelVehicles.ImageOptions.SvgImage")));
            this.btnExportExcelVehicles.Location = new System.Drawing.Point(1124, 26);
            this.btnExportExcelVehicles.Name = "btnExportExcelVehicles";
            this.btnExportExcelVehicles.Size = new System.Drawing.Size(230, 71);
            this.btnExportExcelVehicles.TabIndex = 5;
            this.btnExportExcelVehicles.Text = "Xuất file excel";
            this.btnExportExcelVehicles.Click += new System.EventHandler(this.btnExportExcelVehicles_Click);
            // 
            // dataGridViewActivityHistory
            // 
            this.dataGridViewActivityHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewActivityHistory.Location = new System.Drawing.Point(2, 103);
            this.dataGridViewActivityHistory.MainView = this.gridViewActivityHistory;
            this.dataGridViewActivityHistory.Name = "dataGridViewActivityHistory";
            this.dataGridViewActivityHistory.Size = new System.Drawing.Size(1355, 564);
            this.dataGridViewActivityHistory.TabIndex = 13;
            this.dataGridViewActivityHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewActivityHistory});
            // 
            // gridViewActivityHistory
            // 
            this.gridViewActivityHistory.GridControl = this.dataGridViewActivityHistory;
            this.gridViewActivityHistory.GroupPanelText = "Danh sách lịch sử hoạt động";
            this.gridViewActivityHistory.Name = "gridViewActivityHistory";
            this.gridViewActivityHistory.OptionsBehavior.Editable = false;
            // 
            // frmActivityHistory
            // 
            this.AcceptButton = this.btnFilterActivityHistory;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 685);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmActivityHistory";
            this.Text = "ActivityHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivityHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivityHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExportExcelVehicles;
        private DevExpress.XtraGrid.GridControl dataGridViewActivityHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewActivityHistory;
        private DevExpress.XtraEditors.SimpleButton btnReadActivityHistory;
        private System.Windows.Forms.ComboBox cboActitityHistoryActionType;
        private DevExpress.XtraEditors.SimpleButton btnFilterActivityHistory;
        private System.Windows.Forms.TextBox tbActivityHistoryUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}