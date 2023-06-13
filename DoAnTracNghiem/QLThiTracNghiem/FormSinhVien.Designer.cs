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
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(33, 51);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(46, 16);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Enabled = false;
            mALOPLabel.Location = new System.Drawing.Point(242, 19);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(52, 16);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "MALOP:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(50, 88);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(29, 16);
            hOLabel.TabIndex = 4;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(302, 88);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(35, 16);
            tENLabel.TabIndex = 6;
            tENLabel.Text = "TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(27, 161);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(52, 16);
            dIACHILabel.TabIndex = 10;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(8, 125);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(71, 16);
            nGAYSINHLabel.TabIndex = 14;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Password";
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
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1290, 53);
            this.panelControl1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Location = new System.Drawing.Point(729, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 39);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbKHOA
            // 
            this.cbKHOA.DataSource = this.bdsKhoa;
            this.cbKHOA.DisplayMember = "TENKH";
            this.cbKHOA.FormattingEnabled = true;
            this.cbKHOA.Location = new System.Drawing.Point(406, 14);
            this.cbKHOA.Name = "cbKHOA";
            this.cbKHOA.Size = new System.Drawing.Size(266, 24);
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
            this.labelControl2.Location = new System.Drawing.Point(331, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Khoa";
            // 
            // cbCOSO
            // 
            this.cbCOSO.FormattingEnabled = true;
            this.cbCOSO.Location = new System.Drawing.Point(79, 14);
            this.cbCOSO.Name = "cbCOSO";
            this.cbCOSO.Size = new System.Drawing.Size(188, 24);
            this.cbCOSO.TabIndex = 1;
            this.cbCOSO.SelectedIndexChanged += new System.EventHandler(this.cbCOSO_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 21);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.64203F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.35797F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1290, 433);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gcLOP
            // 
            this.gcLOP.DataSource = this.bdsLop;
            this.gcLOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLOP.Location = new System.Drawing.Point(3, 3);
            this.gcLOP.MainView = this.gvLOP;
            this.gcLOP.Name = "gcLOP";
            this.gcLOP.Size = new System.Drawing.Size(1284, 143);
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
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            this.colMAKHOA.Width = 94;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.80997F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.19003F));
            this.tableLayoutPanel2.Controls.Add(this.gcSINHVIEN, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelSINHVIEN, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 152);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1284, 278);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // gcSINHVIEN
            // 
            this.gcSINHVIEN.DataSource = this.bdsSinhvien;
            this.gcSINHVIEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSINHVIEN.Location = new System.Drawing.Point(3, 3);
            this.gcSINHVIEN.MainView = this.gvSINHVIEN;
            this.gcSINHVIEN.Name = "gcSINHVIEN";
            this.gcSINHVIEN.Size = new System.Drawing.Size(839, 272);
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
            this.gvSINHVIEN.GridControl = this.gcSINHVIEN;
            this.gvSINHVIEN.Name = "gvSINHVIEN";
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
            this.panelSINHVIEN.Location = new System.Drawing.Point(848, 3);
            this.panelSINHVIEN.Name = "panelSINHVIEN";
            this.panelSINHVIEN.Size = new System.Drawing.Size(433, 272);
            this.panelSINHVIEN.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "PASSWORD", true));
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(152, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 22);
            this.txtPassword.TabIndex = 21;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(152, 163);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(252, 22);
            this.txtDIACHI.TabIndex = 20;
            // 
            // dateNGAYSINH
            // 
            this.dateNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "NGAYSINH", true));
            this.dateNGAYSINH.EditValue = null;
            this.dateNGAYSINH.Location = new System.Drawing.Point(152, 122);
            this.dateNGAYSINH.Name = "dateNGAYSINH";
            this.dateNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYSINH.Size = new System.Drawing.Size(125, 22);
            this.dateNGAYSINH.TabIndex = 19;
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "MALOP", true));
            this.txtMALOP.Enabled = false;
            this.txtMALOP.Location = new System.Drawing.Point(300, 16);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Size = new System.Drawing.Size(113, 22);
            this.txtMALOP.TabIndex = 18;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(348, 85);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(79, 22);
            this.txtTEN.TabIndex = 17;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(152, 85);
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(142, 22);
            this.txtHO.TabIndex = 16;
            // 
            // txtMASV
            // 
            this.txtMASV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhvien, "MASV", true));
            this.txtMASV.Location = new System.Drawing.Point(152, 48);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(125, 22);
            this.txtMASV.TabIndex = 15;
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Location = new System.Drawing.Point(280, 237);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(94, 29);
            this.btnPhucHoi.TabIndex = 13;
            this.btnPhucHoi.Text = "Phục hồi";
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // btnGhiSINHVIEN
            // 
            this.btnGhiSINHVIEN.Location = new System.Drawing.Point(85, 237);
            this.btnGhiSINHVIEN.Name = "btnGhiSINHVIEN";
            this.btnGhiSINHVIEN.Size = new System.Drawing.Size(94, 29);
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
            this.menuStripSINHVIEN.Size = new System.Drawing.Size(204, 76);
            // 
            // tsSuaSINHVIEN
            // 
            this.tsSuaSINHVIEN.Name = "tsSuaSINHVIEN";
            this.tsSuaSINHVIEN.Size = new System.Drawing.Size(203, 24);
            this.tsSuaSINHVIEN.Text = "Chỉnh sửa sinh viên";
            this.tsSuaSINHVIEN.Click += new System.EventHandler(this.tsSuaSINHVIEN_Click);
            // 
            // tsThemSINHVIEN
            // 
            this.tsThemSINHVIEN.Name = "tsThemSINHVIEN";
            this.tsThemSINHVIEN.Size = new System.Drawing.Size(203, 24);
            this.tsThemSINHVIEN.Text = "Thêm Sinh Viên";
            this.tsThemSINHVIEN.Click += new System.EventHandler(this.tsThemSINHVIEN_Click);
            // 
            // tsXoaSINHVIEN
            // 
            this.tsXoaSINHVIEN.Name = "tsXoaSINHVIEN";
            this.tsXoaSINHVIEN.Size = new System.Drawing.Size(203, 24);
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
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            this.colNGAYSINH.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // colMALOP1
            // 
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.MinWidth = 25;
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 5;
            this.colMALOP1.Width = 94;
            // 
            // colPASSWORD
            // 
            this.colPASSWORD.FieldName = "PASSWORD";
            this.colPASSWORD.MinWidth = 25;
            this.colPASSWORD.Name = "colPASSWORD";
            this.colPASSWORD.Visible = true;
            this.colPASSWORD.VisibleIndex = 6;
            this.colPASSWORD.Width = 94;
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormSinhVien";
            this.Text = "FormSinhVien";
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
    }
}