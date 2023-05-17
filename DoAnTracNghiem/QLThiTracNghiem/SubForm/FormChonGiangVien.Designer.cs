namespace QLThiTracNghiem.SubForm
{
    partial class FormChonGiangVien
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.DB_TracNghiem = new QLThiTracNghiem.DB_TracNghiem();
            this.bdsV_DS_GiangVien_Chua_Co_Tai_Khoan = new System.Windows.Forms.BindingSource(this.components);
            this.V_DS_GiangVien_Chua_Co_Tai_KhoanTableAdapter = new QLThiTracNghiem.DB_TracNghiemTableAdapters.V_DS_GiangVien_Chua_Co_Tai_KhoanTableAdapter();
            this.tableAdapterManager = new QLThiTracNghiem.DB_TracNghiemTableAdapters.TableAdapterManager();
            this.gcVDSGiangVien = new DevExpress.XtraGrid.GridControl();
            this.gvDSGiangVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TracNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsV_DS_GiangVien_Chua_Co_Tai_Khoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVDSGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gcVDSGiangVien, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.49282F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.50718F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 352);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1078, 63);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(190, 25);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(126, 29);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Chọn Giảng viên";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Location = new System.Drawing.Point(698, 25);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 29);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // DB_TracNghiem
            // 
            this.DB_TracNghiem.DataSetName = "DB_TracNghiem";
            this.DB_TracNghiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsV_DS_GiangVien_Chua_Co_Tai_Khoan
            // 
            this.bdsV_DS_GiangVien_Chua_Co_Tai_Khoan.DataMember = "V_DS_GiangVien_Chua_Co_Tai_Khoan";
            this.bdsV_DS_GiangVien_Chua_Co_Tai_Khoan.DataSource = this.DB_TracNghiem;
            // 
            // V_DS_GiangVien_Chua_Co_Tai_KhoanTableAdapter
            // 
            this.V_DS_GiangVien_Chua_Co_Tai_KhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LICHTHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLThiTracNghiem.DB_TracNghiemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcVDSGiangVien
            // 
            this.gcVDSGiangVien.DataSource = this.bdsV_DS_GiangVien_Chua_Co_Tai_Khoan;
            this.gcVDSGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVDSGiangVien.Location = new System.Drawing.Point(3, 3);
            this.gcVDSGiangVien.MainView = this.gvDSGiangVien;
            this.gcVDSGiangVien.Name = "gcVDSGiangVien";
            this.gcVDSGiangVien.Size = new System.Drawing.Size(1078, 343);
            this.gcVDSGiangVien.TabIndex = 1;
            this.gcVDSGiangVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSGiangVien});
            // 
            // gvDSGiangVien
            // 
            this.gvDSGiangVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHOTEN,
            this.colHOCVI});
            this.gvDSGiangVien.GridControl = this.gcVDSGiangVien;
            this.gvDSGiangVien.Name = "gvDSGiangVien";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 94;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 94;
            // 
            // colHOCVI
            // 
            this.colHOCVI.FieldName = "HOCVI";
            this.colHOCVI.MinWidth = 25;
            this.colHOCVI.Name = "colHOCVI";
            this.colHOCVI.Visible = true;
            this.colHOCVI.VisibleIndex = 2;
            this.colHOCVI.Width = 94;
            // 
            // FormChonGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 418);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormChonGiangVien";
            this.Text = "FormChonGiangVien";
            this.Load += new System.EventHandler(this.FormChonGiangVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DB_TracNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsV_DS_GiangVien_Chua_Co_Tai_Khoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVDSGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSGiangVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DB_TracNghiem DB_TracNghiem;
        private System.Windows.Forms.BindingSource bdsV_DS_GiangVien_Chua_Co_Tai_Khoan;
        private DB_TracNghiemTableAdapters.V_DS_GiangVien_Chua_Co_Tai_KhoanTableAdapter V_DS_GiangVien_Chua_Co_Tai_KhoanTableAdapter;
        private DB_TracNghiemTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcVDSGiangVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSGiangVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVI;
    }
}