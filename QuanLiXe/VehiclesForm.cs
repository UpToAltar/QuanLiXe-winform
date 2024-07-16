using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.Design;
using QuanLiXe.DTO;
using QuanLiXe.Helper;
using QuanLiXe.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe
{
    public partial class frmVehicles : DevExpress.XtraEditors.XtraForm
    {
        public frmVehicles()
        {
            InitializeComponent();
            LoadData(0, DateTime.Now, DateTime.Now);
        }
        public void LoadData(int containDate, DateTime from, DateTime to)
        {
            
            var gridId = new GridColumn() { Caption = "Mã số", Visible = true, FieldName = "ID" };
            var gridName = new GridColumn() { Caption = "Tên xe", Visible = true, FieldName = "Name" };
            var gridPlate = new GridColumn() { Caption = "Biển số", Visible = true, FieldName = "LiscensePlate" };
            var gridColor = new GridColumn() { Caption = "Màu sắc", Visible = true, FieldName = "Color" };
            var gridManufactureName = new GridColumn() { Caption = "Hãng sản xuất", Visible = true, FieldName = "Manufacture" };
            var gridOwnerName = new GridColumn() { Caption = "Tên chủ xe", Visible = true, FieldName = "OwnerName" };
            var gridEngineType = new GridColumn() { Caption = "Loại động cơ", Visible = true, FieldName = "EngineType" };
            var gridFuelType = new GridColumn() { Caption = "Loại nhiên liệu", Visible = true, FieldName = "FuelType" };
            var gridWeigth = new GridColumn() { Caption = "Trọng lượng", Visible = true, FieldName = "Weigth" };
            var gridTopSpeed = new GridColumn() { Caption = "Tốc độ tối đa", Visible = true, FieldName = "TopSpeed" };
            var gridAcceleration = new GridColumn() { Caption = "Tăng tốc", Visible = true, FieldName = "Acceleration" };
            var gridEngineDisplacement = new GridColumn() { Caption = "Dung tích động cơ", Visible = true, FieldName = "EngineDisplacement" };
            var gridCreatedAt = new GridColumn() { Caption = "Ngày tạo", Visible = true, FieldName = "CreatedAt" };
            gridCreatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridCreatedAt.DisplayFormat.FormatString = "dd/MM/yyyy";
            var gridUpdatedAt = new GridColumn() { Caption = "Ngày cập nhật", Visible = true, FieldName = "UpdatedAt" };
            gridUpdatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridUpdatedAt.DisplayFormat.FormatString = "dd/MM/yyyy";

            gridViewVehicles.Columns.Clear();
            gridViewVehicles.Columns.AddRange(new GridColumn[] { gridId, gridName, gridPlate, gridColor, gridManufactureName, gridOwnerName, gridEngineType, gridFuelType, gridWeigth, gridTopSpeed, gridAcceleration, gridEngineDisplacement,gridCreatedAt, gridUpdatedAt });

            string msgError = "";
            if(containDate == 0) dataGridViewVehicles.DataSource = VehiclesServices.Instance.Load(out msgError);
            else dataGridViewVehicles.DataSource = VehiclesServices.Instance.LoadByDate(out msgError, from, to);

            if (msgError != "")
            {
                MessageBox.Show(msgError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnReadVehicles_Click(object sender, EventArgs e)
        {
            if (dtVehicleFrom.EditValue == null && dtVehicleTo.EditValue == null)
            {
                LoadData(0, DateTime.Now, DateTime.Now);
                return;
            }
            else if (dtVehicleFrom.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dtVehicleTo.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtVehicleFrom.DateTimeOffset.DateTime > dtVehicleTo.DateTimeOffset.DateTime)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            

            DateTime from = dtVehicleFrom.DateTimeOffset.DateTime;
            DateTime to = dtVehicleTo.DateTimeOffset.DateTime;
            LoadData(1, from, to);
            dtVehicleFrom.Clear();
            dtVehicleTo.Clear();
        }

        private void btnDeleteVehicles_Click(object sender, EventArgs e)
        {
            var deleteForm = new frmDeleteVehicles(this , gridViewVehicles);
            deleteForm.ShowDialog();
        }

        private void btnAddVehicles_Click(object sender, EventArgs e)
        {
            var addForm = new frmAddVehicles(this);
            addForm.ShowDialog();
            
        }

        private void btnUpdateVehicles_Click(object sender, EventArgs e)
        {
            var updateForm = new frmUpdateVehicles(this, gridViewVehicles);
            updateForm.ShowDialog();
            
        }

        private void btnExportExcelVehicles_Click(object sender, EventArgs e)
        {
            if(ExportExcelFile.Instance.ExportExcel("Danh sách xe", gridViewVehicles))
            {
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Create History
                ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Export, "Xuất file danh sách xe");
            }
            else
            {
                MessageBox.Show("Xuất file thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var reportForm = new FrmReport();
            reportForm.ShowDialog();
        }
    }
}