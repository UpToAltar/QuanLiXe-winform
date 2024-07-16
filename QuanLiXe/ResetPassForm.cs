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
    public partial class frmResetPass : DevExpress.XtraEditors.XtraForm
    {
        public frmResetPass()
        {
            InitializeComponent();
        }

        private frmMyAccount _myAccountForm;

        public frmResetPass(frmMyAccount myAccountForm)
        {
            InitializeComponent();
            _myAccountForm = myAccountForm;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string username = textEditResetUserName.Text;
            string oldPass = textEditResetOldPass.Text;
            string newPass = textEditResetNewPass.Text;
            string newPassConfirm = textEditResetNewPassConfirm.Text;
            string msgError = "";

            var list = new List<TextEdit>
            {
                textEditResetUserName,textEditResetOldPass,textEditResetNewPass,textEditResetNewPassConfirm

            };

            if (ValidateHelper.Instance.IsEmptyTextEdit(list))
            {
                //Check if all fields are filled
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidMaxLengthTextEdit(list, 100))
            {
                //Check max length
                MessageBox.Show("Các trường nhập tối đa 100 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (newPass != newPassConfirm)
            {
                // Check equal pass
                MessageBox.Show("Nhập lại mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (newPass == oldPass)
            {
                // Check equal pass
                MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsPasswordValid(newPass))
            {
                MessageBox.Show("Mật khẩu mới ít nhất có 6 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!CheckResetPass.Instance.IsUserExistedCheckByUserNameAndPassword(out msgError, username, oldPass))
            {
                // Check Exist User and Correct Password
                MessageBox.Show("Tài khoản không tồn tại hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn đổi mật khẩu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Reset password
                    if (CheckResetPass.Instance.ResetPassword(out msgError, username, newPass))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecentUser.Password = newPass;
                        if(_myAccountForm != null)
                        {
                            _myAccountForm.Load();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
               
            }

        }

        private void hyperlinkLogin_Click(object sender, EventArgs e)
        {
            var formLogin = new frmLogin();
            this.Hide();
            formLogin.ShowDialog();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}