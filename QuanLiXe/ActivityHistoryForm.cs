using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using QuanLiXe.DTO;
using QuanLiXe.Helper;
using QuanLiXe.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe
{
    public partial class frmActivityHistory : DevExpress.XtraEditors.XtraForm
    {
        public frmActivityHistory()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            var gridId = new GridColumn() { Caption = "Mã số", Visible = true, FieldName = "ActivityId" };
            var gridActionType = new GridColumn() { Caption = "Loại hành động", Visible = true, FieldName = "ActionType" };
            var gridDescription = new GridColumn() { Caption = "Mô tả hành động", Visible = true, FieldName = "ActionDescription" };
            var gridUserName = new GridColumn() { Caption = "Người thực hiện", Visible = true, FieldName = "UserName" };
            var gridDisplayName = new GridColumn() { Caption = "Tên hiển thị", Visible = true, FieldName = "DisplayName" };
            var gridCreatedAt = new GridColumn() { Caption = "Ngày tạo", Visible = true, FieldName = "CreatedAt" };
            gridCreatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridCreatedAt.DisplayFormat.FormatString = "dd/MM/yyyy";

            if (cboActitityHistoryActionType.Items.Count == 0)
            {
                List<string> type = ActivityType.GetAllConstantValues();
                foreach (var item in type)
                {
                    cboActitityHistoryActionType.Items.Add(item);

                }
            }

            gridViewActivityHistory.Columns.Clear();
            gridViewActivityHistory.Columns.AddRange(new GridColumn[] { gridId, gridActionType, gridDescription, gridUserName, gridDisplayName, gridCreatedAt });

            string msgError = "";
            dataGridViewActivityHistory.DataSource = ActivityHistoryServices.Instance.Load(out msgError);
            if (msgError != "")
            {
                MessageBox.Show(msgError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadActivityHistory_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void btnExportExcelVehicles_Click(object sender, EventArgs e)
        {
            if (ExportExcelFile.Instance.ExportExcel("Danh sách lịch sử hoạt động", gridViewActivityHistory))
            {
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Create History
                ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID), ActivityType.Export, "Xuất file lịch sử hoạt động");
            }
            else
            {
                MessageBox.Show("Xuất file thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilterActivityHistory_Click(object sender, EventArgs e)
        {

            string msgError = "";
            if(cboActitityHistoryActionType.SelectedIndex == -1 && tbActivityHistoryUserName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ít nhất 1 trường để lọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridViewActivityHistory.DataSource = ActivityHistoryServices.Instance.Filter(out msgError, cboActitityHistoryActionType.Text, tbActivityHistoryUserName.Text);
            if (msgError != "")
            {
                MessageBox.Show(msgError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}