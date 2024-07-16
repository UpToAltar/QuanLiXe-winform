namespace QuanLiXe
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAutomaker = new DevExpress.XtraBars.BarButtonItem();
            this.btnOwner = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnMyAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdminUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnActivityHistory = new DevExpress.XtraBars.BarButtonItem();
            this.homePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupCar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupOwner = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupUser = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.adminPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupAdmin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pageAutomaker = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageAutomaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnCar,
            this.btnAutomaker,
            this.btnOwner,
            this.barButtonItem2,
            this.btnMyAccount,
            this.btnAdminUser,
            this.btnActivityHistory});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homePage,
            this.adminPage});
            this.ribbon.Size = new System.Drawing.Size(1405, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnCar
            // 
            this.btnCar.Caption = "Xe";
            this.btnCar.Id = 1;
            this.btnCar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCar.ImageOptions.LargeImage")));
            this.btnCar.Name = "btnCar";
            this.btnCar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCar_ItemClick);
            // 
            // btnAutomaker
            // 
            this.btnAutomaker.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnAutomaker.Caption = "Hãng Xe";
            this.btnAutomaker.Id = 2;
            this.btnAutomaker.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAutomaker.ImageOptions.LargeImage")));
            this.btnAutomaker.Name = "btnAutomaker";
            this.btnAutomaker.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAutomaker_ItemClick);
            // 
            // btnOwner
            // 
            this.btnOwner.Caption = "Chủ xe";
            this.btnOwner.Id = 3;
            this.btnOwner.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOwner.ImageOptions.LargeImage")));
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOwner_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.Caption = "Thông tin cá nhân";
            this.btnMyAccount.Id = 5;
            this.btnMyAccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMyAccount.ImageOptions.LargeImage")));
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMyAccount_ItemClick);
            // 
            // btnAdminUser
            // 
            this.btnAdminUser.Caption = "Người dùng";
            this.btnAdminUser.Id = 6;
            this.btnAdminUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdminUser.ImageOptions.LargeImage")));
            this.btnAdminUser.Name = "btnAdminUser";
            this.btnAdminUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnActivityHistory
            // 
            this.btnActivityHistory.Caption = "Lịch sử hoạt động";
            this.btnActivityHistory.Id = 7;
            this.btnActivityHistory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActivityHistory.ImageOptions.SvgImage")));
            this.btnActivityHistory.Name = "btnActivityHistory";
            this.btnActivityHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActivityHistory_ItemClick);
            // 
            // homePage
            // 
            this.homePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupCar,
            this.groupOwner,
            this.groupUser});
            this.homePage.Name = "homePage";
            this.homePage.Text = "Trang chủ";
            // 
            // groupCar
            // 
            this.groupCar.ItemLinks.Add(this.btnCar, true);
            this.groupCar.ItemLinks.Add(this.btnAutomaker);
            this.groupCar.Name = "groupCar";
            this.groupCar.Text = "Quản lí xe";
            // 
            // groupOwner
            // 
            this.groupOwner.ItemLinks.Add(this.btnOwner);
            this.groupOwner.Name = "groupOwner";
            this.groupOwner.Text = "Quản lí khách hàng";
            // 
            // groupUser
            // 
            this.groupUser.ItemLinks.Add(this.btnMyAccount);
            this.groupUser.Name = "groupUser";
            this.groupUser.Text = "Cá nhân";
            // 
            // adminPage
            // 
            this.adminPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupAdmin});
            this.adminPage.Name = "adminPage";
            this.adminPage.Text = "Quản trị";
            // 
            // groupAdmin
            // 
            this.groupAdmin.ItemLinks.Add(this.btnAdminUser);
            this.groupAdmin.ItemLinks.Add(this.btnActivityHistory);
            this.groupAdmin.Name = "groupAdmin";
            this.groupAdmin.Text = "Quản trị";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 952);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1405, 30);
            // 
            // pageAutomaker
            // 
            this.pageAutomaker.MdiParent = this;
            this.pageAutomaker.MenuManager = this.ribbon;
            this.pageAutomaker.View = this.tabbedView1;
            this.pageAutomaker.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 982);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản Lí Xe";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageAutomaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage homePage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupCar;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnCar;
        private DevExpress.XtraBars.BarButtonItem btnAutomaker;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupOwner;
        private DevExpress.XtraBars.BarButtonItem btnOwner;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnMyAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupUser;
        private DevExpress.XtraBars.BarButtonItem btnAdminUser;
        public DevExpress.XtraBars.Ribbon.RibbonPage adminPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupAdmin;
        private DevExpress.XtraBars.Docking2010.DocumentManager pageAutomaker;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnActivityHistory;
    }
}