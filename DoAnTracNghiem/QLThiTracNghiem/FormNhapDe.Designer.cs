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
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.DB_THI_TN = new QLThiTracNghiem.DB_THI_TN();
            this.label1 = new System.Windows.Forms.Label();
            this.monhocTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.MonhocTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager();
            this.bodeTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.BodeTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCauhoi)).BeginInit();
            this.panelCauhoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCauhoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Font = new System.Drawing.Font("Tahoma", 10F);
            cAUHOILabel.Location = new System.Drawing.Point(24, 33);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(78, 17);
            cAUHOILabel.TabIndex = 0;
            cAUHOILabel.Text = "Mã câu hỏi:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            tRINHDOLabel.Location = new System.Drawing.Point(242, 33);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(64, 17);
            tRINHDOLabel.TabIndex = 3;
            tRINHDOLabel.Text = "Trình độ:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            dAP_ANLabel.Location = new System.Drawing.Point(492, 30);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(57, 17);
            dAP_ANLabel.TabIndex = 5;
            dAP_ANLabel.Text = "Đáp án:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            nOIDUNGLabel.Location = new System.Drawing.Point(24, 64);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(68, 17);
            nOIDUNGLabel.TabIndex = 7;
            nOIDUNGLabel.Text = "Nội dung:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            aLabel.Location = new System.Drawing.Point(471, 91);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(21, 17);
            aLabel.TabIndex = 9;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            bLabel.Location = new System.Drawing.Point(472, 187);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(21, 17);
            bLabel.TabIndex = 11;
            bLabel.Text = "B:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            cLabel.Location = new System.Drawing.Point(773, 91);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(22, 17);
            cLabel.TabIndex = 13;
            cLabel.Text = "C:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            dLabel.Location = new System.Drawing.Point(773, 187);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(23, 17);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1135, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 543);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1135, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 519);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1135, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 519);
            // 
            // panelMonhoc
            // 
            this.panelMonhoc.Controls.Add(this.CBMonhoc);
            this.panelMonhoc.Controls.Add(this.label1);
            this.panelMonhoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMonhoc.Location = new System.Drawing.Point(0, 24);
            this.panelMonhoc.Name = "panelMonhoc";
            this.panelMonhoc.Size = new System.Drawing.Size(1135, 48);
            this.panelMonhoc.TabIndex = 4;
            // 
            // CBMonhoc
            // 
            this.CBMonhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBMonhoc.DataSource = this.bdsMonHoc;
            this.CBMonhoc.DisplayMember = "TENMH";
            this.CBMonhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMonhoc.Font = new System.Drawing.Font("Tahoma", 10F);
            this.CBMonhoc.FormattingEnabled = true;
            this.CBMonhoc.Location = new System.Drawing.Point(145, 14);
            this.CBMonhoc.Name = "CBMonhoc";
            this.CBMonhoc.Size = new System.Drawing.Size(299, 24);
            this.CBMonhoc.TabIndex = 1;
            this.CBMonhoc.ValueMember = "MAMH";
            this.CBMonhoc.SelectedIndexChanged += new System.EventHandler(this.CBMonhoc_SelectedIndexChanged);
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "Monhoc";
            this.bdsMonHoc.DataSource = this.DB_THI_TN;
            // 
            // DB_THI_TN
            // 
            this.DB_THI_TN.DataSetName = "DB_THI_TN";
            this.DB_THI_TN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn môn học:";
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemTableAdapter = null;
            this.tableAdapterManager.BodeTableAdapter = this.bodeTableAdapter;
            this.tableAdapterManager.ChiTiet_BaiThiTableAdapter = null;
            this.tableAdapterManager.Giaovien_DangkyTableAdapter = null;
            this.tableAdapterManager.GiaovienTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonhocTableAdapter = this.monhocTableAdapter;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bodeTableAdapter
            // 
            this.bodeTableAdapter.ClearBeforeFill = true;
            // 
            // bdsBode
            // 
            this.bdsBode.DataMember = "FK_Bode_Monhoc";
            this.bdsBode.DataSource = this.bdsMonHoc;
            this.bdsBode.Filter = "MAGV = '" + Program.username + "'";
            // 
            // gcBode
            // 
            this.gcBode.DataSource = this.bdsBode;
            this.gcBode.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBode.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gcBode.Location = new System.Drawing.Point(0, 72);
            this.gcBode.MainView = this.gvBode;
            this.gcBode.MenuManager = this.barManager1;
            this.gcBode.Name = "gcBode";
            this.gcBode.Size = new System.Drawing.Size(1135, 264);
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
            this.gvBode.GridControl = this.gcBode;
            this.gvBode.Name = "gvBode";
            this.gvBode.OptionsBehavior.Editable = false;
            this.gvBode.OptionsView.ShowViewCaption = true;
            this.gvBode.ViewCaption = "Danh sách câu hỏi";
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.Caption = "Mã câu hỏi";
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 1;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.Caption = "Nội dung";
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 2;
            // 
            // colA
            // 
            this.colA.Caption = "A";
            this.colA.FieldName = "A";
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 3;
            // 
            // colB
            // 
            this.colB.Caption = "B";
            this.colB.FieldName = "B";
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 4;
            // 
            // colC
            // 
            this.colC.Caption = "C";
            this.colC.FieldName = "C";
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 5;
            // 
            // colD
            // 
            this.colD.Caption = "D";
            this.colD.FieldName = "D";
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 6;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.Caption = "Đáp án";
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 7;
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
            this.panelCauhoi.Location = new System.Drawing.Point(0, 336);
            this.panelCauhoi.Name = "panelCauhoi";
            this.panelCauhoi.Size = new System.Drawing.Size(1135, 207);
            this.panelCauhoi.TabIndex = 9;
            // 
            // txtD
            // 
            this.txtD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "D", true));
            this.txtD.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtD.Location = new System.Drawing.Point(797, 157);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(272, 80);
            this.txtD.TabIndex = 16;
            this.txtD.Text = "";
            // 
            // txtC
            // 
            this.txtC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "C", true));
            this.txtC.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtC.Location = new System.Drawing.Point(797, 61);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(272, 80);
            this.txtC.TabIndex = 14;
            this.txtC.Text = "";
            // 
            // txtB
            // 
            this.txtB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "B", true));
            this.txtB.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtB.Location = new System.Drawing.Point(495, 157);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(272, 80);
            this.txtB.TabIndex = 12;
            this.txtB.Text = "";
            // 
            // txtA
            // 
            this.txtA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "A", true));
            this.txtA.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtA.Location = new System.Drawing.Point(495, 61);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(272, 80);
            this.txtA.TabIndex = 10;
            this.txtA.Text = "";
            // 
            // txtNoidung
            // 
            this.txtNoidung.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "NOIDUNG", true));
            this.txtNoidung.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNoidung.Location = new System.Drawing.Point(98, 64);
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(346, 175);
            this.txtNoidung.TabIndex = 8;
            this.txtNoidung.Text = "";
            // 
            // CBDapAn
            // 
            this.CBDapAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBDapAn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "DAP_AN", true));
            this.CBDapAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDapAn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.CBDapAn.FormattingEnabled = true;
            this.CBDapAn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBDapAn.Location = new System.Drawing.Point(555, 27);
            this.CBDapAn.Name = "CBDapAn";
            this.CBDapAn.Size = new System.Drawing.Size(54, 24);
            this.CBDapAn.TabIndex = 6;
            // 
            // CBTrinhDo
            // 
            this.CBTrinhDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "TRINHDO", true));
            this.CBTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTrinhDo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.CBTrinhDo.FormattingEnabled = true;
            this.CBTrinhDo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CBTrinhDo.Location = new System.Drawing.Point(312, 30);
            this.CBTrinhDo.Name = "CBTrinhDo";
            this.CBTrinhDo.Size = new System.Drawing.Size(54, 24);
            this.CBTrinhDo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(5, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chi tiết câu hỏi";
            // 
            // txtMaCauhoi
            // 
            this.txtMaCauhoi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "CAUHOI", true));
            this.txtMaCauhoi.Enabled = false;
            this.txtMaCauhoi.Location = new System.Drawing.Point(108, 30);
            this.txtMaCauhoi.MenuManager = this.barManager1;
            this.txtMaCauhoi.Name = "txtMaCauhoi";
            this.txtMaCauhoi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaCauhoi.Properties.Appearance.Options.UseFont = true;
            this.txtMaCauhoi.Size = new System.Drawing.Size(100, 22);
            this.txtMaCauhoi.TabIndex = 1;
            // 
            // FormNhapDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 563);
            this.Controls.Add(this.panelCauhoi);
            this.Controls.Add(this.gcBode);
            this.Controls.Add(this.panelMonhoc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormNhapDe";
            this.Text = "FormNhapDe";
            this.Load += new System.EventHandler(this.FormNhapDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMonhoc)).EndInit();
            this.panelMonhoc.ResumeLayout(false);
            this.panelMonhoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCauhoi)).EndInit();
            this.panelCauhoi.ResumeLayout(false);
            this.panelCauhoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCauhoi.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DB_THI_TNTableAdapters.MonhocTableAdapter monhocTableAdapter;
        private DB_THI_TNTableAdapters.TableAdapterManager tableAdapterManager;
        private DB_THI_TNTableAdapters.BodeTableAdapter bodeTableAdapter;
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
    }
}