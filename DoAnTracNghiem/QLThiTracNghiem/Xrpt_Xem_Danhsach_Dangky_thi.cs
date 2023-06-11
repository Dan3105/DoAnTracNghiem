using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLThiTracNghiem
{
    public partial class Xrpt_Xem_Danhsach_Dangky_thi : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_Xem_Danhsach_Dangky_thi()
        {
            InitializeComponent();
        }

        public Xrpt_Xem_Danhsach_Dangky_thi(string ngayBatDau, string ngayKetThuc)
        {
            //ti nho lam try catch
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngayBatDau;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngayKetThuc;
            this.sqlDataSource1.Fill();

            this.lblCoSoHienTai.Text =  this.lblCoSoHienTai.Text +
                                        tableCell2.Text + "\\n" +
                                        "TỪ NGÀY " + ngayBatDau + " ĐẾN NGÀY " + ngayKetThuc;

            this.lblCoSoKhac.Text = this.lblCoSoKhac.Text +
                                    tableCell18.Text + "\\n" +
                                    "TỪ NGÀY " + ngayBatDau + " ĐẾN NGÀY " + ngayKetThuc;
            
          
        }

        private void lblCoSoHienTai_BeforePrint(object sender, CancelEventArgs e)
        {
            //before print nay ow dau v :v lo coi alime qua ok deo
            XRLabel label = (XRLabel)sender;
            label.Text = label.Text.Replace("\\n", Environment.NewLine);
        }

        private void lblCoSoKhac_BeforePrint(object sender, CancelEventArgs e)
        {
            //du ghe
            XRLabel label = (XRLabel)sender;
            label.Text = label.Text.Replace("\\n", Environment.NewLine);
        }
    }
}
