using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace QLThiTracNghiem
{
    public partial class Xrpt_Xem_Danhsach_Dangky_thi : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_Xem_Danhsach_Dangky_thi()
        {
            InitializeComponent();
        }
        
        public Xrpt_Xem_Danhsach_Dangky_thi(DateTime batDau, DateTime ketThuc)
        {
            //ti nho lam try catch
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = batDau.ToString("yyyy-MM-dd");
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ketThuc.ToString("yyyy-MM-dd");
            this.sqlDataSource1.Fill();

            this.ngayBatDau = batDau.ToString("dd/MM/yyyy");
            this.ngayKetThuc = ketThuc.ToString("dd/MM/yyyy");

            Console.WriteLine(((DataRowView)Program.bds_dspm[Program.currentServerIndex])["TenCS"]);

            this.lblCoSoHienTai.Text = "DANH SÁCH ĐĂNG KÝ THI TRẮC NGHIỆM CƠ SỞ " +
                                        ((DataRowView)Program.bds_dspm[Program.currentServerIndex])["TenCS"];



            this.lblCoSoKhac.Text = "DANH SÁCH ĐĂNG KÝ THI TRẮC NGHIỆM CƠ SỞ " +
                                    ((DataRowView)Program.bds_dspm[(Program.currentServerIndex == 1 ? 0 : 1)])["TenCS"];
            
            this.XRTuNgayDenNgay.Text = this.XRTuNgayDenNgay1.Text = "TỪ NGÀY " + ngayBatDau + " ĐẾN NGÀY " + ngayKetThuc;
        }

        private void lblCoSoHienTai_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = (XRLabel)sender;
            label.Text = label.Text.Replace("\\n", Environment.NewLine);
        }

        private void lblCoSoKhac_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = (XRLabel)sender;
            label.Text = label.Text.Replace("\\n", Environment.NewLine);
        }
    }
}
