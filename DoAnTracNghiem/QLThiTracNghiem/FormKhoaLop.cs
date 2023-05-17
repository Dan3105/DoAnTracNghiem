using DevExpress.Utils.Html.Internal;
using DevExpress.XtraEditors;
using QLThiTracNghiem.DB_TracNghiemTableAdapters;
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
            this.DB_TracNghiem.EnforceConstraints = false;

            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_TracNghiem.KHOA' table. You can move, or remove it, as needed.
            this.KHOATableAdapter.Fill(this.DB_TracNghiem.KHOA);

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_TracNghiem.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Fill(this.DB_TracNghiem.LOP);

            this.cbCoSo.DataSource = Program.bds_dspm;
            this.cbCoSo.DisplayMember = "TenCS";
            this.cbCoSo.ValueMember = "MaCS";
            this.cbCoSo.SelectedIndex = Program.currentServerIndex;

            try
            {
                maCoSo = ((DataRowView)bdsKHOA[0])["MACS"].ToString();
        
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
                case Simple.GroupLoginType.truong:
                    this.btnThem.Enabled = this.btnGhi.Enabled = this.btnReload.Enabled
                        = this.btnSua.Enabled = this.btnXoa.Enabled = this.btnUndo.Enabled = false;
                    this.cbCoSo.Enabled = true;
                    break;
                case Simple.GroupLoginType.co_so:
                    this.btnThem.Enabled = this.btnReload.Enabled
                       = this.btnSua.Enabled = this.btnXoa.Enabled = true;
                    this.btnUndo.Enabled = this.btnGhi.Enabled = false;
                    this.cbCoSo.Enabled = false;
                    break;
                default:
                    this.btnThem.Enabled = this.btnGhi.Enabled = this.btnReload.Enabled
                        = this.btnSua.Enabled = this.btnXoa.Enabled = false;
                    this.cbCoSo.Enabled = false;
                    break;
            }

            if (bdsKHOA.Count == 0) btnXoa.Enabled = false;
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
                    this.DB_TracNghiem.EnforceConstraints = false;

                    this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dB_TracNghiem.KHOA' table. You can move, or remove it, as needed.
                    this.KHOATableAdapter.Fill(this.DB_TracNghiem.KHOA);

                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dB_TracNghiem.LOP' table. You can move, or remove it, as needed.
                    this.LOPTableAdapter.Fill(this.DB_TracNghiem.LOP);
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionKhoa = this.bdsKHOA.Position;
            bdsKHOA.AddNew();

            ActionBeforeEditKhoa();
            validateAction += ValidateThemKhoa;
            this.txtMACS.Text = this.maCoSo;
            this.txtMAKHOA.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionKhoa = this.bdsKHOA.Position;
            ActionBeforeEditKhoa();
            this.txtMAKHOA.Enabled = false;
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
            if (bdsLOP.Count > 0)
            {
                MessageBox.Show("Không thể xóa Khoa này vì đã có lớp");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maKHOA = ((DataRowView)bdsKHOA[bdsKHOA.Position])["MAKHOA"].ToString();
                    bdsKHOA.RemoveCurrent();

                    this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KHOATableAdapter.Update(this.DB_TracNghiem.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KHOATableAdapter.Update(this.DB_TracNghiem.KHOA);
                    bdsKHOA.Position = bdsKHOA.Find("MAKHOA", maKHOA);

                }
            }

            if (bdsKHOA.Count == 0) btnXoa.Enabled = false;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maKhoa = txtMAKHOA.Text.Trim();
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
            }

            //
            
            if(validateAction != null)
                if(validateAction.Invoke() == false)
                    return;

            try
            {
                bdsKHOA.EndEdit();
                bdsKHOA.ResetCurrentItem();
                this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOATableAdapter.Update(this.DB_TracNghiem.KHOA);
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
            bdsKHOA.CancelEdit();
            if (!btnThem.Enabled) bdsKHOA.Position = positionKhoa;

            ActionAfterEditKhoa();
        }

        private bool ValidateThemKhoa()
        {
            string maKhoa = txtMAKHOA.Text.Trim();
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
                    txtMAKHOA.Focus();
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
                KHOATableAdapter.Fill(this.DB_TracNghiem.KHOA);
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
            positionLop = this.bdsLOP.Position;
            bdsLOP.AddNew();
            ActionBeforeEditLop();
            string currentKhoa = ((DataRowView)this.bdsKHOA[bdsKHOA.Position])["MAKHOA"].ToString();
            this.txtFKMAKHOA.Text = currentKhoa;
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
            if(bdsLOP.Count == 0)
            {
                MessageBox.Show("Không có danh sach lớp ", "OK", MessageBoxButtons.OK);
                return;
            }

            positionLop = this.bdsLOP.Position;
            ActionBeforeEditLop();
            this.txtMALOP.Enabled = false;
        }

        private void xoaLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String maLOP = "";
         /* if (bdsLOP.Count > 0)
            {
                MessageBox.Show("Không thể xóa Khoa này vì đã có lớp");
                return;
            }*/

            if (MessageBox.Show("U sure to del ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLOP = ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString();
                    bdsLOP.RemoveCurrent();

                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Update(this.DB_TracNghiem.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Update(this.DB_TracNghiem.LOP);
                    bdsLOP.Position = bdsLOP.Find("MALOP", maLOP);

                }
            }

            if (bdsLOP.Count == 0) this.xoaLopToolStripMenuItem.Enabled = false;
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
          /*  this.validateAction -= HandlerThemInput;*/

            try
            {
                bdsLOP.EndEdit();
                bdsLOP.ResetCurrentItem();
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Update(this.DB_TracNghiem.LOP);
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
            bdsLOP.CancelEdit();
            if (!btnThem.Enabled) bdsKHOA.Position = positionKhoa;
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

            if (txtNAMNH.Text.Trim() == "")
            {
                MessageBox.Show("Năm nhập học không được để trống!", "", MessageBoxButtons.OK);
                txtNAMNH.Focus();
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
                    txtMAKHOA.Focus();
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
            txtTENKHOA.Text = Utility.FormatToCamelCase(txtTENKHOA.Text);
        }

        private void txtTENLOP_EditValueChanged(object sender, EventArgs e)
        {
            txtTENLOP.Text = Utility.FormatToCamelCase(txtTENLOP.Text);
        }
    }
}