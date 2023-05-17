using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThiTracNghiem.SubForm
{
    public partial class FormChonGiangVien : DevExpress.XtraEditors.XtraForm
    {
        private FormTaoTK frmTK;
        public FormChonGiangVien()
        {
            InitializeComponent();
        }

        private void FormChonGiangVien_Load(object sender, EventArgs e)
        {
            this.V_DS_GiangVien_Chua_Co_Tai_KhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_TracNghiem.V_DS_GiangVien_Chua_Co_Tai_Khoan' table. You can move, or remove it, as needed.
            this.V_DS_GiangVien_Chua_Co_Tai_KhoanTableAdapter.Fill(this.DB_TracNghiem.V_DS_GiangVien_Chua_Co_Tai_Khoan);

            this.gvDSGiangVien.OptionsBehavior.Editable = false;
        }

        public void SetFormTK(FormTaoTK frmTk)
        {
            this.frmTK = frmTk;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string maGV = ((DataRowView)bdsV_DS_GiangVien_Chua_Co_Tai_Khoan[bdsV_DS_GiangVien_Chua_Co_Tai_Khoan.Position])["MAGV"].ToString();
            frmTK.MaGV = maGV;
            this.Close();
        }
    }
}