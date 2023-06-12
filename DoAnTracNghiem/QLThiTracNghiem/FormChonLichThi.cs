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
    public partial class FormChonLichThi : Form
    {
        public FormChonLichThi()
        {
            InitializeComponent();
        }



        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.SP_DS_Co_The_ThiTableAdapter.Fill(this.DB_THI_TN.SP_DS_Co_The_Thi, maLopToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FormChonLichThi_Load(object sender, EventArgs e)
        {
            this.SP_DS_Co_The_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SP_DS_Co_The_ThiTableAdapter.Fill(this.DB_THI_TN.SP_DS_Co_The_Thi, Program.MaLop);
        }

        private bool ValidateInput()
        {
            
            DateTime NgayThi = (DateTime)((DataRowView)bdsSP_DS_Co_The_Thi[bdsSP_DS_Co_The_Thi.Position])["NGAYTHI"];
            TimeSpan timeLeft = DateTime.Now.Subtract(NgayThi);
            if (timeLeft.TotalMinutes < 0)
            {
                MessageBox.Show("Chưa tới giờ thi");
                return false;
            }
            if (timeLeft.TotalMinutes > 5)
            {
                MessageBox.Show("Đã quá hạn giờ thi");
                return false;
            }
            return true;
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            if(bdsSP_DS_Co_The_Thi.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn lịch thi");
                return;
            }

            if(ValidateInput() == false)
            {
                return;
            }

            CauTrucThi ctt = new CauTrucThi();
            
            int SoCauThi = int.Parse(((DataRowView)bdsSP_DS_Co_The_Thi[bdsSP_DS_Co_The_Thi.Position])["SOCAUTHI"].ToString());
            string maMH = ((DataRowView)bdsSP_DS_Co_The_Thi[bdsSP_DS_Co_The_Thi.Position])["MAMH"].ToString();
            string TrinhDo = ((DataRowView)bdsSP_DS_Co_The_Thi[bdsSP_DS_Co_The_Thi.Position])["TRINHDO"].ToString();
            DateTime NgayThi = (DateTime)((DataRowView)bdsSP_DS_Co_The_Thi[bdsSP_DS_Co_The_Thi.Position])["NGAYTHI"];
            int lanThi = int.Parse(((DataRowView)bdsSP_DS_Co_The_Thi[bdsSP_DS_Co_The_Thi.Position])["LAN"].ToString());
            int TgianThi = int.Parse(((DataRowView)bdsSP_DS_Co_The_Thi[bdsSP_DS_Co_The_Thi.Position])["THOIGIAN"].ToString().ToString());
            string tenMH = ((DataRowView)bdsSP_DS_Co_The_Thi[bdsSP_DS_Co_The_Thi.Position])["TENMH"].ToString();

            ctt.MaLOP = Program.MaLop;
            ctt.TenMH = tenMH;
            ctt.SoCauThi = SoCauThi;
            ctt.MaMH = maMH;
            ctt.TrinhDo = TrinhDo.Trim();
            ctt.TgianThi = TgianThi;
            ctt.lanThi = lanThi;
            ctt.ngayThi = NgayThi;

            FormThi formThi = new FormThi();
            formThi.SetFormThi(ctt);
            formThi.ShowDialog(this);
        }
    }
}
