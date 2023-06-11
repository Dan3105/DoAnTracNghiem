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
        }

        private bool validateInput()
        {
            //txt la text label ma :v :< lo roi cho copy paste cai di luoi v cau :<<
            //v de toi sua
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

            Xrpt_Xem_Danhsach_Dangky_thi rpt = new Xrpt_Xem_Danhsach_Dangky_thi(deBatDau.Text, deKetThuc.Text);

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}