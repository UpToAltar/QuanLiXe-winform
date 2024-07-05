using DevExpress.Export;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Native.ExportOptionsControllers;
using QuanLiXe.Services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe.Helper
{
    internal class ExportExcelFile
    {
        private static ExportExcelFile checkLogin;

        public static ExportExcelFile Instance
        {
            get
            {
                if (checkLogin == null)
                {
                    checkLogin = new ExportExcelFile();
                }
                return checkLogin;
            }
            private set
            {
                checkLogin = value;
            }
        }

        private ExportExcelFile() { }

        public bool ExportExcel(string fileName, GridView gridView)
        {
            try
            {
                if (gridView.FocusedRowHandle < 0)
                {
                    return false;
                }
                else
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = "Save Excel File";
                    dialog.Filter = "Excel file (*.xlsx)|*.xlsx";
                    dialog.FileName = fileName;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gridView.ColumnPanelRowHeight = 40;
                        gridView.OptionsPrint.AutoWidth = false; // Tắt AutoWidth để tránh điều chỉnh không mong muốn
                        gridView.BestFitColumns(); // Điều chỉnh kích thước cột theo nội dung
                        gridView.OptionsPrint.PrintHeader = true;
                        gridView.OptionsPrint.ShowPrintExportProgress = true;
                        gridView.OptionsPrint.AllowCancelPrintExport = true;

                        foreach (GridColumn column in gridView.Columns)
                        {
                            column.BestFit(); // Đảm bảo mỗi cột được điều chỉnh phù hợp
                        }

                        XlsxExportOptionsEx options = new XlsxExportOptionsEx();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = "Sheet1";
                         // Đảm bảo nội dung tự động điều chỉnh kích thước

                        ExportSettings.DefaultExportType = ExportType.WYSIWYG;

                        gridView.ExportToXlsx(dialog.FileName, options);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
