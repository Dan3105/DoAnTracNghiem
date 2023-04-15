using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors.NavigatorButtons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLThiTracNghiem
{
    public struct DatabaseInformationLogin
    {
        public string username;
        public string fullname;
        public string facility;
    }
    internal static class Program
    {
        private static string serverNameBase = "DESKTOP-5Q314UD";
        private static string dbname = "DB_TracNghiem";

        public static SqlConnection conn = new SqlConnection();
        public static string connstr;
        public static string connstr_publisher = $"Data Source={serverNameBase};Initial Catalog={dbname};Trusted_Connection=True";

        public static SqlDataReader myReader;
        public static SqlDataAdapter da;
        public static string remote_login = "";
        public static string remote_password = "";

        public static string username = "";
        public static string fullname = "";
        public static string servername = "";
        public static int mservername = 0;
        public static string mloginDN = "";
        public static string mlogin = "";
        public static string passwordDN = "";
        public static string password = "";

        public static BindingSource bds_spm = new BindingSource();
        public static FormMain mainForm;

        public static int Connect()
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog="
                    + Program.dbname + ";User ID=" + Program.mlogin
                    +";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(Program.connstr);
                Console.WriteLine($"check servername: {Program.servername}, userId = {Program.mlogin} and pssw = {Program.password}");
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
            catch (SqlException ex)
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
