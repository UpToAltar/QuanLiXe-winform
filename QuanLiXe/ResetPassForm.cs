using DevExpress.XtraEditors;
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
    public partial class ResetPassForm : DevExpress.XtraEditors.XtraForm
    {
        public ResetPassForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string username = textEditResetUserName.Text;
            string oldPass = textEditResetOldPass.Text;
            string newPass = textEditResetNewPass.Text;
            string newPassConfirm = textEditResetNewPassConfirm.Text;

            if (username == "" || oldPass == "" || newPass == "" || newPassConfirm == "")
            {
                //Check if all fields are filled
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else if (!CheckResetPass.Instance.CheckUserExistedAndPassword(username, oldPass))
            {
                // Check Exist User and Correct Password
                MessageBox.Show("Tài khoản không tồn tại hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!CheckResetPass.Instance.CheckPassword(newPass))
            {
                MessageBox.Show("Mật khẩu mới phải nhiều hơn 6 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (CheckResetPass.Instance.ResetPassword(username, newPass))
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }

        }

        private void hyperlinkLogin_Click(object sender, EventArgs e)
        {
            var formLogin = new LoginForm();
            this.Hide();
            formLogin.ShowDialog();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetPassForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var checkOut = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (checkOut != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}