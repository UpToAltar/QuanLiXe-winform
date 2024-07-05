using QuanLiXe.DTO;
using QuanLiXe.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiXe
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var checkOut = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (checkOut != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var formTable = new MainForm();
            
            if (textEditUserName.Text == "" || textEditPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var checkLogin = CheckLogin.Instance.Check(textEditUserName.Text, textEditPassword.Text);
                if (checkLogin != null && checkLogin.Rows.Count > 0)
                {
                    //Add Recent User

                    DataRow row = checkLogin.Rows[0];
                    RecentUser.UserName = row["UserName"].ToString();
                    RecentUser.Role = row["Role"].ToString();
                    RecentUser.DisplayName = row["DisplayName"].ToString();
                    RecentUser.Password = row["Password"].ToString();

                    //Show Form
                    this.Hide();
                    formTable.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formRegister = new RegisterForm();
            formRegister.ShowDialog();
            this.Show();
        }

        private void groupControlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            var formResetPass = new ResetPassForm();
            this.Hide();
            formResetPass.ShowDialog();
            this.Show();
        }
    }
}
