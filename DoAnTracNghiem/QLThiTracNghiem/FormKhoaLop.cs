using DevExpress.Utils.Html.Internal;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThiTracNghiem
{
    public partial class FormKhoaLop : DevExpress.XtraEditors.XtraForm
    {
        String maCoSo = "";
        int positionKhoa = 0;
        int positionLop = 0;
        Func<bool> validateAction;

        public FormKhoaLop()
        {
            InitializeComponent();
            //this.ContextMenuStrip = this.contextMenuStrip1;
            this.gcLOP.ContextMenuStrip = this.contextMenuStrip1;
        }


        private void FormKhoaLop_Load(object sender, EventArgs e)
        {
            this.DB_THI_TN.EnforceConstraints = false;

            this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KhoaTableAdapter.Fill(this.DB_THI_TN.Khoa);

            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTableAdapter.Fill(this.DB_THI_TN.Lop);

            this.GiaovienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GiaovienTableAdapter.Fill(this.DB_THI_TN.Giaovien);

            this.SinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SinhvienTableAdapter.Fill(this.DB_THI_TN.Sinhvien);

            this.Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.Giaovien_DangkyTableAdapter.Fill(this.DB_THI_TN.Giaovien_Dangky);


            this.cbCoSo.DataSource = Program.bds_dspm;
            this.cbCoSo.DisplayMember = "TenCS";
            this.cbCoSo.ValueMember = "MaCS";
            this.cbCoSo.SelectedIndex = Program.currentServerIndex;

            try
            {
               maCoSo = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
        
            }
            catch(Exception ex)
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
            this.panelLOP.Enabled = false;

            this.gvKHOA.OptionsBehavior.Editable = false;
            this.gvLOP.OptionsBehavior.Editable = false;
        }

        private void EnalbeEditing()
        {
            switch (Program.groupLoginType)
            {
                case Simple.GroupLoginType.Truong:
                    this.btnThem.Enabled = this.btnGhi.Enabled = this.btnReload.Enabled
                        = this.btnSua.Enabled = this.btnXoa.Enabled = this.btnUndo.Enabled = false;
                    this.cbCoSo.Enabled = true;
                    contextMenuStrip1.Enabled = false;
                    break;
                case Simple.GroupLoginType.CoSo:
                    this.btnThem.Enabled = this.btnReload.Enabled
                       = this.btnSua.Enabled = this.btnXoa.Enabled = true;
                    this.btnUndo.Enabled = this.btnGhi.Enabled = false;
                    this.cbCoSo.Enabled = false;
                    contextMenuStrip1.Enabled = true;
                    break;
                default:
                    this.btnThem.Enabled = this.btnGhi.Enabled = this.btnReload.Enabled
                        = this.btnSua.Enabled = this.btnXoa.Enabled = false;
                    this.cbCoSo.Enabled = false;
                    contextMenuStrip1.Enabled = false;
                    break;
            }

            if (bdsKhoa.Count == 0) btnXoa.Enabled = false;
        }

        #region Khoa Data handler
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

                    this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KhoaTableAdapter.Fill(this.DB_THI_TN.Khoa);

                    this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LopTableAdapter.Fill(this.DB_THI_TN.Lop);

                    this.GiaovienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.GiaovienTableAdapter.Fill(this.DB_THI_TN.Giaovien);

                    this.SinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SinhvienTableAdapter.Fill(this.DB_THI_TN.Sinhvien);

                    this.Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.Giaovien_DangkyTableAdapter.Fill(this.DB_THI_TN.Giaovien_Dangky);


                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionKhoa = this.bdsKhoa.Position;
            bdsKhoa.AddNew();

            ActionBeforeEditKhoa();
            validateAction += ValidateThemKhoa;
            this.txtMACS.Text = this.maCoSo;
            this.txtMAKH.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionKhoa = this.bdsKhoa.Position;
            ActionBeforeEditKhoa();
            this.txtMAKH.Enabled = false;
        }

        private void ActionBeforeEditKhoa()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnUndo.Enabled = btnGhi.Enabled = true;
            this.panelKHOA.Enabled = true;
            this.gcKHOA.Enabled = false;
            this.gcLOP.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maKHOA = "";
            if (bdsLop.Count > 0)
            {
                MessageBox.Show("Không thể xóa Khoa này vì đã có lớp");
                return;
            }

            if (bdsGiaovien.Count > 0)
            {
                MessageBox.Show("Không thể xóa Khoa này vì đã có giảng viên");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maKHOA = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString();
                    bdsKhoa.RemoveCurrent();

                    this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KhoaTableAdapter.Update(this.DB_THI_TN.Khoa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KhoaTableAdapter.Fill(this.DB_THI_TN.Khoa);
//                    bdsKhoa.Position = bdsKhoa.Find("MAKHOA", maKHOA);

                }
            }

            if (bdsKhoa.Count == 0) btnXoa.Enabled = false;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maKhoa = txtMAKH.Text.Trim();
            if (maKhoa == "")
            {
                MessageBox.Show("Mã Khoa không được để trống!", "", MessageBoxButtons.OK);
                txtMAKH.Focus();
                return;
            }

            if (txtTENKH.Text.Trim() == "")
            {
                MessageBox.Show("Tên Khoa không được để trống!", "", MessageBoxButtons.OK);
                txtTENKH.Focus();
                return;
            }



            if (validateAction != null)
                if(validateAction.Invoke() == false)
                    return;

            try
            {
                bdsKhoa.EndEdit();
                bdsKhoa.ResetCurrentItem();
                this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KhoaTableAdapter.Update(this.DB_THI_TN.Khoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                return;
            }

            ActionAfterEditKhoa();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            if (!btnThem.Enabled) bdsKhoa.Position = positionKhoa;

            ActionAfterEditKhoa();
        }

        private bool ValidateThemKhoa()
        {
            string maKhoa = txtMAKH.Text.Trim();
            try
            {
                String cmd = "Declare @check int " +
                    $"EXEC @check = SP_Kiem_Tra_Khoa '{maKhoa}' " +
                    $"Select 'result' = @check";
                Program.myReader = Program.ExecSqlDataReader(cmd);
                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result == 1)
                {
                    MessageBox.Show("Đã có mã Khoa tồn tại trong dữ liệu!", "", MessageBoxButtons.OK);
                    txtMAKH.Focus();
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

        private void ActionAfterEditKhoa()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
            panelKHOA.Enabled = false;
            gcKHOA.Enabled = true;
            gcLOP.Enabled = true;
            validateAction -= this.ValidateThemKhoa;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KhoaTableAdapter.Fill(this.DB_THI_TN.Khoa);

                this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LopTableAdapter.Fill(this.DB_THI_TN.Lop);

                this.GiaovienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GiaovienTableAdapter.Fill(this.DB_THI_TN.Giaovien);

                this.SinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SinhvienTableAdapter.Fill(this.DB_THI_TN.Sinhvien);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error Reloading", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region Lop Data Hanlder
        private void themLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionLop = this.bdsLop.Position;
            bdsLop.AddNew();
            ActionBeforeEditLop();
            string currentKhoa = ((DataRowView)this.bdsLop[bdsLop.Position])["MAKH"].ToString();
            this.txtFKMAKH.Text = currentKhoa;
            this.txtMALOP.Enabled = true;
            validateAction += this.HandlerThemLopDS;
        }

        private void ActionBeforeEditLop()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnUndo.Enabled = btnGhi.Enabled = false;
            this.panelLOP.Enabled = true;
            this.gcLOP.Enabled = false;
            this.gcKHOA.Enabled = false;
        }

        private void suaLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bdsLop.Count == 0)
            {
                MessageBox.Show("Không có danh sach lớp ", "OK", MessageBoxButtons.OK);
                return;
            }

            positionLop = this.bdsLop.Position;
            ActionBeforeEditLop();
            this.txtMALOP.Enabled = false;
        }

        private void xoaLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String maLOP = "";
            if (bdsGiaovien_Dangky.Count > 0)
            {
                MessageBox.Show("Không thể xóa Lớp này vì đã có lịch thi");
                return;
            }

            if (bdsSinhvien.Count > 0)
            {
                MessageBox.Show("Không thể xóa Lớp này vì đã có sinh viên");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLOP = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                    bdsLop.RemoveCurrent();

                    this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LopTableAdapter.Update(this.DB_THI_TN.Lop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LopTableAdapter.Update(this.DB_THI_TN.Lop);
                    bdsLop.Position = bdsLop.Find("MALOP", maLOP);

                }
            }

            if (bdsLop.Count == 0) this.xoaLopToolStripMenuItem.Enabled = false;
        }

        private void btnGhiLOP_Click(object sender, EventArgs e)
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
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LopTableAdapter.Update(this.DB_THI_TN.Lop);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                return;
            }

            ActionAfterEditLop();
        }

        private void ActionAfterEditLop()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
            panelLOP.Enabled = false;
            gcLOP.Enabled = true;
            gcKHOA.Enabled = true;

            this.validateAction -= HandlerThemLopDS;
        }

        private void btnUndoLOP_Click(object sender, EventArgs e)
        {
            bdsLop.CancelEdit();
            if (!btnThem.Enabled) bdsKhoa.Position = positionKhoa;
            ActionAfterEditLop();

           
        }

        private bool ValidateInput()
        {
            string maLop = txtMALOP.Text.Trim();
            if (maLop == "")
            {
                MessageBox.Show("Mã Lớp không được để trống!", "", MessageBoxButtons.OK);
                txtMALOP.Focus();
                return false;
            }

            if (txtTENLOP.Text.Trim() == "")
            {
                MessageBox.Show("Tên Lớp không được để trống!", "", MessageBoxButtons.OK);
                txtTENLOP.Focus();
                return false;
            }

            return true;
        }
        #endregion

        private bool HandlerThemLopDS()
        {
            string maLop = txtMALOP.Text.Trim();
            //
            try
            {
                String cmd = "Declare @check int " +
                    $"EXEC @check = SP_Kiem_Tra_Lop '{maLop}' " +
                    $"Select 'result' = @check";
                Program.myReader = Program.ExecSqlDataReader(cmd);
                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result == 1)
                {
                    MessageBox.Show("Đã có mã Lớp tồn tại trong dữ liệu!", "", MessageBoxButtons.OK);
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

        private void txtTENKHOA_EditValueChanged(object sender, EventArgs e)
        {
            txtTENKH.Text = Utility.FormatToCamelCase(txtTENKH.Text);
        }

        private void txtTENLOP_EditValueChanged(object sender, EventArgs e)
        {
            txtTENLOP.Text = Utility.FormatToCamelCase(txtTENLOP.Text);
        }
    }
}