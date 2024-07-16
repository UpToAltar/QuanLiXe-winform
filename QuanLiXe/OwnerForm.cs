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
    public partial class frmOwner : DevExpress.XtraEditors.XtraForm
    {
        public frmOwner()
        {
            InitializeComponent();
            LoadData(0 ,DateTime.Now, DateTime.Now);
        }

        void LoadData(int containDate, DateTime from, DateTime to)
        {
            var gridId = new GridColumn() { Caption = "Mã số", Visible = true, FieldName = "OwnerId" };
            var gridFullName = new GridColumn() { Caption = "Tên đầy đủ", Visible = true, FieldName = "FullName" };
            var gridEmail = new GridColumn() { Caption = "Email", Visible = true, FieldName = "Email" };
            var gridPhoneNumber = new GridColumn() { Caption = "Số điện thoại", Visible = true, FieldName = "PhoneNumber" };
            var gridAddress = new GridColumn() { Caption = "Địa chỉ", Visible = true, FieldName = "Address" };
            var gridCreatedAt = new GridColumn() { Caption = "Ngày tạo", Visible = true, FieldName = "CreatedAt" };
            gridCreatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridCreatedAt.DisplayFormat.FormatString = "dd/MM/yyyy";
            var gridUpdatedAt = new GridColumn() { Caption = "Ngày cập nhật", Visible = true, FieldName = "UpdatedAt" };
            gridUpdatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridUpdatedAt.DisplayFormat.FormatString = "dd/MM/yyyy";

            gridViewOwner.Columns.Clear();
            gridViewOwner.Columns.AddRange(new GridColumn[] { gridId, gridFullName, gridEmail, gridPhoneNumber, gridAddress,gridCreatedAt,gridUpdatedAt });

            string msgError = "";
            if(containDate == 0) dataGridViewOwner.DataSource = OwnerServices.Instance.Load(out msgError);
            else dataGridViewOwner.DataSource = OwnerServices.Instance.LoadByDate(out msgError, from, to);

            if(msgError != "")
            {
                MessageBox.Show(msgError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadOwner_Click(object sender, EventArgs e)
        {
            if (dtOwnerFrom.EditValue == null && dtOwnerTo.EditValue == null)
            {
                LoadData(0, DateTime.Now, DateTime.Now);
                return;
            }
            else if (dtOwnerFrom.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dtOwnerTo.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtOwnerFrom.DateTimeOffset.DateTime > dtOwnerTo.DateTimeOffset.DateTime)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DateTime from = dtOwnerFrom.DateTimeOffset.DateTime;
            DateTime to = dtOwnerTo.DateTimeOffset.DateTime;
            LoadData(1, from, to);
            dtOwnerFrom.Clear();
            dtOwnerTo.Clear();
        }

        private void btnAddOwner_Click_1(object sender, EventArgs e)
        {
            string msgError = "";
            var list = new List<TextBox> { tbOwnerFullName, tbOwnerEmail };
            if(tbOwnerAddress.Text != "")
            {
                list.Add(tbOwnerAddress);
            }
            
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
            else if (tbOwnerPhoneNumer.Text != "" && !ValidateHelper.Instance.IsValidPhoneNumber(tbOwnerPhoneNumer.Text))
            {
                //Check name exist
                MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidEmail(tbOwnerEmail.Text))
            {
                //Check name exist
                MessageBox.Show("Email không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (OwnerServices.Instance.IsEmailExisted(out msgError, tbOwnerEmail.Text))
            {
                //Check name exist
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Create
                
                if (OwnerServices.Instance.CreateOwner(out msgError, tbOwnerFullName.Text,tbOwnerEmail.Text,tbOwnerPhoneNumer.Text,tbOwnerAddress.Text, RecentUser.ID))
                {
                    MessageBox.Show("Thêm người sở hữu xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(0, DateTime.Now, DateTime.Now);
                }
                else
                {
                    MessageBox.Show("Thêm người sở hữu xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchOwner_Click(object sender, EventArgs e)
        {
            string msgError = "";
            if (tbSearchOwner.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var data = OwnerServices.Instance.Search(out msgError, tbSearchOwner.Text);
                if (data != null && data.Rows.Count > 0)
                {
                    dataGridViewOwner.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người sở hữu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            string msgError = "";
            var list = new List<TextBox>
            {
               tbOwnerFullName,tbOwnerEmail,tbOwnerId

            };
            if (ValidateHelper.Instance.IsEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidEmail(tbOwnerEmail.Text))
            {
                //Check name exist
                MessageBox.Show("Email không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbOwnerPhoneNumer.Text != "" && !ValidateHelper.Instance.IsValidPhoneNumber(tbOwnerPhoneNumer.Text))
            {
                //Check name exist
                MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!OwnerServices.Instance.IsOwnerExistedCheckById(out msgError, tbOwnerId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại người sở hữu có ID = {tbOwnerId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (OwnerServices.Instance.IsEmailOtherExisted(out msgError, tbOwnerEmail.Text, tbOwnerId.Text))
            {
                //Check name exist
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Update
                if (OwnerServices.Instance.UpdateOwner(out msgError, tbOwnerId.Text,tbOwnerFullName.Text,tbOwnerEmail.Text,tbOwnerPhoneNumer.Text,tbOwnerAddress.Text, RecentUser.ID))
                {
                    MessageBox.Show("Cập nhật người sở hữu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(0, DateTime.Now, DateTime.Now);
                }
                else
                {
                    MessageBox.Show("Cập nhật người sở hữu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            string msgError = "";
            var list = new List<TextBox> { tbOwnerId };

            if (ValidateHelper.Instance.IsEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập Id người sở hữu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!OwnerServices.Instance.IsOwnerExistedCheckById(out msgError, tbOwnerId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại người sở hữu có ID = {tbOwnerId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn xóa người sở hữu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Delete

                    if (OwnerServices.Instance.DeleteOwner(out msgError, tbOwnerId.Text, RecentUser.ID))
                    {
                        MessageBox.Show("Xóa người sở hữu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(0, DateTime.Now, DateTime.Now);
                    }
                    else
                    {
                        MessageBox.Show("Xóa người sở hữu thất bại, vui lòng kiểm tra kết nối hoặc bảo đảm đã xóa hết xe của người sở hữu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void btnExportExcelOwner_Click(object sender, EventArgs e)
        {
            if (ExportExcelFile.Instance.ExportExcel("Danh sách chủ xe", gridViewOwner))
            {
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Create History
                ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Export, "Xuất file danh sách chủ xe");
            }
            else
            {
                MessageBox.Show("Xuất file thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewOwner_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            tbOwnerId.Text = gridViewOwner.GetFocusedRowCellValue("OwnerId").ToString();
            tbOwnerFullName.Text = gridViewOwner.GetFocusedRowCellValue("FullName").ToString();
            tbOwnerEmail.Text = gridViewOwner.GetFocusedRowCellValue("Email").ToString();
            tbOwnerPhoneNumer.Text = gridViewOwner.GetFocusedRowCellValue("PhoneNumber").ToString();
            tbOwnerAddress.Text = gridViewOwner.GetFocusedRowCellValue("Address").ToString();

        }
    }
}