namespace QLThiTracNghiem
{
    partial class FrptCTBaiThi
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
            System.Windows.Forms.Label lANLabel;
            this.DB_THI_TN = new QLThiTracNghiem.DB_THI_TN();
            this.bdsDSBaithi = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Lay_DS_Bai_ThiTableAdapter = new QLThiTracNghiem.DB_THI_TNTableAdapters.SP_Lay_DS_Bai_ThiTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager();
            this.gcDSBaithi = new DevExpress.XtraGrid.GridControl();
            this.gvDSBaithi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelXuat = new DevExpress.XtraEditors.PanelControl();
            this.txtMonhoc = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtLanthi = new DevExpress.XtraEditors.SpinEdit();
            this.btnPreview = new System.Windows.Forms.Button();
            tENMHLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSBaithi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSBaithi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSBaithi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelXuat)).BeginInit();
            this.panelXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanthi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            tENMHLabel.Location = new System.Drawing.Point(17, 38);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(75, 19);
            tENMHLabel.TabIndex = 0;
            tENMHLabel.Text = "Môn học:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            lANLabel.Location = new System.Drawing.Point(17, 88);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(63, 19);
            lANLabel.TabIndex = 2;
            lANLabel.Text = "Lần thi:";
            // 
            // DB_THI_TN
            // 
            this.DB_THI_TN.DataSetName = "DB_THI_TN";
            this.DB_THI_TN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSBaithi
            // 
            this.bdsDSBaithi.DataMember = "SP_Lay_DS_Bai_Thi";
            this.bdsDSBaithi.DataSource = this.DB_THI_TN;
            this.bdsDSBaithi.Filter = "MASV = \'\'";
            // 
            // sP_Lay_DS_Bai_ThiTableAdapter
            // 
            this.sP_Lay_DS_Bai_ThiTableAdapter.ClearBeforeFill = true;
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
            // gcDSBaithi
            // 
            this.gcDSBaithi.DataSource = this.bdsDSBaithi;
            this.gcDSBaithi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDSBaithi.Location = new System.Drawing.Point(0, 0);
            this.gcDSBaithi.MainView = this.gvDSBaithi;
            this.gcDSBaithi.Name = "gcDSBaithi";
            this.gcDSBaithi.Size = new System.Drawing.Size(994, 266);
            this.gcDSBaithi.TabIndex = 1;
            this.gcDSBaithi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSBaithi});
            // 
            // gvDSBaithi
            // 
            this.gvDSBaithi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colLAN,
            this.colNGAYTHI,
            this.colDIEM});
            this.gvDSBaithi.GridControl = this.gcDSBaithi;
            this.gvDSBaithi.Name = "gvDSBaithi";
            this.gvDSBaithi.OptionsBehavior.Editable = false;
            this.gvDSBaithi.OptionsView.ShowViewCaption = true;
            this.gvDSBaithi.ViewCaption = "Danh sách kết quả thi";
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAMH.AppearanceCell.Options.UseFont = true;
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENMH.AppearanceCell.Options.UseFont = true;
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colLAN
            // 
            this.colLAN.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLAN.AppearanceCell.Options.UseFont = true;
            this.colLAN.Caption = "Lần thi";
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 2;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYTHI.AppearanceCell.Options.UseFont = true;
            this.colNGAYTHI.Caption = "Ngày thi";
            this.colNGAYTHI.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYTHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 3;
            // 
            // colDIEM
            // 
            this.colDIEM.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIEM.AppearanceCell.Options.UseFont = true;
            this.colDIEM.Caption = "Điểm thi";
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 4;
            // 
            // panelXuat
            // 
            this.panelXuat.Controls.Add(this.txtMonhoc);
            this.panelXuat.Controls.Add(this.btnThoat);
            this.panelXuat.Controls.Add(this.txtLanthi);
            this.panelXuat.Controls.Add(this.btnPreview);
            this.panelXuat.Controls.Add(lANLabel);
            this.panelXuat.Controls.Add(tENMHLabel);
            this.panelXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelXuat.Location = new System.Drawing.Point(0, 266);
            this.panelXuat.Name = "panelXuat";
            this.panelXuat.Size = new System.Drawing.Size(994, 282);
            this.panelXuat.TabIndex = 2;
            // 
            // txtMonhoc
            // 
            this.txtMonhoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSBaithi, "TENMH", true));
            this.txtMonhoc.Enabled = false;
            this.txtMonhoc.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtMonhoc.FormattingEnabled = true;
            this.txtMonhoc.Location = new System.Drawing.Point(98, 38);
            this.txtMonhoc.Name = "txtMonhoc";
            this.txtMonhoc.Size = new System.Drawing.Size(306, 27);
            this.txtMonhoc.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThoat.Location = new System.Drawing.Point(295, 140);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 35);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtLanthi
            // 
            this.txtLanthi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSBaithi, "LAN", true));
            this.txtLanthi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLanthi.Enabled = false;
            this.txtLanthi.Location = new System.Drawing.Point(98, 85);
            this.txtLanthi.Name = "txtLanthi";
            this.txtLanthi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtLanthi.Properties.Appearance.Options.UseFont = true;
            this.txtLanthi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLanthi.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtLanthi.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLanthi.Size = new System.Drawing.Size(100, 26);
            this.txtLanthi.TabIndex = 5;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPreview.Location = new System.Drawing.Point(87, 140);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(129, 35);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Xem bài thi";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // FrptCTBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 548);
            this.Controls.Add(this.panelXuat);
            this.Controls.Add(this.gcDSBaithi);
            this.Name = "FrptCTBaiThi";
            this.Text = "Xem lại bài thi";
            this.Load += new System.EventHandler(this.FrptCTBaiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSBaithi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSBaithi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSBaithi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelXuat)).EndInit();
            this.panelXuat.ResumeLayout(false);
            this.panelXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanthi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DB_THI_TN DB_THI_TN;
        private System.Windows.Forms.BindingSource bdsDSBaithi;
        private DB_THI_TNTableAdapters.SP_Lay_DS_Bai_ThiTableAdapter sP_Lay_DS_Bai_ThiTableAdapter;
        private DB_THI_TNTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDSBaithi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSBaithi;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraEditors.PanelControl panelXuat;
        private System.Windows.Forms.Button btnPreview;
        private DevExpress.XtraEditors.SpinEdit txtLanthi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox txtMonhoc;
    }
}