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
    public partial class OwnerForm : DevExpress.XtraEditors.XtraForm
    {
        public OwnerForm()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            var gridId = new GridColumn() { Caption = "ID", Visible = true, FieldName = "OwnerId" };
            var gridFullName = new GridColumn() { Caption = "Tên đầy đủ", Visible = true, FieldName = "FullName" };
            var gridEmail = new GridColumn() { Caption = "Email", Visible = true, FieldName = "Email" };
            var gridPhoneNumber = new GridColumn() { Caption = "Số điện thoại", Visible = true, FieldName = "PhoneNumber" };
            var gridAddress = new GridColumn() { Caption = "Địa chỉ", Visible = true, FieldName = "Address" };

            gridViewOwner.Columns.Clear();
            gridViewOwner.Columns.AddRange(new GridColumn[] { gridId, gridFullName, gridEmail, gridPhoneNumber, gridAddress });

            dataGridViewOwner.DataSource = OwnerServices.Instance.Load();
        }

        private void btnReadOwner_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddOwner_Click_1(object sender, EventArgs e)
        {
            var list = new List<TextBox>
            {
                tbOwnerAddress,tbOwnerAddress,tbOwnerFullName,tbOwnerEmail

            };
            if (!ValidateHelper.Instance.ValidateEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidEmail(tbOwnerEmail.Text))
            {
                //Check name exist
                MessageBox.Show("Email không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (OwnerServices.Instance.CheckEmail(tbOwnerEmail.Text))
            {
                //Check name exist
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Create
                
                if (OwnerServices.Instance.CreateOwner(tbOwnerFullName.Text,tbOwnerEmail.Text,tbOwnerPhoneNumer.Text,tbOwnerAddress.Text))
                {
                    MessageBox.Show("Thêm người sở hữu xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm người sở hữu xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchOwner_Click(object sender, EventArgs e)
        {
            if (tbSearchOwner.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var data = OwnerServices.Instance.Search(tbSearchOwner.Text);
                if (data != null && data.Rows.Count > 0)
                {
                    dataGridViewOwner.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người sở hữu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            var list = new List<TextBox>
            {
                tbOwnerAddress,tbOwnerFullName,tbOwnerEmail,tbOwnerId

            };
            if (!ValidateHelper.Instance.ValidateEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidateHelper.Instance.IsValidEmail(tbOwnerEmail.Text))
            {
                //Check name exist
                MessageBox.Show("Email không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!OwnerServices.Instance.CheckFindById(tbOwnerId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại người sở hữu có ID = {tbOwnerId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (OwnerServices.Instance.CheckEmailOther(tbOwnerEmail.Text, tbOwnerId.Text))
            {
                //Check name exist
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Update
                if (OwnerServices.Instance.UpdateOwner(tbOwnerId.Text,tbOwnerFullName.Text,tbOwnerEmail.Text,tbOwnerPhoneNumer.Text,tbOwnerAddress.Text))
                {
                    MessageBox.Show("Cập nhật người sở hữu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật người sở hữu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            var list = new List<TextBox> { tbOwnerId };

            if (!ValidateHelper.Instance.ValidateEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập Id người sở hữu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!OwnerServices.Instance.CheckFindById(tbOwnerId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại người sở hữu có ID = {tbOwnerId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Delete
                
                if (OwnerServices.Instance.DeleteOwner(tbOwnerId.Text))
                {
                    MessageBox.Show("Xóa người sở hữu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa người sở hữu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportExcelOwner_Click(object sender, EventArgs e)
        {
            if (ExportExcelFile.Instance.ExportExcel("Danh sách chủ xe", gridViewOwner))
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