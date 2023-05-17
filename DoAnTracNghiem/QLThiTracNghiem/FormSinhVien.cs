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
    
            this.DB_TracNghiem.EnforceConstraints = false;

            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'DB_TracNghiem.KHOA' table. You can move, or remove it, as needed.
            this.KHOATableAdapter.Fill(this.DB_TracNghiem.KHOA);
            
            SetComboBox();

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_TracNghiem.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Fill(this.DB_TracNghiem.LOP);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_TracNghiem.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Fill(this.DB_TracNghiem.SINHVIEN);

            
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

            this.cbKHOA.DataSource = this.bdsKHOA;
            this.cbKHOA.DisplayMember = "TENKHOA";
            this.cbKHOA.ValueMember = "MAKHOA";
            this.cbKHOA.SelectedIndex = 0;
        }

        private void CustomButton()
        {
            switch(Program.groupLoginType)
            {
                case Simple.GroupLoginType.truong:
                    this.cbCOSO.Enabled = true;
                    this.menuStripSINHVIEN.Visible = false;
                    break;
                case Simple.GroupLoginType.co_so:
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
                    this.DB_TracNghiem.EnforceConstraints = false;

                    this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dB_TracNghiem.KHOA' table. You can move, or remove it, as needed.
                    this.KHOATableAdapter.Fill(this.DB_TracNghiem.KHOA);

                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dB_TracNghiem.LOP' table. You can move, or remove it, as needed.
                    this.LOPTableAdapter.Fill(this.DB_TracNghiem.LOP);

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dB_TracNghiem.SINHVIEN' table. You can move, or remove it, as needed.
                    this.SINHVIENTableAdapter.Fill(this.DB_TracNghiem.SINHVIEN);
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
        }

        private void tsSuaSINHVIEN_Click(object sender, EventArgs e)
        {
            if(bdsSINHVIEN.Count == 0)
            {
                MessageBox.Show("Không có danh sach lớp ", "OK", MessageBoxButtons.OK);
                return;
            }
            positionSinhVien = this.bdsSINHVIEN.Position;
            this.txtMASV.Enabled = false;
            ActionBeforeEditSINHVIEN();
            
        }


        private void tsXoaSINHVIEN_Click(object sender, EventArgs e)
        {
            String maSV = "";
            if (MessageBox.Show("Bạn có muốn xóa ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maSV = ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["MASV"].ToString();
                    bdsSINHVIEN.RemoveCurrent();

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.DB_TracNghiem.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.DB_TracNghiem.SINHVIEN);
                    bdsSINHVIEN.Position = bdsSINHVIEN.Find("MASV", maSV);

                }
            }

            if (bdsSINHVIEN.Count == 0) this.tsXoaSINHVIEN.Enabled = false;
        }

        private void tsThemSINHVIEN_Click(object sender, EventArgs e)
        {
            positionSinhVien = this.bdsSINHVIEN.Position;
            bdsSINHVIEN.AddNew();
            ActionBeforeEditSINHVIEN();
            string currentLop = ((DataRowView)this.bdsLOP[bdsLOP.Position])["MALOP"].ToString();
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
            /*  this.validateAction -= HandlerThemInput;*/

            try
            {
                bdsSINHVIEN.EndEdit();
                bdsSINHVIEN.ResetCurrentItem();
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Update(this.DB_TracNghiem.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                return;
            }

            ActionAfterEditSINHVIEN();
        }

        private bool ValidateInput()
        {
            /*    string maKhoa = txtMAKHOA.Text.Trim();
                if (maKhoa == "")
                {
                    MessageBox.Show("Mã Khoa không được để trống!", "", MessageBoxButtons.OK);
                    txtMAKHOA.Focus();
                    return;
                }

                if (txtTENKHOA.Text.Trim() == "")
                {
                    MessageBox.Show("Tên Khoa không được để trống!", "", MessageBoxButtons.OK);
                    txtTENKHOA.Focus();
                    return;
                }*/
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
                    MessageBox.Show("Đã có mã sinh vien tồn tại trong dữ liệu!", "", MessageBoxButtons.OK);
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
            bdsLOP.CancelEdit();
            if (validateAction != null) 
                bdsSINHVIEN.Position = positionSinhVien;
            ActionAfterEditSINHVIEN();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LOPTableAdapter.Fill(this.DB_TracNghiem.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error Reloading", MessageBoxButtons.OK);
            }
        }
    }
}