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
    public partial class SubFormChonLop : DevExpress.XtraEditors.XtraForm
    {
       
        private static string MaLop { get; set; }
        private static string TenLop { get; set; }

        private Action<string, string> setThongTin;
        public void SetActionKetThuc(Action<string, string> _setThongTin)
        {
            setThongTin = null;
            this.setThongTin += _setThongTin;
        }
        public SubFormChonLop()
        {
            InitializeComponent();
        }

        private void SubFormChonLop_Load(object sender, EventArgs e)
        {
            this.DB_THI_TN.EnforceConstraints = false;
            
            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'DB_THI_TN.Lop' table. You can move, or remove it, as needed.
            this.LopTableAdapter.Fill(this.DB_THI_TN.Lop);

            this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_THI_TN.Khoa' table. You can move, or remove it, as needed.
            this.KhoaTableAdapter.Fill(this.DB_THI_TN.Khoa);

            this.cbCoSo.DataSource = Program.bds_dspm;
            this.cbCoSo.DisplayMember = "TenCS";
            this.cbCoSo.ValueMember = "MaCS";
            this.cbCoSo.SelectedIndex = Program.currentServerIndex;

            this.gvLop.OptionsBehavior.Editable = false;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(bdsLop.Position == -1)
            {
                MessageBox.Show("Không có tên lớp nào đuọcư chọn", "", MessageBoxButtons.OK);
                //frm.CurrentMaMH = "";
                this.Close();
                return;
            }
            MaLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            TenLop = ((DataRowView)bdsLop[bdsLop.Position])["TENLOP"].ToString();
            this.setThongTin?.Invoke(MaLop, TenLop);
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}