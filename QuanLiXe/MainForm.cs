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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
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
            OpenForm(typeof(AutomakerForm));
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnOwner_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(OwnerForm));
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(RecentUser.Role != "Quản trị viên")
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenForm(typeof(AccountForm));
        }

        private void btnCar_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(VehiclesForm));
        }

        private void btnMyAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(MyAccountForm));
        }
    }
}