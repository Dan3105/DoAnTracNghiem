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
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnWrite = new DevExpress.XtraBars.BarButtonItem();
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
            this.DB_TracNghiemMonHoc = new QLThiTracNghiem.DB_TracNghiemMonHoc();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOCTableAdapter = new QLThiTracNghiem.DB_TracNghiemMonHocTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_TracNghiemMonHocTableAdapters.TableAdapterManager();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gcMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIETLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIETTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelDataView = new DevExpress.XtraEditors.PanelControl();
            this.sOTIETTHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sOTIETLTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            sOTIETLTLabel = new System.Windows.Forms.Label();
            sOTIETTHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TracNghiemMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDataView)).BeginInit();
            this.panelDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIETTHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIETLTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(101, 105);
            mAMHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(48, 16);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "MAMH:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(101, 175);
            tENMHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(53, 16);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "TENMH:";
            // 
            // sOTIETLTLabel
            // 
            sOTIETLTLabel.AutoSize = true;
            sOTIETLTLabel.Location = new System.Drawing.Point(532, 105);
            sOTIETLTLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            sOTIETLTLabel.Name = "sOTIETLTLabel";
            sOTIETLTLabel.Size = new System.Drawing.Size(70, 16);
            sOTIETLTLabel.TabIndex = 4;
            sOTIETLTLabel.Text = "SOTIETLT:";
            // 
            // sOTIETTHLabel
            // 
            sOTIETTHLabel.AutoSize = true;
            sOTIETTHLabel.Location = new System.Drawing.Point(529, 174);
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
            this.btnAdd,
            this.btnDel,
            this.btnWrite,
            this.btnUndo,
            this.btnReload,
            this.btnEdit});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnWrite, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Them";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sua";
            this.btnEdit.Id = 5;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Name = "btnEdit";
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Xoa";
            this.btnDel.Id = 1;
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.LargeImage")));
            this.btnDel.Name = "btnDel";
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
            // 
            // btnWrite
            // 
            this.btnWrite.Caption = "Ghi";
            this.btnWrite.Id = 2;
            this.btnWrite.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnWrite.ImageOptions.SvgImage")));
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWrite_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(920, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 783);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(920, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 732);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(920, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 732);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbServer);
            this.panelControl1.Controls.Add(this.lbCoso);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(920, 47);
            this.panelControl1.TabIndex = 4;
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(62, 15);
            this.cbServer.Margin = new System.Windows.Forms.Padding(6);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(246, 24);
            this.cbServer.TabIndex = 1;
            // 
            // lbCoso
            // 
            this.lbCoso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCoso.Location = new System.Drawing.Point(16, 18);
            this.lbCoso.Margin = new System.Windows.Forms.Padding(8);
            this.lbCoso.Name = "lbCoso";
            this.lbCoso.Size = new System.Drawing.Size(32, 16);
            this.lbCoso.TabIndex = 0;
            this.lbCoso.Text = "Cơ sở";
            // 
            // DB_TracNghiemMonHoc
            // 
            this.DB_TracNghiemMonHoc.DataSetName = "DB_TracNghiemMonHoc";
            this.DB_TracNghiemMonHoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.DB_TracNghiemMonHoc;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.LICHTHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_TracNghiemMonHocTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCGridControl
            // 
            this.mONHOCGridControl.DataSource = this.bdsMONHOC;
            this.mONHOCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mONHOCGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.mONHOCGridControl.Location = new System.Drawing.Point(0, 98);
            this.mONHOCGridControl.MainView = this.gcMonHoc;
            this.mONHOCGridControl.Margin = new System.Windows.Forms.Padding(6);
            this.mONHOCGridControl.MenuManager = this.barManager1;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.Size = new System.Drawing.Size(920, 430);
            this.mONHOCGridControl.TabIndex = 9;
            this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcMonHoc});
            // 
            // gcMonHoc
            // 
            this.gcMonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIETLT,
            this.colSOTIETTH});
            this.gcMonHoc.DetailHeight = 546;
            this.gcMonHoc.GridControl = this.mONHOCGridControl;
            this.gcMonHoc.Name = "gcMonHoc";
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 39;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 146;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 39;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 146;
            // 
            // colSOTIETLT
            // 
            this.colSOTIETLT.FieldName = "SOTIETLT";
            this.colSOTIETLT.MinWidth = 39;
            this.colSOTIETLT.Name = "colSOTIETLT";
            this.colSOTIETLT.Visible = true;
            this.colSOTIETLT.VisibleIndex = 2;
            this.colSOTIETLT.Width = 146;
            // 
            // colSOTIETTH
            // 
            this.colSOTIETTH.FieldName = "SOTIETTH";
            this.colSOTIETTH.MinWidth = 39;
            this.colSOTIETTH.Name = "colSOTIETTH";
            this.colSOTIETTH.Visible = true;
            this.colSOTIETTH.VisibleIndex = 3;
            this.colSOTIETTH.Width = 146;
            // 
            // panelDataView
            // 
            this.panelDataView.Controls.Add(sOTIETTHLabel);
            this.panelDataView.Controls.Add(this.sOTIETTHTextEdit);
            this.panelDataView.Controls.Add(sOTIETLTLabel);
            this.panelDataView.Controls.Add(this.sOTIETLTTextEdit);
            this.panelDataView.Controls.Add(tENMHLabel);
            this.panelDataView.Controls.Add(this.tENMHTextEdit);
            this.panelDataView.Controls.Add(mAMHLabel);
            this.panelDataView.Controls.Add(this.mAMHTextEdit);
            this.panelDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataView.Location = new System.Drawing.Point(0, 528);
            this.panelDataView.Margin = new System.Windows.Forms.Padding(6);
            this.panelDataView.Name = "panelDataView";
            this.panelDataView.Size = new System.Drawing.Size(920, 255);
            this.panelDataView.TabIndex = 10;
            // 
            // sOTIETTHTextEdit
            // 
            this.sOTIETTHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMONHOC, "SOTIETTH", true));
            this.sOTIETTHTextEdit.Location = new System.Drawing.Point(652, 169);
            this.sOTIETTHTextEdit.Margin = new System.Windows.Forms.Padding(6);
            this.sOTIETTHTextEdit.MenuManager = this.barManager1;
            this.sOTIETTHTextEdit.Name = "sOTIETTHTextEdit";
            this.sOTIETTHTextEdit.Size = new System.Drawing.Size(244, 22);
            this.sOTIETTHTextEdit.TabIndex = 7;
            // 
            // sOTIETLTTextEdit
            // 
            this.sOTIETLTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMONHOC, "SOTIETLT", true));
            this.sOTIETLTTextEdit.Location = new System.Drawing.Point(652, 99);
            this.sOTIETLTTextEdit.Margin = new System.Windows.Forms.Padding(6);
            this.sOTIETLTTextEdit.MenuManager = this.barManager1;
            this.sOTIETLTTextEdit.Name = "sOTIETLTTextEdit";
            this.sOTIETLTTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sOTIETLTTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sOTIETLTTextEdit.Size = new System.Drawing.Size(244, 22);
            this.sOTIETLTTextEdit.TabIndex = 5;
            // 
            // tENMHTextEdit
            // 
            this.tENMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMONHOC, "TENMH", true));
            this.tENMHTextEdit.Location = new System.Drawing.Point(195, 170);
            this.tENMHTextEdit.Margin = new System.Windows.Forms.Padding(6);
            this.tENMHTextEdit.MenuManager = this.barManager1;
            this.tENMHTextEdit.Name = "tENMHTextEdit";
            this.tENMHTextEdit.Size = new System.Drawing.Size(244, 22);
            this.tENMHTextEdit.TabIndex = 3;
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMONHOC, "MAMH", true));
            this.mAMHTextEdit.Location = new System.Drawing.Point(195, 100);
            this.mAMHTextEdit.Margin = new System.Windows.Forms.Padding(6);
            this.mAMHTextEdit.MenuManager = this.barManager1;
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Size = new System.Drawing.Size(244, 22);
            this.mAMHTextEdit.TabIndex = 1;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 803);
            this.Controls.Add(this.panelDataView);
            this.Controls.Add(this.mONHOCGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormMonHoc";
            this.Text = " FormMonHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TracNghiemMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDataView)).EndInit();
            this.panelDataView.ResumeLayout(false);
            this.panelDataView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIETTHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIETLTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnWrite;
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
        private DB_TracNghiemMonHoc DB_TracNghiemMonHoc;
        private DB_TracNghiemMonHocTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private DB_TracNghiemMonHocTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraEditors.PanelControl panelDataView;
        private DevExpress.XtraEditors.TextEdit sOTIETTHTextEdit;
        private DevExpress.XtraEditors.TextEdit sOTIETLTTextEdit;
        private DevExpress.XtraEditors.TextEdit tENMHTextEdit;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gcMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIETLT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIETTH;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
    }
}