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
        private String maLop { get; set; }
        private String maMH { get; set; }
        public FormBangDiem()
        {
            InitializeComponent();
        }

        private void FormBangDiem_Load(object sender, EventArgs e)
        {
            this.DB_THI_TN.EnforceConstraints = false;
            this.cbLAN.Items.AddRange(new object[] {1,2});
            this.cbLAN.SelectedIndex = 0;
        }

        private void btnXEM_Click(object sender, EventArgs e)
        {
            if(maLop == null)
            {
                MessageBox.Show("Vui lòng chọn lớp!", "", MessageBoxButtons.OK);
                return;
            }
            if(maMH == null)
            {
                MessageBox.Show("Vui lòng chọn Môn học!", "", MessageBoxButtons.OK);
                return;
            }

            Xrpt_Lay_BangDiem rpt = new Xrpt_Lay_BangDiem(maLop, maMH, int.Parse(this.cbLAN.Text));
            rpt.lblMaLop.Text = maLop;
            rpt.lblTenLop.Text = this.txtTenLop.Text;
            rpt.lblMaMH.Text = this.maMH;
            rpt.lblTenMH.Text = this.txtTenMH.Text;
            rpt.lblLan.Text = this.cbLAN.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();


        }

        private void SetThongTinLop(string maLop, string tenLop)
        {
            this.maLop = maLop;
            this.txtTenLop.Text = tenLop;
        }

        private void SetThongTinMonHoc(string maMH, string tenMH)
        {
            this.maMH = maMH;
            this.txtTenMH.Text = tenMH;
        }

        private void btnCHONLOP_Click(object sender, EventArgs e)
        {
            SubFormChonLop subFormChonLop = new SubFormChonLop();
            subFormChonLop.SetActionKetThuc(SetThongTinLop);
            subFormChonLop.ShowDialog(this);
        }

        private void btnCHONMON_Click(object sender, EventArgs e)
        {
            SubFormChonMonHoc subFormChonMonHoc = new SubFormChonMonHoc();
            subFormChonMonHoc.SetActionKetThuc(SetThongTinMonHoc);
            subFormChonMonHoc.ShowDialog(this);
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}