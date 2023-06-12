using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThiTracNghiem
{
    public partial class FormDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();

        public FormDangNhap()
        {
            InitializeComponent();
        }


        private int Connecto_MainDB()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine($"Check nameserver {Program.currentServerValue}, and {Program.connstr_publisher} ");
                return 0;
            }

        }

        private void GetDatabase(string cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);

            Program.bds_dspm.DataSource = dt;
            cbServer.DataSource = Program.bds_dspm;
            cbServer.DisplayMember = "TenCS";
            cbServer.ValueMember = "MaCS";
        
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (Connecto_MainDB() == 0) return;
            GetDatabase(SqlCollections.Get_V_Subscribers);
            cbServer.SelectedIndex = 1;
            cbServer.SelectedIndex = 0;
        }
        #region Button Handler
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống!");
                return;
            }

            bool isTeacher = this.radioStudentAccount.Checked ? false : true;

            string strLenh = "";
            if (isTeacher)
            {
                Program.mlogin = txtUsername.Text;
                Program.password = txtPassword.Text;
                strLenh = SqlCollections.Sp_Get_User_Info();
            }
            else
            {
                strLenh = SqlCollections.Sp_DN_Cho_SV(txtUsername.Text, txtPassword.Text);
                Program.mlogin = Program.sv_login;
                Program.password = Program.sv_password;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Đăng nhập thất bại kiểm tra quyền hạn, tài khoản và mật khẩu");
                return;
            }

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            try
            {
                Program.username = Program.myReader.GetString(0);

                if(isTeacher)
                {
                    Program.fullname = Program.myReader.GetString(1);
                    Program.groupLoginType = Simple.ConvertLoginGroup(Program.myReader.GetString(2));
                }
                else
                {
                    Program.MaLop = Program.myReader.GetString(1);
                    Program.fullname = Program.myReader.GetString(2);
                    Program.groupLoginType = Simple.ConvertLoginGroup(Program.myReader.GetString(3));
                }
                
                Program.currentServerIndex = cbServer.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.mpasswordDN = Program.password;


                
                Program.mainForm.AssignUserLoginData();
                
                

                Program.myReader.Close();
                Program.conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Đăng nhập thất bại kiểm tra quyền hạn, tài khoản và mật khẩu");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Program.mainForm.Close();
        }

        private void cbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbServer.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.currentServerValue = cbServer.SelectedValue.ToString();
            }
            catch(Exception exc)
            { Console.Write(exc.ToString()); }
        }

        #endregion
    }
}
