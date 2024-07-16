using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
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
    public partial class frmMyAccount : DevExpress.XtraEditors.XtraForm
    {
        public const string DEFAULT_IMAGE = "https://png.pngtree.com/png-vector/20190803/ourlarge/pngtree-avatar-user-basic-abstract-circle-background-flat-color-icon-png-image_1647265.jpg";
        public frmMyAccount()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            tbMyAccountDisplayName.Text = RecentUser.DisplayName;
            tbMyAccountUserName.Text = RecentUser.UserName;
            tbMyAccountRole.Text = RecentUser.Role;
            tbMyAccountPassword.Text = RecentUser.Password;
            tbMyAccountImage.Text = RecentUser.Image;
            pbMyAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            tbMyAccountCreatedAt.Text = RecentUser.CreatedAt.ToString();
            tbMyAccountUpdatedAt.Text = RecentUser.UpdatedAt.ToString();
            if (RecentUser.Image != "")
            {
                pbMyAccount.ImageLocation = RecentUser.Image;

            }
            else
            {
                pbMyAccount.ImageLocation = DEFAULT_IMAGE;
            }
        }

        private void btnResetPasswordMyAccount_Click(object sender, EventArgs e)
        {
            var formResetPass = new frmResetPass(this);
            
            formResetPass.ShowDialog();
        }

        private void btnUpdateMyAccount_Click(object sender, EventArgs e)
        {
            string msgError = "";
            var list = new List<TextEdit>
            {
                tbMyAccountUserName,tbMyAccountDisplayName

            };
            if (ValidateHelper.Instance.IsEmptyTextEdit(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidMaxLengthTextEdit(list, 100))
            {
                //Check max length
                MessageBox.Show("Các trường nhập tối đa 100 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbMyAccountImage.Text != "" && !ChechImageUrl.Instance.IsImageUrlValid(tbMyAccountImage.Text))
            {
                //Check name exist
                MessageBox.Show("Đường dẫn ảnh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!AccountServices.Instance.IsUserExistedCheckById(out msgError, RecentUser.ID))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại người dùng, có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AccountServices.Instance.IsUserExisted(out msgError, tbMyAccountUserName.Text, RecentUser.ID))
            {
                //Check name exist
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                //Update

                if (AccountServices.Instance.UpdateUser(out msgError, RecentUser.ID, tbMyAccountUserName.Text,"", tbMyAccountDisplayName.Text, RecentUser.Role, tbMyAccountImage.Text,1, RecentUser.ID))
                {
                    MessageBox.Show("Cập nhật người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RecentUser.UserName = tbMyAccountUserName.Text;
                    RecentUser.DisplayName = tbMyAccountDisplayName.Text;
                    RecentUser.Image = tbMyAccountImage.Text;
                    RecentUser.UpdatedAt = DateTime.Now;
                    Load();
                }
                else
                {
                    MessageBox.Show("Cập nhật người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}