using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
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
    public partial class frmAutomaker : DevExpress.XtraEditors.XtraForm
    {
        public frmAutomaker()
        {
            InitializeComponent();
            LoadData(0 ,DateTime.Now, DateTime.Now);
        }

        void LoadData(int containDate, DateTime from, DateTime to)
        {
            var gridId = new GridColumn() { Caption = "Mã số", Visible = true, FieldName = "ManufacturesId" };
            var gridName = new GridColumn() { Caption = "Tên hãng xe", Visible = true, FieldName = "Name" };
            var gridIcon = new GridColumn() { Caption = "Đường dẫn ảnh biểu tượng", Visible = true, FieldName = "Icon" };
            var gridCreatedAt = new GridColumn() { Caption = "Ngày tạo", Visible = true, FieldName = "CreatedAt" };
            gridCreatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridCreatedAt.DisplayFormat.FormatString = "dd/MM/yyyy";
            var gridUpdatedAt = new GridColumn() { Caption = "Ngày cập nhật", Visible = true, FieldName = "UpdatedAt" };
            gridUpdatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridUpdatedAt.DisplayFormat.FormatString = "dd/MM/yyyy";

            gridViewAutomaker.Columns.Clear();
            gridViewAutomaker.GroupPanelText = "Danh sách hãng xe";
            gridViewAutomaker.OptionsView.ColumnAutoWidth = true;
            gridViewAutomaker.Columns.AddRange(new GridColumn[] { gridId, gridName, gridIcon,gridCreatedAt,gridUpdatedAt });

            string msgError = "";
            if(containDate == 0) dataGridViewAutomaker.DataSource = AutomakerServices.Instance.Load(out msgError);
            else dataGridViewAutomaker.DataSource = AutomakerServices.Instance.LoadByDate(out msgError, from, to);
            if(msgError != "")
            {
                MessageBox.Show(msgError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAutomaker_Click(object sender, EventArgs e)
        {
            string msgError = "";
            var list = new List<TextBox> { tbAutomakerName };
            if (ValidateHelper.Instance.IsEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidMaxLengthTextBox(list, 100))
            {
                //Check name exist
                MessageBox.Show("Các trường nhập tối đa 100 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbAutomakerIcon.Text != "" && !ChechImageUrl.Instance.IsImageUrlValid(tbAutomakerIcon.Text))
            {
                //Check name exist
                MessageBox.Show("Đường dẫn ảnh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AutomakerServices.Instance.IsAutomakerNameExisted(out msgError,tbAutomakerName.Text))
            {
                //Check name exist
                MessageBox.Show("Hãng xe đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Create
                
                if (AutomakerServices.Instance.CreateAutomaker(out msgError, tbAutomakerName.Text,tbAutomakerIcon.Text, RecentUser.ID))
                {
                    MessageBox.Show("Thêm hãng xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(0, DateTime.Now, DateTime.Now);
                }
                else
                {
                    MessageBox.Show("Thêm hãng xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

            
        }

        private void btnSearchAutomaker_Click(object sender, EventArgs e)
        {
            string msgError = "";
            if(tbSearchAutomaker.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var data = AutomakerServices.Instance.Search(out msgError, tbSearchAutomaker.Text);
                if (data != null && data.Rows.Count > 0) {
                    dataGridViewAutomaker.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hãng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void btnReadAutomaker_Click(object sender, EventArgs e)
        {
            if (dtAutomakerFrom.EditValue == null && dtAutomakerTo.EditValue == null)
            {
                LoadData(0, DateTime.Now, DateTime.Now);
                return;
            }
            else if (dtAutomakerFrom.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dtAutomakerTo.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtAutomakerFrom.DateTimeOffset.DateTime > dtAutomakerTo.DateTimeOffset.DateTime)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DateTime from = dtAutomakerFrom.DateTimeOffset.DateTime;
            DateTime to = dtAutomakerTo.DateTimeOffset.DateTime;
            LoadData(1, from, to);
            dtAutomakerFrom.Clear();
            dtAutomakerTo.Clear();
        }

        private void btnUpdateAutomaker_Click(object sender, EventArgs e)
        {
            string msgError = "";
            var list = new List<TextBox> { tbAutomakerName, tbAutomakerId };
            if (ValidateHelper.Instance.IsEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidMaxLengthTextBox(list, 100))
            {
                //Check max length
                MessageBox.Show("Các trường nhập tối đa 100 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbAutomakerIcon.Text != "" && !ChechImageUrl.Instance.IsImageUrlValid(tbAutomakerIcon.Text))
            {
                //Check name exist
                MessageBox.Show("Đường dẫn ảnh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!AutomakerServices.Instance.IsAutomakerExistedCheckById(out msgError, tbAutomakerId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại hãng xe có ID = {tbAutomakerId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AutomakerServices.Instance.IsOtherAutomakerExisted(out msgError, tbAutomakerName.Text,tbAutomakerId.Text))
            {
                //Check name exist
                MessageBox.Show("Hãng xe đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Update
                
                if (AutomakerServices.Instance.UpdateAutomaker(out msgError, tbAutomakerId.Text, tbAutomakerName.Text,tbAutomakerIcon.Text, RecentUser.ID))
                {
                    MessageBox.Show("Cập nhật hãng xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(0, DateTime.Now, DateTime.Now);
                }
                else
                {
                    MessageBox.Show("Cập nhật hãng xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteAutomaker_Click(object sender, EventArgs e)
        {
            string msgError = "";
            var list = new List<TextBox> { tbAutomakerId };
            if (ValidateHelper.Instance.IsEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập Id hãng xe cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!AutomakerServices.Instance.IsAutomakerExistedCheckById(out msgError, tbAutomakerId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại xe có ID = {tbAutomakerId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Show dialog confirm
                if(MessageBox.Show("Bạn có chắc chắn muốn xóa hãng xe này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Delete
                    if (AutomakerServices.Instance.DeleteAutomaker(out msgError, tbAutomakerId.Text, RecentUser.ID))
                    {
                        MessageBox.Show("Xóa hãng xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(0, DateTime.Now, DateTime.Now);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhật hãng xe thất bại, vui lòng kiểm tra kết nối hoặc bảo đảm đã xóa hết xe của hãng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                
            }
        }

        private void btnViewVehiclesOfAutoMaker_Click(object sender, EventArgs e)
        {
            string msgError = "";
            if(tbAutomakerName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hãng xe cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!AutomakerServices.Instance.IsAutomakerNameExisted(out msgError, tbAutomakerName.Text))
            {
                MessageBox.Show($"Không có hãng xe nào tên là : {tbAutomakerName.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var data = AutomakerServices.Instance.GetVehiclesByAutomakerName(out msgError,tbAutomakerName.Text);
                if(data!= null && data.Rows.Count > 0)
                {
                    var gridId = new GridColumn() { Caption = "Mã số", Visible = true, FieldName = "VehiclesId" };
                    var gridName = new GridColumn() { Caption = "Tên xe", Visible = true, FieldName = "VehicleName" };
                    var gridPlate = new GridColumn() { Caption = "Biển số", Visible = true, FieldName = "LiscensePlate" };
                    var gridColor = new GridColumn() { Caption = "Màu sắc", Visible = true, FieldName = "Color" };
                    var gridManufactureName = new GridColumn() { Caption = "Hãng sản xuất", Visible = true, FieldName = "ManufactureName" };
                    var gridOwnerName = new GridColumn() { Caption = "Tên chủ xe", Visible = true, FieldName = "OwnerName" };
                    var gridEngineType = new GridColumn() { Caption = "Loại động cơ", Visible = true, FieldName = "EngineType" };
                    var gridFuelType = new GridColumn() { Caption = "Loại nhiên liệu", Visible = true, FieldName = "FuelType" };
                    var gridWeigth = new GridColumn() { Caption = "Trọng lượng", Visible = true, FieldName = "Weigth" };
                    var gridTopSpeed = new GridColumn() { Caption = "Tốc độ tối đa", Visible = true, FieldName = "TopSpeed" };
                    var gridAcceleration = new GridColumn() { Caption = "Tăng tốc", Visible = true, FieldName = "Acceleration" };
                    var gridEngineDisplacement = new GridColumn() { Caption = "Dung tích động cơ", Visible = true, FieldName = "EngineDisplacement" };

                    gridViewAutomaker.Columns.Clear();
                    gridViewAutomaker.GroupPanelText = "Danh sách xe của hãng " + tbAutomakerName.Text;
                    gridViewAutomaker.OptionsView.ColumnAutoWidth = false;
                    gridViewAutomaker.Columns.AddRange(new GridColumn[] { gridId, gridName, gridPlate, gridColor, gridManufactureName, gridOwnerName, gridEngineType, gridFuelType, gridWeigth, gridTopSpeed, gridAcceleration, gridEngineDisplacement });

                    dataGridViewAutomaker.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy xe hoặc có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExportExcelAutomaker_Click(object sender, EventArgs e)
        {
            if (ExportExcelFile.Instance.ExportExcel("Danh sách hãng xe", gridViewAutomaker))
            {
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Create History
                ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Export, "Xuất file danh sách hãng xe");
            }
            else
            {
                MessageBox.Show("Xuất file thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewAutomaker_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewAutomaker.Columns["ManufacturesId"] != null)
            {
                tbAutomakerId.Text = gridViewAutomaker.GetFocusedRowCellValue("ManufacturesId").ToString();
                tbAutomakerName.Text = gridViewAutomaker.GetFocusedRowCellValue("Name").ToString();
                tbAutomakerIcon.Text = gridViewAutomaker.GetFocusedRowCellValue("Icon").ToString();
            }
        }
    }
}