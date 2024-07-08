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
    public partial class MyAccountForm : DevExpress.XtraEditors.XtraForm
    {
        public const string DefaultImage = "https://png.pngtree.com/png-vector/20190803/ourlarge/pngtree-avatar-user-basic-abstract-circle-background-flat-color-icon-png-image_1647265.jpg";
        public MyAccountForm()
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
            pictureBoxMyAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            if (RecentUser.Image != "")
            {
                pictureBoxMyAccount.ImageLocation = RecentUser.Image;

            }
            else
            {
                pictureBoxMyAccount.ImageLocation = DefaultImage;
            }
        }

        private void btnResetPasswordMyAccount_Click(object sender, EventArgs e)
        {
            var formResetPass = new ResetPassForm(this);
            
            formResetPass.ShowDialog();
        }

        private void btnUpdateMyAccount_Click(object sender, EventArgs e)
        {
            var list = new List<TextEdit>
            {
                tbMyAccountUserName,tbMyAccountDisplayName

            };
            if (!ValidateHelper.Instance.ValidateEmptyTextEdit(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!AccountServices.Instance.CheckFindById(RecentUser.ID))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại người dùng, có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AccountServices.Instance.CheckUserNameOther(tbMyAccountUserName.Text, RecentUser.ID))
            {
                //Check name exist
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbMyAccountImage.Text != "" &&  !ChechImageUrl.Instance.IsImageUrlValid(tbMyAccountImage.Text))
            {
                //Check name exist
                MessageBox.Show("Đường dẫn ảnh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Update

                if (AccountServices.Instance.UpdateUser(RecentUser.ID, tbMyAccountUserName.Text, RecentUser.Password, tbMyAccountDisplayName.Text, RecentUser.Role, tbMyAccountImage.Text))
                {
                    MessageBox.Show("Cập nhật người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RecentUser.UserName = tbMyAccountUserName.Text;
                    RecentUser.DisplayName = tbMyAccountDisplayName.Text;
                    RecentUser.Image = tbMyAccountImage.Text;
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