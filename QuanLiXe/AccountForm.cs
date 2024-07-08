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
    public partial class AccountForm : DevExpress.XtraEditors.XtraForm
    {
        public AccountForm()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            var gridId = new GridColumn() { Caption = "ID", Visible = true, FieldName = "ID" };
            var gridUserName = new GridColumn() { Caption = "Tên đăng nhập", Visible = true, FieldName = "UserName" };
            var gridPassword = new GridColumn() { Caption = "Mật khẩu", Visible = true, FieldName = "Password" };
            var gridDisplayName = new GridColumn() { Caption = "Tên hiển thị", Visible = true, FieldName = "DisplayName" };
            var gridImage = new GridColumn() { Caption = "Đường dẫn ảnh", Visible = true, FieldName = "Image" };
            var gridRole = new GridColumn() { Caption = "Vai trò", Visible = true, FieldName = "Role" };

            gridViewAccount.Columns.Clear();
            gridViewAccount.Columns.AddRange(new GridColumn[] { gridId, gridUserName, gridPassword, gridDisplayName, gridRole,gridImage });



            dataGridViewAccount.DataSource = AccountServices.Instance.Load();
            if(tbAccountRole.Items.Count == 0 )
            {
                tbAccountRole.Items.Add("Nhân viên");
                tbAccountRole.Items.Add("Quản trị viên");
                tbAccountRole.SelectedIndex = 0;
            }
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            if (tbSearchAccount.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var data = AccountServices.Instance.Search(tbSearchAccount.Text);
                if (data != null && data.Rows.Count > 0)
                {
                    dataGridViewAccount.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnReadAccount_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var list = new List<TextBox>
            {
                tbAccountUserName,tbAccountPassword,tbAccountDisplayName

            };
            string role = tbAccountRole.SelectedItem != null ? tbAccountRole.SelectedItem.ToString() : "";
            if (!ValidateHelper.Instance.ValidateEmptyTextBox(list) || role == "")
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!CheckRegister.Instance.CheckPassword(tbAccountPassword.Text))
            {
                //Check name exist
                MessageBox.Show("Password phải nhiều hơn 6 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AccountServices.Instance.CheckUserName(tbAccountUserName.Text))
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
                
                if (AccountServices.Instance.CreateUser(tbAccountUserName.Text,tbAccountPassword.Text,tbAccountDisplayName.Text,tbAccountRole.Text,tbAccountImage.Text))
                {
                    MessageBox.Show("Thêm người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            var list = new List<TextBox>
            {
                tbAccountUserName,tbAccountPassword,tbAccountDisplayName,tbAccountId

            };
            string role = tbAccountRole.SelectedItem != null ? tbAccountRole.SelectedItem.ToString() : "";
            if (!ValidateHelper.Instance.ValidateEmptyTextBox(list) || role == "")
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!CheckRegister.Instance.CheckPassword(tbAccountPassword.Text))
            {
                //Check name exist
                MessageBox.Show("Password phải nhiều hơn 6 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!AccountServices.Instance.CheckFindById(tbAccountId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại người dùng có ID = {tbAccountId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AccountServices.Instance.CheckUserNameOther(tbAccountUserName.Text, tbAccountId.Text))
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
               
                if (AccountServices.Instance.UpdateUser(tbAccountId.Text,tbAccountUserName.Text,tbAccountPassword.Text,tbAccountDisplayName.Text,tbAccountRole.Text,tbAccountImage.Text))
                {
                    MessageBox.Show("Cập nhật người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var list = new List<TextBox> { tbAccountId };

            if (!ValidateHelper.Instance.ValidateEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập Id người dùng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!AccountServices.Instance.CheckFindById(tbAccountId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại người sở hữu có ID = {tbAccountId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Delete
                
                if (AccountServices.Instance.DeleteUser(tbAccountId.Text))
                {
                    MessageBox.Show("Xóa người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportExcelAccount_Click(object sender, EventArgs e)
        {
            if (ExportExcelFile.Instance.ExportExcel("Danh sách người dùng", gridViewAccount))
            {
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xuất file thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}