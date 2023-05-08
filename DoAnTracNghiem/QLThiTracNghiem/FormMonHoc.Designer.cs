namespace QLThiTracNghiem
{
    partial class FormMonHoc
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label sOTIETLTLabel;
            System.Windows.Forms.Label sOTIETTHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonHoc));
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.lbCoso = new DevExpress.XtraEditors.LabelControl();
            this.DB_TracNghiem = new QLThiTracNghiem.DB_TracNghiem();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOCTableAdapter = new QLThiTracNghiem.DB_TracNghiemTableAdapters.MONHOCTableAdapter();
            this.gcMONHOC = new DevExpress.XtraGrid.GridControl();
            this.gvMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIETLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIETTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelDataView = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSOTIETTH = new DevExpress.XtraEditors.TextEdit();
            this.txtSOTIETLT = new DevExpress.XtraEditors.TextEdit();
            this.txtTENMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMAMH = new DevExpress.XtraEditors.TextEdit();
            this.tableAdapterManager = new QLThiTracNghiem.DB_TracNghiemTableAdapters.TableAdapterManager();
            this.CAUHOITableAdapter = new QLThiTracNghiem.DB_TracNghiemTableAdapters.CAUHOITableAdapter();
            this.bdsCAUHOI = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLICHTHI = new System.Windows.Forms.BindingSource(this.components);
            this.LICHTHITableAdapter = new QLThiTracNghiem.DB_TracNghiemTableAdapters.LICHTHITableAdapter();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            sOTIETLTLabel = new System.Windows.Forms.Label();
            sOTIETTHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TracNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDataView)).BeginInit();
            this.panelDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTIETTH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTIETLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCAUHOI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLICHTHI)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(44, 53);
            mAMHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(48, 16);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "MAMH:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(39, 105);
            tENMHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(53, 16);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "TENMH:";
            // 
            // sOTIETLTLabel
            // 
            sOTIETLTLabel.AutoSize = true;
            sOTIETLTLabel.Location = new System.Drawing.Point(22, 148);
            sOTIETLTLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            sOTIETLTLabel.Name = "sOTIETLTLabel";
            sOTIETLTLabel.Size = new System.Drawing.Size(70, 16);
            sOTIETLTLabel.TabIndex = 4;
            sOTIETLTLabel.Text = "SOTIETLT:";
            // 
            // sOTIETTHLabel
            // 
            sOTIETTHLabel.AutoSize = true;
            sOTIETTHLabel.Location = new System.Drawing.Point(22, 200);
            sOTIETTHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            sOTIETTHLabel.Name = "sOTIETTHLabel";
            sOTIETTHLabel.Size = new System.Drawing.Size(72, 16);
            sOTIETTHLabel.TabIndex = 6;
            sOTIETTHLabel.Text = "SOTIETTH:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(920, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 782);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(920, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 731);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(920, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 731);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbServer);
            this.panelControl1.Controls.Add(this.lbCoso);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(920, 47);
            this.panelControl1.TabIndex = 4;
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(61, 15);
            this.cbServer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(247, 24);
            this.cbServer.TabIndex = 1;
            this.cbServer.SelectedIndexChanged += new System.EventHandler(this.cbServer_SelectedIndexChanged);
            // 
            // lbCoso
            // 
            this.lbCoso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCoso.Location = new System.Drawing.Point(16, 18);
            this.lbCoso.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbCoso.Name = "lbCoso";
            this.lbCoso.Size = new System.Drawing.Size(32, 16);
            this.lbCoso.TabIndex = 0;
            this.lbCoso.Text = "Cơ sở";
            // 
            // DB_TracNghiem
            // 
            this.DB_TracNghiem.DataSetName = "DB_TracNghiem";
            this.DB_TracNghiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.DB_TracNghiem;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // gcMONHOC
            // 
            this.gcMONHOC.DataSource = this.bdsMONHOC;
            this.gcMONHOC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMONHOC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gcMONHOC.Location = new System.Drawing.Point(0, 98);
            this.gcMONHOC.MainView = this.gvMonHoc;
            this.gcMONHOC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gcMONHOC.MenuManager = this.barManager1;
            this.gcMONHOC.Name = "gcMONHOC";
            this.gcMONHOC.Size = new System.Drawing.Size(920, 430);
            this.gcMONHOC.TabIndex = 9;
            this.gcMONHOC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMonHoc});
            // 
            // gvMonHoc
            // 
            this.gvMonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIETLT,
            this.colSOTIETTH});
            this.gvMonHoc.DetailHeight = 546;
            this.gvMonHoc.GridControl = this.gcMONHOC;
            this.gvMonHoc.Name = "gvMonHoc";
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 39;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 145;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 39;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 145;
            // 
            // colSOTIETLT
            // 
            this.colSOTIETLT.FieldName = "SOTIETLT";
            this.colSOTIETLT.MinWidth = 39;
            this.colSOTIETLT.Name = "colSOTIETLT";
            this.colSOTIETLT.Visible = true;
            this.colSOTIETLT.VisibleIndex = 2;
            this.colSOTIETLT.Width = 145;
            // 
            // colSOTIETTH
            // 
            this.colSOTIETTH.FieldName = "SOTIETTH";
            this.colSOTIETTH.MinWidth = 39;
            this.colSOTIETTH.Name = "colSOTIETTH";
            this.colSOTIETTH.Visible = true;
            this.colSOTIETTH.VisibleIndex = 3;
            this.colSOTIETTH.Width = 145;
            // 
            // panelDataView
            // 
            this.panelDataView.AutoSize = true;
            this.panelDataView.Controls.Add(this.labelControl1);
            this.panelDataView.Controls.Add(sOTIETTHLabel);
            this.panelDataView.Controls.Add(this.txtSOTIETTH);
            this.panelDataView.Controls.Add(sOTIETLTLabel);
            this.panelDataView.Controls.Add(this.txtSOTIETLT);
            this.panelDataView.Controls.Add(tENMHLabel);
            this.panelDataView.Controls.Add(this.txtTENMH);
            this.panelDataView.Controls.Add(mAMHLabel);
            this.panelDataView.Controls.Add(this.txtMAMH);
            this.panelDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataView.Location = new System.Drawing.Point(0, 528);
            this.panelDataView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelDataView.Name = "panelDataView";
            this.panelDataView.Size = new System.Drawing.Size(920, 254);
            this.panelDataView.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(107, 26);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Thông tin môn học";
            // 
            // txtSOTIETTH
            // 
            this.txtSOTIETTH.AllowDrop = true;
            this.txtSOTIETTH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMONHOC, "SOTIETTH", true));
            this.txtSOTIETTH.Location = new System.Drawing.Point(154, 197);
            this.txtSOTIETTH.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSOTIETTH.MenuManager = this.barManager1;
            this.txtSOTIETTH.Name = "txtSOTIETTH";
            this.txtSOTIETTH.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSOTIETTH.Properties.MaxLength = 2;
            this.txtSOTIETTH.Size = new System.Drawing.Size(63, 22);
            this.txtSOTIETTH.TabIndex = 7;
            // 
            // txtSOTIETLT
            // 
            this.txtSOTIETLT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMONHOC, "SOTIETLT", true));
            this.txtSOTIETLT.Location = new System.Drawing.Point(154, 145);
            this.txtSOTIETLT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSOTIETLT.MenuManager = this.barManager1;
            this.txtSOTIETLT.Name = "txtSOTIETLT";
            this.txtSOTIETLT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSOTIETLT.Properties.MaxLength = 2;
            this.txtSOTIETLT.Size = new System.Drawing.Size(63, 22);
            this.txtSOTIETLT.TabIndex = 5;
            // 
            // txtTENMH
            // 
            this.txtTENMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMONHOC, "TENMH", true));
            this.txtTENMH.Location = new System.Drawing.Point(154, 102);
            this.txtTENMH.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTENMH.MenuManager = this.barManager1;
            this.txtTENMH.Name = "txtTENMH";
            this.txtTENMH.Size = new System.Drawing.Size(244, 22);
            this.txtTENMH.TabIndex = 3;
            this.txtTENMH.EditValueChanged += new System.EventHandler(this.txtTENMH_EditValueChanged);
            // 
            // txtMAMH
            // 
            this.txtMAMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMONHOC, "MAMH", true));
            this.txtMAMH.Location = new System.Drawing.Point(154, 50);
            this.txtMAMH.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMAMH.MenuManager = this.barManager1;
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMAMH.Properties.MaxLength = 4;
            this.txtMAMH.Size = new System.Drawing.Size(129, 22);
            this.txtMAMH.TabIndex = 1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = this.CAUHOITableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LICHTHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_TracNghiemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CAUHOITableAdapter
            // 
            this.CAUHOITableAdapter.ClearBeforeFill = true;
            // 
            // bdsCAUHOI
            // 
            this.bdsCAUHOI.DataMember = "FK_CAUHOI_MONHOC";
            this.bdsCAUHOI.DataSource = this.bdsMONHOC;
            // 
            // bdsLICHTHI
            // 
            this.bdsLICHTHI.DataMember = "FK_LICHTHI_MONHOC";
            this.bdsLICHTHI.DataSource = this.bdsMONHOC;
            // 
            // LICHTHITableAdapter
            // 
            this.LICHTHITableAdapter.ClearBeforeFill = true;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 802);
            this.Controls.Add(this.panelDataView);
            this.Controls.Add(this.gcMONHOC);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMonHoc";
            this.Text = " FormMonHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TracNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDataView)).EndInit();
            this.panelDataView.ResumeLayout(false);
            this.panelDataView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTIETTH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTIETLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCAUHOI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLICHTHI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbServer;
        private DevExpress.XtraEditors.LabelControl lbCoso;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private DB_TracNghiem DB_TracNghiem;
        private DB_TracNghiemTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private DevExpress.XtraGrid.GridControl gcMONHOC;
        private DevExpress.XtraEditors.PanelControl panelDataView;
        private DevExpress.XtraEditors.TextEdit txtSOTIETTH;
        private DevExpress.XtraEditors.TextEdit txtSOTIETLT;
        private DevExpress.XtraEditors.TextEdit txtTENMH;
        private DevExpress.XtraEditors.TextEdit txtMAMH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIETLT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIETTH;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DB_TracNghiemTableAdapters.TableAdapterManager tableAdapterManager;
        private DB_TracNghiemTableAdapters.CAUHOITableAdapter CAUHOITableAdapter;
        private System.Windows.Forms.BindingSource bdsCAUHOI;
        private System.Windows.Forms.BindingSource bdsLICHTHI;
        private DB_TracNghiemTableAdapters.LICHTHITableAdapter LICHTHITableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}