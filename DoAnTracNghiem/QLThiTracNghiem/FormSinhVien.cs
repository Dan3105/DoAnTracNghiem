using DevExpress.Xpo;
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
    public partial class FormSinhVien : DevExpress.XtraEditors.XtraForm
    {
        Func<bool> validateAction;
        String maCoSo = "";
        int positionSinhVien = 0;
        public FormSinhVien()
        {
            InitializeComponent();
           
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            this.DB_THI_TN.EnforceConstraints = false;

            this.SinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_THI_TN.Sinhvien' table. You can move, or remove it, as needed.
            this.SinhvienTableAdapter.Fill(this.DB_THI_TN.Sinhvien);

            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_THI_TN.Lop' table. You can move, or remove it, as needed.
            this.LopTableAdapter.Fill(this.DB_THI_TN.Lop);

            this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_THI_TN.Khoa' table. You can move, or remove it, as needed.
            this.KhoaTableAdapter.Fill(this.DB_THI_TN.Khoa);
            // TODO: This line of code loads data into the 'dB_THI_TNDataSet.Khoa' table. You can move, or remove it, as needed.



            SetComboBox();

            CustomButton();

            gvLOP.OptionsBehavior.Editable = false;
            gvSINHVIEN.OptionsBehavior.Editable = false;
            panelSINHVIEN.Enabled = false;
        }

        private void SetComboBox()
        {
            this.cbCOSO.DataSource = Program.bds_dspm;
            this.cbCOSO.DisplayMember = "TenCS";
            this.cbCOSO.ValueMember = "MaCS";
            this.cbCOSO.SelectedIndex = Program.currentServerIndex;

/*            this.cbKHOA.DataSource = this.bdsKHOA;*/
            this.cbKHOA.DisplayMember = "TENKHOA";
            this.cbKHOA.ValueMember = "MAKH";
            this.cbKHOA.SelectedIndex = 0;
        }

        private void CustomButton()
        {
            switch(Program.groupLoginType)
            {
                case Simple.GroupLoginType.Truong:
                    this.cbCOSO.Enabled = true;
                    this.menuStripSINHVIEN.Visible = false;
                    break;
                case Simple.GroupLoginType.CoSo:
                    this.cbCOSO.Enabled = false;
                    this.gcSINHVIEN.ContextMenuStrip = this.menuStripSINHVIEN;
                    break;
                default:
                    this.cbCOSO.Enabled = false;
                    this.gcLOP.Enabled = this.gcSINHVIEN.Enabled = false;
                    this.menuStripSINHVIEN.Visible = false;
                    break;
            }
        }

        private void cbCOSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCOSO.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.currentServerValue = cbCOSO.SelectedValue.ToString();
            }
            catch (Exception) { };
            if (cbCOSO.SelectedIndex != Program.currentServerIndex)
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
                    this.SinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dB_THI_TN.Sinhvien' table. You can move, or remove it, as needed.
                    this.SinhvienTableAdapter.Fill(this.DB_THI_TN.Sinhvien);

                    this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dB_THI_TN.Lop' table. You can move, or remove it, as needed.
                    this.LopTableAdapter.Fill(this.DB_THI_TN.Lop);

                    this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dB_THI_TN.Khoa' table. You can move, or remove it, as needed.
                    this.KhoaTableAdapter.Fill(this.DB_THI_TN.Khoa);
                    // TODO: This line of code loads data into the 'dB_THI_TNDataSet.Khoa' table. You can move, or remove it, as needed.
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
        }

        private void tsSuaSINHVIEN_Click(object sender, EventArgs e)
        {
            if (bdsSinhvien.Count == 0)
            {
                MessageBox.Show("Không có Sinh viên nào đuọc chọn ", "OK", MessageBoxButtons.OK);
                return;
            }
            positionSinhVien = this.bdsSinhvien.Position;
            this.txtMASV.Enabled = false;
            ActionBeforeEditSINHVIEN();
            
        }


        private void tsXoaSINHVIEN_Click(object sender, EventArgs e)
        {
            if (bdsSinhvien.Count == 0)
            {
                MessageBox.Show("Không có Sinh Vien nào được chọn", "OK", MessageBoxButtons.OK);
                return;
            }
            String maSV = "";
            if (MessageBox.Show("Bạn có muốn xóa ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maSV = ((DataRowView)bdsSinhvien[bdsSinhvien.Position])["MASV"].ToString();
                    bdsSinhvien.RemoveCurrent();

                    this.SinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SinhvienTableAdapter.Update(this.DB_THI_TN.Sinhvien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    this.SinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SinhvienTableAdapter.Update(this.DB_THI_TN.Sinhvien);
                    bdsSinhvien.Position = bdsSinhvien.Find("MASV", maSV);

                }
            }

            if (bdsSinhvien.Count == 0) this.tsXoaSINHVIEN.Enabled = false;
        }

        private void tsThemSINHVIEN_Click(object sender, EventArgs e)
        {
            if (bdsLop.Count == 0)
            {
                MessageBox.Show("Không có danh sach lớp ", "OK", MessageBoxButtons.OK);
                return;
            }
            positionSinhVien = this.bdsSinhvien.Position;
            var newRecord = bdsSinhvien.AddNew();
            //Set mat khau mat dinh
            txtPassword.Text = "kc";
            ActionBeforeEditSINHVIEN();
            string currentLop = ((DataRowView)this.bdsLop[bdsLop.Position])["MALOP"].ToString();
            this.txtMALOP.Text = currentLop;
            
            this.txtMASV.Enabled = true;
            validateAction += this.ValidateThemSV;
        }

        private void ActionBeforeEditSINHVIEN()
        {
            btnGhiSINHVIEN.Enabled = btnPhucHoi.Enabled = true;
            this.panelSINHVIEN.Enabled = true;;
            this.gcLOP.Enabled = false;
            this.gcSINHVIEN.Enabled = false;
        }

        private void ActionAfterEditSINHVIEN()
        {
            btnGhiSINHVIEN.Enabled = btnPhucHoi.Enabled = false;
            this.panelSINHVIEN.Enabled = false;
            this.gcLOP.Enabled = true;
            this.gcSINHVIEN.Enabled = true;
            validateAction -= this.ValidateThemSV;
        }

        private void btnGhiSINHVIEN_Click(object sender, EventArgs e)
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
             
                bdsSinhvien.EndEdit();
                bdsSinhvien.ResetCurrentItem();
                this.SinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SinhvienTableAdapter.Update(this.DB_THI_TN.Sinhvien);
            }
            catch (Exception ex)
            {
                bdsSinhvien.EndEdit();
                MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                return;
            }

            ActionAfterEditSINHVIEN();
        }

        private bool ValidateInput()
        {
            string maSV = txtMASV.Text.Trim();
            string ho = txtHO.Text.Trim();
            string ten = txtTEN.Text.Trim();
            object ngaySinh = dateNGAYSINH.EditValue;
            string diachi = txtDIACHI.Text.Trim();
            if (maSV == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "", MessageBoxButtons.OK);
                txtMASV.Focus();
                return false;
            }

            if (ho == "")
            {
                MessageBox.Show("Họ không được để trống!", "", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }

            if (ten == "")
            {
                MessageBox.Show("Tên không được để trống!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            if (diachi == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            if (ngaySinh == null)
            {
                MessageBox.Show("không được để ngày sinh trống!", "", MessageBoxButtons.OK);
                dateNGAYSINH.Focus();
                return false;
            }
            return true;

        }

        private bool ValidateThemSV()
        {
            string maSV = txtMASV.Text.Trim();
            try
            {
                String cmd = "Declare @check int " +
                    $"EXEC @check = SP_Kiem_Tra_SinhVien '{maSV}' " +
                    $"Select 'result' = @check";
                Program.myReader = Program.ExecSqlDataReader(cmd);
                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result == 1)
                {
                    MessageBox.Show("Đã có mã sinh viên tồn tại trong dữ liệu!", "", MessageBoxButtons.OK);
                    txtMASV.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            return true;
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            bdsLop.CancelEdit();
            if (validateAction != null)
                bdsSinhvien.Position = positionSinhVien;
            ActionAfterEditSINHVIEN();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LopTableAdapter.Fill(this.DB_THI_TN.Lop);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error Reloading", MessageBoxButtons.OK);
            }
        }
    }
}