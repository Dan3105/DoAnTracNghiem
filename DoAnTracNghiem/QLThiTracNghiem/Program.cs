using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLThiTracNghiem
{
    internal static class Program
    {
        private static string serverAuthentication = "DESKTOP-5Q314UD";
        private static string dbname = "DB_TracNghiem";
        public static SqlConnection conn = new SqlConnection();
        public static string connstr;
        public static string connstr_publisher = $"Data Source={serverAuthentication};Initial Catalog={dbname};Intergrated Security=True";

        public static SqlDataReader myReader;
        public static string remote_login = "";
        public static string remote_password = "";

        public static string username = "";
        public static string servername = "";
        public static int mservername = 0;
        public static string mloginDN = "";
        public static string mlogin = "";
        public static string passwordDN = "";
        public static string password = "";

        public static BindingSource bds_spm = new BindingSource();
        public static Form mainForm;

        public static int Connect()
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source" + Program.servername + ";Initial Catalog="
                    + Program.dbname + ";User ID=" + Program.mlogin
                    +";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine($"check servername: {Program.servername}, userId = {Program.mlogin} and pssw = {Program.password}");
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader myreader;
            //Program.conn = new SqlConnection(connectionstring);

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


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new frmDangNhap();
            Application.Run(mainForm);
        }
    }
}
