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
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void hyperlinkLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string msgError = "";
            var list = new List<TextEdit>
            {
                textEditRegisterDisplayName,textEditRegisterPassword,textEditRegisterUserName,textEditRegisterPasswordConfirm

            };
            //Check if all fields are filled
            if (ValidateHelper.Instance.IsEmptyTextEdit(list))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidMaxLengthTextEdit(list, 100))
            {
                //Check max length
                MessageBox.Show("Các trường nhập tối đa 100 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                if (AccountServices.Instance.IsUserNameExisted(out msgError,textEditRegisterUserName.Text)) { 
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if(!ValidateHelper.Instance.IsPasswordValid(textEditRegisterPassword.Text))
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                else if (textEditRegisterPassword.Text != textEditRegisterPasswordConfirm.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (AccountServices.Instance.CreateUser(out msgError,textEditRegisterUserName.Text, textEditRegisterPassword.Text, textEditRegisterDisplayName.Text,"Nhân viên", "",1,"0",0))
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
            var formResetPass = new frmResetPass();
            this.Hide();
            formResetPass.ShowDialog();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}