using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
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
    public partial class AutomakerForm : DevExpress.XtraEditors.XtraForm
    {
        public AutomakerForm()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            var gridId = new GridColumn() { Caption = "ID", Visible = true, FieldName = "ManufacturesId" };
            var gridName = new GridColumn() { Caption = "Tên hãng xe", Visible = true, FieldName = "Name" };
            var gridIcon = new GridColumn() { Caption = "Đường dẫn ảnh biểu tượng", Visible = true, FieldName = "Icon" };

            gridViewAutomaker.Columns.Clear();
            gridViewAutomaker.GroupPanelText = "Danh sách hãng xe";
            gridViewAutomaker.OptionsView.ColumnAutoWidth = true;
            gridViewAutomaker.Columns.AddRange(new GridColumn[] { gridId, gridName, gridIcon });

            dataGridViewAutomaker.DataSource = AutomakerServices.Instance.Load();
        }

        private void btnAddAutomaker_Click(object sender, EventArgs e)
        {
            var list = new List<TextBox>
            {
                tbAutomakerName,
                tbAutomakerId,
              
            };
            if(!ValidateHelper.Instance.ValidateEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (AutomakerServices.Instance.CheckName(tbAutomakerName.Text))
            {
                //Check name exist
                MessageBox.Show("Hãng xe đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Create
                
                if (AutomakerServices.Instance.CreateAutomaker(tbAutomakerName.Text,tbAutomakerIcon.Text))
                {
                    MessageBox.Show("Thêm hãng xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm hãng xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

            
        }

        private void btnSearchAutomaker_Click(object sender, EventArgs e)
        {
            if(tbSearchAutomaker.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var data = AutomakerServices.Instance.Search(tbSearchAutomaker.Text);
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
            LoadData();
        }

        private void btnUpdateAutomaker_Click(object sender, EventArgs e)
        {
            var list = new List<TextBox>
            {
                tbAutomakerName,
                tbAutomakerId,

            };
            if (!ValidateHelper.Instance.ValidateEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!AutomakerServices.Instance.CheckFindById(tbAutomakerId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại hãng xe có ID = {tbAutomakerId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AutomakerServices.Instance.CheckName(tbAutomakerName.Text))
            {
                //Check name exist
                MessageBox.Show("Hãng xe đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Update
                
                if (AutomakerServices.Instance.UpdateAutomaker(tbAutomakerId.Text, tbAutomakerName.Text,tbAutomakerIcon.Text))
                {
                    MessageBox.Show("Cập nhật hãng xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật hãng xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteAutomaker_Click(object sender, EventArgs e)
        {
            var list = new List<TextBox>
            {
                
                tbAutomakerId,

            };
            if (!ValidateHelper.Instance.ValidateEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập Id hãng xe cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!AutomakerServices.Instance.CheckFindById(tbAutomakerId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại xe có ID = {tbAutomakerId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Delete
                
                if (AutomakerServices.Instance.DeleteAutomaker(tbAutomakerId.Text))
                {
                    MessageBox.Show("Xóa hãng xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa nhật hãng xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnViewVehiclesOfAutoMaker_Click(object sender, EventArgs e)
        {
            if(tbAutomakerName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hãng xe cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!AutomakerServices.Instance.CheckName(tbAutomakerName.Text))
            {
                MessageBox.Show($"Không có hãng xe nào tên là : {tbAutomakerName.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var data = AutomakerServices.Instance.GetVehiclesByAutomakerName(tbAutomakerName.Text);
                if(data!= null && data.Rows.Count > 0)
                {
                    var gridId = new GridColumn() { Caption = "ID", Visible = true, FieldName = "VehiclesId" };
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
            }
            else
            {
                MessageBox.Show("Xuất file thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}