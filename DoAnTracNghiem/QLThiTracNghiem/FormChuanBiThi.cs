using DevExpress.XtraEditors;
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

namespace QLThiTracNghiem
{
   
    public partial class FormChuanBiThi : DevExpress.XtraEditors.XtraForm
    {
        private string currentMaMH;

        public string CurrentMaMH
        {
            private get 
            { return currentMaMH;}
            set {
                this.currentMaMH = value;
                this.txtMALOP.Text = this.currentMaMH;
            }
        }
        public FormChuanBiThi()
        {
            InitializeComponent();
        }

        private void FormChuanBiThi_Load(object sender, EventArgs e)
        {
            this.DB_THI_TN.EnforceConstraints = false;

            this.MonhocTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'DB_THI_TN.Monhoc' table. You can move, or remove it, as needed.
            this.MonhocTableAdapter.Fill(this.DB_THI_TN.Monhoc);

            this.Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_THI_TN.Giaovien_Dangky' table. You can move, or remove it, as needed.
            this.Giaovien_DangkyTableAdapter.Fill(this.DB_THI_TN.Giaovien_Dangky);
            this.txtMAGV.Text = Program.username;

            this.cbTRINHDO.Items.Add("A");
            this.cbTRINHDO.Items.Add("B");
            this.cbTRINHDO.Items.Add("C");

            this.cbLANTHI.Items.Add(1);
            this.cbLANTHI.Items.Add(2);
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {

        }

        private void btnXemLop_Click(object sender, EventArgs e)
        {
            SubFormChonLop subFormChonLop = new SubFormChonLop();
            subFormChonLop.SetFormCbiThi(this);
            subFormChonLop.ShowDialog(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}