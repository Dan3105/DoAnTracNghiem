namespace QLThiTracNghiem
{
	partial class FormSinhVien
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSinhVien));
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.cbKHOA = new System.Windows.Forms.ComboBox();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.DB_THI_TN = new QLThiTracNghiem.DB_THI_TN();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbCOSO = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gcLOP = new DevExpress.XtraGrid.GridControl();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.gvLOP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMNH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gcSINHVIEN = new DevExpress.XtraGrid.GridControl();
            this.bdsSinhvien = new System.Windows.Forms.BindingSource(this.components);
            this.gvSINHVIEN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelSINHVIEN = new DevExpress.XtraEditors.PanelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtDIACHI = new DevExpress.XtraEditors.TextEdit();
            this.dateNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.txtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.txtMASV = new DevExpress.XtraEditors.TextEdit();
            this.btnPhucHoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhiSINHVIEN = new DevExpress.XtraEditors.SimpleButton();
            this.menuStripSINHVIEN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsSuaSINHVIEN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsThemSINHVIEN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsXoaSINHVIEN = new System.Windows.Forms.ToolStripMenuItem();
            this.KhoaTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.KhoaTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager();
            this.LopTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.LopTableAdapter();
            this.SinhvienTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.SinhvienTableAdapter();
            this.bdsBangdiem = new System.Windows.Forms.BindingSource(this.components);
            this.bangDiemTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.BangDiemTableAdapter();
            mASVLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLOP)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSINHVIEN)).BeginInit();
            this.panelSINHVIEN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).BeginInit();
            this.menuStripSINHVIEN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mASVLabel.Location = new System.Drawing.Point(26, 58);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(88, 19);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "Mã sinh viên:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Enabled = false;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(196, 16);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(56, 19);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(82, 89);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(31, 19);
            hOLabel.TabIndex = 4;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(257, 89);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(35, 19);
            tENLabel.TabIndex = 6;
            tENLabel.Text = "Tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(59, 152);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(54, 19);
            dIACHILabel.TabIndex = 10;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYSINHLabel.Location = new System.Drawing.Point(41, 119);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(72, 19);
            nGAYSINHLabel.TabIndex = 14;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Password:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.cbKHOA);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.cbCOSO);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1139, 43);
            this.panelControl1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Location = new System.Drawing.Point(625, 6);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbKHOA
            // 
            this.cbKHOA.DataSource = this.bdsKhoa;
            this.cbKHOA.DisplayMember = "TENKH";
            this.cbKHOA.FormattingEnabled = true;
            this.cbKHOA.Location = new System.Drawing.Point(348, 11);
            this.cbKHOA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKHOA.Name = "cbKHOA";
            this.cbKHOA.Size = new System.Drawing.Size(229, 21);
            this.cbKHOA.TabIndex = 3;
            this.cbKHOA.ValueMember = "MAKH";
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(284, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Khoa";
            // 
            // cbCOSO
            // 
            this.cbCOSO.FormattingEnabled = true;
            this.cbCOSO.Location = new System.Drawing.Point(68, 11);
            this.cbCOSO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCOSO.Name = "cbCOSO";
            this.cbCOSO.Size = new System.Drawing.Size(162, 21);
            this.cbCOSO.TabIndex = 1;
            this.cbCOSO.SelectedIndexChanged += new System.EventHandler(this.cbCOSO_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cơ sở";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gcLOP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.64203F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.35797F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 482);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gcLOP
            // 
            this.gcLOP.DataSource = this.bdsLop;
            this.gcLOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLOP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcLOP.Location = new System.Drawing.Point(3, 2);
            this.gcLOP.MainView = this.gvLOP;
            this.gcLOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcLOP.Name = "gcLOP";
            this.gcLOP.Size = new System.Drawing.Size(1133, 162);
            this.gcLOP.TabIndex = 0;
            this.gcLOP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLOP});
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "FK_Lop_Khoa";
            this.bdsLop.DataSource = this.bdsKhoa;
            // 
            // gvLOP
            // 
            this.gvLOP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colNAMNH,
            this.colMAKHOA});
            this.gvLOP.DetailHeight = 284;
            this.gvLOP.GridControl = this.gcLOP;
            this.gvLOP.Name = "gvLOP";
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALOP.AppearanceCell.Options.UseFont = true;
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 21;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 81;
            // 
            // colTENLOP
            // 
            this.colTENLOP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENLOP.AppearanceCell.Options.UseFont = true;
            this.colTENLOP.Caption = "Tên lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 21;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 81;
            // 
            // colNAMNH
            // 
            this.colNAMNH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNAMNH.AppearanceCell.Options.UseFont = true;
            this.colNAMNH.Caption = "Năm nhập học";
            this.colNAMNH.FieldName = "NAMNH";
            this.colNAMNH.MinWidth = 21;
            this.colNAMNH.Name = "colNAMNH";
            this.colNAMNH.Visible = true;
            this.colNAMNH.VisibleIndex = 2;
            this.colNAMNH.Width = 81;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHOA.AppearanceCell.Options.UseFont = true;
            this.colMAKHOA.Caption = "Mã khoa";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 21;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            this.colMAKHOA.Width = 81;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.80997F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.19003F));
            this.tableLayoutPanel2.Controls.Add(this.gcSINHVIEN, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelSINHVIEN, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 168);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1133, 312);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // gcSINHVIEN
            // 
            this.gcSINHVIEN.DataSource = this.bdsSinhvien;
            this.gcSINHVIEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSINHVIEN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSINHVIEN.Location = new System.Drawing.Point(3, 2);
            this.gcSINHVIEN.MainView = this.gvSINHVIEN;
            this.gcSINHVIEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSINHVIEN.Name = "gcSINHVIEN";
            this.gcSINHVIEN.Size = new System.Drawing.Size(739, 308);
            this.gcSINHVIEN.TabIndex = 0;
            this.gcSINHVIEN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSINHVIEN});
            // 
            // bdsSinhvien
            // 
            this.bdsSinhvien.DataMember = "FK_Sinhvien_Lop";
            this.bdsSinhvien.DataSource = this.bdsLop;
            // 
            // gvSINHVIEN
            // 
            this.gvSINHVIEN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colMALOP1,
            this.colPASSWORD});
            this.gvSINHVIEN.DetailHeight = 284;
            this.gvSINHVIEN.GridControl = this.gcSINHVIEN;
            this.gvSINHVIEN.Name = "gvSINHVIEN";
            // 
            // colMASV
            // 
            this.colMASV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMASV.AppearanceCell.Options.UseFont = true;
            this.colMASV.Caption = "Mã sinh viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 21;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 81;
            // 
            // colHO
            // 
            this.colHO.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHO.AppearanceCell.Options.UseFont = true;
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 21;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 81;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTEN.AppearanceCell.Options.UseFont = true;
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 21;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 81;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYSINH.AppearanceCell.Options.UseFont = true;
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYSINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 21;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            this.colNGAYSINH.Width = 81;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIACHI.AppearanceCell.Options.UseFont = true;
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 21;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 81;
            // 
            // colMALOP1
            // 
            this.colMALOP1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALOP1.AppearanceCell.Options.UseFont = true;
            this.colMALOP1.Caption = "Mã lớp";
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.MinWidth = 21;
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 5;
            this.colMALOP1.Width = 81;
            // 
            // colPASSWORD
            // 
            this.colPASSWORD.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPASSWORD.AppearanceCell.Options.UseFont = true;
            this.colPASSWORD.Caption = "Password";
            this.colPASSWORD.FieldName = "PASSWORD";
            this.colPASSWORD.MinWidth = 21;
            this.colPASSWORD.Name = "colPASSWORD";
            this.colPASSWORD.Visible = true;
            this.colPASSWORD.VisibleIndex = 6;
            this.colPASSWORD.Width = 81;
            // 
            // panelSINHVIEN
            // 
            this.panelSINHVIEN.Controls.Add(this.label1);
            this.panelSINHVIEN.Controls.Add(this.txtPassword);
            this.panelSINHVIEN.Controls.Add(this.txtDIACHI);
            this.panelSINHVIEN.Controls.Add(this.dateNGAYSINH);
            this.panelSINHVIEN.Controls.Add(this.txtMALOP);
            this.panelSINHVIEN.Controls.Add(this.txtTEN);
            this.panelSINHVIEN.Controls.Add(this.txtHO);
            this.panelSINHVIEN.Controls.Add(this.txtMASV);
            this.panelSINHVIEN.Controls.Add(nGAYSINHLabel);
            this.panelSINHVIEN.Controls.Add(this.btnPhucHoi);
            this.panelSINHVIEN.Controls.Add(this.btnGhiSINHVIEN);
            this.panelSINHVIEN.Controls.Add(dIACHILabel);
            this.panelSINHVIEN.Controls.Add(tENLabel);
            this.panelSINHVIEN.Controls.Add(hOLabel);
            this.panelSINHVIEN.Controls.Add(mALOPLabel);
            this.panelSINHVIEN.Controls.Add(mASVLabel);
            this.panelSINHVIEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSINHVIEN.Location = new System.Drawing.Point(748, 2);
            this.panelSINHVIEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSINHVIEN.Name = "panelSINHVIEN";
            this.panelSINHVIEN.Size = new System.Drawing.Size(382, 308);
            this.panelSINHVIEN.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "PASSWORD", true));
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(128, 179);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Size = new System.Drawing.Size(107, 26);
            this.txtPassword.TabIndex = 21;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(128, 149);
            this.txtDIACHI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDIACHI.Properties.Appearance.Options.UseFont = true;
            this.txtDIACHI.Size = new System.Drawing.Size(216, 26);
            this.txtDIACHI.TabIndex = 20;
            // 
            // dateNGAYSINH
            // 
            this.dateNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "NGAYSINH", true));
            this.dateNGAYSINH.EditValue = null;
            this.dateNGAYSINH.Location = new System.Drawing.Point(128, 116);
            this.dateNGAYSINH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNGAYSINH.Name = "dateNGAYSINH";
            this.dateNGAYSINH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNGAYSINH.Properties.Appearance.Options.UseFont = true;
            this.dateNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYSINH.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNGAYSINH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNGAYSINH.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNGAYSINH.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNGAYSINH.Size = new System.Drawing.Size(107, 26);
            this.dateNGAYSINH.TabIndex = 19;
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "MALOP", true));
            this.txtMALOP.Enabled = false;
            this.txtMALOP.Location = new System.Drawing.Point(258, 13);
            this.txtMALOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMALOP.Properties.Appearance.Options.UseFont = true;
            this.txtMALOP.Size = new System.Drawing.Size(97, 26);
            this.txtMALOP.TabIndex = 18;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(296, 86);
            this.txtTEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTEN.Properties.Appearance.Options.UseFont = true;
            this.txtTEN.Size = new System.Drawing.Size(68, 26);
            this.txtTEN.TabIndex = 17;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(128, 86);
            this.txtHO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHO.Name = "txtHO";
            this.txtHO.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHO.Properties.Appearance.Options.UseFont = true;
            this.txtHO.Size = new System.Drawing.Size(122, 26);
            this.txtHO.TabIndex = 16;
            // 
            // txtMASV
            // 
            this.txtMASV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "MASV", true));
            this.txtMASV.Location = new System.Drawing.Point(128, 56);
            this.txtMASV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMASV.Properties.Appearance.Options.UseFont = true;
            this.txtMASV.Size = new System.Drawing.Size(107, 26);
            this.txtMASV.TabIndex = 15;
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhucHoi.Appearance.Options.UseFont = true;
            this.btnPhucHoi.Location = new System.Drawing.Point(230, 225);
            this.btnPhucHoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(95, 32);
            this.btnPhucHoi.TabIndex = 13;
            this.btnPhucHoi.Text = "Phục hồi";
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // btnGhiSINHVIEN
            // 
            this.btnGhiSINHVIEN.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiSINHVIEN.Appearance.Options.UseFont = true;
            this.btnGhiSINHVIEN.Location = new System.Drawing.Point(63, 225);
            this.btnGhiSINHVIEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGhiSINHVIEN.Name = "btnGhiSINHVIEN";
            this.btnGhiSINHVIEN.Size = new System.Drawing.Size(95, 32);
            this.btnGhiSINHVIEN.TabIndex = 12;
            this.btnGhiSINHVIEN.Text = "Ghi Sinh Viên";
            this.btnGhiSINHVIEN.Click += new System.EventHandler(this.btnGhiSINHVIEN_Click);
            // 
            // menuStripSINHVIEN
            // 
            this.menuStripSINHVIEN.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripSINHVIEN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSuaSINHVIEN,
            this.tsThemSINHVIEN,
            this.tsXoaSINHVIEN});
            this.menuStripSINHVIEN.Name = "menuStripSINHVIEN";
            this.menuStripSINHVIEN.Size = new System.Drawing.Size(178, 70);
            // 
            // tsSuaSINHVIEN
            // 
            this.tsSuaSINHVIEN.Name = "tsSuaSINHVIEN";
            this.tsSuaSINHVIEN.Size = new System.Drawing.Size(177, 22);
            this.tsSuaSINHVIEN.Text = "Chỉnh sửa sinh viên";
            this.tsSuaSINHVIEN.Click += new System.EventHandler(this.tsSuaSINHVIEN_Click);
            // 
            // tsThemSINHVIEN
            // 
            this.tsThemSINHVIEN.Name = "tsThemSINHVIEN";
            this.tsThemSINHVIEN.Size = new System.Drawing.Size(177, 22);
            this.tsThemSINHVIEN.Text = "Thêm Sinh Viên";
            this.tsThemSINHVIEN.Click += new System.EventHandler(this.tsThemSINHVIEN_Click);
            // 
            // tsXoaSINHVIEN
            // 
            this.tsXoaSINHVIEN.Name = "tsXoaSINHVIEN";
            this.tsXoaSINHVIEN.Size = new System.Drawing.Size(177, 22);
            this.tsXoaSINHVIEN.Text = "Xóa Sinh Viên";
            this.tsXoaSINHVIEN.Click += new System.EventHandler(this.tsXoaSINHVIEN_Click);
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
            this.tableAdapterManager.SinhvienTableAdapter = this.SinhvienTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LopTableAdapter
            // 
            this.LopTableAdapter.ClearBeforeFill = true;
            // 
            // SinhvienTableAdapter
            // 
            this.SinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // bdsBangdiem
            // 
            this.bdsBangdiem.DataMember = "FK_BangDiem_Sinhvien";
            this.bdsBangdiem.DataSource = this.bdsSinhvien;
            // 
            // bangDiemTableAdapter
            // 
            this.bangDiemTableAdapter.ClearBeforeFill = true;
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSinhVien";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLOP)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSINHVIEN)).EndInit();
            this.panelSINHVIEN.ResumeLayout(false);
            this.panelSINHVIEN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).EndInit();
            this.menuStripSINHVIEN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangdiem)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbKHOA;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cbCOSO;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gcLOP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMNH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraGrid.GridControl gcSINHVIEN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSINHVIEN;
        private DevExpress.XtraEditors.PanelControl panelSINHVIEN;
        private DevExpress.XtraEditors.SimpleButton btnPhucHoi;
        private DevExpress.XtraEditors.SimpleButton btnGhiSINHVIEN;
        private System.Windows.Forms.ContextMenuStrip menuStripSINHVIEN;
        private System.Windows.Forms.ToolStripMenuItem tsSuaSINHVIEN;
        private System.Windows.Forms.ToolStripMenuItem tsThemSINHVIEN;
        private System.Windows.Forms.ToolStripMenuItem tsXoaSINHVIEN;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DB_THI_TN DB_THI_TN;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DB_THI_TNTableAdapters.KhoaTableAdapter KhoaTableAdapter;
        private DB_THI_TNTableAdapters.TableAdapterManager tableAdapterManager;
        private DB_THI_TNTableAdapters.LopTableAdapter LopTableAdapter;
        private System.Windows.Forms.BindingSource bdsLop;
        private DB_THI_TNTableAdapters.SinhvienTableAdapter SinhvienTableAdapter;
        private System.Windows.Forms.BindingSource bdsSinhvien;
        private DevExpress.XtraEditors.TextEdit txtDIACHI;
        private DevExpress.XtraEditors.DateEdit dateNGAYSINH;
        private DevExpress.XtraEditors.TextEdit txtMALOP;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.TextEdit txtHO;
        private DevExpress.XtraEditors.TextEdit txtMASV;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD;
        private System.Windows.Forms.BindingSource bdsBangdiem;
        private DB_THI_TNTableAdapters.BangDiemTableAdapter bangDiemTableAdapter;
    }
}