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
            this.radioStudentAccount = new System.Windows.Forms.RadioButton();
            this.gAccountType = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.gFormLogin.SuspendLayout();
            this.gAccountType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(17, 107);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(333, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.Location = new System.Drawing.Point(17, 85);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 16);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "&Username";
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(17, 141);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(55, 16);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "&Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(17, 163);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(333, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // lbServer
            // 
            this.lbServer.Location = new System.Drawing.Point(17, 29);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(38, 16);
            this.lbServer.TabIndex = 4;
            this.lbServer.Text = "&Server";
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(17, 51);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(196, 24);
            this.cbServer.TabIndex = 5;
            this.cbServer.SelectedIndexChanged += new System.EventHandler(this.cbServer_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(17, 258);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "&Đăng Nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(256, 258);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
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
            this.gFormLogin.Location = new System.Drawing.Point(12, 12);
            this.gFormLogin.Name = "gFormLogin";
            this.gFormLogin.Size = new System.Drawing.Size(606, 306);
            this.gFormLogin.TabIndex = 8;
            this.gFormLogin.TabStop = false;
            this.gFormLogin.Text = "Đăng Nhập";
            // 
            // radioStudentAccount
            // 
            this.radioStudentAccount.AutoSize = true;
            this.radioStudentAccount.Location = new System.Drawing.Point(6, 21);
            this.radioStudentAccount.Name = "radioStudentAccount";
            this.radioStudentAccount.Size = new System.Drawing.Size(84, 20);
            this.radioStudentAccount.TabIndex = 8;
            this.radioStudentAccount.TabStop = true;
            this.radioStudentAccount.Text = "Sinh Viên";
            this.radioStudentAccount.UseVisualStyleBackColor = true;
            // 
            // gAccountType
            // 
            this.gAccountType.Controls.Add(this.radioButton1);
            this.gAccountType.Controls.Add(this.radioStudentAccount);
            this.gAccountType.Location = new System.Drawing.Point(17, 192);
            this.gAccountType.Name = "gAccountType";
            this.gAccountType.Size = new System.Drawing.Size(211, 52);
            this.gAccountType.TabIndex = 9;
            this.gAccountType.TabStop = false;
            this.gAccountType.Text = "Loại Tài Khoản";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(110, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 20);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Giảng Viên";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 338);
            this.Controls.Add(this.gFormLogin);
            this.Name = "frmDangNhap";
            this.Text = "Form Đăng Nhập";
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