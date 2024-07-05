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
    public partial class RegisterForm : DevExpress.XtraEditors.XtraForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void groupControlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hyperlinkLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Check if all fields are filled
            if (textEditRegisterDisplayName.Text == "" || textEditRegisterPassword.Text == "" || textEditRegisterUserName.Text == "" || textEditRegisterPasswordConfirm.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                if (CheckRegister.Instance.CheckUserExisted(textEditRegisterUserName.Text)) { 
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if(!CheckRegister.Instance.CheckPassword(textEditRegisterPassword.Text))
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                else if (textEditRegisterPassword.Text != textEditRegisterPasswordConfirm.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (CheckRegister.Instance.CreateUser(textEditRegisterUserName.Text, textEditRegisterPassword.Text, textEditRegisterDisplayName.Text))
                    {
                        MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            var formResetPass = new ResetPassForm();
            this.Hide();
            formResetPass.ShowDialog();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var checkOut = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (checkOut != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}