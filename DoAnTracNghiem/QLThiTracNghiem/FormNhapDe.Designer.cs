namespace QLThiTracNghiem
{
    partial class FormNhapDe
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
            System.Windows.Forms.Label cAUHOILabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label dLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapDe));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelMonhoc = new DevExpress.XtraEditors.PanelControl();
            this.CBMonhoc = new System.Windows.Forms.ComboBox();
            this.DB_THI_TN = new QLThiTracNghiem.DB_THI_TN();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsBode = new System.Windows.Forms.BindingSource(this.components);
            this.gcBode = new DevExpress.XtraGrid.GridControl();
            this.gvBode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelCauhoi = new DevExpress.XtraEditors.PanelControl();
            this.txtD = new System.Windows.Forms.RichTextBox();
            this.txtC = new System.Windows.Forms.RichTextBox();
            this.txtB = new System.Windows.Forms.RichTextBox();
            this.txtA = new System.Windows.Forms.RichTextBox();
            this.txtNoidung = new System.Windows.Forms.RichTextBox();
            this.CBDapAn = new System.Windows.Forms.ComboBox();
            this.CBTrinhDo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaCauhoi = new DevExpress.XtraEditors.TextEdit();
            this.sP_Lay_DS_CauHoiTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.SP_Lay_DS_CauHoiTableAdapter();
            this.bdsMonhoc = new System.Windows.Forms.BindingSource(this.components);
            this.monhocTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.MonhocTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager();
            cAUHOILabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMonhoc)).BeginInit();
            this.panelMonhoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCauhoi)).BeginInit();
            this.panelCauhoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCauhoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Font = new System.Drawing.Font("Tahoma", 10F);
            cAUHOILabel.Location = new System.Drawing.Point(28, 41);
            cAUHOILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(96, 21);
            cAUHOILabel.TabIndex = 0;
            cAUHOILabel.Text = "Mã câu hỏi:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            tRINHDOLabel.Location = new System.Drawing.Point(282, 41);
            tRINHDOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(78, 21);
            tRINHDOLabel.TabIndex = 3;
            tRINHDOLabel.Text = "Trình độ:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            dAP_ANLabel.Location = new System.Drawing.Point(574, 37);
            dAP_ANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(69, 21);
            dAP_ANLabel.TabIndex = 5;
            dAP_ANLabel.Text = "Đáp án:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            nOIDUNGLabel.Location = new System.Drawing.Point(28, 79);
            nOIDUNGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(81, 21);
            nOIDUNGLabel.TabIndex = 7;
            nOIDUNGLabel.Text = "Nội dung:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            aLabel.Location = new System.Drawing.Point(550, 112);
            aLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(27, 21);
            aLabel.TabIndex = 9;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            bLabel.Location = new System.Drawing.Point(551, 230);
            bLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(26, 21);
            bLabel.TabIndex = 11;
            bLabel.Text = "B:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            cLabel.Location = new System.Drawing.Point(902, 112);
            cLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(26, 21);
            cLabel.TabIndex = 13;
            cLabel.Text = "C:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            dLabel.Location = new System.Drawing.Point(902, 230);
            dLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(28, 21);
            dLabel.TabIndex = 15;
            dLabel.Text = "D:";
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
            this.btnSua,
            this.btnThoat});
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(280, 132);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoat";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1324, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 673);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1324, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 643);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1324, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 643);
            // 
            // panelMonhoc
            // 
            this.panelMonhoc.Controls.Add(this.CBMonhoc);
            this.panelMonhoc.Controls.Add(this.label1);
            this.panelMonhoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMonhoc.Location = new System.Drawing.Point(0, 30);
            this.panelMonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.panelMonhoc.Name = "panelMonhoc";
            this.panelMonhoc.Size = new System.Drawing.Size(1324, 59);
            this.panelMonhoc.TabIndex = 4;
            // 
            // CBMonhoc
            // 
            this.CBMonhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBMonhoc.DataSource = this.bdsMonhoc;
            this.CBMonhoc.DisplayMember = "TENMH";
            this.CBMonhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMonhoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMonhoc.FormattingEnabled = true;
            this.CBMonhoc.Location = new System.Drawing.Point(169, 17);
            this.CBMonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.CBMonhoc.Name = "CBMonhoc";
            this.CBMonhoc.Size = new System.Drawing.Size(348, 30);
            this.CBMonhoc.TabIndex = 1;
            this.CBMonhoc.ValueMember = "MAMH";
            this.CBMonhoc.SelectedIndexChanged += new System.EventHandler(this.CBMonhoc_SelectedIndexChanged);
            // 
            // DB_THI_TN
            // 
            this.DB_THI_TN.DataSetName = "DB_THI_TN";
            this.DB_THI_TN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn môn học:";
            // 
            // bdsBode
            // 
            this.bdsBode.DataMember = "SP_Lay_DS_CauHoi";
            this.bdsBode.DataSource = this.DB_THI_TN;
            this.bdsBode.Filter = "";
            // 
            // gcBode
            // 
            this.gcBode.DataSource = this.bdsBode;
            this.gcBode.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBode.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcBode.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gcBode.Location = new System.Drawing.Point(0, 89);
            this.gcBode.MainView = this.gvBode;
            this.gcBode.Margin = new System.Windows.Forms.Padding(4);
            this.gcBode.MenuManager = this.barManager1;
            this.gcBode.Name = "gcBode";
            this.gcBode.Size = new System.Drawing.Size(1324, 325);
            this.gcBode.TabIndex = 8;
            this.gcBode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBode});
            // 
            // gvBode
            // 
            this.gvBode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUHOI,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN});
            this.gvBode.DetailHeight = 431;
            this.gvBode.GridControl = this.gcBode;
            this.gvBode.Name = "gvBode";
            this.gvBode.OptionsBehavior.Editable = false;
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCAUHOI.AppearanceCell.Options.UseFont = true;
            this.colCAUHOI.Caption = "Mã câu hỏi";
            this.colCAUHOI.FieldName = "IDCAUHOI";
            this.colCAUHOI.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colCAUHOI.MinWidth = 23;
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            this.colCAUHOI.Width = 87;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRINHDO.AppearanceCell.Options.UseFont = true;
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 23;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 1;
            this.colTRINHDO.Width = 87;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNOIDUNG.AppearanceCell.Options.UseFont = true;
            this.colNOIDUNG.Caption = "Nội dung";
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 23;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 2;
            this.colNOIDUNG.Width = 87;
            // 
            // colA
            // 
            this.colA.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colA.AppearanceCell.Options.UseFont = true;
            this.colA.Caption = "A";
            this.colA.FieldName = "A";
            this.colA.MinWidth = 23;
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 3;
            this.colA.Width = 87;
            // 
            // colB
            // 
            this.colB.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colB.AppearanceCell.Options.UseFont = true;
            this.colB.Caption = "B";
            this.colB.FieldName = "B";
            this.colB.MinWidth = 23;
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 4;
            this.colB.Width = 87;
            // 
            // colC
            // 
            this.colC.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colC.AppearanceCell.Options.UseFont = true;
            this.colC.Caption = "C";
            this.colC.FieldName = "C";
            this.colC.MinWidth = 23;
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 5;
            this.colC.Width = 87;
            // 
            // colD
            // 
            this.colD.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colD.AppearanceCell.Options.UseFont = true;
            this.colD.Caption = "D";
            this.colD.FieldName = "D";
            this.colD.MinWidth = 23;
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 6;
            this.colD.Width = 87;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDAP_AN.AppearanceCell.Options.UseFont = true;
            this.colDAP_AN.Caption = "Đáp án";
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 23;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 7;
            this.colDAP_AN.Width = 87;
            // 
            // panelCauhoi
            // 
            this.panelCauhoi.Controls.Add(dLabel);
            this.panelCauhoi.Controls.Add(this.txtD);
            this.panelCauhoi.Controls.Add(cLabel);
            this.panelCauhoi.Controls.Add(this.txtC);
            this.panelCauhoi.Controls.Add(bLabel);
            this.panelCauhoi.Controls.Add(this.txtB);
            this.panelCauhoi.Controls.Add(aLabel);
            this.panelCauhoi.Controls.Add(this.txtA);
            this.panelCauhoi.Controls.Add(nOIDUNGLabel);
            this.panelCauhoi.Controls.Add(this.txtNoidung);
            this.panelCauhoi.Controls.Add(dAP_ANLabel);
            this.panelCauhoi.Controls.Add(this.CBDapAn);
            this.panelCauhoi.Controls.Add(tRINHDOLabel);
            this.panelCauhoi.Controls.Add(this.CBTrinhDo);
            this.panelCauhoi.Controls.Add(this.label2);
            this.panelCauhoi.Controls.Add(cAUHOILabel);
            this.panelCauhoi.Controls.Add(this.txtMaCauhoi);
            this.panelCauhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCauhoi.Location = new System.Drawing.Point(0, 414);
            this.panelCauhoi.Margin = new System.Windows.Forms.Padding(4);
            this.panelCauhoi.Name = "panelCauhoi";
            this.panelCauhoi.Size = new System.Drawing.Size(1324, 259);
            this.panelCauhoi.TabIndex = 9;
            // 
            // txtD
            // 
            this.txtD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "D", true));
            this.txtD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(930, 193);
            this.txtD.Margin = new System.Windows.Forms.Padding(4);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(317, 98);
            this.txtD.TabIndex = 16;
            this.txtD.Text = "";
            // 
            // txtC
            // 
            this.txtC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "C", true));
            this.txtC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(930, 75);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(317, 98);
            this.txtC.TabIndex = 14;
            this.txtC.Text = "";
            // 
            // txtB
            // 
            this.txtB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "B", true));
            this.txtB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(578, 193);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(317, 98);
            this.txtB.TabIndex = 12;
            this.txtB.Text = "";
            // 
            // txtA
            // 
            this.txtA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "A", true));
            this.txtA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(578, 75);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(317, 98);
            this.txtA.TabIndex = 10;
            this.txtA.Text = "";
            // 
            // txtNoidung
            // 
            this.txtNoidung.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "NOIDUNG", true));
            this.txtNoidung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoidung.Location = new System.Drawing.Point(114, 79);
            this.txtNoidung.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(403, 214);
            this.txtNoidung.TabIndex = 8;
            this.txtNoidung.Text = "";
            // 
            // CBDapAn
            // 
            this.CBDapAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBDapAn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "DAP_AN", true));
            this.CBDapAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDapAn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDapAn.FormattingEnabled = true;
            this.CBDapAn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBDapAn.Location = new System.Drawing.Point(648, 33);
            this.CBDapAn.Margin = new System.Windows.Forms.Padding(4);
            this.CBDapAn.Name = "CBDapAn";
            this.CBDapAn.Size = new System.Drawing.Size(62, 34);
            this.CBDapAn.TabIndex = 6;
            // 
            // CBTrinhDo
            // 
            this.CBTrinhDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "TRINHDO", true));
            this.CBTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTrinhDo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTrinhDo.FormattingEnabled = true;
            this.CBTrinhDo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CBTrinhDo.Location = new System.Drawing.Point(364, 37);
            this.CBTrinhDo.Margin = new System.Windows.Forms.Padding(4);
            this.CBTrinhDo.Name = "CBTrinhDo";
            this.CBTrinhDo.Size = new System.Drawing.Size(62, 34);
            this.CBTrinhDo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chi tiết câu hỏi";
            // 
            // txtMaCauhoi
            // 
            this.txtMaCauhoi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "IDCAUHOI", true));
            this.txtMaCauhoi.Enabled = false;
            this.txtMaCauhoi.Location = new System.Drawing.Point(126, 37);
            this.txtMaCauhoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCauhoi.MenuManager = this.barManager1;
            this.txtMaCauhoi.Name = "txtMaCauhoi";
            this.txtMaCauhoi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCauhoi.Properties.Appearance.Options.UseFont = true;
            this.txtMaCauhoi.Size = new System.Drawing.Size(117, 32);
            this.txtMaCauhoi.TabIndex = 1;
            // 
            // sP_Lay_DS_CauHoiTableAdapter
            // 
            this.sP_Lay_DS_CauHoiTableAdapter.ClearBeforeFill = true;
            // 
            // bdsMonhoc
            // 
            this.bdsMonhoc.DataMember = "Monhoc";
            this.bdsMonhoc.DataSource = this.DB_THI_TN;
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemTableAdapter = null;
            this.tableAdapterManager.BodeTableAdapter = null;
            this.tableAdapterManager.ChiTiet_BaiThiTableAdapter = null;
            this.tableAdapterManager.Giaovien_DangkyTableAdapter = null;
            this.tableAdapterManager.GiaovienTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonhocTableAdapter = this.monhocTableAdapter;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormNhapDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 693);
            this.Controls.Add(this.panelCauhoi);
            this.Controls.Add(this.gcBode);
            this.Controls.Add(this.panelMonhoc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNhapDe";
            this.Text = "Quản lý bộ đề";
            this.Load += new System.EventHandler(this.FormNhapDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMonhoc)).EndInit();
            this.panelMonhoc.ResumeLayout(false);
            this.panelMonhoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCauhoi)).EndInit();
            this.panelCauhoi.ResumeLayout(false);
            this.panelCauhoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCauhoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelMonhoc;
        private System.Windows.Forms.ComboBox CBMonhoc;
        private System.Windows.Forms.Label label1;
        private DB_THI_TN DB_THI_TN;
        private System.Windows.Forms.BindingSource bdsBode;
        private DevExpress.XtraEditors.PanelControl panelCauhoi;
        private DevExpress.XtraGrid.GridControl gcBode;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBode;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtMaCauhoi;
        private System.Windows.Forms.ComboBox CBTrinhDo;
        private System.Windows.Forms.RichTextBox txtC;
        private System.Windows.Forms.RichTextBox txtB;
        private System.Windows.Forms.RichTextBox txtA;
        private System.Windows.Forms.RichTextBox txtNoidung;
        private System.Windows.Forms.ComboBox CBDapAn;
        private System.Windows.Forms.RichTextBox txtD;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DB_THI_TNTableAdapters.SP_Lay_DS_CauHoiTableAdapter sP_Lay_DS_CauHoiTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonhoc;
        private DB_THI_TNTableAdapters.MonhocTableAdapter monhocTableAdapter;
        private DB_THI_TNTableAdapters.TableAdapterManager tableAdapterManager;
    }
}