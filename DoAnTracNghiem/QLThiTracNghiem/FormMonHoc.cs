using DevExpress.XtraRichEdit.Layout;
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
    public partial class FormMonHoc : Form
    {
        int crrPosition = 0;
        Func<bool> validateThemAction;
        public FormMonHoc()
        {
            InitializeComponent();       
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            this.DB_THI_TN.EnforceConstraints = false;
            this.MonhocTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_THI_TN.Monhoc' table. You can move, or remove it, as needed.
            this.MonhocTableAdapter.Fill(this.DB_THI_TN.Monhoc);

            this.BodeTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'DB_THI_TN.Bode' table. You can move, or remove it, as needed.
            this.BodeTableAdapter.Fill(this.DB_THI_TN.Bode);

            this.Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'DB_THI_TN.Giaovien_Dangky' table. You can move, or remove it, as needed.
            this.Giaovien_DangkyTableAdapter.Fill(this.DB_THI_TN.Giaovien_Dangky);

            SetCbServer();
            CustomHeaderButtons();
            this.gvMonHoc.OptionsBehavior.Editable = false;
        }

        private void SetCbServer()
        {
            this.cbServer.DataSource = Program.bds_dspm;
            this.cbServer.DisplayMember = "TenCS";
            this.cbServer.ValueMember = "MaCS";
            this.cbServer.SelectedIndex = Program.currentServerIndex;

        }

        #region Data Handler
        private void CustomHeaderButtons()
        {
            switch (Program.groupLoginType)
            {
                case Simple.GroupLoginType.Truong:
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled =
                        btnReload.Enabled = false;
                    this.cbServer.Enabled = true;
                    panelMonhoc.Enabled = false;
                    break;
                case Simple.GroupLoginType.CoSo:
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled =
                        btnReload.Enabled = true;
                    this.cbServer.Enabled = false;
                    panelMonhoc.Enabled = false;
                    break;
                default:
                    //Console.WriteLine($"Error Info user {Program.groupLoginType.ToString()}");
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled =
                        btnReload.Enabled = false;
                    this.cbServer.Enabled = false;
                    panelMonhoc.Enabled = false;
                    break;

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            crrPosition = this.bdsMonhoc.Position;
            bdsMonhoc.AddNew();

            ActionBeforeEdit();

            validateThemAction += ValidateBeforeThem;
        }

      

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maMH = "";
            
            if(ValidateBeforeXoa() == false)
            {
                return;
            }

            if(MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maMH = ((DataRowView)bdsMonhoc[bdsMonhoc.Position])["MAMH"].ToString();
                    bdsMonhoc.RemoveCurrent();

                    this.MonhocTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MonhocTableAdapter.Update(this.DB_THI_TN.Monhoc);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    this.MonhocTableAdapter.Update(this.DB_THI_TN.Monhoc);
                    bdsMonhoc.Position = bdsMonhoc.Find("MAMH", maMH);

                }
            }

            if (bdsMonhoc.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            crrPosition = this.bdsMonhoc.Position;
            ActionBeforeEdit();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                MonhocTableAdapter.Fill(this.DB_THI_TN.Monhoc);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error Reloading: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonhoc.CancelEdit();
            if (!btnThem.Enabled) bdsMonhoc.Position = crrPosition;
            ActionAfterEdit();
            
        }
        private void ActionBeforeEdit()
        {
            gcMONHOC.Enabled = false;
            panelMonhoc.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnUndo.Enabled = btnGhi.Enabled = true;
        }
        private void ActionAfterEdit()
        {
            gcMONHOC.Enabled = true;
            validateThemAction -= ValidateBeforeThem;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
            panelMonhoc.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!ValidateInput())
            {
                return;
            }

            if(validateThemAction != null)
            {
                if(validateThemAction?.Invoke() == false)
                {
                    return;
                }
                    
            }

            try
            {
                bdsMonhoc.EndEdit();
                bdsMonhoc.ResetCurrentItem();         
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
            }
            finally
            {
                this.MonhocTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MonhocTableAdapter.Update(this.DB_THI_TN.Monhoc);
            }

            ActionAfterEdit();
        }

        private void cbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbServer.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.currentServerValue = cbServer.SelectedValue.ToString();

            if(cbServer.SelectedIndex != Program.currentServerIndex)
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
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                cbServer.SelectedIndex = Program.currentServerIndex;
            }
            else
            {
                this.DB_THI_TN.EnforceConstraints = false;
                this.MonhocTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MonhocTableAdapter.Update(this.DB_THI_TN.Monhoc);

                this.BodeTableAdapter.Connection.ConnectionString = Program.connstr;
                this.BodeTableAdapter.Update(this.DB_THI_TN.Bode);

                this.Giaovien_DangkyTableAdapter.Connection.ConnectionString = Program.connstr;
                this.Giaovien_DangkyTableAdapter.Update(this.DB_THI_TN.Giaovien_Dangky);
            }
        }

        #region Validate input
        private bool ValidateInput()
        {
            string maMH = txtMAMH.Text.Trim();
            if (txtMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống!", "", MessageBoxButtons.OK);
                txtMAMH.Focus();
                return false;
            }

            if (txtTENMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống!", "", MessageBoxButtons.OK);
                txtTENMH.Focus();
                return false;
            }


            try
            {
                String cmd = "Declare @check int " +
                    $"EXEC @check = SP_Kiem_Tra_MonHoc '{maMH}' " +
                    $"Select 'result' = @check";
                Program.myReader = Program.ExecSqlDataReader(cmd);
                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                int currentMonHoc = bdsMonhoc.Position;
                int currentIdChoosing = bdsMonhoc.Find("MAMH", maMH);

                if (result == 1 && currentMonHoc != currentIdChoosing)
                {
                    MessageBox.Show("Đã có mã Khoa tồn tại trong dữ liệu!", "", MessageBoxButtons.OK);
                    txtMAMH.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return true;
        }

        private bool ValidateBeforeThem()
        {
            
            return true;
        }

        private bool ValidateBeforeXoa()
        {
            if (bdsBode.Count > 0)
            {
                MessageBox.Show("Không thể xóa Môn học này vì đã có lịch thi của môn này");
                return false;
            }

            if (bdsGiaovien_Dangky.Count > 0)
            {
                MessageBox.Show("Không thể xóa Môn học này vì đã có câu hỏi của môn này");
                return false;
            }
            return true;
        }
        #endregion

        private void txtTENMH_EditValueChanged(object sender, EventArgs e)
        {
            txtTENMH.Text = Utility.FormatToCamelCase(txtTENMH.Text);
        }
    }
    #endregion
}
