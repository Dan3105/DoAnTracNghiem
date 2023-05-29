using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLThiTracNghiem.FormThi;

namespace QLThiTracNghiem
{
    public partial class FormLichThiThu : Form
    {
        public FormLichThiThu()
        {
            InitializeComponent();
        }

        private void FormLichThi_Load(object sender, EventArgs e)
        {
            DB_THI_TN.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dB_THI_TN.Giaovien_Dangky' table. You can move, or remove it, as needed.
            this.giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giaovien_DangkyTableAdapter.Fill(this.DB_THI_TN.Giaovien_Dangky);

            // TODO: This line of code loads data into the 'dB_THI_TN.Monhoc' table. You can move, or remove it, as needed.
            this.MonhocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MonhocTableAdapter.Fill(this.DB_THI_TN.Monhoc);

        }

        private void btnThiThu_Click(object sender, EventArgs e)
        {
            if(bdsGiaovien_Dangky.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn lịch thi", "", MessageBoxButtons.OK);
                return;
            }
            CauTrucThi ctt = new CauTrucThi();

            string maLop = ((DataRowView)bdsGiaovien_Dangky[bdsGiaovien_Dangky.Position])["MALOP"].ToString();
            int SoCauThi = int.Parse(((DataRowView)bdsGiaovien_Dangky[bdsGiaovien_Dangky.Position])["SOCAUTHI"].ToString());
            string maMH = ((DataRowView)bdsGiaovien_Dangky[bdsGiaovien_Dangky.Position])["MAMH"].ToString();
            string TrinhDo = ((DataRowView)bdsGiaovien_Dangky[bdsGiaovien_Dangky.Position])["TRINHDO"].ToString();
            DateTime NgayThi = (DateTime)((DataRowView)bdsGiaovien_Dangky[bdsGiaovien_Dangky.Position])["NGAYTHI"];
            int lanThi = int.Parse(((DataRowView)bdsGiaovien_Dangky[bdsGiaovien_Dangky.Position])["LAN"].ToString());
            int TgianThi = int.Parse(((DataRowView)bdsGiaovien_Dangky[bdsGiaovien_Dangky.Position])["THOIGIAN"].ToString().ToString());


            ctt.MaLOP = maLop;
            ctt.TenMH = txtTENMH.Text;
            ctt.SoCauThi = SoCauThi;
            ctt.MaMH = maMH;
            ctt.TrinhDo = TrinhDo.Trim();
            ctt.TgianThi= TgianThi;
            ctt.lanThi = lanThi;
            ctt.ngayThi = NgayThi;

            FormThi formThi = new FormThi();
            formThi.SetFormThi(ctt);
            formThi.ShowDialog(this);
        }
    }
}
