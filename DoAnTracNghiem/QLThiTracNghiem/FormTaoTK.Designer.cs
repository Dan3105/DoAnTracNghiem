namespace QLThiTracNghiem
{
    partial class FormTaoTK
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.cbNhom = new System.Windows.Forms.ComboBox();
            this.txtTenTK = new DevExpress.XtraEditors.TextEdit();
            this.txtMATKHAU = new DevExpress.XtraEditors.TextEdit();
            this.btnXemGV = new DevExpress.XtraEditors.SimpleButton();
            this.txtMAGV = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMATKHAU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1204, 244);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(201, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(136, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tạo tài khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(236, 165);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhóm Quyền:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(236, 219);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên tài khoản:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(236, 273);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 21);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Mật khẩu:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(236, 330);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 21);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Giảng Viên:";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(310, 399);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(94, 29);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(582, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbNhom
            // 
            this.cbNhom.FormattingEnabled = true;
            this.cbNhom.Location = new System.Drawing.Point(407, 162);
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(189, 24);
            this.cbNhom.TabIndex = 7;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(407, 216);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(257, 22);
            this.txtTenTK.TabIndex = 9;
            // 
            // txtMATKHAU
            // 
            this.txtMATKHAU.Location = new System.Drawing.Point(407, 270);
            this.txtMATKHAU.Name = "txtMATKHAU";
            this.txtMATKHAU.Properties.UseSystemPasswordChar = true;
            this.txtMATKHAU.Size = new System.Drawing.Size(257, 22);
            this.txtMATKHAU.TabIndex = 10;
            // 
            // btnXemGV
            // 
            this.btnXemGV.Location = new System.Drawing.Point(549, 328);
            this.btnXemGV.Name = "btnXemGV";
            this.btnXemGV.Size = new System.Drawing.Size(96, 25);
            this.btnXemGV.TabIndex = 11;
            this.btnXemGV.Text = "Xem DS";
            this.btnXemGV.Click += new System.EventHandler(this.btnXemGV_Click);
            // 
            // txtMAGV
            // 
            this.txtMAGV.Enabled = false;
            this.txtMAGV.Location = new System.Drawing.Point(407, 330);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(101, 22);
            this.txtMAGV.TabIndex = 12;
            // 
            // FormTaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 484);
            this.Controls.Add(this.txtMAGV);
            this.Controls.Add(this.btnXemGV);
            this.Controls.Add(this.txtMATKHAU);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.cbNhom);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormTaoTK";
            this.Text = "FormTaoTK";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMATKHAU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnDangKy;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.ComboBox cbNhom;
        private DevExpress.XtraEditors.TextEdit txtTenTK;
        private DevExpress.XtraEditors.TextEdit txtMATKHAU;
        private DevExpress.XtraEditors.SimpleButton btnXemGV;
        private DevExpress.XtraEditors.TextEdit txtMAGV;
    }
}