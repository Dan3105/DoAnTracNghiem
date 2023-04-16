﻿using DevExpress.CodeParser;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username and Password are not allowed empty");
                return;
            }

            Program.mlogin = txtUsername.Text;
            Program.password = txtPassword.Text;
            if (Program.Connect() == 0) return;
            bool isTeacher = this.radioStudentAccount.Checked ? false : true;
            string strLenh = $"EXEC SP_Get_User_Info '{Program.mlogin}', {(isTeacher ? '1' : '0')}";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            try
            {
                Program.username = Program.myReader.GetString(0);
                Program.fullname = Program.myReader.GetString(1);
                Program.mserverSelected = cbServer.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.groupLoginType = Simple.ConvertLoginGroup(Program.myReader.GetString(2));
                Program.mainForm.AssignUserLoginData();
                Program.myReader.Close();
                Program.conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Invalid Login, Check your username and password");
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
                Program.servername = cbServer.SelectedValue.ToString();
            }
            catch(Exception exc)
            { Console.Write(exc.ToString()); }
        }

        private static string GetServersSql = "Select * From Get_Subscribers";
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (Connecto_MainDB() == 0) return;
            GetDatabase(GetServersSql);
            cbServer.SelectedIndex = 1;
            cbServer.SelectedIndex = 0;

            
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
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine($"Check nameserver {Program.servername}, and {Program.connstr_publisher} ");
                return 0;
            }
            
        }

    }
}
