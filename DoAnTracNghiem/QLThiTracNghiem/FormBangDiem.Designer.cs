namespace QLThiTracNghiem
{
    partial class FormBangDiem
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
            this.panelCHON = new DevExpress.XtraEditors.PanelControl();
            this.btnCHONMON = new System.Windows.Forms.Button();
            this.btnCHONLOP = new System.Windows.Forms.Button();
            this.cbLAN = new System.Windows.Forms.ComboBox();
            this.btnXEM = new System.Windows.Forms.Button();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DB_THI_TN = new QLThiTracNghiem.DB_THI_TN();
            this.tableAdapterManager = new QLThiTracNghiem.DB_THI_TNTableAdapters.TableAdapterManager();
            this.btnTHOAT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelCHON)).BeginInit();
            this.panelCHON.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCHON
            // 
            this.panelCHON.Controls.Add(this.btnTHOAT);
            this.panelCHON.Controls.Add(this.btnCHONMON);
            this.panelCHON.Controls.Add(this.btnCHONLOP);
            this.panelCHON.Controls.Add(this.cbLAN);
            this.panelCHON.Controls.Add(this.btnXEM);
            this.panelCHON.Controls.Add(this.labelControl3);
            this.panelCHON.Controls.Add(this.labelControl2);
            this.panelCHON.Controls.Add(this.txtTenMH);
            this.panelCHON.Controls.Add(this.txtTenLop);
            this.panelCHON.Controls.Add(this.labelControl1);
            this.panelCHON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCHON.Location = new System.Drawing.Point(0, 0);
            this.panelCHON.Name = "panelCHON";
            this.panelCHON.Size = new System.Drawing.Size(672, 252);
            this.panelCHON.TabIndex = 0;
            // 
            // btnCHONMON
            // 
            this.btnCHONMON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCHONMON.Location = new System.Drawing.Point(329, 43);
            this.btnCHONMON.Name = "btnCHONMON";
            this.btnCHONMON.Size = new System.Drawing.Size(75, 23);
            this.btnCHONMON.TabIndex = 9;
            this.btnCHONMON.Text = "Chọn Môn";
            this.btnCHONMON.UseVisualStyleBackColor = true;
            this.btnCHONMON.Click += new System.EventHandler(this.btnCHONMON_Click);
            // 
            // btnCHONLOP
            // 
            this.btnCHONLOP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCHONLOP.Location = new System.Drawing.Point(329, 7);
            this.btnCHONLOP.Name = "btnCHONLOP";
            this.btnCHONLOP.Size = new System.Drawing.Size(75, 23);
            this.btnCHONLOP.TabIndex = 8;
            this.btnCHONLOP.Text = "Chọn Lớp";
            this.btnCHONLOP.UseVisualStyleBackColor = true;
            this.btnCHONLOP.Click += new System.EventHandler(this.btnCHONLOP_Click);
            // 
            // cbLAN
            // 
            this.cbLAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLAN.FormattingEnabled = true;
            this.cbLAN.Location = new System.Drawing.Point(83, 81);
            this.cbLAN.Name = "cbLAN";
            this.cbLAN.Size = new System.Drawing.Size(47, 21);
            this.cbLAN.TabIndex = 7;
            // 
            // btnXEM
            // 
            this.btnXEM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXEM.Location = new System.Drawing.Point(136, 79);
            this.btnXEM.Name = "btnXEM";
            this.btnXEM.Size = new System.Drawing.Size(75, 23);
            this.btnXEM.TabIndex = 6;
            this.btnXEM.Text = "Xem";
            this.btnXEM.UseVisualStyleBackColor = true;
            this.btnXEM.Click += new System.EventHandler(this.btnXEM_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Lần thi:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tên Môn học:";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTenMH.Enabled = false;
            this.txtTenMH.Location = new System.Drawing.Point(83, 46);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenMH.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenMH.Properties.ReadOnly = true;
            this.txtTenMH.Size = new System.Drawing.Size(240, 20);
            this.txtTenMH.TabIndex = 2;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(83, 8);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenLop.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenLop.Properties.ReadOnly = true;
            this.txtTenLop.Size = new System.Drawing.Size(240, 20);
            this.txtTenLop.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Lớp:";
            // 
            // DB_THI_TN
            // 
            this.DB_THI_TN.DataSetName = "DB_THI_TN";
            this.DB_THI_TN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnTHOAT
            // 
            this.btnTHOAT.Location = new System.Drawing.Point(248, 79);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(75, 23);
            this.btnTHOAT.TabIndex = 10;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // FormBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 252);
            this.Controls.Add(this.panelCHON);
            this.Name = "FormBangDiem";
            this.Text = "Bảng Điểm";
            this.Load += new System.EventHandler(this.FormBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelCHON)).EndInit();
            this.panelCHON.ResumeLayout(false);
            this.panelCHON.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_THI_TN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelCHON;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btnXEM;
        private DB_THI_TN DB_THI_TN;
        private DB_THI_TNTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbLAN;
        private System.Windows.Forms.Button btnCHONMON;
        private System.Windows.Forms.Button btnCHONLOP;
        private System.Windows.Forms.Button btnTHOAT;
    }
}