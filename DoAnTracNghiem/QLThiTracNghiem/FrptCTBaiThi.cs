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
    public partial class FrptCTBaiThi : DevExpress.XtraEditors.XtraForm
    {
        public FrptCTBaiThi()
        {
            InitializeComponent();
        }


        private void FrptCTBaiThi_Load(object sender, EventArgs e)
        {
            this.DB_THI_TN.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dB_THI_TN.SP_Lay_DS_Bai_Thi' table. You can move, or remove it, as needed.
            this.sP_Lay_DS_Bai_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_Lay_DS_Bai_ThiTableAdapter.Fill(this.DB_THI_TN.SP_Lay_DS_Bai_Thi, Program.username.Trim());
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string maMH = ((DataRowView)bdsDSBaithi[bdsDSBaithi.Position])["MAMH"].ToString();
            Xrpt_CT_Bai_Thi rpt = new Xrpt_CT_Bai_Thi(Program.username, maMH, int.Parse(txtLanthi.Text));
            rpt.lbLop.Text = Program.MaLop;
            rpt.lbHoten.Text = Program.fullname;
            rpt.lbLanthi.Text = txtLanthi.Text;
            rpt.lbMonthi.Text = txtMonhoc.Text;
            rpt.lbNgaythi.Text = ((DataRowView)bdsDSBaithi[bdsDSBaithi.Position])["NGAYTHI"].ToString();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}