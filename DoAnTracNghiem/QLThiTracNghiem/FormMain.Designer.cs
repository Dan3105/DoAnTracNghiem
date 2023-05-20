namespace QLThiTracNghiem
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MAUSER = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnSignup = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnMONHOC = new DevExpress.XtraBars.BarButtonItem();
            this.btnKHOA = new DevExpress.XtraBars.BarSubItem();
            this.barBtnLop = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSINHVIEN = new DevExpress.XtraBars.BarButtonItem();
            this.rbSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPageUser = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQuanly = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDKThi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDkyThi = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAUSER,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 586);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MAUSER
            // 
            this.MAUSER.Name = "MAUSER";
            this.MAUSER.Size = new System.Drawing.Size(67, 20);
            this.MAUSER.Text = "MAUSER";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(57, 20);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(55, 20);
            this.NHOM.Text = "NHOM";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(46);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnLogin,
            this.btnSignup,
            this.btnLogout,
            this.btnMONHOC,
            this.btnKHOA,
            this.barBtnLop,
            this.barBtnSINHVIEN,
            this.btnDkyThi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 515;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbSystem});
            this.ribbonControl1.Size = new System.Drawing.Size(879, 183);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng Nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnSignup
            // 
            this.btnSignup.Caption = "Tạo Tài Khoản";
            this.btnSignup.Id = 2;
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSignup_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 3;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnMONHOC
            // 
            this.btnMONHOC.Caption = "Quan ly Mon hoc";
            this.btnMONHOC.Id = 4;
            this.btnMONHOC.ImageOptions.ImageUri.Uri = "icon%20builder/actions_book";
            this.btnMONHOC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMONHOC.ImageOptions.SvgImage")));
            this.btnMONHOC.LargeWidth = 70;
            this.btnMONHOC.Name = "btnMONHOC";
            this.btnMONHOC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonhoc_ItemClick);
            // 
            // btnKHOA
            // 
            this.btnKHOA.Caption = "Quản lý Khoa";
            this.btnKHOA.Id = 10;
            this.btnKHOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKHOA.ImageOptions.SvgImage")));
            this.btnKHOA.LargeWidth = 79;
            this.btnKHOA.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnLop),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSINHVIEN)});
            this.btnKHOA.Name = "btnKHOA";
            this.btnKHOA.SmallWithTextWidth = 70;
            // 
            // barBtnLop
            // 
            this.barBtnLop.Caption = "Quản lý lớp";
            this.barBtnLop.Id = 12;
            this.barBtnLop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnLop.ImageOptions.SvgImage")));
            this.barBtnLop.Name = "barBtnLop";
            this.barBtnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLop_ItemClick);
            // 
            // barBtnSINHVIEN
            // 
            this.barBtnSINHVIEN.Caption = "Quản lý Sinh Viên";
            this.barBtnSINHVIEN.Id = 13;
            this.barBtnSINHVIEN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSINHVIEN.ImageOptions.SvgImage")));
            this.barBtnSINHVIEN.Name = "barBtnSINHVIEN";
            this.barBtnSINHVIEN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSINHVIEN_ItemClick);
            // 
            // rbSystem
            // 
            this.rbSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPageUser,
            this.rbQuanly,
            this.rbDKThi});
            this.rbSystem.Name = "rbSystem";
            this.rbSystem.Text = "Hệ Thống";
            // 
            // rbPageUser
            // 
            this.rbPageUser.ItemLinks.Add(this.btnLogin);
            this.rbPageUser.ItemLinks.Add(this.btnSignup);
            this.rbPageUser.ItemLinks.Add(this.btnLogout);
            this.rbPageUser.Name = "rbPageUser";
            // 
            // rbQuanly
            // 
            this.rbQuanly.ItemLinks.Add(this.btnMONHOC);
            this.rbQuanly.ItemLinks.Add(this.btnKHOA);
            this.rbQuanly.Name = "rbQuanly";
            this.rbQuanly.Text = "Quản lý dữ liệu";
            this.rbQuanly.Visible = false;
            // 
            // rbDKThi
            // 
            this.rbDKThi.ItemLinks.Add(this.btnDkyThi);
            this.rbDKThi.Name = "rbDKThi";
            this.rbDKThi.Visible = false;
            // 
            // btnDkyThi
            // 
            this.btnDkyThi.Caption = "Đăng ký Thi";
            this.btnDkyThi.Id = 14;
            this.btnDkyThi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDkyThi.ImageOptions.SvgImage")));
            this.btnDkyThi.Name = "btnDkyThi";
            this.btnDkyThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDkyThi_ItemClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 612);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MAUSER;
        private System.Windows.Forms.ToolStripStatusLabel HOTEN;
        private System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnSignup;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnMONHOC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbQuanly;
        private DevExpress.XtraBars.BarSubItem btnKHOA;
        private DevExpress.XtraBars.BarButtonItem barBtnLop;
        private DevExpress.XtraBars.BarButtonItem barBtnSINHVIEN;
        private DevExpress.XtraBars.BarButtonItem btnDkyThi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDKThi;
    }
}