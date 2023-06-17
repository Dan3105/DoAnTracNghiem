using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using QLThiTracNghiem.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLThiTracNghiem
{
    public partial class FormBangDiem : DevExpress.XtraEditors.XtraForm
    {
        String maCoSo = "";
        
        public FormBangDiem()
        {
            InitializeComponent();
        }

        private void FormBangDiem_Load(object sender, EventArgs e)
        {
            this.DB_THI_TN.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DB_THI_TN.SP_Lay_DS_Lich_Thi_Da_Thi' table. You can move, or remove it, as needed.
            this.SP_Lay_DS_Lich_Thi_Da_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SP_Lay_DS_Lich_Thi_Da_ThiTableAdapter.Fill(this.DB_THI_TN.SP_Lay_DS_Lich_Thi_Da_Thi);

            this.cbCoSo.DataSource = Program.bds_dspm;
            this.cbCoSo.DisplayMember = "TenCS";
            this.cbCoSo.ValueMember = "MaCS";
            this.cbCoSo.SelectedIndex = Program.currentServerIndex;

            try
            {
                string spCOSO = "Exec SP_Tim_MACS";
                Program.myReader = Program.ExecSqlDataReader(spCOSO);
                Program.myReader.Read();
                maCoSo = Program.myReader.GetValue(0).ToString();
                Program.conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            gvLichDaThi.OptionsBehavior.Editable = false;
            if (Program.groupLoginType != Simple.GroupLoginType.Truong)
                this.cbCoSo.Enabled = false;
        }


        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.currentServerValue = cbCoSo.SelectedValue.ToString();
            }
            catch (Exception) { };
            if (cbCoSo.SelectedIndex != Program.currentServerIndex)
            {
                Program.mlogin = Program.remote_login;
                Program.password = Program.remote_password;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.mpasswordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    this.DB_THI_TN.EnforceConstraints = false;
                    // TODO: This line of code loads data into the 'DB_THI_TN.SP_Lay_DS_Lich_Thi_Da_Thi' table. You can move, or remove it, as needed.
                    this.SP_Lay_DS_Lich_Thi_Da_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SP_Lay_DS_Lich_Thi_Da_ThiTableAdapter.Fill(this.DB_THI_TN.SP_Lay_DS_Lich_Thi_Da_Thi);
                }
                catch (Exception ex) { MessageBox.Show($"Lỗi kết nối {ex.Message}"); Console.WriteLine(ex); }
            }
        }

        private void btnXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLichDaThi.Position == -1)
            {
                MessageBox.Show("Không có bảng điểm nào được chọn!", "", MessageBoxButtons.OK);
                return;
            }
            String maLop = ((DataRowView)bdsLichDaThi[bdsLichDaThi.Position])["MALOP"].ToString().Trim();
            String maMH = ((DataRowView)bdsLichDaThi[bdsLichDaThi.Position])["MAMH"].ToString().Trim();
            String lan = ((DataRowView)bdsLichDaThi[bdsLichDaThi.Position])["LAN"].ToString();
            Xrpt_Lay_BangDiem rpt = new Xrpt_Lay_BangDiem(maLop, maMH, int.Parse(lan));
            rpt.lblMaLop.Text = maLop;
            rpt.lblTenLop.Text = ((DataRowView)bdsLichDaThi[bdsLichDaThi.Position])["TENLOP"].ToString();
            rpt.lblMaMH.Text = maMH;
            rpt.lblTenMH.Text = ((DataRowView)bdsLichDaThi[bdsLichDaThi.Position])["TENMH"].ToString();
            rpt.lblLan.Text = lan;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.DB_THI_TN.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'DB_THI_TN.SP_Lay_DS_Lich_Thi_Da_Thi' table. You can move, or remove it, as needed.
                this.SP_Lay_DS_Lich_Thi_Da_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SP_Lay_DS_Lich_Thi_Da_ThiTableAdapter.Fill(this.DB_THI_TN.SP_Lay_DS_Lich_Thi_Da_Thi);
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi kết nối {ex.Message}"); Console.WriteLine(ex); }
        }
    }
}