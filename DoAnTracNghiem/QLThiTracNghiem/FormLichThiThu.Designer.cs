namespace QLThiTracNghiem
{
    partial class FormLichThiThu
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gcMonhoc = new DevExpress.XtraGrid.GridControl();
            this.bdsMonhoc = new System.Windows.Forms.BindingSource(this.components);
            this.DB_THI_TN = new QLThiTracNghiem.DB_THI_TN();
            this.gvMonhoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.giaovien_DangkyGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsGiaovien_Dangky = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panelThi = new System.Windows.Forms.Panel();
            this.txtTENMH = new DevExpress.XtraEditors.TextEdit();
            this.btnThiThu = new System.Windows.Forms.Button();
            this.tHOIGIANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.lANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.nGAYTHIDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tRINHDOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mALOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MonhocTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.MonhocTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager();
            this.giaovien_DangkyTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.Giaovien_DangkyTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonhoc)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaovien_DangkyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaovien_Dangky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(8, 59);
            mALOPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(56, 19);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã lớp:";
            mALOPLabel.Click += new System.EventHandler(this.mALOPLabel_Click);
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRINHDOLabel.Location = new System.Drawing.Point(8, 103);
            tRINHDOLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(62, 19);
            tRINHDOLabel.TabIndex = 2;
            tRINHDOLabel.Text = "Trình độ:";
            tRINHDOLabel.Click += new System.EventHandler(this.tRINHDOLabel_Click);
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYTHILabel.Location = new System.Drawing.Point(560, 18);
            nGAYTHILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(63, 19);
            nGAYTHILabel.TabIndex = 4;
            nGAYTHILabel.Text = "Ngày thi:";
            nGAYTHILabel.Click += new System.EventHandler(this.nGAYTHILabel_Click);
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lANLabel.Location = new System.Drawing.Point(569, 62);
            lANLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(53, 19);
            lANLabel.TabIndex = 6;
            lANLabel.Text = "Lần thi:";
            lANLabel.Click += new System.EventHandler(this.lANLabel_Click);
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tHOIGIANLabel.Location = new System.Drawing.Point(510, 103);
            tHOIGIANLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(85, 19);
            tHOIGIANLabel.TabIndex = 8;
            tHOIGIANLabel.Text = "Thời gian thi:";
            tHOIGIANLabel.Click += new System.EventHandler(this.tHOIGIANLabel_Click);
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMHLabel.Location = new System.Drawing.Point(8, 15);
            tENMHLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(91, 19);
            tENMHLabel.TabIndex = 11;
            tENMHLabel.Text = "Tên môn học:";
            tENMHLabel.Click += new System.EventHandler(this.tENMHLabel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelThi, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 444);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(994, 286);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.gcMonhoc, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.76923F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.23077F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(244, 282);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // gcMonhoc
            // 
            this.gcMonhoc.DataSource = this.bdsMonhoc;
            this.gcMonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMonhoc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcMonhoc.Location = new System.Drawing.Point(8, 49);
            this.gcMonhoc.MainView = this.gvMonhoc;
            this.gcMonhoc.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gcMonhoc.Name = "gcMonhoc";
            this.gcMonhoc.Size = new System.Drawing.Size(228, 225);
            this.gcMonhoc.TabIndex = 0;
            this.gcMonhoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMonhoc});
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
            // gvMonhoc
            // 
            this.gvMonhoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gvMonhoc.DetailHeight = 284;
            this.gvMonhoc.GridControl = this.gcMonhoc;
            this.gvMonhoc.Name = "gvMonhoc";
            this.gvMonhoc.OptionsBehavior.Editable = false;
            this.gvMonhoc.OptionsView.RowAutoHeight = true;
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAMH.AppearanceCell.Options.UseFont = true;
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 19;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 70;
            // 
            // colTENMH
            // 
            this.colTENMH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENMH.AppearanceCell.Options.UseFont = true;
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 19;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách các môn học";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.giaovien_DangkyGridControl, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(250, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.76923F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.23077F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(742, 282);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // giaovien_DangkyGridControl
            // 
            this.giaovien_DangkyGridControl.DataSource = this.bdsGiaovien_Dangky;
            this.giaovien_DangkyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giaovien_DangkyGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.giaovien_DangkyGridControl.Location = new System.Drawing.Point(2, 43);
            this.giaovien_DangkyGridControl.MainView = this.gridView1;
            this.giaovien_DangkyGridControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.giaovien_DangkyGridControl.Name = "giaovien_DangkyGridControl";
            this.giaovien_DangkyGridControl.Size = new System.Drawing.Size(738, 237);
            this.giaovien_DangkyGridControl.TabIndex = 1;
            this.giaovien_DangkyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsGiaovien_Dangky
            // 
            this.bdsGiaovien_Dangky.DataMember = "FK_Giaovien_Dangky_Monhoc";
            this.bdsGiaovien_Dangky.DataSource = this.bdsMonhoc;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.giaovien_DangkyGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALOP.AppearanceCell.Options.UseFont = true;
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 19;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 70;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTRINHDO.AppearanceCell.Options.UseFont = true;
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 19;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 1;
            this.colTRINHDO.Width = 70;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYTHI.AppearanceCell.Options.UseFont = true;
            this.colNGAYTHI.Caption = "Ngày thi";
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.MinWidth = 19;
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 2;
            this.colNGAYTHI.Width = 70;
            // 
            // colLAN
            // 
            this.colLAN.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLAN.AppearanceCell.Options.UseFont = true;
            this.colLAN.Caption = "Lần thi";
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 19;
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 3;
            this.colLAN.Width = 70;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOCAUTHI.AppearanceCell.Options.UseFont = true;
            this.colSOCAUTHI.Caption = "Số câu thi";
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.MinWidth = 19;
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 4;
            this.colSOCAUTHI.Width = 70;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTHOIGIAN.AppearanceCell.Options.UseFont = true;
            this.colTHOIGIAN.Caption = "Thời gian thi";
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.MinWidth = 19;
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 5;
            this.colTHOIGIAN.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(738, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách thi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelThi
            // 
            this.panelThi.AutoScroll = true;
            this.panelThi.Controls.Add(tENMHLabel);
            this.panelThi.Controls.Add(this.txtTENMH);
            this.panelThi.Controls.Add(this.btnThiThu);
            this.panelThi.Controls.Add(tHOIGIANLabel);
            this.panelThi.Controls.Add(this.tHOIGIANSpinEdit);
            this.panelThi.Controls.Add(lANLabel);
            this.panelThi.Controls.Add(this.lANSpinEdit);
            this.panelThi.Controls.Add(nGAYTHILabel);
            this.panelThi.Controls.Add(this.nGAYTHIDateEdit);
            this.panelThi.Controls.Add(tRINHDOLabel);
            this.panelThi.Controls.Add(this.tRINHDOTextEdit);
            this.panelThi.Controls.Add(mALOPLabel);
            this.panelThi.Controls.Add(this.mALOPTextEdit);
            this.panelThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThi.Location = new System.Drawing.Point(2, 292);
            this.panelThi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelThi.Name = "panelThi";
            this.panelThi.Size = new System.Drawing.Size(994, 150);
            this.panelThi.TabIndex = 2;
            // 
            // txtTENMH
            // 
            this.txtTENMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonhoc, "TENMH", true));
            this.txtTENMH.Enabled = false;
            this.txtTENMH.Location = new System.Drawing.Point(139, 7);
            this.txtTENMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTENMH.Name = "txtTENMH";
            this.txtTENMH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENMH.Properties.Appearance.Options.UseFont = true;
            this.txtTENMH.Size = new System.Drawing.Size(325, 32);
            this.txtTENMH.TabIndex = 12;
            this.txtTENMH.EditValueChanged += new System.EventHandler(this.txtTENMH_EditValueChanged);
            // 
            // btnThiThu
            // 
            this.btnThiThu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThiThu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThiThu.Location = new System.Drawing.Point(922, 0);
            this.btnThiThu.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnThiThu.Name = "btnThiThu";
            this.btnThiThu.Size = new System.Drawing.Size(72, 150);
            this.btnThiThu.TabIndex = 10;
            this.btnThiThu.Text = "Thi thử";
            this.btnThiThu.UseVisualStyleBackColor = true;
            this.btnThiThu.Click += new System.EventHandler(this.btnThiThu_Click);
            // 
            // tHOIGIANSpinEdit
            // 
            this.tHOIGIANSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaovien_Dangky, "THOIGIAN", true));
            this.tHOIGIANSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tHOIGIANSpinEdit.Enabled = false;
            this.tHOIGIANSpinEdit.Location = new System.Drawing.Point(643, 101);
            this.tHOIGIANSpinEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tHOIGIANSpinEdit.Name = "tHOIGIANSpinEdit";
            this.tHOIGIANSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHOIGIANSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.tHOIGIANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tHOIGIANSpinEdit.Size = new System.Drawing.Size(94, 26);
            this.tHOIGIANSpinEdit.TabIndex = 9;
            this.tHOIGIANSpinEdit.EditValueChanged += new System.EventHandler(this.tHOIGIANSpinEdit_EditValueChanged);
            // 
            // lANSpinEdit
            // 
            this.lANSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaovien_Dangky, "LAN", true));
            this.lANSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lANSpinEdit.Enabled = false;
            this.lANSpinEdit.Location = new System.Drawing.Point(643, 57);
            this.lANSpinEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lANSpinEdit.Name = "lANSpinEdit";
            this.lANSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lANSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.lANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lANSpinEdit.Size = new System.Drawing.Size(94, 26);
            this.lANSpinEdit.TabIndex = 7;
            this.lANSpinEdit.EditValueChanged += new System.EventHandler(this.lANSpinEdit_EditValueChanged);
            // 
            // nGAYTHIDateEdit
            // 
            this.nGAYTHIDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaovien_Dangky, "NGAYTHI", true));
            this.nGAYTHIDateEdit.EditValue = null;
            this.nGAYTHIDateEdit.Enabled = false;
            this.nGAYTHIDateEdit.Location = new System.Drawing.Point(643, 7);
            this.nGAYTHIDateEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nGAYTHIDateEdit.Name = "nGAYTHIDateEdit";
            this.nGAYTHIDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nGAYTHIDateEdit.Properties.Appearance.Options.UseFont = true;
            this.nGAYTHIDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.nGAYTHIDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.nGAYTHIDateEdit.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.nGAYTHIDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.nGAYTHIDateEdit.Properties.MaskSettings.Set("mask", "dd/MM/yyyy HH:mm:ss");
            this.nGAYTHIDateEdit.Size = new System.Drawing.Size(129, 32);
            this.nGAYTHIDateEdit.TabIndex = 5;
            this.nGAYTHIDateEdit.EditValueChanged += new System.EventHandler(this.nGAYTHIDateEdit_EditValueChanged);
            // 
            // tRINHDOTextEdit
            // 
            this.tRINHDOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaovien_Dangky, "TRINHDO", true));
            this.tRINHDOTextEdit.Enabled = false;
            this.tRINHDOTextEdit.Location = new System.Drawing.Point(139, 101);
            this.tRINHDOTextEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tRINHDOTextEdit.Name = "tRINHDOTextEdit";
            this.tRINHDOTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRINHDOTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tRINHDOTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tRINHDOTextEdit.Size = new System.Drawing.Size(94, 26);
            this.tRINHDOTextEdit.TabIndex = 3;
            this.tRINHDOTextEdit.EditValueChanged += new System.EventHandler(this.tRINHDOTextEdit_EditValueChanged);
            // 
            // mALOPTextEdit
            // 
            this.mALOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaovien_Dangky, "MALOP", true));
            this.mALOPTextEdit.EditValue = "";
            this.mALOPTextEdit.Enabled = false;
            this.mALOPTextEdit.Location = new System.Drawing.Point(139, 58);
            this.mALOPTextEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mALOPTextEdit.Name = "mALOPTextEdit";
            this.mALOPTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mALOPTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mALOPTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mALOPTextEdit.Size = new System.Drawing.Size(168, 26);
            this.mALOPTextEdit.TabIndex = 1;
            this.mALOPTextEdit.EditValueChanged += new System.EventHandler(this.mALOPTextEdit_EditValueChanged);
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
            this.tableAdapterManager.Giaovien_DangkyTableAdapter = this.giaovien_DangkyTableAdapter;
            this.tableAdapterManager.GiaovienTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonhocTableAdapter = this.MonhocTableAdapter;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // giaovien_DangkyTableAdapter
            // 
            this.giaovien_DangkyTableAdapter.ClearBeforeFill = true;
            // 
            // FormLichThiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLichThiThu";
            this.Text = "Quản lý lịch thi";
            this.Load += new System.EventHandler(this.FormLichThi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonhoc)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaovien_DangkyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaovien_Dangky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelThi.ResumeLayout(false);
            this.panelThi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DB_THI_TN DB_THI_TN;
        private System.Windows.Forms.BindingSource bdsMonhoc;
        private DB_THI_TNTableAdapters.MonhocTableAdapter MonhocTableAdapter;
        private DB_THI_TNTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcMonhoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMonhoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private DB_THI_TNTableAdapters.Giaovien_DangkyTableAdapter giaovien_DangkyTableAdapter;
        private System.Windows.Forms.BindingSource bdsGiaovien_Dangky;
        private DevExpress.XtraGrid.GridControl giaovien_DangkyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.Panel panelThi;
        private System.Windows.Forms.Button btnThiThu;
        private DevExpress.XtraEditors.SpinEdit tHOIGIANSpinEdit;
        private DevExpress.XtraEditors.SpinEdit lANSpinEdit;
        private DevExpress.XtraEditors.DateEdit nGAYTHIDateEdit;
        private DevExpress.XtraEditors.TextEdit tRINHDOTextEdit;
        private DevExpress.XtraEditors.TextEdit mALOPTextEdit;
        private DevExpress.XtraEditors.TextEdit txtTENMH;
    }
}