using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors.NavigatorButtons;
using QLThiTracNghiem;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLThiTracNghiem
{
    internal class Simple
    {
        public enum GroupLoginType
        {
            NONE,
            TRUONG,
            COSO,
            GIANGVIEN,
            SINHVIEN,
        }
        public static GroupLoginType ConvertLoginGroup(String loginType)
        {
            Console.WriteLine(loginType);
            switch (loginType.ToUpper())
            {
                case "TRUONG":
                    return GroupLoginType.TRUONG;
                case "COSO":
                    return GroupLoginType.COSO;
                case "GIANGVIEN":
                    return GroupLoginType.GIANGVIEN;
                case "SINHVIEN":
                    return GroupLoginType.SINHVIEN;
                default:
                    return GroupLoginType.NONE;
            }
        }
    }

    internal static class Program
    {
        private static string serverNameBase = "DESKTOP-5Q314UD";
        private static string dbname = "DB_TracNghiem";

        public static SqlConnection conn = new SqlConnection();
        //Ten Conn dang ket noi
        public static string connstr;

        //Ten Conn site chu
        public static string connstr_publisher = $"Data Source={serverNameBase};Initial Catalog={dbname};Trusted_Connection=True";

        
        public static SqlDataReader myReader;
        public static SqlDataAdapter da;

        //TK HTKN
        public static string remote_login = "HTKN";
        public static string remote_password = "kc";

        //TK SV
        public static string sv_login = "SV";
        public static string sv_password = "kc";

        #region Thong Tin User
        public static string username = "";
        public static string fullname = "";
        public static string currentServerValue = "";
        public static int currentServerIndex = 0; // server index selected
        public static string mloginDN = "";
        public static string mlogin = "";
        public static string mpasswordDN = "";
        public static string password = "";
        public static Simple.GroupLoginType groupLoginType;

        #endregion
        
        //Luu View_Subscribers Phan manh
        public static BindingSource bds_dspm = new BindingSource();
        public static FormMain mainForm;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.currentServerValue + ";Initial Catalog="
                    + Program.dbname + ";User ID=" + Program.mlogin
                    + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(Program.connstr);
                Console.WriteLine($"check currentServerValue: {Program.currentServerValue}, userId = {Program.mlogin} and pssw = {Program.password}");
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader myreader;

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Program.conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlQuery(String cmd, String connectionString)
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(connectionString);
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            return dt;
        }

        public static int ExecSqlNonQuery(String cmd, String connectionstring)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.Connection = conn;
            Sqlcmd.CommandText = cmd;
            Sqlcmd.CommandTimeout = 600;
            Sqlcmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {

                Sqlcmd.ExecuteNonQuery(); conn.Close(); return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 0;
            }

        }

        public static void ResetUser()
        {
            //username = "";
            //fullname = "";
            //currentServerIndex = 0;
            //mloginDN = "";
            mlogin = "";
            //groupLoginType = Simple.GroupLoginType.NONE;
            password = "";
            //mpasswordDN = "";
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new FormMain();
            Application.Run(mainForm);
        }
    }
}
