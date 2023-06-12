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
            this.lbCoso = new DevExpress.XtraEditors.LabelControl();
            this.gcMONHOC = new DevExpress.XtraGrid.GridControl();
            this.bdsMonhoc = new System.Windows.Forms.BindingSource(this.components);
            this.DB_THI_TN = new QLThiTracNghiem.DB_THI_TN();
            this.gvMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelDataView = new DevExpress.XtraEditors.PanelControl();
            this.panelMonhoc = new DevExpress.XtraEditors.PanelControl();
            this.txtTENMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMAMH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.MonhocTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.MonhocTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager();
            this.Giaovien_DangkyTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.Giaovien_DangkyTableAdapter();
            this.bdsGiaovien_Dangky = new System.Windows.Forms.BindingSource(this.components);
            this.bdsBode = new System.Windows.Forms.BindingSource(this.components);
            this.BodeTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.BodeTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMonhoc)).BeginInit();
            this.panelMonhoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaovien_Dangky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBode)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(11, 55);
            mAMHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(48, 16);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "MAMH:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(11, 107);
            tENMHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(53, 16);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "TENMH:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(889, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 474);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(889, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 423);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(889, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 423);
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
            // gcMONHOC
            // 
            this.gcMONHOC.DataSource = this.bdsMonhoc;
            this.gcMONHOC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMONHOC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gcMONHOC.Location = new System.Drawing.Point(5, 6);
            this.gcMONHOC.MainView = this.gvMonHoc;
            this.gcMONHOC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gcMONHOC.MenuManager = this.barManager1;
            this.gcMONHOC.Name = "gcMONHOC";
            this.gcMONHOC.Size = new System.Drawing.Size(879, 223);
            this.gcMONHOC.TabIndex = 9;
            this.gcMONHOC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMonHoc});
            // 
            // bdsMonhoc
            // 
            this.bdsMonhoc.DataMember = "Monhoc";
            this.bdsMonhoc.DataSource = this.DB_THI_TN;
            // 
            // DB_THI_TN
            // 
            this.DB_THI_TN.DataSetName = "DB_THI_TN";
            this.DB_THI_TN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMonHoc
            // 
            this.gvMonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gvMonHoc.DetailHeight = 546;
            this.gvMonHoc.GridControl = this.gcMONHOC;
            this.gvMonHoc.Name = "gvMonHoc";
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // panelDataView
            // 
            this.panelDataView.AutoSize = true;
            this.panelDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDataView.Location = new System.Drawing.Point(0, 470);
            this.panelDataView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelDataView.Name = "panelDataView";
            this.panelDataView.Size = new System.Drawing.Size(889, 4);
            this.panelDataView.TabIndex = 10;
            // 
            // panelMonhoc
            // 
            this.panelMonhoc.Controls.Add(this.txtTENMH);
            this.panelMonhoc.Controls.Add(this.txtMAMH);
            this.panelMonhoc.Controls.Add(this.labelControl1);
            this.panelMonhoc.Controls.Add(tENMHLabel);
            this.panelMonhoc.Controls.Add(mAMHLabel);
            this.panelMonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMonhoc.Location = new System.Drawing.Point(3, 238);
            this.panelMonhoc.Name = "panelMonhoc";
            this.panelMonhoc.Size = new System.Drawing.Size(883, 178);
            this.panelMonhoc.TabIndex = 9;
            // 
            // txtTENMH
            // 
            this.txtTENMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonhoc, "TENMH", true));
            this.txtTENMH.Location = new System.Drawing.Point(88, 101);
            this.txtTENMH.MenuManager = this.barManager1;
            this.txtTENMH.Name = "txtTENMH";
            this.txtTENMH.Properties.MaxLength = 50;
            this.txtTENMH.Size = new System.Drawing.Size(203, 22);
            this.txtTENMH.TabIndex = 10;
            // 
            // txtMAMH
            // 
            this.txtMAMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonhoc, "MAMH", true));
            this.txtMAMH.Location = new System.Drawing.Point(88, 52);
            this.txtMAMH.MenuManager = this.barManager1;
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.Properties.MaxLength = 5;
            this.txtMAMH.Size = new System.Drawing.Size(125, 22);
            this.txtMAMH.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(107, 26);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Thông tin môn học";
            // 
            // MonhocTableAdapter
            // 
            this.MonhocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemTableAdapter = null;
            this.tableAdapterManager.BodeTableAdapter = null;
            this.tableAdapterManager.ChiTiet_BaiThiTableAdapter = null;
            this.tableAdapterManager.Giaovien_DangkyTableAdapter = this.Giaovien_DangkyTableAdapter;
            this.tableAdapterManager.GiaovienTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonhocTableAdapter = this.MonhocTableAdapter;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Giaovien_DangkyTableAdapter
            // 
            this.Giaovien_DangkyTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGiaovien_Dangky
            // 
            this.bdsGiaovien_Dangky.DataMember = "FK_Giaovien_Dangky_Monhoc";
            this.bdsGiaovien_Dangky.DataSource = this.bdsMonhoc;
            // 
            // bdsBode
            // 
            this.bdsBode.DataMember = "FK_Bode_Monhoc";
            this.bdsBode.DataSource = this.bdsMonhoc;
            // 
            // BodeTableAdapter
            // 
            this.BodeTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelMonhoc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gcMONHOC, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 419);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelDataView);
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
            ((System.ComponentModel.ISupportInitialize)(this.gcMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMonhoc)).EndInit();
            this.panelMonhoc.ResumeLayout(false);
            this.panelMonhoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaovien_Dangky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBode)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        //private System.Windows.Forms.ComboBox cbServer;
        private DevExpress.XtraEditors.LabelControl lbCoso;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraGrid.GridControl gcMONHOC;
        private DevExpress.XtraEditors.PanelControl panelDataView;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelMonhoc;
        private DB_THI_TN DB_THI_TN;
        private System.Windows.Forms.BindingSource bdsMonhoc;
        private DB_THI_TNTableAdapters.MonhocTableAdapter MonhocTableAdapter;
        private DB_THI_TNTableAdapters.TableAdapterManager tableAdapterManager;
        private DB_THI_TNTableAdapters.Giaovien_DangkyTableAdapter Giaovien_DangkyTableAdapter;
        private System.Windows.Forms.BindingSource bdsGiaovien_Dangky;
        private System.Windows.Forms.BindingSource bdsBode;
        private DB_THI_TNTableAdapters.BodeTableAdapter BodeTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraEditors.TextEdit txtTENMH;
        private DevExpress.XtraEditors.TextEdit txtMAMH;
    }
}