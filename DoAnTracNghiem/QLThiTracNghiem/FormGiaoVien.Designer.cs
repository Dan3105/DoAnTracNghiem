namespace QLThiTracNghiem
{
	partial class FormGiaoVien
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label hOCVILabel;
            System.Windows.Forms.Label mAKHLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoVien));
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.DB_THI_TN = new QLThiTracNghiem.DB_THI_TN();
            this.KhoaTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.KhoaTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager();
            this.GiaovienTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.GiaovienTableAdapter();
            this.bdsGiaoVien = new System.Windows.Forms.BindingSource(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbCoSo = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcKHOA = new DevExpress.XtraGrid.GridControl();
            this.gvKHOA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelGIAOVIEN = new DevExpress.XtraEditors.PanelControl();
            this.btnUndoGIAOVIEN = new System.Windows.Forms.Button();
            this.btnGhiGIAOVIEN = new System.Windows.Forms.Button();
            this.cbHOCVI = new System.Windows.Forms.ComboBox();
            this.txtFKMAKH = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.txtMAGIAOVIEN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelKHOA = new DevExpress.XtraEditors.PanelControl();
            this.txtMACS = new DevExpress.XtraEditors.TextEdit();
            this.txtTENKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMAKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcGIAOVIEN = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themGiaoVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaGiaoVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaGiaoVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvGIAOVIEN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.BodeTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.BodeTableAdapter();
            this.bdsGiaoVien_DangKy = new System.Windows.Forms.BindingSource(this.components);
            this.Giaovien_DangkyTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.Giaovien_DangkyTableAdapter();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            hOCVILabel = new System.Windows.Forms.Label();
            mAKHLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelGIAOVIEN)).BeginInit();
            this.panelGIAOVIEN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFKMAKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGIAOVIEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelKHOA)).BeginInit();
            this.panelKHOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGIAOVIEN)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGIAOVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien_DangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(17, 39);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(52, 13);
            mAKHLabel.TabIndex = 1;
            mAKHLabel.Text = "Mã Khoa:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(13, 80);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(56, 13);
            tENKHLabel.TabIndex = 3;
            tENKHLabel.Text = "Tên Khoa:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(206, 8);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(53, 13);
            mACSLabel.TabIndex = 5;
            mACSLabel.Text = "Mã cơ sở:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(17, 48);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(41, 13);
            mAGVLabel.TabIndex = 1;
            mAGVLabel.Text = "Mã GV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(17, 83);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(43, 13);
            hOLabel.TabIndex = 3;
            hOLabel.Text = "Họ tên:";
            // 
            // hOCVILabel
            // 
            hOCVILabel.AutoSize = true;
            hOCVILabel.Location = new System.Drawing.Point(206, 48);
            hOCVILabel.Name = "hOCVILabel";
            hOCVILabel.Size = new System.Drawing.Size(40, 13);
            hOCVILabel.TabIndex = 7;
            hOCVILabel.Text = "Học vị:";
            // 
            // mAKHLabel1
            // 
            mAKHLabel1.AutoSize = true;
            mAKHLabel1.Location = new System.Drawing.Point(206, 18);
            mAKHLabel1.Name = "mAKHLabel1";
            mAKHLabel1.Size = new System.Drawing.Size(51, 13);
            mAKHLabel1.TabIndex = 8;
            mAKHLabel1.Text = "Mã khoa:";
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "Khoa";
            this.bdsKhoa.DataSource = this.DB_THI_TN;
            // 
            // DB_THI_TN
            // 
            this.DB_THI_TN.DataSetName = "DB_THI_TN";
            this.DB_THI_TN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KhoaTableAdapter
            // 
            this.KhoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemTableAdapter = null;
            this.tableAdapterManager.BodeTableAdapter = null;
            this.tableAdapterManager.ChiTiet_BaiThiTableAdapter = null;
            this.tableAdapterManager.Giaovien_DangkyTableAdapter = null;
            this.tableAdapterManager.GiaovienTableAdapter = this.GiaovienTableAdapter;
            this.tableAdapterManager.KhoaTableAdapter = this.KhoaTableAdapter;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonhocTableAdapter = null;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // GiaovienTableAdapter
            // 
            this.GiaovienTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGiaoVien
            // 
            this.bdsGiaoVien.DataMember = "FK_Giaovien_Khoa";
            this.bdsGiaoVien.DataSource = this.bdsKhoa;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 45);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1093, 0);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnUndo,
            this.btnReload,
            this.btnSua});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Them";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sua";
            this.btnSua.Id = 5;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phuc hoi";
            this.btnUndo.Id = 3;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(1093, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 606);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1093, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 561);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1093, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 561);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbCoSo);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 45);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1093, 40);
            this.panelControl1.TabIndex = 6;
            // 
            // cbCoSo
            // 
            this.cbCoSo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCoSo.FormattingEnabled = true;
            this.cbCoSo.Location = new System.Drawing.Point(61, 11);
            this.cbCoSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCoSo.Name = "cbCoSo";
            this.cbCoSo.Size = new System.Drawing.Size(175, 21);
            this.cbCoSo.TabIndex = 1;
            this.cbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbCoSo_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cơ sở";
            // 
            // gcKHOA
            // 
            this.gcKHOA.DataSource = this.bdsKhoa;
            this.gcKHOA.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKHOA.Location = new System.Drawing.Point(0, 85);
            this.gcKHOA.MainView = this.gvKHOA;
            this.gcKHOA.MenuManager = this.barManager1;
            this.gcKHOA.Name = "gcKHOA";
            this.gcKHOA.Size = new System.Drawing.Size(1093, 200);
            this.gcKHOA.TabIndex = 6;
            this.gcKHOA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKHOA});
            // 
            // gvKHOA
            // 
            this.gvKHOA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gvKHOA.GridControl = this.gcKHOA;
            this.gvKHOA.Name = "gvKHOA";
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelGIAOVIEN);
            this.panelControl2.Controls.Add(this.panelKHOA);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 285);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(397, 321);
            this.panelControl2.TabIndex = 7;
            // 
            // panelGIAOVIEN
            // 
            this.panelGIAOVIEN.Controls.Add(this.btnUndoGIAOVIEN);
            this.panelGIAOVIEN.Controls.Add(this.btnGhiGIAOVIEN);
            this.panelGIAOVIEN.Controls.Add(this.cbHOCVI);
            this.panelGIAOVIEN.Controls.Add(mAKHLabel1);
            this.panelGIAOVIEN.Controls.Add(this.txtFKMAKH);
            this.panelGIAOVIEN.Controls.Add(hOCVILabel);
            this.panelGIAOVIEN.Controls.Add(this.txtTEN);
            this.panelGIAOVIEN.Controls.Add(hOLabel);
            this.panelGIAOVIEN.Controls.Add(this.txtHO);
            this.panelGIAOVIEN.Controls.Add(mAGVLabel);
            this.panelGIAOVIEN.Controls.Add(this.txtMAGIAOVIEN);
            this.panelGIAOVIEN.Controls.Add(this.labelControl3);
            this.panelGIAOVIEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGIAOVIEN.Location = new System.Drawing.Point(2, 128);
            this.panelGIAOVIEN.Name = "panelGIAOVIEN";
            this.panelGIAOVIEN.Size = new System.Drawing.Size(393, 191);
            this.panelGIAOVIEN.TabIndex = 1;
            // 
            // btnUndoGIAOVIEN
            // 
            this.btnUndoGIAOVIEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndoGIAOVIEN.Location = new System.Drawing.Point(267, 128);
            this.btnUndoGIAOVIEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUndoGIAOVIEN.Name = "btnUndoGIAOVIEN";
            this.btnUndoGIAOVIEN.Size = new System.Drawing.Size(64, 24);
            this.btnUndoGIAOVIEN.TabIndex = 12;
            this.btnUndoGIAOVIEN.Text = "Undo";
            this.btnUndoGIAOVIEN.UseVisualStyleBackColor = true;
            this.btnUndoGIAOVIEN.Click += new System.EventHandler(this.btnUndoGIAOVIEN_Click);
            // 
            // btnGhiGIAOVIEN
            // 
            this.btnGhiGIAOVIEN.Location = new System.Drawing.Point(82, 128);
            this.btnGhiGIAOVIEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGhiGIAOVIEN.Name = "btnGhiGIAOVIEN";
            this.btnGhiGIAOVIEN.Size = new System.Drawing.Size(64, 24);
            this.btnGhiGIAOVIEN.TabIndex = 11;
            this.btnGhiGIAOVIEN.Text = "Ghi";
            this.btnGhiGIAOVIEN.UseVisualStyleBackColor = true;
            this.btnGhiGIAOVIEN.Click += new System.EventHandler(this.btnGhiGIAOVIEN_Click);
            // 
            // cbHOCVI
            // 
            this.cbHOCVI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiaoVien, "HOCVI", true));
            this.cbHOCVI.FormattingEnabled = true;
            this.cbHOCVI.Location = new System.Drawing.Point(267, 48);
            this.cbHOCVI.Name = "cbHOCVI";
            this.cbHOCVI.Size = new System.Drawing.Size(121, 21);
            this.cbHOCVI.TabIndex = 10;
            // 
            // txtFKMAKH
            // 
            this.txtFKMAKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "MAKH", true));
            this.txtFKMAKH.Enabled = false;
            this.txtFKMAKH.Location = new System.Drawing.Point(267, 11);
            this.txtFKMAKH.MenuManager = this.barManager1;
            this.txtFKMAKH.Name = "txtFKMAKH";
            this.txtFKMAKH.Size = new System.Drawing.Size(100, 20);
            this.txtFKMAKH.TabIndex = 9;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(267, 80);
            this.txtTEN.MenuManager = this.barManager1;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(100, 20);
            this.txtTEN.TabIndex = 6;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(82, 80);
            this.txtHO.MenuManager = this.barManager1;
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(175, 20);
            this.txtHO.TabIndex = 4;
            // 
            // txtMAGIAOVIEN
            // 
            this.txtMAGIAOVIEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaoVien, "MAGV", true));
            this.txtMAGIAOVIEN.Location = new System.Drawing.Point(82, 45);
            this.txtMAGIAOVIEN.MenuManager = this.barManager1;
            this.txtMAGIAOVIEN.Name = "txtMAGIAOVIEN";
            this.txtMAGIAOVIEN.Size = new System.Drawing.Size(100, 20);
            this.txtMAGIAOVIEN.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(121, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Thông tin giáo viên";
            // 
            // panelKHOA
            // 
            this.panelKHOA.Controls.Add(mACSLabel);
            this.panelKHOA.Controls.Add(this.txtMACS);
            this.panelKHOA.Controls.Add(tENKHLabel);
            this.panelKHOA.Controls.Add(this.txtTENKH);
            this.panelKHOA.Controls.Add(mAKHLabel);
            this.panelKHOA.Controls.Add(this.txtMAKH);
            this.panelKHOA.Controls.Add(this.labelControl2);
            this.panelKHOA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKHOA.Location = new System.Drawing.Point(2, 2);
            this.panelKHOA.Name = "panelKHOA";
            this.panelKHOA.Size = new System.Drawing.Size(393, 126);
            this.panelKHOA.TabIndex = 0;
            // 
            // txtMACS
            // 
            this.txtMACS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MACS", true));
            this.txtMACS.Enabled = false;
            this.txtMACS.Location = new System.Drawing.Point(267, 5);
            this.txtMACS.MenuManager = this.barManager1;
            this.txtMACS.Name = "txtMACS";
            this.txtMACS.Size = new System.Drawing.Size(100, 20);
            this.txtMACS.TabIndex = 6;
            // 
            // txtTENKH
            // 
            this.txtTENKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "TENKH", true));
            this.txtTENKH.Location = new System.Drawing.Point(82, 77);
            this.txtTENKH.MenuManager = this.barManager1;
            this.txtTENKH.Name = "txtTENKH";
            this.txtTENKH.Size = new System.Drawing.Size(100, 20);
            this.txtTENKH.TabIndex = 4;
            // 
            // txtMAKH
            // 
            this.txtMAKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MAKH", true));
            this.txtMAKH.Location = new System.Drawing.Point(82, 36);
            this.txtMAKH.MenuManager = this.barManager1;
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(100, 20);
            this.txtMAKH.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Thông tin khoa";
            // 
            // gcGIAOVIEN
            // 
            this.gcGIAOVIEN.DataSource = this.bdsGiaoVien;
            this.gcGIAOVIEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGIAOVIEN.EmbeddedNavigator.ContextMenuStrip = this.contextMenuStrip1;
            this.gcGIAOVIEN.Location = new System.Drawing.Point(397, 285);
            this.gcGIAOVIEN.MainView = this.gvGIAOVIEN;
            this.gcGIAOVIEN.MenuManager = this.barManager1;
            this.gcGIAOVIEN.Name = "gcGIAOVIEN";
            this.gcGIAOVIEN.Size = new System.Drawing.Size(696, 321);
            this.gcGIAOVIEN.TabIndex = 8;
            this.gcGIAOVIEN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGIAOVIEN});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themGiaoVienToolStripMenuItem,
            this.suaGiaoVienToolStripMenuItem,
            this.xoaGiaoVienToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 70);
            // 
            // themGiaoVienToolStripMenuItem
            // 
            this.themGiaoVienToolStripMenuItem.Name = "themGiaoVienToolStripMenuItem";
            this.themGiaoVienToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.themGiaoVienToolStripMenuItem.Text = "Nhập thêm giáo viên";
            this.themGiaoVienToolStripMenuItem.Click += new System.EventHandler(this.themGiaoVienToolStripMenuItem_Click);
            // 
            // suaGiaoVienToolStripMenuItem
            // 
            this.suaGiaoVienToolStripMenuItem.Name = "suaGiaoVienToolStripMenuItem";
            this.suaGiaoVienToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.suaGiaoVienToolStripMenuItem.Text = "Sửa giáo viên";
            this.suaGiaoVienToolStripMenuItem.Click += new System.EventHandler(this.suaGiaoVienToolStripMenuItem_Click);
            // 
            // xoaGiaoVienToolStripMenuItem
            // 
            this.xoaGiaoVienToolStripMenuItem.Name = "xoaGiaoVienToolStripMenuItem";
            this.xoaGiaoVienToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.xoaGiaoVienToolStripMenuItem.Text = "Xóa giáo viên";
            this.xoaGiaoVienToolStripMenuItem.Click += new System.EventHandler(this.xoaGiaoVienToolStripMenuItem_Click);
            // 
            // gvGIAOVIEN
            // 
            this.gvGIAOVIEN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colHOCVI,
            this.colMAKH1});
            this.gvGIAOVIEN.GridControl = this.gcGIAOVIEN;
            this.gvGIAOVIEN.Name = "gvGIAOVIEN";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colHOCVI
            // 
            this.colHOCVI.FieldName = "HOCVI";
            this.colHOCVI.Name = "colHOCVI";
            this.colHOCVI.Visible = true;
            this.colHOCVI.VisibleIndex = 3;
            // 
            // colMAKH1
            // 
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 4;
            // 
            // bdsBoDe
            // 
            this.bdsBoDe.DataMember = "FK_Bode_Giaovien";
            this.bdsBoDe.DataSource = this.bdsGiaoVien;
            // 
            // BodeTableAdapter
            // 
            this.BodeTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGiaoVien_DangKy
            // 
            this.bdsGiaoVien_DangKy.DataMember = "FK_Giaovien_Dangky_Giaovien";
            this.bdsGiaoVien_DangKy.DataSource = this.bdsGiaoVien;
            // 
            // Giaovien_DangkyTableAdapter
            // 
            this.Giaovien_DangkyTableAdapter.ClearBeforeFill = true;
            // 
            // FormGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 626);
            this.Controls.Add(this.gcGIAOVIEN);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcKHOA);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormGiaoVien";
            this.Text = "FormGiangVien";
            this.Load += new System.EventHandler(this.FormGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelGIAOVIEN)).EndInit();
            this.panelGIAOVIEN.ResumeLayout(false);
            this.panelGIAOVIEN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFKMAKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGIAOVIEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelKHOA)).EndInit();
            this.panelKHOA.ResumeLayout(false);
            this.panelKHOA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGIAOVIEN)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGIAOVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien_DangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private DB_THI_TN DB_THI_TN;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DB_THI_TNTableAdapters.KhoaTableAdapter KhoaTableAdapter;
        private DB_THI_TNTableAdapters.TableAdapterManager tableAdapterManager;
        private DB_THI_TNTableAdapters.GiaovienTableAdapter GiaovienTableAdapter;
        private System.Windows.Forms.BindingSource bdsGiaoVien;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbCoSo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcGIAOVIEN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGIAOVIEN;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcKHOA;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKHOA;
        private DevExpress.XtraEditors.PanelControl panelGIAOVIEN;
        private DevExpress.XtraEditors.PanelControl panelKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTENKH;
        private DevExpress.XtraEditors.TextEdit txtMAKH;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraEditors.TextEdit txtMACS;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.TextEdit txtHO;
        private DevExpress.XtraEditors.TextEdit txtMAGIAOVIEN;
        private DevExpress.XtraEditors.TextEdit txtFKMAKH;
        private System.Windows.Forms.BindingSource bdsBoDe;
        private DB_THI_TNTableAdapters.BodeTableAdapter BodeTableAdapter;
        private System.Windows.Forms.BindingSource bdsGiaoVien_DangKy;
        private DB_THI_TNTableAdapters.Giaovien_DangkyTableAdapter Giaovien_DangkyTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themGiaoVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaGiaoVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaGiaoVienToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbHOCVI;
        private System.Windows.Forms.Button btnGhiGIAOVIEN;
        private System.Windows.Forms.Button btnUndoGIAOVIEN;
    }
}