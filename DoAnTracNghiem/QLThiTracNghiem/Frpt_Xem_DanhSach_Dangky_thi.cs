using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThiTracNghiem
{
    public partial class Frpt_Xem_DanhSach_Dangky_thi : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_Xem_DanhSach_Dangky_thi()
        {
            InitializeComponent();
            this.deBatDau.DateTime = DateTime.Now;
            this.deKetThuc.DateTime = DateTime.Now;
        }

        private bool validateInput()
        {
            if (string.IsNullOrEmpty(deBatDau.Text))
            {
                MessageBox.Show("Thời gian bắt đầu không được để trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrEmpty(deKetThuc.Text))
            {
                MessageBox.Show("Thời gian kết thúc không được để trống ", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (DateTime.Compare(deBatDau.DateTime, deKetThuc.DateTime) > 0)
            {
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (!validateInput()) return;

            Xrpt_Xem_Danhsach_Dangky_thi rpt = new Xrpt_Xem_Danhsach_Dangky_thi(deBatDau.DateTime, deKetThuc.DateTime);

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}