namespace QuanLiXe
{
    partial class VehiclesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiclesForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridViewVehicles = new DevExpress.XtraGrid.GridControl();
            this.gridViewVehicles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDeleteVehicles = new DevExpress.XtraEditors.SimpleButton();
            this.btnReadVehicles = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchVehicles = new DevExpress.XtraEditors.SimpleButton();
            this.tbSearchVehicles = new System.Windows.Forms.TextBox();
            this.btnUpdateVehicles = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddVehicles = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportExcelVehicles = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExportExcelVehicles);
            this.panelControl1.Controls.Add(this.dataGridViewVehicles);
            this.panelControl1.Controls.Add(this.btnDeleteVehicles);
            this.panelControl1.Controls.Add(this.btnReadVehicles);
            this.panelControl1.Controls.Add(this.btnSearchVehicles);
            this.panelControl1.Controls.Add(this.tbSearchVehicles);
            this.panelControl1.Controls.Add(this.btnUpdateVehicles);
            this.panelControl1.Controls.Add(this.btnAddVehicles);
            this.panelControl1.Location = new System.Drawing.Point(22, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1151, 669);
            this.panelControl1.TabIndex = 2;
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(2, 185);
            this.dataGridViewVehicles.MainView = this.gridViewVehicles;
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.Size = new System.Drawing.Size(1147, 482);
            this.dataGridViewVehicles.TabIndex = 13;
            this.dataGridViewVehicles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVehicles});
            // 
            // gridViewVehicles
            // 
            this.gridViewVehicles.GridControl = this.dataGridViewVehicles;
            this.gridViewVehicles.GroupPanelText = "Danh sách xe";
            this.gridViewVehicles.Name = "gridViewVehicles";
            // 
            // btnDeleteVehicles
            // 
            this.btnDeleteVehicles.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVehicles.Appearance.Options.UseFont = true;
            this.btnDeleteVehicles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeleteVehicles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteVehicles.ImageOptions.SvgImage")));
            this.btnDeleteVehicles.Location = new System.Drawing.Point(736, 108);
            this.btnDeleteVehicles.Name = "btnDeleteVehicles";
            this.btnDeleteVehicles.Size = new System.Drawing.Size(169, 71);
            this.btnDeleteVehicles.TabIndex = 12;
            this.btnDeleteVehicles.Text = "Xóa";
            this.btnDeleteVehicles.Click += new System.EventHandler(this.btnDeleteVehicles_Click);
            // 
            // btnReadVehicles
            // 
            this.btnReadVehicles.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadVehicles.Appearance.Options.UseFont = true;
            this.btnReadVehicles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReadVehicles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReadVehicles.ImageOptions.SvgImage")));
            this.btnReadVehicles.Location = new System.Drawing.Point(500, 108);
            this.btnReadVehicles.Name = "btnReadVehicles";
            this.btnReadVehicles.Size = new System.Drawing.Size(164, 71);
            this.btnReadVehicles.TabIndex = 11;
            this.btnReadVehicles.Text = "Xem";
            this.btnReadVehicles.Click += new System.EventHandler(this.btnReadVehicles_Click);
            // 
            // btnSearchVehicles
            // 
            this.btnSearchVehicles.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchVehicles.Appearance.Options.UseFont = true;
            this.btnSearchVehicles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearchVehicles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearchVehicles.ImageOptions.SvgImage")));
            this.btnSearchVehicles.Location = new System.Drawing.Point(651, 13);
            this.btnSearchVehicles.Name = "btnSearchVehicles";
            this.btnSearchVehicles.Size = new System.Drawing.Size(150, 71);
            this.btnSearchVehicles.TabIndex = 10;
            this.btnSearchVehicles.Text = "Tìm kiếm";
            this.btnSearchVehicles.Click += new System.EventHandler(this.btnSearchVehicles_Click);
            // 
            // tbSearchVehicles
            // 
            this.tbSearchVehicles.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchVehicles.Location = new System.Drawing.Point(186, 33);
            this.tbSearchVehicles.Name = "tbSearchVehicles";
            this.tbSearchVehicles.Size = new System.Drawing.Size(420, 35);
            this.tbSearchVehicles.TabIndex = 9;
            // 
            // btnUpdateVehicles
            // 
            this.btnUpdateVehicles.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVehicles.Appearance.Options.UseFont = true;
            this.btnUpdateVehicles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateVehicles.ImageOptions.SvgImage")));
            this.btnUpdateVehicles.Location = new System.Drawing.Point(255, 108);
            this.btnUpdateVehicles.Name = "btnUpdateVehicles";
            this.btnUpdateVehicles.Size = new System.Drawing.Size(174, 71);
            this.btnUpdateVehicles.TabIndex = 8;
            this.btnUpdateVehicles.Text = "Cập nhật";
            this.btnUpdateVehicles.Click += new System.EventHandler(this.btnUpdateVehicles_Click);
            // 
            // btnAddVehicles
            // 
            this.btnAddVehicles.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicles.Appearance.Options.UseFont = true;
            this.btnAddVehicles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddVehicles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddVehicles.ImageOptions.SvgImage")));
            this.btnAddVehicles.Location = new System.Drawing.Point(5, 108);
            this.btnAddVehicles.Name = "btnAddVehicles";
            this.btnAddVehicles.Size = new System.Drawing.Size(177, 71);
            this.btnAddVehicles.TabIndex = 7;
            this.btnAddVehicles.Text = "Thêm";
            this.btnAddVehicles.Click += new System.EventHandler(this.btnAddVehicles_Click);
            // 
            // btnExportExcelVehicles
            // 
            this.btnExportExcelVehicles.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcelVehicles.Appearance.Options.UseFont = true;
            this.btnExportExcelVehicles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExportExcelVehicles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnExportExcelVehicles.Location = new System.Drawing.Point(977, 108);
            this.btnExportExcelVehicles.Name = "btnExportExcelVehicles";
            this.btnExportExcelVehicles.Size = new System.Drawing.Size(169, 71);
            this.btnExportExcelVehicles.TabIndex = 14;
            this.btnExportExcelVehicles.Text = "Xuất file";
            this.btnExportExcelVehicles.Click += new System.EventHandler(this.btnExportExcelVehicles_Click);
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 683);
            this.Controls.Add(this.panelControl1);
            this.Name = "VehiclesForm";
            this.Text = "Quản lí xe";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteVehicles;
        private DevExpress.XtraEditors.SimpleButton btnReadVehicles;
        private DevExpress.XtraEditors.SimpleButton btnSearchVehicles;
        private System.Windows.Forms.TextBox tbSearchVehicles;
        private DevExpress.XtraEditors.SimpleButton btnUpdateVehicles;
        private DevExpress.XtraEditors.SimpleButton btnAddVehicles;
        private DevExpress.XtraGrid.GridControl dataGridViewVehicles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVehicles;
        private DevExpress.XtraEditors.SimpleButton btnExportExcelVehicles;
    }
}