using DevExpress.XtraBars;
using QuanLiXe.DTO;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        void OpenForm(Type typeForm)
        {
            foreach (var form in MdiChildren)
            {
                if (form.GetType() == typeForm)
                {
                    form.Activate();
                    return;
                }
            }
            Form newForm = (Form)Activator.CreateInstance(typeForm);
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnAutomaker_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmAutomaker));
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnOwner_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmOwner));
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(RecentUser.Role != "Quản trị viên")
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenForm(typeof(frmAccount));
        }

        private void btnCar_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmVehicles));
        }

        private void btnMyAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmMyAccount));
        }

        private void btnActivityHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (RecentUser.Role != "Quản trị viên")
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenForm(typeof(frmActivityHistory));
        }
    }
}