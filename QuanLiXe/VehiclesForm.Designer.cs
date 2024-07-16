namespace QuanLiXe
{
    partial class frmVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicles));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportExcelVehicles = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewVehicles = new DevExpress.XtraGrid.GridControl();
            this.gridViewVehicles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDeleteVehicles = new DevExpress.XtraEditors.SimpleButton();
            this.btnReadVehicles = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateVehicles = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddVehicles = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtVehicleFrom = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtVehicleTo = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVehicleFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVehicleTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dtVehicleTo);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.dtVehicleFrom);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnExportExcelVehicles);
            this.panelControl1.Controls.Add(this.dataGridViewVehicles);
            this.panelControl1.Controls.Add(this.btnDeleteVehicles);
            this.panelControl1.Controls.Add(this.btnReadVehicles);
            this.panelControl1.Controls.Add(this.btnUpdateVehicles);
            this.panelControl1.Controls.Add(this.btnAddVehicles);
            this.panelControl1.Location = new System.Drawing.Point(22, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1359, 669);
            this.panelControl1.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(701, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(186, 71);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "Tạo báo cáo";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnExportExcelVehicles
            // 
            this.btnExportExcelVehicles.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcelVehicles.Appearance.Options.UseFont = true;
            this.btnExportExcelVehicles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportExcelVehicles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportExcelVehicles.ImageOptions.SvgImage")));
            this.btnExportExcelVehicles.Location = new System.Drawing.Point(529, 26);
            this.btnExportExcelVehicles.Name = "btnExportExcelVehicles";
            this.btnExportExcelVehicles.Size = new System.Drawing.Size(166, 71);
            this.btnExportExcelVehicles.TabIndex = 5;
            this.btnExportExcelVehicles.Text = "Xuất file";
            this.btnExportExcelVehicles.Click += new System.EventHandler(this.btnExportExcelVehicles_Click);
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(2, 103);
            this.dataGridViewVehicles.MainView = this.gridViewVehicles;
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.Size = new System.Drawing.Size(1355, 564);
            this.dataGridViewVehicles.TabIndex = 13;
            this.dataGridViewVehicles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVehicles});
            // 
            // gridViewVehicles
            // 
            this.gridViewVehicles.GridControl = this.dataGridViewVehicles;
            this.gridViewVehicles.GroupPanelText = "Danh sách xe";
            this.gridViewVehicles.Name = "gridViewVehicles";
            this.gridViewVehicles.OptionsBehavior.Editable = false;
            // 
            // btnDeleteVehicles
            // 
            this.btnDeleteVehicles.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVehicles.Appearance.Options.UseFont = true;
            this.btnDeleteVehicles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeleteVehicles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteVehicles.ImageOptions.SvgImage")));
            this.btnDeleteVehicles.Location = new System.Drawing.Point(354, 26);
            this.btnDeleteVehicles.Name = "btnDeleteVehicles";
            this.btnDeleteVehicles.Size = new System.Drawing.Size(169, 71);
            this.btnDeleteVehicles.TabIndex = 4;
            this.btnDeleteVehicles.Text = "Xóa";
            this.btnDeleteVehicles.Click += new System.EventHandler(this.btnDeleteVehicles_Click);
            // 
            // btnReadVehicles
            // 
            this.btnReadVehicles.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadVehicles.Appearance.Options.UseFont = true;
            this.btnReadVehicles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReadVehicles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReadVehicles.ImageOptions.SvgImage")));
            this.btnReadVehicles.Location = new System.Drawing.Point(893, 26);
            this.btnReadVehicles.Name = "btnReadVehicles";
            this.btnReadVehicles.Size = new System.Drawing.Size(153, 71);
            this.btnReadVehicles.TabIndex = 3;
            this.btnReadVehicles.Text = "Xem";
            this.btnReadVehicles.Click += new System.EventHandler(this.btnReadVehicles_Click);
            // 
            // btnUpdateVehicles
            // 
            this.btnUpdateVehicles.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVehicles.Appearance.Options.UseFont = true;
            this.btnUpdateVehicles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateVehicles.ImageOptions.SvgImage")));
            this.btnUpdateVehicles.Location = new System.Drawing.Point(174, 26);
            this.btnUpdateVehicles.Name = "btnUpdateVehicles";
            this.btnUpdateVehicles.Size = new System.Drawing.Size(174, 71);
            this.btnUpdateVehicles.TabIndex = 2;
            this.btnUpdateVehicles.Text = "Cập nhật";
            this.btnUpdateVehicles.Click += new System.EventHandler(this.btnUpdateVehicles_Click);
            // 
            // btnAddVehicles
            // 
            this.btnAddVehicles.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicles.Appearance.Options.UseFont = true;
            this.btnAddVehicles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddVehicles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddVehicles.ImageOptions.SvgImage")));
            this.btnAddVehicles.Location = new System.Drawing.Point(5, 26);
            this.btnAddVehicles.Name = "btnAddVehicles";
            this.btnAddVehicles.Size = new System.Drawing.Size(163, 71);
            this.btnAddVehicles.TabIndex = 1;
            this.btnAddVehicles.Text = "Thêm";
            this.btnAddVehicles.Click += new System.EventHandler(this.btnAddVehicles_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1064, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 28);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Từ";
            // 
            // dtVehicleFrom
            // 
            this.dtVehicleFrom.EditValue = null;
            this.dtVehicleFrom.Location = new System.Drawing.Point(1129, 27);
            this.dtVehicleFrom.Name = "dtVehicleFrom";
            this.dtVehicleFrom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVehicleFrom.Properties.Appearance.Options.UseFont = true;
            this.dtVehicleFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtVehicleFrom.Size = new System.Drawing.Size(225, 34);
            this.dtVehicleFrom.TabIndex = 16;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1064, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 28);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Đến";
            // 
            // dtVehicleTo
            // 
            this.dtVehicleTo.EditValue = null;
            this.dtVehicleTo.Location = new System.Drawing.Point(1129, 64);
            this.dtVehicleTo.Name = "dtVehicleTo";
            this.dtVehicleTo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVehicleTo.Properties.Appearance.Options.UseFont = true;
            this.dtVehicleTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtVehicleTo.Size = new System.Drawing.Size(225, 34);
            this.dtVehicleTo.TabIndex = 18;
            // 
            // frmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 683);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmVehicles";
            this.Text = "Quản lí xe";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVehicleFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVehicleTo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteVehicles;
        private DevExpress.XtraEditors.SimpleButton btnReadVehicles;
        private DevExpress.XtraEditors.SimpleButton btnUpdateVehicles;
        private DevExpress.XtraEditors.SimpleButton btnAddVehicles;
        private DevExpress.XtraGrid.GridControl dataGridViewVehicles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVehicles;
        private DevExpress.XtraEditors.SimpleButton btnExportExcelVehicles;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtVehicleTo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtVehicleFrom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}