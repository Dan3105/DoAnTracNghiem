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
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace QLThiTracNghiem
{
   
    public partial class FormDangkyThi : DevExpress.XtraEditors.XtraForm
    {

        public FormDangkyThi()
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
            string maGV = txtMAGV.Text.Trim();
            if (String.IsNullOrEmpty(maGV))
            {
                MessageBox.Show("Mã NV đã bị trống", "", MessageBoxButtons.OK);
                return;
            }

            string maLop = txtMALOP.Text.Trim();
            if (String.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Mã Lớp đã bị trống", "", MessageBoxButtons.OK);
                return;
            }

            if(cbTRINHDO.SelectedIndex == -1)
            {
                MessageBox.Show("Trình độ đã bị trống", "", MessageBoxButtons.OK);
                return;
            }
            string trinhDo = cbTRINHDO.SelectedItem.ToString();
         
            if (cbTENMH.SelectedIndex == -1)
            {
                MessageBox.Show("Tên môn học đã bị trống", "", MessageBoxButtons.OK);
                return;
            }
            string maMH = cbTENMH.SelectedValue.ToString();

            if (String.IsNullOrEmpty(txtSOCAUTHI.Text.Trim()))
            {
                MessageBox.Show("Số câu thi đã bị trống", "", MessageBoxButtons.OK);
                return;
            }
            int soCauThi = int.Parse(txtSOCAUTHI.Text.Trim());

            if (cbLANTHI.SelectedIndex == -1)
            {
                MessageBox.Show("Lần thi đã bị trống", "", MessageBoxButtons.OK);
                return;
            }
            int lanThi = int.Parse(cbLANTHI.SelectedItem.ToString());


            if (String.IsNullOrEmpty(tHOIGIANSpinEdit.Text.Trim()))
            {
                MessageBox.Show("Tgian thi đã bị trống", "", MessageBoxButtons.OK);
                return;
            }
            int thoiGian = int.Parse(tHOIGIANSpinEdit.Text.Trim());
            DateTime dateTime = (DateTime)nGAYTHIDateEdit.EditValue;
            if (dateTime == null)
            {
                MessageBox.Show("Tgian thi đã bị trống", "", MessageBoxButtons.OK);
                return;
            }
            if(dateTime.CompareTo(DateTime.Now) <= 0)
            {
                MessageBox.Show("Tgian đăng ký vui lòng sau ngày hôm nay", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                String cmd = "Declare @check int " +
                    $"EXEC @check = SP_KT_DKThi '{cbTRINHDO.SelectedItem}', '{soCauThi}', " +
                    $"{maMH} " +
                    $"Select 'result' = @check";
                Program.myReader = Program.ExecSqlDataReader(cmd);
                if(Program.myReader != null)
                {
                    Program.myReader.Read();
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result != 0)
                    {
                        MessageBox.Show($"Còn thiếu {result} trong bộ đề!", "", MessageBoxButtons.OK);

                        return;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }

            try
            {
                Giaovien_DangkyTableAdapter.Insert(maGV, maLop, maMH, trinhDo, dateTime, (short)lanThi, (short)soCauThi, (short)thoiGian);
                Giaovien_DangkyTableAdapter.Update(DB_THI_TN.Giaovien_Dangky);
                this.Giaovien_DangkyTableAdapter.Fill(this.DB_THI_TN.Giaovien_Dangky);

                MessageBox.Show("Đã thêm thành công !", "", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK);

                return;
            }


        }

        private void btnXemLop_Click(object sender, EventArgs e)
        {
            SubFormChonLop subFormChonLop = new SubFormChonLop();
            //subFormChonLop.SetFormCbiThi(this);
            subFormChonLop.SetActionKetThuc(SetThongTinLop);
            subFormChonLop.ShowDialog(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetThongTinLop(string maLop, string tenLop)
        {
            this.txtMALOP.Text = maLop;
        }
    }
}