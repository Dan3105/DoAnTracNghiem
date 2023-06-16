namespace QLThiTracNghiem
{
    partial class FormKhoaLop
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
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label tENKHOALabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label mAKHOALabel1;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoaLop));
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.DB_THI_TN = new QLThiTracNghiem.DB_THI_TN();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gcKHOA = new DevExpress.XtraGrid.GridControl();
            this.gvKHOA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelKHOA = new DevExpress.XtraEditors.PanelControl();
            this.txtMACS = new DevExpress.XtraEditors.TextEdit();
            this.txtTENKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMAKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelLOP = new DevExpress.XtraEditors.PanelControl();
            this.txtTENLOP = new DevExpress.XtraEditors.TextEdit();
            this.txtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.txtFKMAKH = new DevExpress.XtraEditors.TextEdit();
            this.btnUndoLOP = new System.Windows.Forms.Button();
            this.btnGhiLOP = new System.Windows.Forms.Button();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gcLOP = new DevExpress.XtraGrid.GridControl();
            this.gvLOP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbCoSo = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhoaTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.KhoaTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager();
            this.LopTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.LopTableAdapter();
            this.bdsGiaovien_Dangky = new System.Windows.Forms.BindingSource(this.components);
            this.Giaovien_DangkyTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.Giaovien_DangkyTableAdapter();
            this.bdsSinhvien = new System.Windows.Forms.BindingSource(this.components);
            this.SinhvienTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.SinhvienTableAdapter();
            this.bdsGiaovien = new System.Windows.Forms.BindingSource(this.components);
            this.GiaovienTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.GiaovienTableAdapter();
            mACSLabel = new System.Windows.Forms.Label();
            tENKHOALabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            mAKHOALabel1 = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKHOA)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelKHOA)).BeginInit();
            this.panelKHOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLOP)).BeginInit();
            this.panelLOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENLOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFKMAKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaovien_Dangky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaovien)).BeginInit();
            this.SuspendLayout();
            // 
            // mACSLabel
            // 
            mACSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            mACSLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACSLabel.Location = new System.Drawing.Point(262, 20);
            mACSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(90, 28);
            mACSLabel.TabIndex = 1;
            mACSLabel.Text = "Mã Cơ sở:";
            // 
            // tENKHOALabel
            // 
            tENKHOALabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHOALabel.Location = new System.Drawing.Point(27, 103);
            tENKHOALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENKHOALabel.Name = "tENKHOALabel";
            tENKHOALabel.Size = new System.Drawing.Size(89, 30);
            tENKHOALabel.TabIndex = 3;
            tENKHOALabel.Text = "Tên Khoa:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOALabel.Location = new System.Drawing.Point(27, 63);
            mAKHOALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(89, 34);
            mAKHOALabel.TabIndex = 5;
            mAKHOALabel.Text = "Mã Khoa:";
            // 
            // mAKHOALabel1
            // 
            mAKHOALabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            mAKHOALabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOALabel1.Location = new System.Drawing.Point(259, 22);
            mAKHOALabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAKHOALabel1.Name = "mAKHOALabel1";
            mAKHOALabel1.Size = new System.Drawing.Size(92, 28);
            mAKHOALabel1.TabIndex = 1;
            mAKHOALabel1.Text = "Mã Khoa:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(27, 58);
            mALOPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(85, 34);
            mALOPLabel.TabIndex = 3;
            mALOPLabel.Text = "Mã Lớp:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(27, 103);
            tENLOPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(85, 33);
            tENLOPLabel.TabIndex = 5;
            tENLOPLabel.Text = "Tên Lớp:";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "FK_Lop_Khoa";
            this.bdsLop.DataSource = this.bdsKhoa;
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
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
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
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1526, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 768);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1526, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 738);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1526, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 738);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1526, 738);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gcKHOA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1526, 689);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gcKHOA
            // 
            this.gcKHOA.DataSource = this.bdsKhoa;
            this.gcKHOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKHOA.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcKHOA.Location = new System.Drawing.Point(4, 2);
            this.gcKHOA.MainView = this.gvKHOA;
            this.gcKHOA.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcKHOA.MenuManager = this.barManager1;
            this.gcKHOA.Name = "gcKHOA";
            this.gcKHOA.Size = new System.Drawing.Size(1518, 271);
            this.gcKHOA.TabIndex = 1;
            this.gcKHOA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKHOA});
            // 
            // gvKHOA
            // 
            this.gvKHOA.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvKHOA.Appearance.Row.Options.UseFont = true;
            this.gvKHOA.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvKHOA.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gvKHOA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH});
            this.gvKHOA.GridControl = this.gcKHOA;
            this.gvKHOA.Name = "gvKHOA";
            this.gvKHOA.OptionsView.RowAutoHeight = true;
            // 
            // colMAKH
            // 
            this.colMAKH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKH.AppearanceCell.Options.UseFont = true;
            this.colMAKH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKH.AppearanceHeader.Options.UseFont = true;
            this.colMAKH.Caption = "Mã khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 24;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 94;
            // 
            // colTENKH
            // 
            this.colTENKH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENKH.AppearanceCell.Options.UseFont = true;
            this.colTENKH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENKH.AppearanceHeader.Options.UseFont = true;
            this.colTENKH.Caption = "Tên khoa";
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 24;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 94;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.65717F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.34283F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gcLOP, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 277);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1518, 410);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panelKHOA, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelLOP, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.10386F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.89614F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(578, 406);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panelKHOA
            // 
            this.panelKHOA.Controls.Add(this.txtMACS);
            this.panelKHOA.Controls.Add(this.txtTENKH);
            this.panelKHOA.Controls.Add(this.txtMAKH);
            this.panelKHOA.Controls.Add(mAKHOALabel);
            this.panelKHOA.Controls.Add(tENKHOALabel);
            this.panelKHOA.Controls.Add(mACSLabel);
            this.panelKHOA.Controls.Add(this.labelControl2);
            this.panelKHOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKHOA.Location = new System.Drawing.Point(4, 2);
            this.panelKHOA.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelKHOA.Name = "panelKHOA";
            this.panelKHOA.Size = new System.Drawing.Size(570, 179);
            this.panelKHOA.TabIndex = 0;
            // 
            // txtMACS
            // 
            this.txtMACS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMACS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MACS", true));
            this.txtMACS.Enabled = false;
            this.txtMACS.Location = new System.Drawing.Point(359, 16);
            this.txtMACS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMACS.MenuManager = this.barManager1;
            this.txtMACS.Name = "txtMACS";
            this.txtMACS.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMACS.Properties.Appearance.Options.UseFont = true;
            this.txtMACS.Size = new System.Drawing.Size(115, 28);
            this.txtMACS.TabIndex = 8;
            // 
            // txtTENKH
            // 
            this.txtTENKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "TENKH", true));
            this.txtTENKH.Location = new System.Drawing.Point(122, 100);
            this.txtTENKH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTENKH.MenuManager = this.barManager1;
            this.txtTENKH.Name = "txtTENKH";
            this.txtTENKH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENKH.Properties.Appearance.Options.UseFont = true;
            this.txtTENKH.Size = new System.Drawing.Size(223, 28);
            this.txtTENKH.TabIndex = 7;
            // 
            // txtMAKH
            // 
            this.txtMAKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MAKH", true));
            this.txtMAKH.Location = new System.Drawing.Point(122, 59);
            this.txtMAKH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMAKH.MenuManager = this.barManager1;
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAKH.Properties.Appearance.Options.UseFont = true;
            this.txtMAKH.Size = new System.Drawing.Size(142, 28);
            this.txtMAKH.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 6);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(122, 22);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Thông tin Khoa";
            // 
            // panelLOP
            // 
            this.panelLOP.Controls.Add(this.txtTENLOP);
            this.panelLOP.Controls.Add(this.txtMALOP);
            this.panelLOP.Controls.Add(this.txtFKMAKH);
            this.panelLOP.Controls.Add(this.btnUndoLOP);
            this.panelLOP.Controls.Add(this.btnGhiLOP);
            this.panelLOP.Controls.Add(tENLOPLabel);
            this.panelLOP.Controls.Add(mALOPLabel);
            this.panelLOP.Controls.Add(mAKHOALabel1);
            this.panelLOP.Controls.Add(this.labelControl3);
            this.panelLOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLOP.Location = new System.Drawing.Point(4, 185);
            this.panelLOP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelLOP.Name = "panelLOP";
            this.panelLOP.Size = new System.Drawing.Size(570, 219);
            this.panelLOP.TabIndex = 1;
            // 
            // txtTENLOP
            // 
            this.txtTENLOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.txtTENLOP.Location = new System.Drawing.Point(122, 105);
            this.txtTENLOP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTENLOP.MenuManager = this.barManager1;
            this.txtTENLOP.Name = "txtTENLOP";
            this.txtTENLOP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENLOP.Properties.Appearance.Options.UseFont = true;
            this.txtTENLOP.Size = new System.Drawing.Size(215, 28);
            this.txtTENLOP.TabIndex = 13;
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtMALOP.Location = new System.Drawing.Point(122, 54);
            this.txtMALOP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMALOP.MenuManager = this.barManager1;
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMALOP.Properties.Appearance.Options.UseFont = true;
            this.txtMALOP.Size = new System.Drawing.Size(134, 28);
            this.txtMALOP.TabIndex = 12;
            // 
            // txtFKMAKH
            // 
            this.txtFKMAKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFKMAKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MAKH", true));
            this.txtFKMAKH.Enabled = false;
            this.txtFKMAKH.Location = new System.Drawing.Point(359, 18);
            this.txtFKMAKH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtFKMAKH.MenuManager = this.barManager1;
            this.txtFKMAKH.Name = "txtFKMAKH";
            this.txtFKMAKH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFKMAKH.Properties.Appearance.Options.UseFont = true;
            this.txtFKMAKH.Size = new System.Drawing.Size(115, 28);
            this.txtFKMAKH.TabIndex = 11;
            // 
            // btnUndoLOP
            // 
            this.btnUndoLOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndoLOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndoLOP.Location = new System.Drawing.Point(362, 158);
            this.btnUndoLOP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnUndoLOP.Name = "btnUndoLOP";
            this.btnUndoLOP.Size = new System.Drawing.Size(88, 39);
            this.btnUndoLOP.TabIndex = 10;
            this.btnUndoLOP.Text = "Undo";
            this.btnUndoLOP.UseVisualStyleBackColor = true;
            this.btnUndoLOP.Click += new System.EventHandler(this.btnUndoLOP_Click);
            // 
            // btnGhiLOP
            // 
            this.btnGhiLOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGhiLOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiLOP.Location = new System.Drawing.Point(91, 159);
            this.btnGhiLOP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGhiLOP.Name = "btnGhiLOP";
            this.btnGhiLOP.Size = new System.Drawing.Size(82, 38);
            this.btnGhiLOP.TabIndex = 9;
            this.btnGhiLOP.Text = "Ghi";
            this.btnGhiLOP.UseVisualStyleBackColor = true;
            this.btnGhiLOP.Click += new System.EventHandler(this.btnGhiLOP_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 6);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 22);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Thông tin lớp";
            // 
            // gcLOP
            // 
            this.gcLOP.DataSource = this.bdsLop;
            this.gcLOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLOP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcLOP.Location = new System.Drawing.Point(590, 2);
            this.gcLOP.MainView = this.gvLOP;
            this.gcLOP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcLOP.MenuManager = this.barManager1;
            this.gcLOP.Name = "gcLOP";
            this.gcLOP.Size = new System.Drawing.Size(924, 406);
            this.gcLOP.TabIndex = 1;
            this.gcLOP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLOP});
            // 
            // gvLOP
            // 
            this.gvLOP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP});
            this.gvLOP.GridControl = this.gcLOP;
            this.gvLOP.Name = "gvLOP";
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALOP.AppearanceCell.Options.UseFont = true;
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 24;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENLOP.AppearanceCell.Options.UseFont = true;
            this.colTENLOP.Caption = "Tên lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 24;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbCoSo);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1526, 49);
            this.panelControl1.TabIndex = 0;
            // 
            // cbCoSo
            // 
            this.cbCoSo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCoSo.FormattingEnabled = true;
            this.cbCoSo.Location = new System.Drawing.Point(71, 14);
            this.cbCoSo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbCoSo.Name = "cbCoSo";
            this.cbCoSo.Size = new System.Drawing.Size(204, 24);
            this.cbCoSo.TabIndex = 1;
            this.cbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbCoSo_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cơ sở";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themLopToolStripMenuItem,
            this.suaLopToolStripMenuItem,
            this.xoaLopToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 76);
            // 
            // themLopToolStripMenuItem
            // 
            this.themLopToolStripMenuItem.Name = "themLopToolStripMenuItem";
            this.themLopToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.themLopToolStripMenuItem.Text = "Nhập thêm lớp";
            this.themLopToolStripMenuItem.Click += new System.EventHandler(this.themLopToolStripMenuItem_Click);
            // 
            // suaLopToolStripMenuItem
            // 
            this.suaLopToolStripMenuItem.Name = "suaLopToolStripMenuItem";
            this.suaLopToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.suaLopToolStripMenuItem.Text = "Sửa Thông tin Lớp";
            this.suaLopToolStripMenuItem.Click += new System.EventHandler(this.suaLopToolStripMenuItem_Click);
            // 
            // xoaLopToolStripMenuItem
            // 
            this.xoaLopToolStripMenuItem.Name = "xoaLopToolStripMenuItem";
            this.xoaLopToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.xoaLopToolStripMenuItem.Text = "Xóa Lớp";
            this.xoaLopToolStripMenuItem.Click += new System.EventHandler(this.xoaLopToolStripMenuItem_Click);
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
            this.tableAdapterManager.GiaovienTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = this.KhoaTableAdapter;
            this.tableAdapterManager.LopTableAdapter = this.LopTableAdapter;
            this.tableAdapterManager.MonhocTableAdapter = null;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LopTableAdapter
            // 
            this.LopTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGiaovien_Dangky
            // 
            this.bdsGiaovien_Dangky.DataMember = "FK_Giaovien_Dangky_Lop";
            this.bdsGiaovien_Dangky.DataSource = this.bdsLop;
            // 
            // Giaovien_DangkyTableAdapter
            // 
            this.Giaovien_DangkyTableAdapter.ClearBeforeFill = true;
            // 
            // bdsSinhvien
            // 
            this.bdsSinhvien.DataMember = "FK_Sinhvien_Lop";
            this.bdsSinhvien.DataSource = this.bdsLop;
            // 
            // SinhvienTableAdapter
            // 
            this.SinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGiaovien
            // 
            this.bdsGiaovien.DataMember = "FK_Giaovien_Khoa";
            this.bdsGiaovien.DataSource = this.bdsKhoa;
            // 
            // GiaovienTableAdapter
            // 
            this.GiaovienTableAdapter.ClearBeforeFill = true;
            // 
            // FormKhoaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormKhoaLop";
            this.Text = "Quản lý khoa lớp";
            this.Load += new System.EventHandler(this.FormKhoaLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKHOA)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelKHOA)).EndInit();
            this.panelKHOA.ResumeLayout(false);
            this.panelKHOA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLOP)).EndInit();
            this.panelLOP.ResumeLayout(false);
            this.panelLOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENLOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFKMAKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaovien_Dangky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaovien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbCoSo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcKHOA;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKHOA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraGrid.GridControl gcLOP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLOP;
        private DevExpress.XtraEditors.PanelControl panelKHOA;
        private DevExpress.XtraEditors.PanelControl panelLOP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btnUndoLOP;
        private System.Windows.Forms.Button btnGhiLOP;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themLopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaLopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaLopToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DB_THI_TN DB_THI_TN;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DB_THI_TNTableAdapters.KhoaTableAdapter KhoaTableAdapter;
        private DB_THI_TNTableAdapters.TableAdapterManager tableAdapterManager;
        private DB_THI_TNTableAdapters.LopTableAdapter LopTableAdapter;
        private System.Windows.Forms.BindingSource bdsLop;
        private DevExpress.XtraEditors.TextEdit txtMACS;
        private DevExpress.XtraEditors.TextEdit txtTENKH;
        private DevExpress.XtraEditors.TextEdit txtMAKH;
        private DevExpress.XtraEditors.TextEdit txtTENLOP;
        private DevExpress.XtraEditors.TextEdit txtMALOP;
        private DevExpress.XtraEditors.TextEdit txtFKMAKH;
        private System.Windows.Forms.BindingSource bdsGiaovien_Dangky;
        private DB_THI_TNTableAdapters.Giaovien_DangkyTableAdapter Giaovien_DangkyTableAdapter;
        private System.Windows.Forms.BindingSource bdsSinhvien;
        private DB_THI_TNTableAdapters.SinhvienTableAdapter SinhvienTableAdapter;
        private System.Windows.Forms.BindingSource bdsGiaovien;
        private DB_THI_TNTableAdapters.GiaovienTableAdapter GiaovienTableAdapter;
    }
}