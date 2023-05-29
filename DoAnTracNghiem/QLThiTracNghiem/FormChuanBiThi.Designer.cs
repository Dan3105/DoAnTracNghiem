namespace QLThiTracNghiem
{
    partial class FormChuanBiThi
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuanBiThi));
            this.DB_THI_TN = new QLThiTracNghiem.DB_THI_TN();
            this.bdsGiaovien_Dangky = new System.Windows.Forms.BindingSource(this.components);
            this.Giaovien_DangkyTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.Giaovien_DangkyTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXemLop = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.tHOIGIANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtSOCAUTHI = new DevExpress.XtraEditors.SpinEdit();
            this.cbLANTHI = new System.Windows.Forms.ComboBox();
            this.nGAYTHIDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.cbTRINHDO = new System.Windows.Forms.ComboBox();
            this.cbTENMH = new System.Windows.Forms.ComboBox();
            this.bdsMonhoc = new System.Windows.Forms.BindingSource(this.components);
            this.txtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.txtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.MonhocTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.MonhocTableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaovien_Dangky)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOCAUTHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(39, 34);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(88, 16);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã nhân viên:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(448, 34);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(50, 16);
            mALOPLabel.TabIndex = 4;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(39, 73);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(82, 16);
            mAMHLabel.TabIndex = 5;
            mAMHLabel.Text = "Tên môn học";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(438, 78);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(60, 16);
            tRINHDOLabel.TabIndex = 6;
            tRINHDOLabel.Text = "Trình độ:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(73, 172);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(58, 16);
            nGAYTHILabel.TabIndex = 8;
            nGAYTHILabel.Text = "Ngày thi:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(466, 121);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(32, 16);
            lANLabel.TabIndex = 10;
            lANLabel.Text = "Lần:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(54, 121);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(69, 16);
            sOCAUTHILabel.TabIndex = 12;
            sOCAUTHILabel.Text = "Số câu thi:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(415, 171);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(83, 16);
            tHOIGIANLabel.TabIndex = 14;
            tHOIGIANLabel.Text = "Thời gian thi:";
            // 
            // DB_THI_TN
            // 
            this.DB_THI_TN.DataSetName = "DB_THI_TN";
            this.DB_THI_TN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGiaovien_Dangky
            // 
            this.bdsGiaovien_Dangky.DataMember = "Giaovien_Dangky";
            this.bdsGiaovien_Dangky.DataSource = this.DB_THI_TN;
            // 
            // Giaovien_DangkyTableAdapter
            // 
            this.Giaovien_DangkyTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MonhocTableAdapter = null;
            this.tableAdapterManager.SinhvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.7868F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1438, 394);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(1432, 50);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Form Nhập Lịch thi";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXemLop);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnGhi);
            this.panelControl1.Controls.Add(tHOIGIANLabel);
            this.panelControl1.Controls.Add(this.tHOIGIANSpinEdit);
            this.panelControl1.Controls.Add(sOCAUTHILabel);
            this.panelControl1.Controls.Add(this.txtSOCAUTHI);
            this.panelControl1.Controls.Add(lANLabel);
            this.panelControl1.Controls.Add(this.cbLANTHI);
            this.panelControl1.Controls.Add(nGAYTHILabel);
            this.panelControl1.Controls.Add(this.nGAYTHIDateEdit);
            this.panelControl1.Controls.Add(tRINHDOLabel);
            this.panelControl1.Controls.Add(this.cbTRINHDO);
            this.panelControl1.Controls.Add(mAMHLabel);
            this.panelControl1.Controls.Add(this.cbTENMH);
            this.panelControl1.Controls.Add(mALOPLabel);
            this.panelControl1.Controls.Add(this.txtMALOP);
            this.panelControl1.Controls.Add(mAGVLabel);
            this.panelControl1.Controls.Add(this.txtMAGV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 59);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1432, 332);
            this.panelControl1.TabIndex = 1;
            // 
            // btnXemLop
            // 
            this.btnXemLop.Location = new System.Drawing.Point(690, 27);
            this.btnXemLop.Name = "btnXemLop";
            this.btnXemLop.Size = new System.Drawing.Size(94, 29);
            this.btnXemLop.TabIndex = 18;
            this.btnXemLop.Text = "Chọn lớp";
            this.btnXemLop.Click += new System.EventHandler(this.btnXemLop_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(492, 247);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 59);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.Location = new System.Drawing.Point(241, 247);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(134, 59);
            this.btnGhi.TabIndex = 16;
            this.btnGhi.Text = "Thêm lịch thi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // tHOIGIANSpinEdit
            // 
            this.tHOIGIANSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaovien_Dangky, "THOIGIAN", true));
            this.tHOIGIANSpinEdit.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.tHOIGIANSpinEdit.Location = new System.Drawing.Point(526, 167);
            this.tHOIGIANSpinEdit.Name = "tHOIGIANSpinEdit";
            this.tHOIGIANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tHOIGIANSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tHOIGIANSpinEdit.Properties.MaskSettings.Set("mask", "n0");
            this.tHOIGIANSpinEdit.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.tHOIGIANSpinEdit.Properties.MinValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.tHOIGIANSpinEdit.Size = new System.Drawing.Size(56, 24);
            this.tHOIGIANSpinEdit.TabIndex = 15;
            // 
            // txtSOCAUTHI
            // 
            this.txtSOCAUTHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaovien_Dangky, "SOCAUTHI", true));
            this.txtSOCAUTHI.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.txtSOCAUTHI.Location = new System.Drawing.Point(153, 117);
            this.txtSOCAUTHI.Name = "txtSOCAUTHI";
            this.txtSOCAUTHI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSOCAUTHI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSOCAUTHI.Properties.MaskSettings.Set("mask", "n0");
            this.txtSOCAUTHI.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtSOCAUTHI.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtSOCAUTHI.Size = new System.Drawing.Size(74, 24);
            this.txtSOCAUTHI.TabIndex = 13;
            // 
            // cbLANTHI
            // 
            this.cbLANTHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiaovien_Dangky, "LAN", true));
            this.cbLANTHI.FormattingEnabled = true;
            this.cbLANTHI.Location = new System.Drawing.Point(526, 113);
            this.cbLANTHI.Name = "cbLANTHI";
            this.cbLANTHI.Size = new System.Drawing.Size(56, 24);
            this.cbLANTHI.TabIndex = 11;
            // 
            // nGAYTHIDateEdit
            // 
            this.nGAYTHIDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaovien_Dangky, "NGAYTHI", true));
            this.nGAYTHIDateEdit.EditValue = null;
            this.nGAYTHIDateEdit.Location = new System.Drawing.Point(153, 169);
            this.nGAYTHIDateEdit.Name = "nGAYTHIDateEdit";
            this.nGAYTHIDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Size = new System.Drawing.Size(125, 22);
            this.nGAYTHIDateEdit.TabIndex = 9;
            // 
            // cbTRINHDO
            // 
            this.cbTRINHDO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGiaovien_Dangky, "TRINHDO", true));
            this.cbTRINHDO.FormattingEnabled = true;
            this.cbTRINHDO.Location = new System.Drawing.Point(526, 73);
            this.cbTRINHDO.Name = "cbTRINHDO";
            this.cbTRINHDO.Size = new System.Drawing.Size(56, 24);
            this.cbTRINHDO.TabIndex = 7;
            // 
            // cbTENMH
            // 
            this.cbTENMH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsGiaovien_Dangky, "MAMH", true));
            this.cbTENMH.DataSource = this.bdsMonhoc;
            this.cbTENMH.DisplayMember = "TENMH";
            this.cbTENMH.FormattingEnabled = true;
            this.cbTENMH.Location = new System.Drawing.Point(153, 70);
            this.cbTENMH.Name = "cbTENMH";
            this.cbTENMH.Size = new System.Drawing.Size(174, 24);
            this.cbTENMH.TabIndex = 6;
            this.cbTENMH.ValueMember = "MAMH";
            // 
            // bdsMonhoc
            // 
            this.bdsMonhoc.DataMember = "Monhoc";
            this.bdsMonhoc.DataSource = this.DB_THI_TN;
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaovien_Dangky, "MALOP", true));
            this.txtMALOP.Enabled = false;
            this.txtMALOP.Location = new System.Drawing.Point(526, 31);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Size = new System.Drawing.Size(141, 22);
            this.txtMALOP.TabIndex = 5;
            // 
            // txtMAGV
            // 
            this.txtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiaovien_Dangky, "MAGV", true));
            this.txtMAGV.Enabled = false;
            this.txtMAGV.Location = new System.Drawing.Point(153, 31);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(125, 22);
            this.txtMAGV.TabIndex = 1;
            // 
            // MonhocTableAdapter
            // 
            this.MonhocTableAdapter.ClearBeforeFill = true;
            // 
            // FormChuanBiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 394);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormChuanBiThi";
            this.Text = "FormChuanBiThi";
            this.Load += new System.EventHandler(this.FormChuanBiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaovien_Dangky)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHOIGIANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOCAUTHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsGiaovien_Dangky;
        private DB_THI_TN DB_THI_TN;
        private DB_THI_TNTableAdapters.Giaovien_DangkyTableAdapter Giaovien_DangkyTableAdapter;
        private DB_THI_TNTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SpinEdit tHOIGIANSpinEdit;
        private DevExpress.XtraEditors.SpinEdit txtSOCAUTHI;
        private System.Windows.Forms.ComboBox cbLANTHI;
        private DevExpress.XtraEditors.DateEdit nGAYTHIDateEdit;
        private System.Windows.Forms.ComboBox cbTRINHDO;
        private System.Windows.Forms.ComboBox cbTENMH;
        private DevExpress.XtraEditors.TextEdit txtMALOP;
        private DevExpress.XtraEditors.TextEdit txtMAGV;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private DevExpress.XtraEditors.SimpleButton btnXemLop;
        private System.Windows.Forms.BindingSource bdsMonhoc;
        private DB_THI_TNTableAdapters.MonhocTableAdapter MonhocTableAdapter;
    }
}