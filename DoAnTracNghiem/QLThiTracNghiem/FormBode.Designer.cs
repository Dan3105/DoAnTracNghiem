namespace QLThiTracNghiem
{
    partial class FormBode
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
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label dLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBode));
            System.Windows.Forms.Label dAP_ANLabel;
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
            this.dB_THI_TN = new QLThiTracNghiem.DB_THI_TN();
            this.bdsBode = new System.Windows.Forms.BindingSource(this.components);
            this.bodeTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.BodeTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager();
            this.chiTiet_BaiThiTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.ChiTiet_BaiThiTableAdapter();
            this.monhocTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.MonhocTableAdapter();
            this.gcBode = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelCauhoi = new DevExpress.XtraEditors.PanelControl();
            this.dTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.aTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nOIDUNGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tRINHDOComboBox = new System.Windows.Forms.ComboBox();
            this.mAMHComboBox = new System.Windows.Forms.ComboBox();
            this.bdsMonhoc = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTBaithi = new System.Windows.Forms.BindingSource(this.components);
            this.dAP_ANComboBox = new System.Windows.Forms.ComboBox();
            mAMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_THI_TN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCauhoi)).BeginInit();
            this.panelCauhoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOIDUNGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBaithi)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(36, 28);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(41, 13);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "MAMH:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(344, 28);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(57, 13);
            tRINHDOLabel.TabIndex = 4;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(36, 71);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(58, 13);
            nOIDUNGLabel.TabIndex = 7;
            nOIDUNGLabel.Text = "NOIDUNG:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Location = new System.Drawing.Point(36, 116);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(18, 13);
            aLabel.TabIndex = 8;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(37, 157);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(17, 13);
            bLabel.TabIndex = 10;
            bLabel.Text = "B:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Location = new System.Drawing.Point(37, 202);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(18, 13);
            cLabel.TabIndex = 12;
            cLabel.Text = "C:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new System.Drawing.Point(37, 243);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(18, 13);
            dLabel.TabIndex = 14;
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1110, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 625);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1110, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 601);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1110, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 601);
            // 
            // dB_THI_TN
            // 
            this.dB_THI_TN.DataSetName = "DB_THI_TN";
            this.dB_THI_TN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsBode
            // 
            this.bdsBode.DataMember = "Bode";
            this.bdsBode.DataSource = this.dB_THI_TN;
            this.bdsBode.Filter = "MAGV = '" + Program.username + "'";
            // 
            // bodeTableAdapter
            // 
            this.bodeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BodeTableAdapter = this.bodeTableAdapter;
            this.tableAdapterManager.ChiTiet_BaiThiTableAdapter = this.chiTiet_BaiThiTableAdapter;
            this.tableAdapterManager.Giaovien_DangkyTableAdapter = null;
            this.tableAdapterManager.GiaovienTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonhocTableAdapter = this.monhocTableAdapter;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chiTiet_BaiThiTableAdapter
            // 
            this.chiTiet_BaiThiTableAdapter.ClearBeforeFill = true;
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // gcBode
            // 
            this.gcBode.DataSource = this.bdsBode;
            this.gcBode.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBode.Location = new System.Drawing.Point(0, 24);
            this.gcBode.MainView = this.gridView1;
            this.gcBode.MenuManager = this.barManager1;
            this.gcBode.Name = "gcBode";
            this.gcBode.Size = new System.Drawing.Size(1110, 220);
            this.gcBode.TabIndex = 4;
            this.gcBode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colCAUHOI,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN});
            this.gridView1.GridControl = this.gcBode;
            this.gridView1.Name = "gridView1";
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 1;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 3;
            // 
            // colA
            // 
            this.colA.FieldName = "A";
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 4;
            // 
            // colB
            // 
            this.colB.FieldName = "B";
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 5;
            // 
            // colC
            // 
            this.colC.FieldName = "C";
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 6;
            // 
            // colD
            // 
            this.colD.FieldName = "D";
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 7;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 8;
            // 
            // panelCauhoi
            // 
            this.panelCauhoi.Controls.Add(dAP_ANLabel);
            this.panelCauhoi.Controls.Add(this.dAP_ANComboBox);
            this.panelCauhoi.Controls.Add(dLabel);
            this.panelCauhoi.Controls.Add(this.dTextEdit);
            this.panelCauhoi.Controls.Add(cLabel);
            this.panelCauhoi.Controls.Add(this.cTextEdit);
            this.panelCauhoi.Controls.Add(bLabel);
            this.panelCauhoi.Controls.Add(this.bTextEdit);
            this.panelCauhoi.Controls.Add(aLabel);
            this.panelCauhoi.Controls.Add(this.aTextEdit);
            this.panelCauhoi.Controls.Add(nOIDUNGLabel);
            this.panelCauhoi.Controls.Add(this.nOIDUNGTextEdit);
            this.panelCauhoi.Controls.Add(tRINHDOLabel);
            this.panelCauhoi.Controls.Add(this.tRINHDOComboBox);
            this.panelCauhoi.Controls.Add(mAMHLabel);
            this.panelCauhoi.Controls.Add(this.mAMHComboBox);
            this.panelCauhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCauhoi.Location = new System.Drawing.Point(0, 244);
            this.panelCauhoi.Name = "panelCauhoi";
            this.panelCauhoi.Size = new System.Drawing.Size(1110, 381);
            this.panelCauhoi.TabIndex = 5;
            // 
            // dTextEdit
            // 
            this.dTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "D", true));
            this.dTextEdit.Location = new System.Drawing.Point(61, 240);
            this.dTextEdit.MenuManager = this.barManager1;
            this.dTextEdit.Name = "dTextEdit";
            this.dTextEdit.Size = new System.Drawing.Size(557, 20);
            this.dTextEdit.TabIndex = 15;
            // 
            // cTextEdit
            // 
            this.cTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "C", true));
            this.cTextEdit.Location = new System.Drawing.Point(61, 199);
            this.cTextEdit.MenuManager = this.barManager1;
            this.cTextEdit.Name = "cTextEdit";
            this.cTextEdit.Size = new System.Drawing.Size(557, 20);
            this.cTextEdit.TabIndex = 13;
            // 
            // bTextEdit
            // 
            this.bTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "B", true));
            this.bTextEdit.Location = new System.Drawing.Point(60, 154);
            this.bTextEdit.MenuManager = this.barManager1;
            this.bTextEdit.Name = "bTextEdit";
            this.bTextEdit.Size = new System.Drawing.Size(558, 20);
            this.bTextEdit.TabIndex = 11;
            // 
            // aTextEdit
            // 
            this.aTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "A", true));
            this.aTextEdit.Location = new System.Drawing.Point(60, 113);
            this.aTextEdit.MenuManager = this.barManager1;
            this.aTextEdit.Name = "aTextEdit";
            this.aTextEdit.Size = new System.Drawing.Size(558, 20);
            this.aTextEdit.TabIndex = 9;
            // 
            // nOIDUNGTextEdit
            // 
            this.nOIDUNGTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "NOIDUNG", true));
            this.nOIDUNGTextEdit.Location = new System.Drawing.Point(100, 68);
            this.nOIDUNGTextEdit.MenuManager = this.barManager1;
            this.nOIDUNGTextEdit.Name = "nOIDUNGTextEdit";
            this.nOIDUNGTextEdit.Size = new System.Drawing.Size(518, 20);
            this.nOIDUNGTextEdit.TabIndex = 8;
            // 
            // tRINHDOComboBox
            // 
            this.tRINHDOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "TRINHDO", true));
            this.tRINHDOComboBox.FormattingEnabled = true;
            this.tRINHDOComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.tRINHDOComboBox.Location = new System.Drawing.Point(407, 25);
            this.tRINHDOComboBox.Name = "tRINHDOComboBox";
            this.tRINHDOComboBox.Size = new System.Drawing.Size(121, 21);
            this.tRINHDOComboBox.TabIndex = 5;
            // 
            // mAMHComboBox
            // 
            this.mAMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsBode, "MAMH", true));
            this.mAMHComboBox.DataSource = this.bdsMonhoc;
            this.mAMHComboBox.DisplayMember = "TENMH";
            this.mAMHComboBox.FormattingEnabled = true;
            this.mAMHComboBox.Location = new System.Drawing.Point(83, 25);
            this.mAMHComboBox.Name = "mAMHComboBox";
            this.mAMHComboBox.Size = new System.Drawing.Size(222, 21);
            this.mAMHComboBox.TabIndex = 1;
            this.mAMHComboBox.ValueMember = "MAMH";
            // 
            // bdsMonhoc
            // 
            this.bdsMonhoc.DataMember = "Monhoc";
            this.bdsMonhoc.DataSource = this.dB_THI_TN;
            // 
            // bdsCTBaithi
            // 
            this.bdsCTBaithi.DataMember = "ChiTiet_BaiThi";
            this.bdsCTBaithi.DataSource = this.dB_THI_TN;
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Location = new System.Drawing.Point(583, 28);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(48, 13);
            dAP_ANLabel.TabIndex = 15;
            dAP_ANLabel.Text = "DAP AN:";
            // 
            // dAP_ANComboBox
            // 
            this.dAP_ANComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBode, "DAP_AN", true));
            this.dAP_ANComboBox.FormattingEnabled = true;
            this.dAP_ANComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.dAP_ANComboBox.Location = new System.Drawing.Point(637, 25);
            this.dAP_ANComboBox.Name = "dAP_ANComboBox";
            this.dAP_ANComboBox.Size = new System.Drawing.Size(121, 21);
            this.dAP_ANComboBox.TabIndex = 16;
            // 
            // FormBode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 645);
            this.Controls.Add(this.panelCauhoi);
            this.Controls.Add(this.gcBode);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormBode";
            this.Text = "FormBode";
            this.Load += new System.EventHandler(this.FormBode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_THI_TN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCauhoi)).EndInit();
            this.panelCauhoi.ResumeLayout(false);
            this.panelCauhoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOIDUNGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBaithi)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsBode;
        private DB_THI_TN dB_THI_TN;
        private DB_THI_TNTableAdapters.BodeTableAdapter bodeTableAdapter;
        private DB_THI_TNTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcBode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraEditors.PanelControl panelCauhoi;
        private DevExpress.XtraEditors.TextEdit bTextEdit;
        private DevExpress.XtraEditors.TextEdit aTextEdit;
        private DevExpress.XtraEditors.TextEdit nOIDUNGTextEdit;
        private System.Windows.Forms.ComboBox tRINHDOComboBox;
        private System.Windows.Forms.ComboBox mAMHComboBox;
        private DevExpress.XtraEditors.TextEdit dTextEdit;
        private DevExpress.XtraEditors.TextEdit cTextEdit;
        private DB_THI_TNTableAdapters.MonhocTableAdapter monhocTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonhoc;
        private DB_THI_TNTableAdapters.ChiTiet_BaiThiTableAdapter chiTiet_BaiThiTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTBaithi;
        private System.Windows.Forms.ComboBox dAP_ANComboBox;
    }
}