using DevExpress.XtraEditors;
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
            else
            {
                //Create
                string query = $"INSERT INTO Account (UserName, DisplayName, Password, Role) VALUES (N'{tbAccountUserName.Text}', N'{tbAccountDisplayName.Text}', N'{tbAccountPassword.Text}', N'{tbAccountRole.Text}' )";
                if (AccountServices.Instance.GetSuccessQuery(query))
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
            else
            {
                //Create
                string query = $"UPDATE Account SET UserName = N'{tbAccountUserName.Text}', " +
                    $"DisplayName = N'{tbAccountDisplayName.Text}', Password = N'{tbAccountPassword.Text}', " +
                    $"Role = N'{tbAccountRole.Text}'" +
                    $" WHERE ID = {tbAccountId.Text};";
                if (AccountServices.Instance.GetSuccessQuery(query))
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
                //Create
                string query = $"DELETE FROM Account WHERE ID = {tbAccountId.Text};";
                if (AccountServices.Instance.GetSuccessQuery(query))
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
    }
}