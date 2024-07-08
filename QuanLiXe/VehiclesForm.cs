using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.Design;
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
    public partial class VehiclesForm : DevExpress.XtraEditors.XtraForm
    {
        public VehiclesForm()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            
            var gridId = new GridColumn() { Caption = "ID", Visible = true, FieldName = "ID" };
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

            gridViewVehicles.Columns.Clear();
            gridViewVehicles.Columns.AddRange(new GridColumn[] { gridId, gridName, gridPlate, gridColor, gridManufactureName, gridOwnerName, gridEngineType, gridFuelType, gridWeigth, gridTopSpeed, gridAcceleration, gridEngineDisplacement });


            dataGridViewVehicles.DataSource = VehiclesServices.Instance.Load();
            
        }

        private void btnReadVehicles_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearchVehicles_Click(object sender, EventArgs e)
        {
            if (tbSearchVehicles.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var data = VehiclesServices.Instance.Search(tbSearchVehicles.Text);
                if (data != null && data.Count > 0)
                {
                    dataGridViewVehicles.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteVehicles_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteVehiclesForm(this);
            deleteForm.ShowDialog();
        }

        private void btnAddVehicles_Click(object sender, EventArgs e)
        {
            var addForm = new AddVehiclesForm(this);
            addForm.ShowDialog();
            
        }

        private void btnUpdateVehicles_Click(object sender, EventArgs e)
        {
            var updateForm = new UpdateVehiclesForm(this);
            updateForm.ShowDialog();
            
        }

        private void btnExportExcelVehicles_Click(object sender, EventArgs e)
        {
            if(ExportExcelFile.Instance.ExportExcel("Danh sách xe", gridViewVehicles))
            {
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xuất file thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}