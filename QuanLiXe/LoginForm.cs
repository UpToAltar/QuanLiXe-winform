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
using System.Windows.Forms;

namespace QuanLiXe
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
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
            var formTable = new frmMain();
            string msgError = "";
            var list = new List<TextEdit>
            {
                textEditUserName,textEditPassword

            };
            
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
                var user = CheckLogin.Instance.GetUserByUserName(out msgError, textEditUserName.Text, textEditPassword.Text);
                if (user != null && user.Rows.Count > 0)
                {
                    
                    //Add Recent User

                    DataRow row = user.Rows[0];
                    //Check Active
                    if ((bool)row["IsActive"] == false)
                    {
                        MessageBox.Show("Tài khoản đã bị khóa, vui lòng liên hệ quản trị viên để mở khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(row["ID"].ToString()), ActivityType.Login, $"Người dùng : {row["UserName"].ToString()} đăng nhập thất bại do tài khoản bị khóa");
                    }
                    else
                    {
                        RecentUser.ID = row["ID"].ToString();
                        RecentUser.UserName = row["UserName"].ToString();
                        RecentUser.Role = row["Role"].ToString();
                        RecentUser.DisplayName = row["DisplayName"].ToString();
                        RecentUser.Password = row["Password"].ToString();
                        RecentUser.Image = row["Image"].ToString();
                        RecentUser.CreatedAt = DateTime.Parse(row["CreatedAt"].ToString());
                        RecentUser.UpdatedAt = DateTime.Parse(row["UpdatedAt"].ToString());

                        //Create History
                        ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Login, $"Người dùng : {RecentUser.UserName} đăng nhập thành công");

                        //Show Form
                        this.Hide();
                        formTable.ShowDialog();
                        this.Show();
                    }

                    
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
            var formRegister = new frmRegister();
            formRegister.ShowDialog();
            this.Show();
        }

        private void groupControlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            var formResetPass = new frmResetPass();
            this.Hide();
            formResetPass.ShowDialog();
            this.Show();
        }
    }
}
