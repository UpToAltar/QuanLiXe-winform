
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;
using QuanLiXe.DTO;
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
    public partial class FrmReport : DevExpress.XtraEditors.XtraForm
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            string msgError = "";

            reportViewer1.LocalReport.ReportPath = "FReport.rdlc";
            List<VehiclesDTO> list = VehiclesServices.Instance.Load(out msgError);
            var parameter = new List<ReportParameter>();
            parameter.Add(new ReportParameter("UserName", RecentUser.DisplayName));
            parameter.Add(new ReportParameter("Count", list.Count.ToString()));
            parameter.Add(new ReportParameter("Day", DateTime.Now.Day.ToString()));
            parameter.Add(new ReportParameter("Month", DateTime.Now.Month.ToString()));
            parameter.Add(new ReportParameter("Year", DateTime.Now.Year.ToString()));
            this.reportViewer1.LocalReport.SetParameters(parameter); 
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("VehiclesList", list));

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            // Thiết lập tên file khi tải xuống
            reportViewer1.LocalReport.DisplayName = "Báo cáo thống kê danh sách xe";
            ActivityHistoryServices.Instance.CreateActivityHistory(Int32.Parse(RecentUser.ID),ActivityType.Export,"Xuất báo cáo thống kê danh sách xe");
        }
    }
}