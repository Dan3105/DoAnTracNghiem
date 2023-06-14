using DevExpress.Utils.Html.Internal;
using DevExpress.XtraEditors;
using QLThiTracNghiem.DB_THI_TNTableAdapters;
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
        int crrPosition = 0;
        public FormDangkyThi()
        {
            InitializeComponent();
        }

        private void FormChuanBiThi_Load(object sender, EventArgs e)
        {
            this.DB_THI_TN.EnforceConstraints = false;

            this.Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_THI_TN.Giaovien_Dangky' table. You can move, or remove it, as needed.
            this.Giaovien_DangkyTableAdapter.Fill(this.DB_THI_TN.Giaovien_Dangky);
            this.txtMAGV.Text = Program.username;

            this.cbTRINHDO.Items.Add("A");
            this.cbTRINHDO.Items.Add("B");
            this.cbTRINHDO.Items.Add("C");

            this.cbLANTHI.Items.Add(1);
            this.cbLANTHI.Items.Add(2);

            SetCbServer();
        }

        private void SetCbServer()
        {
            this.cbServer.DataSource = Program.bds_dspm;
            this.cbServer.DisplayMember = "TenCS";
            this.cbServer.ValueMember = "MaCS";
            this.cbServer.SelectedIndex = Program.currentServerIndex;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            crrPosition = this.bdsGiaovien_Dangky.Position;
            bdsGiaovien_Dangky.AddNew();
            txtMAGV.Text = Program.username;
            ActionBeforeEdit();
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

        private void SetThongTinMh(string maMH, string tenMH)
        {
            this.txtMAMH.Text = maMH;
        }    

        private void btnWrite_Click(object sender, EventArgs e)
        {
            
            string maGV = txtMAGV.Text.Trim();
            if (String.IsNullOrEmpty(maGV))
            {
                MessageBox.Show("Mã NV đã bị trống", "", MessageBoxButtons.OK);
                return;
            }
            if (String.IsNullOrEmpty(txtMALOP.Text.Trim()))
            {
                MessageBox.Show("Mã Lớp đã bị trống", "", MessageBoxButtons.OK);
                return;
            }

            if (cbTRINHDO.SelectedIndex == -1)
            {
                MessageBox.Show("Trình độ đã bị trống", "", MessageBoxButtons.OK);
                return;
            }

            string maMH = txtMAMH.Text.Trim();
            if (maMH == "")
            {
                MessageBox.Show("Tên môn học đã bị trống", "", MessageBoxButtons.OK);
                return;
            }

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

            if (String.IsNullOrEmpty(tHOIGIANSpinEdit.Text.Trim()))
            {
                MessageBox.Show("Tgian thi đã bị trống", "", MessageBoxButtons.OK);
                return;
            }

            DateTime dateTime = (DateTime)nGAYTHIDateEdit.EditValue;
            if (dateTime == null)
            {
                MessageBox.Show("Tgian thi đã bị trống", "", MessageBoxButtons.OK);
                return;
            }
            if (dateTime.CompareTo(DateTime.Now) < 0)
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
                if (Program.myReader != null)
                {
                    Program.myReader.Read();
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result != 0)
                    {
                        bdsGiaovien_Dangky.EndEdit();
                        bdsGiaovien_Dangky.ResetCurrentItem();
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
                  MessageBox.Show("Đã thêm thành công !", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK);

                return;
            }
            finally
            {
                Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
                Giaovien_DangkyTableAdapter.Update(DB_THI_TN.Giaovien_Dangky);
                ActionAfterEdit();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            crrPosition = this.bdsGiaovien_Dangky.Position;
            ActionBeforeEdit();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (ValidateBeforeXoa() == false)
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    //maMH = ((DataRowView)bdsMonhoc[bdsMonhoc.Position])["MAMH"].ToString();
                    crrPosition = bdsGiaovien_Dangky.Position;
                    bdsGiaovien_Dangky.RemoveCurrent();

                    this.Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
                    Giaovien_DangkyTableAdapter.Update(this.DB_THI_TN.Giaovien_Dangky);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    this.Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
                    Giaovien_DangkyTableAdapter.Fill(this.DB_THI_TN.Giaovien_Dangky);
                    bdsGiaovien_Dangky.Position = crrPosition;

                }
            }

            if (bdsGiaovien_Dangky.Count == 0) btnDel.Enabled = false;
        }

        private bool ValidateBeforeXoa()
        {
            if (cbLANTHI.SelectedIndex == -1)
            {
                return false;
            }    
            string maMH = txtMAMH.Text;
            string maLop = txtMALOP.Text;
            int lan = int.Parse(cbLANTHI.SelectedItem.ToString());

            try
            {
                String cmd = "Declare @check int " +
                    $"EXEC @check = SP_Kiem_Tra_DaThi '{maMH}', '{maLop}', {lan} " +
                    $"Select 'result' = @check";
                Program.myReader = Program.ExecSqlDataReader(cmd);
                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result == 1)
                {
                    MessageBox.Show("Không thể xoá lịch vì đã có lớp thi", "", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return true;
        }

        private void ActionBeforeEdit()
        {
            gcGiaovien_Dangky.Enabled = false;
            panelDangky.Enabled = true;
            btnThem.Enabled = btnUpdate.Enabled = btnDel.Enabled = false;
            btnUndo.Enabled = btnWrite.Enabled = true;
        }

        private void ActionAfterEdit()
        {
            gcGiaovien_Dangky.Enabled = true;
            panelDangky.Enabled = false;
            btnThem.Enabled = btnUpdate.Enabled = btnDel.Enabled = true;
            btnUndo.Enabled = btnWrite.Enabled = false;
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            SubFormChonMonHoc subForm = new SubFormChonMonHoc();
            subForm.SetActionKetThuc(SetThongTinMh);
            subForm.ShowDialog(this);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            bdsGiaovien_Dangky.CancelEdit();
            if (!btnThem.Enabled) bdsGiaovien_Dangky.Position = crrPosition;
            ActionAfterEdit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                Giaovien_DangkyTableAdapter.Fill(this.DB_THI_TN.Giaovien_Dangky);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Reloading: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void cbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbServer.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.currentServerValue = cbServer.SelectedValue.ToString();
            }
            catch (Exception) { };
            if (cbServer.SelectedIndex != Program.currentServerIndex)
            {
                Program.mlogin = Program.remote_login;
                Program.password = Program.remote_password;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.mpasswordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    this.DB_THI_TN.EnforceConstraints = false;

                    this.Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dB_TracNghiem.KHOA' table. You can move, or remove it, as needed.
                    this.Giaovien_DangkyTableAdapter.Update(this.DB_THI_TN.Giaovien_Dangky);
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
        }
    }
}