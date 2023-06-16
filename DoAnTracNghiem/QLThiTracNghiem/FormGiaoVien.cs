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

namespace QLThiTracNghiem
{
    public partial class FormGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        String maCoSo = "";
        int positionKhoa = 0;
        int positionGiaoVien = 0;
        Func<bool> validateAction;

        public FormGiaoVien()
        {
            InitializeComponent();
            this.gcGIAOVIEN.ContextMenuStrip = contextMenuStrip1;
        }

        private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DB_THI_TN);

        }

        private void FormGiangVien_Load(object sender, EventArgs e)
        {

            this.DB_THI_TN.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'DB_THI_TN.Khoa' table. You can move, or remove it, as needed.
            this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KhoaTableAdapter.Fill(this.DB_THI_TN.Khoa);

            // TODO: This line of code loads data into the 'dB_THI_TN.Giaovien' table. You can move, or remove it, as needed.
            this.GiaovienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GiaovienTableAdapter.Fill(this.DB_THI_TN.Giaovien);

            // TODO: This line of code loads data into the 'DB_THI_TN.Giaovien_Dangky' table. You can move, or remove it, as needed.
            this.Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.Giaovien_DangkyTableAdapter.Fill(this.DB_THI_TN.Giaovien_Dangky);

            // TODO: This line of code loads data into the 'DB_THI_TN.Bode' table. You can move, or remove it, as needed.
            this.BodeTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BodeTableAdapter.Fill(this.DB_THI_TN.Bode);

            this.cbCoSo.DataSource = Program.bds_dspm;
            this.cbCoSo.DisplayMember = "TenCS";
            this.cbCoSo.ValueMember = "MaCS";
            this.cbCoSo.SelectedIndex = Program.currentServerIndex;
            this.cbCoSo.DropDownStyle = ComboBoxStyle.DropDownList;

            //this.cbHOCVI.Items.AddRange(new object[] {"Giáo sư",
            //            "Phó giáo sư",
            //            "Tiến Sĩ",
            //            "Kỹ Sư",
            //            "Cử Nhân",
            //            "Thạc Sĩ"});

            this.cbHOCVI.Items.Add("Giáo sư");
            this.cbHOCVI.Items.Add("Phó giáo sư");
            this.cbHOCVI.Items.Add("Tiến Sĩ");
            this.cbHOCVI.Items.Add("Kỹ Sư");
            this.cbHOCVI.Items.Add("Cử Nhân");
            this.cbHOCVI.Items.Add("Thạc Sĩ");
            this.cbHOCVI.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                maCoSo = ((DataRowView)bdsKhoa[0])["MACS"].ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                string spCOSO = "Exec SP_Tim_MACS";
                Program.myReader = Program.ExecSqlDataReader(spCOSO);
                Program.myReader.Read();
                maCoSo = Program.myReader.GetValue(0).ToString();
                Console.WriteLine($"Ham nay chay {maCoSo}");
                Program.conn.Close();
            }

            EnalbeEditing();

            this.panelKHOA.Enabled = false;
            this.panelGIAOVIEN.Enabled = false;

            this.gvKHOA.OptionsBehavior.Editable = false;
            this.gvGIAOVIEN.OptionsBehavior.Editable = false;

        }

        private void EnalbeEditing()
        {
            switch (Program.groupLoginType)
            {
                case Simple.GroupLoginType.Truong:
                    this.btnThem.Enabled = this.btnGhi.Enabled = this.btnReload.Enabled
                        = this.btnSua.Enabled = this.btnXoa.Enabled = this.btnUndo.Enabled = false;
                    this.cbCoSo.Enabled = true;
                    this.contextMenuStrip1.Enabled = false;
                    break;
                case Simple.GroupLoginType.CoSo:
                    this.btnThem.Enabled = this.btnReload.Enabled
                       = this.btnSua.Enabled = this.btnXoa.Enabled = true;
                    this.btnUndo.Enabled = this.btnGhi.Enabled = false;
                    this.cbCoSo.Enabled = false;
                    this.contextMenuStrip1.Enabled = true;
                    this.gcGIAOVIEN.ContextMenuStrip = this.contextMenuStrip1;
                    break;
                default:
                    this.btnThem.Enabled = this.btnGhi.Enabled = this.btnReload.Enabled
                        = this.btnSua.Enabled = this.btnXoa.Enabled = false;
                    this.cbCoSo.Enabled = false;
                    this.contextMenuStrip1.Enabled = false;
                    break;
            }

            if (bdsKhoa.Count == 0) btnXoa.Enabled = false;
        }

        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.currentServerValue = cbCoSo.SelectedValue.ToString();
            }
            catch (Exception) { };
            if (cbCoSo.SelectedIndex != Program.currentServerIndex)
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

                    // TODO: This line of code loads data into the 'dB_THI_TN.Giaovien' table. You can move, or remove it, as needed.
                    this.GiaovienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.GiaovienTableAdapter.Fill(this.DB_THI_TN.Giaovien);

                    // TODO: This line of code loads data into the 'DB_THI_TN.Khoa' table. You can move, or remove it, as needed.
                    this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KhoaTableAdapter.Fill(this.DB_THI_TN.Khoa);

                    // TODO: This line of code loads data into the 'DB_THI_TN.Giaovien_Dangky' table. You can move, or remove it, as needed.
                    this.Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.Giaovien_DangkyTableAdapter.Fill(this.DB_THI_TN.Giaovien_Dangky);

                    // TODO: This line of code loads data into the 'DB_THI_TN.Bode' table. You can move, or remove it, as needed.
                    this.BodeTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.BodeTableAdapter.Fill(this.DB_THI_TN.Bode);
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'DB_THI_TN.Khoa' table. You can move, or remove it, as needed.
                this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KhoaTableAdapter.Fill(this.DB_THI_TN.Khoa);

                // TODO: This line of code loads data into the 'dB_THI_TN.Giaovien' table. You can move, or remove it, as needed.
                this.GiaovienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GiaovienTableAdapter.Fill(this.DB_THI_TN.Giaovien);

                // TODO: This line of code loads data into the 'DB_THI_TN.Giaovien_Dangky' table. You can move, or remove it, as needed.
                this.Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
                this.Giaovien_DangkyTableAdapter.Fill(this.DB_THI_TN.Giaovien_Dangky);

                // TODO: This line of code loads data into the 'DB_THI_TN.Bode' table. You can move, or remove it, as needed.
                this.BodeTableAdapter.Connection.ConnectionString = Program.connstr;
                this.BodeTableAdapter.Fill(this.DB_THI_TN.Bode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Lỗi reload! Vui lòng thử lại sau.", MessageBoxButtons.OK);
            }
        }


        private void themGiaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionGiaoVien = this.bdsGiaoVien.Position;
            bdsGiaoVien.AddNew();
            ActionBeforeEditGiaoVien();
            string currentKhoa = ((DataRowView)this.bdsGiaoVien[bdsGiaoVien.Position])["MAKH"].ToString();
            this.cbHOCVI.SelectedIndex = 0;
            this.txtFKMAKH.Text = currentKhoa;
            this.txtMAGIAOVIEN.Enabled = true;
            validateAction += this.HandlerThemGiaoVienDS;
        }

        private void ActionBeforeEditGiaoVien()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnUndo.Enabled = btnGhi.Enabled = false;
            this.panelGIAOVIEN.Enabled = true;
            this.gcGIAOVIEN.Enabled = false;
            this.gcKHOA.Enabled = false;
        }

        private bool HandlerThemGiaoVienDS()
        {
            string maGiaoVien = txtMAGIAOVIEN.Text.Trim();
            //
            try
            {
                String cmd = "Declare @check int " +
                    $"EXEC @check = SP_Kiem_Tra_GiaoVien '{maGiaoVien}' " +
                    $"Select 'result' = @check";
                Program.myReader = Program.ExecSqlDataReader(cmd);
                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result == 1)
                {
                    MessageBox.Show("Đã có mã Giáo Viên tồn tại trong dữ liệu!", "", MessageBoxButtons.OK);
                    txtMAKH.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            return true;
        }

        private void btnGhiGIAOVIEN_Click(object sender, EventArgs e)
        {
            if (ValidateInput() == false)
            {
                return;
            }

            //Validate by SP
            if (validateAction != null)
                if (validateAction?.Invoke() == false)
                    return;

            try
            {
                bdsGiaoVien.EndEdit();
                bdsGiaoVien.ResetCurrentItem();
                this.GiaovienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GiaovienTableAdapter.Update(this.DB_THI_TN.Giaovien);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                return;
            }

            ActionAfterEditGiaoVien();
        }

        private bool ValidateInput()
        {
            string maGiaoVien = txtMAGIAOVIEN.Text.Trim();
            if (maGiaoVien == "")
            {
                MessageBox.Show("Mã Giáo Viên không được để trống!", "", MessageBoxButtons.OK);
                txtMAGIAOVIEN.Focus();
                return false;
            }

            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống!", "", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }

            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            if (cbHOCVI.Text.Trim() == "")
            {
                MessageBox.Show("Hãy chọn học vị!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            return true;
        }


        private void btnUndoGIAOVIEN_Click(object sender, EventArgs e)
        {
            bdsGiaoVien.CancelEdit();
            if (!btnThem.Enabled) bdsKhoa.Position = positionKhoa;
            ActionAfterEditGiaoVien();
        }

        private void ActionAfterEditGiaoVien()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
            panelGIAOVIEN.Enabled = false;
            gcGIAOVIEN.Enabled = true;
            gcKHOA.Enabled = true;

            this.validateAction -= HandlerThemGiaoVienDS;
        }

        private void suaGiaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bdsGiaoVien.Count == 0)
            {
                MessageBox.Show("Không có danh sach Giáo Viên ", "OK", MessageBoxButtons.OK);
                return;
            }


            positionGiaoVien = this.bdsGiaoVien.Position;
            ActionBeforeEditGiaoVien();
            this.txtMAGIAOVIEN.Enabled = false;
        }

        private void xoaGiaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String maGiaoVien = "";

            if (bdsGiaoVien.Count == 0)
            {
                MessageBox.Show("Không có danh sach Giáo Viên ", "OK", MessageBoxButtons.OK);
                return;
            }

            if (bdsBoDe.Count > 0)
            {
                MessageBox.Show("Không thể xóa, Giáo Viên đã lập câu hỏi!!");
                return;
            }

            if (bdsGiaoVien_DangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa, Giáo viên đã lập lịch thi!!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xoá?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int currPos = bdsGiaoVien.Position;
                try
                {
                    maGiaoVien = ((DataRowView)bdsGiaoVien[bdsGiaoVien.Position])["MAGV"].ToString();
                    bdsGiaoVien.RemoveCurrent();

                    this.GiaovienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.GiaovienTableAdapter.Update(this.DB_THI_TN.Giaovien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    this.GiaovienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.GiaovienTableAdapter.Fill(this.DB_THI_TN.Giaovien);
                    bdsGiaoVien.Position = currPos;

                }
            }
        }
    }
}