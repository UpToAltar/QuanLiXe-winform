using DevExpress.DataAccess.Native.Sql;
using DevExpress.XtraGrid.Columns;
using QuanLiXe.DTO;
using QuanLiXe.Helper;
using QuanLiXe.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiXe
{
    public partial class frmAccount : DevExpress.XtraEditors.XtraForm
    {
        public frmAccount()
        {
            InitializeComponent();
            LoadData(0 ,DateTime.Now,DateTime.Now);
        }
        void LoadData(int containDate, DateTime from, DateTime to)
        {
            var gridId = new GridColumn() { Caption = "Mã số", Visible = true, FieldName = "ID" };
            var gridUserName = new GridColumn() { Caption = "Tên đăng nhập", Visible = true, FieldName = "UserName" };
            var gridPassword = new GridColumn() { Caption = "Mật khẩu", Visible = false, FieldName = "Password" };
            var gridDisplayName = new GridColumn() { Caption = "Tên hiển thị", Visible = true, FieldName = "DisplayName" };
            var gridImage = new GridColumn() { Caption = "Đường dẫn ảnh", Visible = true, FieldName = "Image" };
            var gridRole = new GridColumn() { Caption = "Vai trò", Visible = true, FieldName = "Role" };
            var gridIsActive = new GridColumn() { Caption = "Kích hoạt", Visible = true, FieldName = "IsActive" };
            var gridCreatedAt = new GridColumn() { Caption = "Ngày tạo", Visible = true, FieldName = "CreatedAt" };
            gridCreatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridCreatedAt.DisplayFormat.FormatString = "dd/MM/yyyy";
            var gridUpdatedAt = new GridColumn() { Caption = "Ngày cập nhật", Visible = true, FieldName = "UpdatedAt" };
            gridUpdatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridUpdatedAt.DisplayFormat.FormatString = "dd/MM/yyyy";

            gridViewAccount.Columns.Clear();
            gridViewAccount.Columns.AddRange(new GridColumn[] { gridId, gridUserName, gridPassword, gridDisplayName, gridRole,gridImage,gridIsActive,gridCreatedAt,gridUpdatedAt });


            string msgError = "";
            
            if(containDate == 0) dataGridViewAccount.DataSource = AccountServices.Instance.Load(out msgError);
            else dataGridViewAccount.DataSource = AccountServices.Instance.LoadByDate(out msgError, from, to);

            if(msgError != "")
            {
                MessageBox.Show(msgError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(cboAccountRole.Items.Count == 0 )
            {
                cboAccountRole.Items.Add("Nhân viên");
                cboAccountRole.Items.Add("Quản trị viên");
                cboAccountRole.SelectedIndex = 0;
            }
        }
        void LoadWhenClick()
        {
            tbAccountId.Text = gridViewAccount.GetFocusedRowCellValue("ID").ToString();
            tbAccountDisplayName.Text = gridViewAccount.GetFocusedRowCellValue("DisplayName").ToString();
            tbAccountUserName.Text = gridViewAccount.GetFocusedRowCellValue("UserName").ToString();
            tbAccountPassword.Text = gridViewAccount.GetFocusedRowCellValue("Password").ToString();

            chkAccountIsActive.Checked = (bool)gridViewAccount.GetFocusedRowCellValue("IsActive");

            tbAccountImage.Text = gridViewAccount.GetFocusedRowCellValue("Image").ToString();
            cboAccountRole.SelectedItem = cboAccountRole.Items.Cast<string>().FirstOrDefault(item => item == gridViewAccount.GetFocusedRowCellValue("Role").ToString());
        }

        private void btnReadAccount_Click(object sender, EventArgs e)
        {
            if (dtAccountFrom.EditValue == null && dtAccountTo.EditValue == null)
            {
                LoadData(0, DateTime.Now, DateTime.Now);
                return;
            }
            else if (dtAccountFrom.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dtAccountTo.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtAccountFrom.DateTimeOffset.DateTime > dtAccountTo.DateTimeOffset.DateTime)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DateTime from = dtAccountFrom.DateTimeOffset.DateTime;
            DateTime to = dtAccountTo.DateTimeOffset.DateTime;
            LoadData(1, from, to);
            dtAccountFrom.Clear();
            dtAccountTo.Clear();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            tbAccountId.Text = "";

            tbAccountDisplayName.ReadOnly = false;
            tbAccountDisplayName.Text = "";

            tbAccountUserName.ReadOnly = false;
            tbAccountUserName.Text = "";

            tbAccountPassword.ReadOnly = false;
            tbAccountPassword.Text = "";

            tbAccountImage.ReadOnly = false;
            tbAccountImage.Text = "";

            btnAddAccount.Enabled = false;
            btnSaveAccount.Enabled = true;  
            btnCancelAccount.Enabled = true;
            btnDeleteAccount.Enabled = false;
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {

            tbAccountDisplayName.ReadOnly = false;

            tbAccountUserName.ReadOnly = false;

            tbAccountImage.ReadOnly = false;

            tbAccountPassword.ReadOnly = false;
            tbAccountPassword.Text = "";

            btnSaveAccount.Enabled = true;
            btnUpdateAccount.Enabled = false;
            btnCancelAccount.Enabled = true;
            btnDeleteAccount.Enabled = false;

            lbRequiredPassword.Visible = false;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string msgError = "";
            var list = new List<TextBox> { tbAccountId };

            if (ValidateHelper.Instance.IsEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập Id người dùng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!AccountServices.Instance.IsUserExistedCheckById(out msgError,tbAccountId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại người sở hữu có ID = {tbAccountId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Show confirm dialog
                if(MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này không?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (AccountServices.Instance.DeleteUser(out msgError, tbAccountId.Text, RecentUser.ID))
                    {
                        MessageBox.Show("Xóa người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(0, DateTime.Now, DateTime.Now);
                    }
                    else
                    {
                        MessageBox.Show("Xóa người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExportExcelAccount_Click(object sender, EventArgs e)
        {
            if (ExportExcelFile.Instance.ExportExcel("Danh sách người dùng", gridViewAccount))
            {
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Create History
                ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID),ActivityType.Export,"Xuất file danh sách người dùng");
            }
            else
            {
                MessageBox.Show("Xuất file thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void gridViewAccount_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadWhenClick();
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            string msgError = "";
            if(tbAccountId.Text == "")
            {
                // Add
                var list = new List<TextBox>
            {
                tbAccountUserName,tbAccountPassword,tbAccountDisplayName

            };
                string role = cboAccountRole.SelectedItem != null ? cboAccountRole.SelectedItem.ToString() : "";
                if (ValidateHelper.Instance.IsEmptyTextBox(list) || role == "")
                {
                    // Check empty
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!ValidateHelper.Instance.IsValidMaxLengthTextBox(list, 100))
                {
                    //Check max length
                    MessageBox.Show("Các trường nhập tối đa 100 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!ValidateHelper.Instance.IsPasswordValid(tbAccountPassword.Text))
                {
                    //Check name exist
                    MessageBox.Show("Mật khẩu có ít nhất 6 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (AccountServices.Instance.IsUserNameExisted(out msgError,tbAccountUserName.Text))
                {
                    //Check name exist
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tbAccountImage.Text != "" && !ChechImageUrl.Instance.IsImageUrlValid(tbAccountImage.Text))
                {
                    //Check name exist
                    MessageBox.Show("Đường dẫn ảnh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Create
                    int isActive = chkAccountIsActive.Checked ? 1 : 0;
                    if (AccountServices.Instance.CreateUser(out msgError, tbAccountUserName.Text, tbAccountPassword.Text, tbAccountDisplayName.Text, cboAccountRole.Text, tbAccountImage.Text,isActive, RecentUser.ID,1))
                    {
                        MessageBox.Show("Thêm người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbAccountDisplayName.ReadOnly = true;
                        tbAccountDisplayName.Text = "";

                        tbAccountUserName.ReadOnly = true;
                        tbAccountUserName.Text = "";

                        tbAccountPassword.ReadOnly = true;
                        tbAccountPassword.Text = "";

                        tbAccountImage.ReadOnly = true;
                        tbAccountImage.Text = "";

                        btnAddAccount.Enabled = true;
                        btnSaveAccount.Enabled = false;
                        btnUpdateAccount.Enabled = true;
                        btnCancelAccount.Enabled = false;
                        btnDeleteAccount.Enabled = true;

                        LoadData(0, DateTime.Now, DateTime.Now);
                    }
                    else
                    {
                        MessageBox.Show("Thêm người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Update
                var list = new List<TextBox>
                    {
                        tbAccountUserName,tbAccountDisplayName,tbAccountId

                    };
                string role = cboAccountRole.SelectedItem != null ? cboAccountRole.SelectedItem.ToString() : "";
                if (ValidateHelper.Instance.IsEmptyTextBox(list) || role == "")
                {
                    // Check empty
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (!ValidateHelper.Instance.IsValidMaxLengthTextBox(list, 100))
                {
                    //Check max length
                    MessageBox.Show("Các trường nhập tối đa 100 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tbAccountPassword.Text!= "" && !ValidateHelper.Instance.IsPasswordValid(tbAccountPassword.Text))
                {
                    //Check name exist
                    MessageBox.Show("Mật khẩu có ít nhất 6 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!AccountServices.Instance.IsUserExistedCheckById(out msgError, tbAccountId.Text))
                {
                    //Check id exist
                    MessageBox.Show($"Không tồn tại người dùng có ID = {tbAccountId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (AccountServices.Instance.IsUserExisted(out msgError, tbAccountUserName.Text, tbAccountId.Text))
                {
                    //Check name exist
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tbAccountImage.Text != "" && !ChechImageUrl.Instance.IsImageUrlValid(tbAccountImage.Text))
                {
                    //Check name exist
                    MessageBox.Show("Đường dẫn ảnh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Update
                    int isActive = chkAccountIsActive.Checked ? 1 : 0;

                    if (AccountServices.Instance.UpdateUser(out msgError, tbAccountId.Text, tbAccountUserName.Text, tbAccountPassword.Text, tbAccountDisplayName.Text, cboAccountRole.Text, tbAccountImage.Text,isActive, RecentUser.ID))
                    {
                        MessageBox.Show("Cập nhật người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tbAccountDisplayName.ReadOnly = true;
                        tbAccountDisplayName.Text = "";

                        tbAccountUserName.ReadOnly = true;
                        tbAccountUserName.Text = "";

                        tbAccountPassword.ReadOnly = true;
                        tbAccountPassword.Text = "";

                        tbAccountImage.ReadOnly = true;
                        tbAccountImage.Text = "";

                        btnAddAccount.Enabled = true;
                        btnSaveAccount.Enabled = false;
                        btnUpdateAccount.Enabled = true;
                        btnCancelAccount.Enabled = false;
                        btnDeleteAccount.Enabled = true;

                        lbRequiredPassword.Visible = true;
                        LoadData(0, DateTime.Now, DateTime.Now);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelAccount_Click(object sender, EventArgs e)
        {
            tbAccountDisplayName.ReadOnly = true;
            tbAccountId.ReadOnly = true;
            tbAccountUserName.ReadOnly = true;
            tbAccountPassword.ReadOnly = true;
            tbAccountImage.ReadOnly = true;

            btnDeleteAccount.Enabled = true;
            btnAddAccount.Enabled = true;
            btnSaveAccount.Enabled = false;
            btnUpdateAccount.Enabled = true;
            btnCancelAccount.Enabled = false;

            lbRequiredPassword.Visible = true;
            LoadWhenClick();
        }

        private void dataGridViewAccount_Click(object sender, EventArgs e)
        {

        }
    }
}