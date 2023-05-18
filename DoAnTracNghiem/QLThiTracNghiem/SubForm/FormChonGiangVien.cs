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
            this.V_DSGV_Chua_Co_TKTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_THI_TN.V_DSGV_Chua_Co_TK' table. You can move, or remove it, as needed.
            this.V_DSGV_Chua_Co_TKTableAdapter.Fill(this.DB_THI_TN.V_DSGV_Chua_Co_TK);
               
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
            string maGV = ((DataRowView)bdsV_DSGV_Chua_Co_TK[bdsV_DSGV_Chua_Co_TK.Position])["MAGV"].ToString();
            frmTK.MaGV = maGV;
            this.Close();
        }
    }
}