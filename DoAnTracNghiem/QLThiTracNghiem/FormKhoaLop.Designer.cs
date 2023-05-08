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
            System.Windows.Forms.Label nAMNHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoaLop));
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gcKHOA = new DevExpress.XtraGrid.GridControl();
            this.bdsKHOA = new System.Windows.Forms.BindingSource(this.components);
            this.DB_TracNghiem = new QLThiTracNghiem.DB_TracNghiem();
            this.gvKHOA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelKHOA = new DevExpress.XtraEditors.PanelControl();
            this.txtMAKHOA = new DevExpress.XtraEditors.TextEdit();
            this.txtTENKHOA = new DevExpress.XtraEditors.TextEdit();
            this.txtMACS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelLOP = new DevExpress.XtraEditors.PanelControl();
            this.btnUndoLOP = new System.Windows.Forms.Button();
            this.btnGhiLOP = new System.Windows.Forms.Button();
            this.txtNAMNH = new DevExpress.XtraEditors.SpinEdit();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.txtTENLOP = new DevExpress.XtraEditors.TextEdit();
            this.txtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.txtFKMAKHOA = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gcLOP = new DevExpress.XtraGrid.GridControl();
            this.gvLOP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMNH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbCoSo = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.KHOATableAdapter = new QLThiTracNghiem.DB_TracNghiemTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_TracNghiemTableAdapters.TableAdapterManager();
            this.LOPTableAdapter = new QLThiTracNghiem.DB_TracNghiemTableAdapters.LOPTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mACSLabel = new System.Windows.Forms.Label();
            tENKHOALabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            mAKHOALabel1 = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            nAMNHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TracNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKHOA)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelKHOA)).BeginInit();
            this.panelKHOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHOA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENKHOA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLOP)).BeginInit();
            this.panelLOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAMNH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENLOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFKMAKHOA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mACSLabel
            // 
            mACSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            mACSLabel.Location = new System.Drawing.Point(154, 20);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(71, 16);
            mACSLabel.TabIndex = 1;
            mACSLabel.Text = "Mã Cơ sở:";
            // 
            // tENKHOALabel
            // 
            tENKHOALabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            tENKHOALabel.Location = new System.Drawing.Point(5, 96);
            tENKHOALabel.Name = "tENKHOALabel";
            tENKHOALabel.Size = new System.Drawing.Size(72, 16);
            tENKHOALabel.TabIndex = 3;
            tENKHOALabel.Text = "Tên Khoa:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            mAKHOALabel.Location = new System.Drawing.Point(5, 62);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(72, 16);
            mAKHOALabel.TabIndex = 5;
            mAKHOALabel.Text = "Mã Khoa:";
            // 
            // mAKHOALabel1
            // 
            mAKHOALabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            mAKHOALabel1.Location = new System.Drawing.Point(163, 15);
            mAKHOALabel1.Name = "mAKHOALabel1";
            mAKHOALabel1.Size = new System.Drawing.Size(62, 16);
            mAKHOALabel1.TabIndex = 1;
            mAKHOALabel1.Text = "Mã Khoa:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            mALOPLabel.Location = new System.Drawing.Point(5, 51);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(76, 16);
            mALOPLabel.TabIndex = 3;
            mALOPLabel.Text = "Mã Lớp:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            tENLOPLabel.Location = new System.Drawing.Point(5, 85);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(66, 16);
            tENLOPLabel.TabIndex = 5;
            tENLOPLabel.Text = "Tên Lớp:";
            // 
            // nAMNHLabel
            // 
            nAMNHLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            nAMNHLabel.Location = new System.Drawing.Point(5, 117);
            nAMNHLabel.Name = "nAMNHLabel";
            nAMNHLabel.Size = new System.Drawing.Size(103, 16);
            nAMNHLabel.TabIndex = 7;
            nAMNHLabel.Text = "Năm Nhập học:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(989, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 693);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(989, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 642);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(989, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 642);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 642);
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(989, 593);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gcKHOA
            // 
            this.gcKHOA.DataSource = this.bdsKHOA;
            this.gcKHOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKHOA.Location = new System.Drawing.Point(3, 3);
            this.gcKHOA.MainView = this.gvKHOA;
            this.gcKHOA.MenuManager = this.barManager1;
            this.gcKHOA.Name = "gcKHOA";
            this.gcKHOA.Size = new System.Drawing.Size(983, 231);
            this.gcKHOA.TabIndex = 1;
            this.gcKHOA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKHOA});
            // 
            // bdsKHOA
            // 
            this.bdsKHOA.DataMember = "KHOA";
            this.bdsKHOA.DataSource = this.DB_TracNghiem;
            // 
            // DB_TracNghiem
            // 
            this.DB_TracNghiem.DataSetName = "DB_TracNghiem";
            this.DB_TracNghiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvKHOA
            // 
            this.gvKHOA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHOA,
            this.colTENKHOA,
            this.colMACS});
            this.gvKHOA.GridControl = this.gcKHOA;
            this.gvKHOA.Name = "gvKHOA";
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 0;
            this.colMAKHOA.Width = 94;
            // 
            // colTENKHOA
            // 
            this.colTENKHOA.FieldName = "TENKHOA";
            this.colTENKHOA.MinWidth = 25;
            this.colTENKHOA.Name = "colTENKHOA";
            this.colTENKHOA.Visible = true;
            this.colTENKHOA.VisibleIndex = 1;
            this.colTENKHOA.Width = 94;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 25;
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 94;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.65717F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.34283F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gcLOP, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 240);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(983, 350);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panelKHOA, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelLOP, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.95349F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.04651F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(373, 344);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panelKHOA
            // 
            this.panelKHOA.Controls.Add(mAKHOALabel);
            this.panelKHOA.Controls.Add(this.txtMAKHOA);
            this.panelKHOA.Controls.Add(tENKHOALabel);
            this.panelKHOA.Controls.Add(this.txtTENKHOA);
            this.panelKHOA.Controls.Add(mACSLabel);
            this.panelKHOA.Controls.Add(this.txtMACS);
            this.panelKHOA.Controls.Add(this.labelControl2);
            this.panelKHOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKHOA.Location = new System.Drawing.Point(3, 3);
            this.panelKHOA.Name = "panelKHOA";
            this.panelKHOA.Size = new System.Drawing.Size(367, 128);
            this.panelKHOA.TabIndex = 0;
            // 
            // txtMAKHOA
            // 
            this.txtMAKHOA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMAKHOA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKHOA, "MAKHOA", true));
            this.txtMAKHOA.Location = new System.Drawing.Point(114, 59);
            this.txtMAKHOA.MenuManager = this.barManager1;
            this.txtMAKHOA.Name = "txtMAKHOA";
            this.txtMAKHOA.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMAKHOA.Properties.MaxLength = 15;
            this.txtMAKHOA.Size = new System.Drawing.Size(125, 22);
            this.txtMAKHOA.TabIndex = 6;
            // 
            // txtTENKHOA
            // 
            this.txtTENKHOA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTENKHOA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKHOA, "TENKHOA", true));
            this.txtTENKHOA.Location = new System.Drawing.Point(114, 93);
            this.txtTENKHOA.MenuManager = this.barManager1;
            this.txtTENKHOA.Name = "txtTENKHOA";
            this.txtTENKHOA.Size = new System.Drawing.Size(242, 22);
            this.txtTENKHOA.TabIndex = 4;
            this.txtTENKHOA.EditValueChanged += new System.EventHandler(this.txtTENKHOA_EditValueChanged);
            // 
            // txtMACS
            // 
            this.txtMACS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMACS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKHOA, "MACS", true));
            this.txtMACS.Enabled = false;
            this.txtMACS.Location = new System.Drawing.Point(231, 17);
            this.txtMACS.MenuManager = this.barManager1;
            this.txtMACS.Name = "txtMACS";
            this.txtMACS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMACS.Properties.MaxLength = 15;
            this.txtMACS.Size = new System.Drawing.Size(125, 22);
            this.txtMACS.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 22);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Thông tin Khoa";
            // 
            // panelLOP
            // 
            this.panelLOP.Controls.Add(this.btnUndoLOP);
            this.panelLOP.Controls.Add(this.btnGhiLOP);
            this.panelLOP.Controls.Add(nAMNHLabel);
            this.panelLOP.Controls.Add(this.txtNAMNH);
            this.panelLOP.Controls.Add(tENLOPLabel);
            this.panelLOP.Controls.Add(this.txtTENLOP);
            this.panelLOP.Controls.Add(mALOPLabel);
            this.panelLOP.Controls.Add(this.txtMALOP);
            this.panelLOP.Controls.Add(mAKHOALabel1);
            this.panelLOP.Controls.Add(this.txtFKMAKHOA);
            this.panelLOP.Controls.Add(this.labelControl3);
            this.panelLOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLOP.Location = new System.Drawing.Point(3, 137);
            this.panelLOP.Name = "panelLOP";
            this.panelLOP.Size = new System.Drawing.Size(367, 204);
            this.panelLOP.TabIndex = 1;
            // 
            // btnUndoLOP
            // 
            this.btnUndoLOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndoLOP.Location = new System.Drawing.Point(231, 154);
            this.btnUndoLOP.Name = "btnUndoLOP";
            this.btnUndoLOP.Size = new System.Drawing.Size(75, 30);
            this.btnUndoLOP.TabIndex = 10;
            this.btnUndoLOP.Text = "Undo";
            this.btnUndoLOP.UseVisualStyleBackColor = true;
            this.btnUndoLOP.Click += new System.EventHandler(this.btnUndoLOP_Click);
            // 
            // btnGhiLOP
            // 
            this.btnGhiLOP.Location = new System.Drawing.Point(62, 154);
            this.btnGhiLOP.Name = "btnGhiLOP";
            this.btnGhiLOP.Size = new System.Drawing.Size(75, 30);
            this.btnGhiLOP.TabIndex = 9;
            this.btnGhiLOP.Text = "Ghi";
            this.btnGhiLOP.UseVisualStyleBackColor = true;
            this.btnGhiLOP.Click += new System.EventHandler(this.btnGhiLOP_Click);
            // 
            // txtNAMNH
            // 
            this.txtNAMNH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNAMNH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "NAMNH", true));
            this.txtNAMNH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNAMNH.Location = new System.Drawing.Point(114, 113);
            this.txtNAMNH.MenuManager = this.barManager1;
            this.txtNAMNH.Name = "txtNAMNH";
            this.txtNAMNH.Properties.MaskSettings.Set("mask", "d");
            this.txtNAMNH.Properties.MaxLength = 4;
            this.txtNAMNH.Size = new System.Drawing.Size(125, 22);
            this.txtNAMNH.TabIndex = 8;
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "FK_LOP_KHOA";
            this.bdsLOP.DataSource = this.bdsKHOA;
            // 
            // txtTENLOP
            // 
            this.txtTENLOP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTENLOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "TENLOP", true));
            this.txtTENLOP.Location = new System.Drawing.Point(114, 82);
            this.txtTENLOP.MenuManager = this.barManager1;
            this.txtTENLOP.Name = "txtTENLOP";
            this.txtTENLOP.Size = new System.Drawing.Size(242, 22);
            this.txtTENLOP.TabIndex = 6;
            this.txtTENLOP.EditValueChanged += new System.EventHandler(this.txtTENLOP_EditValueChanged);
            // 
            // txtMALOP
            // 
            this.txtMALOP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "MALOP", true));
            this.txtMALOP.Location = new System.Drawing.Point(114, 48);
            this.txtMALOP.MenuManager = this.barManager1;
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMALOP.Properties.MaxLength = 15;
            this.txtMALOP.Size = new System.Drawing.Size(125, 22);
            this.txtMALOP.TabIndex = 4;
            // 
            // txtFKMAKHOA
            // 
            this.txtFKMAKHOA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFKMAKHOA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "MAKHOA", true));
            this.txtFKMAKHOA.Enabled = false;
            this.txtFKMAKHOA.Location = new System.Drawing.Point(231, 12);
            this.txtFKMAKHOA.MenuManager = this.barManager1;
            this.txtFKMAKHOA.Name = "txtFKMAKHOA";
            this.txtFKMAKHOA.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFKMAKHOA.Properties.MaxLength = 15;
            this.txtFKMAKHOA.Size = new System.Drawing.Size(125, 22);
            this.txtFKMAKHOA.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 22);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Thông tin lớp";
            // 
            // gcLOP
            // 
            this.gcLOP.DataSource = this.bdsLOP;
            this.gcLOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLOP.Location = new System.Drawing.Point(382, 3);
            this.gcLOP.MainView = this.gvLOP;
            this.gcLOP.MenuManager = this.barManager1;
            this.gcLOP.Name = "gcLOP";
            this.gcLOP.Size = new System.Drawing.Size(598, 344);
            this.gcLOP.TabIndex = 1;
            this.gcLOP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLOP});
            // 
            // gvLOP
            // 
            this.gvLOP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colNAMNH});
            this.gvLOP.GridControl = this.gcLOP;
            this.gvLOP.Name = "gvLOP";
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colNAMNH
            // 
            this.colNAMNH.FieldName = "NAMNH";
            this.colNAMNH.MinWidth = 25;
            this.colNAMNH.Name = "colNAMNH";
            this.colNAMNH.Visible = true;
            this.colNAMNH.VisibleIndex = 2;
            this.colNAMNH.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbCoSo);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(989, 49);
            this.panelControl1.TabIndex = 0;
            // 
            // cbCoSo
            // 
            this.cbCoSo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCoSo.FormattingEnabled = true;
            this.cbCoSo.Location = new System.Drawing.Point(71, 14);
            this.cbCoSo.Name = "cbCoSo";
            this.cbCoSo.Size = new System.Drawing.Size(203, 24);
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
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cơ sở";
            // 
            // KHOATableAdapter
            // 
            this.KHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.KHOATableAdapter;
            this.tableAdapterManager.LICHTHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_TracNghiemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
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
            // FormKhoaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormKhoaLop";
            this.Text = "FormKhoaLop";
            this.Load += new System.EventHandler(this.FormKhoaLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TracNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKHOA)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelKHOA)).EndInit();
            this.panelKHOA.ResumeLayout(false);
            this.panelKHOA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHOA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENKHOA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLOP)).EndInit();
            this.panelLOP.ResumeLayout(false);
            this.panelLOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAMNH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENLOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFKMAKHOA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private DevExpress.XtraBars.Bar bar2;
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
        private System.Windows.Forms.BindingSource bdsKHOA;
        private DB_TracNghiem DB_TracNghiem;
        private DB_TracNghiemTableAdapters.KHOATableAdapter KHOATableAdapter;
        private DB_TracNghiemTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKHOA;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKHOA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DB_TracNghiemTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DevExpress.XtraGrid.GridControl gcLOP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMNH;
        private DevExpress.XtraEditors.PanelControl panelKHOA;
        private DevExpress.XtraEditors.PanelControl panelLOP;
        private DevExpress.XtraEditors.TextEdit txtMAKHOA;
        private DevExpress.XtraEditors.TextEdit txtTENKHOA;
        private DevExpress.XtraEditors.TextEdit txtMACS;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btnUndoLOP;
        private System.Windows.Forms.Button btnGhiLOP;
        private DevExpress.XtraEditors.SpinEdit txtNAMNH;
        private DevExpress.XtraEditors.TextEdit txtTENLOP;
        private DevExpress.XtraEditors.TextEdit txtMALOP;
        private DevExpress.XtraEditors.TextEdit txtFKMAKHOA;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themLopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaLopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaLopToolStripMenuItem;
    }
}