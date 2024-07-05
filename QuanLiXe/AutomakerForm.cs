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
    public partial class AutomakerForm : DevExpress.XtraEditors.XtraForm
    {
        public AutomakerForm()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dataGridViewAutomaker.DataSource = AutomakerServices.Instance.Load();
        }

        private void btnAddAutomaker_Click(object sender, EventArgs e)
        {
            var list = new List<TextBox>
            {
                tbAutomakerName,
                tbAutomakerId,
              
            };
            if(!ValidateHelper.Instance.ValidateEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (AutomakerServices.Instance.CheckName(tbAutomakerName.Text))
            {
                //Check name exist
                MessageBox.Show("Hãng xe đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Create
                string query = $"INSERT INTO Manufactures (Name,Icon) VALUES (N'{tbAutomakerName.Text}', N'{tbAutomakerIcon.Text}')";
                if (AutomakerServices.Instance.GetSuccessQuery(query))
                {
                    MessageBox.Show("Thêm hãng xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm hãng xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

            
        }

        private void btnSearchAutomaker_Click(object sender, EventArgs e)
        {
            if(tbSearchAutomaker.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var data = AutomakerServices.Instance.Search(tbSearchAutomaker.Text);
                if (data != null && data.Rows.Count > 0) {
                    dataGridViewAutomaker.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hãng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void btnReadAutomaker_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdateAutomaker_Click(object sender, EventArgs e)
        {
            var list = new List<TextBox>
            {
                tbAutomakerName,
                tbAutomakerId,

            };
            if (!ValidateHelper.Instance.ValidateEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!AutomakerServices.Instance.CheckFindById(tbAutomakerId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại xe có ID = {tbAutomakerId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AutomakerServices.Instance.CheckName(tbAutomakerName.Text))
            {
                //Check name exist
                MessageBox.Show("Hãng xe đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Create
                string query = $"UPDATE Manufactures SET Name = N'{tbAutomakerName.Text}', Icon = N'{tbAutomakerIcon.Text}' WHERE ManufacturesId = {tbAutomakerId.Text};";
                if (AutomakerServices.Instance.GetSuccessQuery(query))
                {
                    MessageBox.Show("Cập nhật hãng xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật hãng xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteAutomaker_Click(object sender, EventArgs e)
        {
            var list = new List<TextBox>
            {
                
                tbAutomakerId,

            };
            if (!ValidateHelper.Instance.ValidateEmptyTextBox(list))
            {
                // Check empty
                MessageBox.Show("Vui lòng nhập Id hãng xe cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!AutomakerServices.Instance.CheckFindById(tbAutomakerId.Text))
            {
                //Check id exist
                MessageBox.Show($"Không tồn tại xe có ID = {tbAutomakerId.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Create
                string query = $"DELETE FROM Manufactures WHERE ManufacturesId = {tbAutomakerId.Text};";
                if (AutomakerServices.Instance.GetSuccessQuery(query))
                {
                    MessageBox.Show("Xóa hãng xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa nhật hãng xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnViewVehiclesOfAutoMaker_Click(object sender, EventArgs e)
        {
            if(tbAutomakerName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hãng xe cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!AutomakerServices.Instance.CheckFindByName(tbAutomakerName.Text))
            {
                MessageBox.Show($"Không có hãng xe nào tên là : {tbAutomakerName.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var data = AutomakerServices.Instance.GetVehiclesByAutomakerName(tbAutomakerName.Text);
                if(data!= null && data.Rows.Count > 0)
                {
                    dataGridViewAutomaker.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy xe hoặc có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExportExcelAutomaker_Click(object sender, EventArgs e)
        {
            if (ExportExcelFile.Instance.ExportExcel("Danh sách hãng xe", gridViewAutomaker))
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