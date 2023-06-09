﻿namespace QLThiTracNghiem
{
    partial class FormChonLichThi
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label lANLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLop = new System.Windows.Forms.Label();
            this.sP_DS_Co_The_ThiGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsSP_DS_Co_The_Thi = new System.Windows.Forms.BindingSource(this.components);
            this.DB_THI_TN = new QLThiTracNghiem.DB_THI_TN();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tHOIGIANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sOCAUTHISpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.nGAYTHIDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tENMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnThi = new System.Windows.Forms.Button();
            this.SP_DS_Co_The_ThiTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.SP_DS_Co_The_ThiTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            tENMHLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_Co_The_ThiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_DS_Co_The_Thi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCAUTHISpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(22, 24);
            tENMHLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(49, 13);
            tENMHLabel.TabIndex = 0;
            tENMHLabel.Text = "TENMH:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(22, 52);
            nGAYTHILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(58, 13);
            nGAYTHILabel.TabIndex = 2;
            nGAYTHILabel.Text = "NGAYTHI:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(16, 84);
            sOCAUTHILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(65, 13);
            sOCAUTHILabel.TabIndex = 4;
            sOCAUTHILabel.Text = "SOCAUTHI:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(256, 84);
            tHOIGIANLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(62, 13);
            tHOIGIANLabel.TabIndex = 6;
            tHOIGIANLabel.Text = "THOIGIAN:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(284, 52);
            lANLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(31, 13);
            lANLabel.TabIndex = 8;
            lANLabel.Text = "LAN:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sP_DS_Co_The_ThiGridControl, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.86747F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.13253F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(584, 219);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbLop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 32);
            this.panel1.TabIndex = 3;
            // 
            // lbLop
            // 
            this.lbLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(17, 10);
            this.lbLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(35, 13);
            this.lbLop.TabIndex = 0;
            this.lbLop.Text = "label1";
            // 
            // sP_DS_Co_The_ThiGridControl
            // 
            this.sP_DS_Co_The_ThiGridControl.DataSource = this.bdsSP_DS_Co_The_Thi;
            this.sP_DS_Co_The_ThiGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DS_Co_The_ThiGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sP_DS_Co_The_ThiGridControl.Location = new System.Drawing.Point(2, 38);
            this.sP_DS_Co_The_ThiGridControl.MainView = this.gridView1;
            this.sP_DS_Co_The_ThiGridControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sP_DS_Co_The_ThiGridControl.Name = "sP_DS_Co_The_ThiGridControl";
            this.sP_DS_Co_The_ThiGridControl.Size = new System.Drawing.Size(580, 179);
            this.sP_DS_Co_The_ThiGridControl.TabIndex = 0;
            this.sP_DS_Co_The_ThiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsSP_DS_Co_The_Thi
            // 
            this.bdsSP_DS_Co_The_Thi.DataMember = "SP_DS_Co_The_Thi";
            this.bdsSP_DS_Co_The_Thi.DataSource = this.DB_THI_TN;
            // 
            // DB_THI_TN
            // 
            this.DB_THI_TN.DataSetName = "DB_THI_TN";
            this.DB_THI_TN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.sP_DS_Co_The_ThiGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnThi, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 237);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(596, 127);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(lANLabel);
            this.panel2.Controls.Add(this.lANSpinEdit);
            this.panel2.Controls.Add(tHOIGIANLabel);
            this.panel2.Controls.Add(this.tHOIGIANSpinEdit);
            this.panel2.Controls.Add(sOCAUTHILabel);
            this.panel2.Controls.Add(this.sOCAUTHISpinEdit);
            this.panel2.Controls.Add(nGAYTHILabel);
            this.panel2.Controls.Add(this.nGAYTHIDateEdit);
            this.panel2.Controls.Add(tENMHLabel);
            this.panel2.Controls.Add(this.tENMHTextEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 123);
            this.panel2.TabIndex = 0;
            // 
            // lANSpinEdit
            // 
            this.lANSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSP_DS_Co_The_Thi, "LAN", true));
            this.lANSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lANSpinEdit.Enabled = false;
            this.lANSpinEdit.Location = new System.Drawing.Point(336, 49);
            this.lANSpinEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lANSpinEdit.Name = "lANSpinEdit";
            this.lANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lANSpinEdit.Size = new System.Drawing.Size(94, 20);
            this.lANSpinEdit.TabIndex = 9;
            // 
            // tHOIGIANSpinEdit
            // 
            this.tHOIGIANSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSP_DS_Co_The_Thi, "THOIGIAN", true));
            this.tHOIGIANSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tHOIGIANSpinEdit.Enabled = false;
            this.tHOIGIANSpinEdit.Location = new System.Drawing.Point(336, 80);
            this.tHOIGIANSpinEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tHOIGIANSpinEdit.Name = "tHOIGIANSpinEdit";
            this.tHOIGIANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tHOIGIANSpinEdit.Size = new System.Drawing.Size(94, 20);
            this.tHOIGIANSpinEdit.TabIndex = 7;
            // 
            // sOCAUTHISpinEdit
            // 
            this.sOCAUTHISpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSP_DS_Co_The_Thi, "SOCAUTHI", true));
            this.sOCAUTHISpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOCAUTHISpinEdit.Enabled = false;
            this.sOCAUTHISpinEdit.Location = new System.Drawing.Point(94, 80);
            this.sOCAUTHISpinEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sOCAUTHISpinEdit.Name = "sOCAUTHISpinEdit";
            this.sOCAUTHISpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOCAUTHISpinEdit.Size = new System.Drawing.Size(94, 20);
            this.sOCAUTHISpinEdit.TabIndex = 5;
            // 
            // nGAYTHIDateEdit
            // 
            this.nGAYTHIDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSP_DS_Co_The_Thi, "NGAYTHI", true));
            this.nGAYTHIDateEdit.EditValue = null;
            this.nGAYTHIDateEdit.Enabled = false;
            this.nGAYTHIDateEdit.Location = new System.Drawing.Point(94, 50);
            this.nGAYTHIDateEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nGAYTHIDateEdit.Name = "nGAYTHIDateEdit";
            this.nGAYTHIDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Properties.DisplayFormat.FormatString = "G";
            this.nGAYTHIDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.nGAYTHIDateEdit.Properties.EditFormat.FormatString = "G";
            this.nGAYTHIDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.nGAYTHIDateEdit.Size = new System.Drawing.Size(94, 20);
            this.nGAYTHIDateEdit.TabIndex = 3;
            // 
            // tENMHTextEdit
            // 
            this.tENMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSP_DS_Co_The_Thi, "TENMH", true));
            this.tENMHTextEdit.Enabled = false;
            this.tENMHTextEdit.Location = new System.Drawing.Point(94, 22);
            this.tENMHTextEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tENMHTextEdit.Name = "tENMHTextEdit";
            this.tENMHTextEdit.Size = new System.Drawing.Size(173, 20);
            this.tENMHTextEdit.TabIndex = 1;
            // 
            // btnThi
            // 
            this.btnThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThi.Location = new System.Drawing.Point(537, 24);
            this.btnThi.Margin = new System.Windows.Forms.Padding(8, 24, 8, 24);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(51, 79);
            this.btnThi.TabIndex = 1;
            this.btnThi.Text = "Thi";
            this.btnThi.UseVisualStyleBackColor = true;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // SP_DS_Co_The_ThiTableAdapter
            // 
            this.SP_DS_Co_The_ThiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemTableAdapter = null;
            this.tableAdapterManager.BodeTableAdapter = null;
            this.tableAdapterManager.ChiTiet_BaiThiTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Giaovien_DangkyTableAdapter = null;
            this.tableAdapterManager.GiaovienTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.MonhocTableAdapter = null;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 56;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 56;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            this.colTRINHDO.Width = 56;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 3;
            this.colNGAYTHI.Width = 56;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 4;
            this.colLAN.Width = 56;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 5;
            this.colSOCAUTHI.Width = 56;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 6;
            this.colTHOIGIAN.Width = 56;
            // 
            // FormChonLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormChonLichThi";
            this.Text = "FormChonLichThi";
            this.Load += new System.EventHandler(this.FormChonLichThi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_Co_The_ThiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_DS_Co_The_Thi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCAUTHISpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DB_THI_TN DB_THI_TN;
        private System.Windows.Forms.BindingSource bdsSP_DS_Co_The_Thi;
        private DB_THI_TNTableAdapters.SP_DS_Co_The_ThiTableAdapter SP_DS_Co_The_ThiTableAdapter;
        private DB_THI_TNTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_DS_Co_The_ThiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SpinEdit lANSpinEdit;
        private DevExpress.XtraEditors.SpinEdit tHOIGIANSpinEdit;
        private DevExpress.XtraEditors.SpinEdit sOCAUTHISpinEdit;
        private DevExpress.XtraEditors.DateEdit nGAYTHIDateEdit;
        private DevExpress.XtraEditors.TextEdit tENMHTextEdit;
        private System.Windows.Forms.Button btnThi;
        private System.Windows.Forms.Label lbLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
    }
}