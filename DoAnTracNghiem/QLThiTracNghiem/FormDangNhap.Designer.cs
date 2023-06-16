namespace QLThiTracNghiem
{
    partial class FormDangNhap
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
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelUsername = new DevExpress.XtraEditors.LabelControl();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lbServer = new DevExpress.XtraEditors.LabelControl();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.gFormLogin = new System.Windows.Forms.GroupBox();
            this.gAccountType = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioStudentAccount = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.gFormLogin.SuspendLayout();
            this.gAccountType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(9, 113);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Size = new System.Drawing.Size(250, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Appearance.Options.UseFont = true;
            this.labelUsername.Location = new System.Drawing.Point(10, 89);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(74, 20);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "&Username";
            // 
            // labelPassword
            // 
            this.labelPassword.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Appearance.Options.UseFont = true;
            this.labelPassword.Location = new System.Drawing.Point(10, 143);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 20);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "&Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(10, 167);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(250, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // lbServer
            // 
            this.lbServer.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServer.Appearance.Options.UseFont = true;
            this.lbServer.Location = new System.Drawing.Point(10, 33);
            this.lbServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(46, 20);
            this.lbServer.TabIndex = 4;
            this.lbServer.Text = "&Server";
            // 
            // cbServer
            // 
            this.cbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(9, 57);
            this.cbServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(148, 28);
            this.cbServer.TabIndex = 5;
            this.cbServer.SelectedIndexChanged += new System.EventHandler(this.cbServer_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.AutoSize = true;
            this.btnLogin.Location = new System.Drawing.Point(14, 271);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 29);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(193, 271);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gFormLogin
            // 
            this.gFormLogin.Controls.Add(this.gAccountType);
            this.gFormLogin.Controls.Add(this.labelPassword);
            this.gFormLogin.Controls.Add(this.lbServer);
            this.gFormLogin.Controls.Add(this.txtPassword);
            this.gFormLogin.Controls.Add(this.cbServer);
            this.gFormLogin.Controls.Add(this.labelUsername);
            this.gFormLogin.Controls.Add(this.btnLogin);
            this.gFormLogin.Controls.Add(this.txtUsername);
            this.gFormLogin.Controls.Add(this.btnExit);
            this.gFormLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gFormLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gFormLogin.Location = new System.Drawing.Point(0, 0);
            this.gFormLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gFormLogin.Name = "gFormLogin";
            this.gFormLogin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gFormLogin.Size = new System.Drawing.Size(671, 376);
            this.gFormLogin.TabIndex = 8;
            this.gFormLogin.TabStop = false;
            this.gFormLogin.Text = "Đăng Nhập";
            // 
            // gAccountType
            // 
            this.gAccountType.Controls.Add(this.radioButton1);
            this.gAccountType.Controls.Add(this.radioStudentAccount);
            this.gAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gAccountType.Location = new System.Drawing.Point(10, 207);
            this.gAccountType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gAccountType.Name = "gAccountType";
            this.gAccountType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gAccountType.Size = new System.Drawing.Size(278, 60);
            this.gAccountType.TabIndex = 9;
            this.gAccountType.TabStop = false;
            this.gAccountType.Text = "Loại Tài Khoản";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(134, 22);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Giảng Viên";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioStudentAccount
            // 
            this.radioStudentAccount.AutoSize = true;
            this.radioStudentAccount.Location = new System.Drawing.Point(4, 22);
            this.radioStudentAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioStudentAccount.Name = "radioStudentAccount";
            this.radioStudentAccount.Size = new System.Drawing.Size(95, 24);
            this.radioStudentAccount.TabIndex = 8;
            this.radioStudentAccount.TabStop = true;
            this.radioStudentAccount.Text = "Sinh Viên";
            this.radioStudentAccount.UseVisualStyleBackColor = true;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(671, 376);
            this.Controls.Add(this.gFormLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDangNhap";
            this.Text = "Đăng Nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.gFormLogin.ResumeLayout(false);
            this.gFormLogin.PerformLayout();
            this.gAccountType.ResumeLayout(false);
            this.gAccountType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelUsername;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lbServer;
        private System.Windows.Forms.ComboBox cbServer;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.GroupBox gFormLogin;
        private System.Windows.Forms.GroupBox gAccountType;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioStudentAccount;
    }
}