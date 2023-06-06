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
    public partial class SubFormChonMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private static string MaMH { get; set; }
        private static string TenMH { get; set; }

        private Action<string, string> setThongTin;

        public void SetActionKetThuc(Action<string, string> _setThongTin)
        {
            setThongTin = null;
            this.setThongTin += _setThongTin;
        }

        public SubFormChonMonHoc()
        {
            InitializeComponent();
        }

        private void SubFormChonMonHoc_Load(object sender, EventArgs e)
        {
            this.DB_THI_TN.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dB_THI_TN.Monhoc' table. You can move, or remove it, as needed.
            this.MonhocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MonhocTableAdapter.Fill(this.DB_THI_TN.Monhoc);

            gvMonHoc.OptionsBehavior.Editable = false;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (bdsMonHoc.Position == -1)
            {
                MessageBox.Show("Không có môn nào đuọc chọn", "", MessageBoxButtons.OK);
                this.Close();
                return;
            }
            MaMH = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
            TenMH = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["TENMH"].ToString();
            this.setThongTin?.Invoke(MaMH, TenMH);
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}