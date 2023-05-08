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
           
            DB_TracNghiem.EnforceConstraints = false;
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_TracNghiemMonHoc.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Fill(this.DB_TracNghiem.MONHOC);

            this.LICHTHITableAdapter.Connection.ConnectionString= Program.connstr;

            // TODO: This line of code loads data into the 'DB_TracNghiem.LICHTHI' table. You can move, or remove it, as needed.
            this.LICHTHITableAdapter.Fill(this.DB_TracNghiem.LICHTHI);

            this.CAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'DB_TracNghiem.CAUHOI' table. You can move, or remove it, as needed.
            this.CAUHOITableAdapter.Fill(this.DB_TracNghiem.CAUHOI);

            SetCbServer();
            CustomHeaderButtons();
            //this.mONHOCGridControl.MainView.OptionsLayout = false;
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
                case Simple.GroupLoginType.TRUONG:
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled =
                        btnReload.Enabled = false;
                    this.cbServer.Enabled = true;
                    panelDataView.Enabled = false;
                    break;
                case Simple.GroupLoginType.COSO:
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled =
                        btnReload.Enabled = true;
                    this.cbServer.Enabled = false;
                    panelDataView.Enabled = false;
                    break;
                default:
                    //Console.WriteLine($"Error Info user {Program.groupLoginType.ToString()}");
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled =
                        btnReload.Enabled = false;
                    this.cbServer.Enabled = false;
                    panelDataView.Enabled = false;
                    break;

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            crrPosition = this.bdsMONHOC.Position;
            bdsMONHOC.AddNew();

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
                    maMH = ((DataRowView)bdsMONHOC[bdsMONHOC.Position])["MAMH"].ToString();
                    bdsMONHOC.RemoveCurrent();

                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MONHOCTableAdapter.Update(this.DB_TracNghiem.MONHOC);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    this.MONHOCTableAdapter.Fill(this.DB_TracNghiem.MONHOC);
                    bdsMONHOC.Position = bdsMONHOC.Find("MAMH", maMH);
                    
                }
            }

            if (bdsMONHOC.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            crrPosition = this.bdsMONHOC.Position;
            ActionBeforeEdit();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                MONHOCTableAdapter.Fill(this.DB_TracNghiem.MONHOC);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error Reloading: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMONHOC.CancelEdit();
            if (!btnThem.Enabled) bdsMONHOC.Position = crrPosition;
            ActionAfterEdit();
            
        }
        private void ActionBeforeEdit()
        {
            gcMONHOC.Enabled = false;
            panelDataView.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnUndo.Enabled = btnGhi.Enabled = true;
        }
        private void ActionAfterEdit()
        {
            gcMONHOC.Enabled = true;
            validateThemAction -= ValidateBeforeThem;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
            panelDataView.Enabled = false;
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
                bdsMONHOC.EndEdit();
                bdsMONHOC.ResetCurrentItem();
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Update(this.DB_TracNghiem.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex }", "", MessageBoxButtons.OK);
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Update(this.DB_TracNghiem.MONHOC);
                
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
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Fill(this.DB_TracNghiem.MONHOC);
                this.LICHTHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.LICHTHITableAdapter.Fill(this.DB_TracNghiem.LICHTHI);
                this.CAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
                this.CAUHOITableAdapter.Fill(this.DB_TracNghiem.CAUHOI);
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

            if (txtSOTIETLT.Text.Trim() == "")
            {
                MessageBox.Show("Số tiết lý thuyết không được để trống!", "", MessageBoxButtons.OK);
                txtSOTIETLT.Focus();
                return false;
            }

            if (txtSOTIETTH.Text.Trim() == "")
            {
                MessageBox.Show("Số tiết thực hành không được để trống!", "", MessageBoxButtons.OK);
                txtSOTIETTH.Focus();
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

                int currentMonHoc = bdsMONHOC.Position;
                int currentIdChoosing = bdsMONHOC.Find("MAMH", maMH);

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
            if (bdsLICHTHI.Count > 0)
            {
                MessageBox.Show("Không thể xóa Môn học này vì đã có lịch thi của môn này");
                return false;
            }

            if (bdsCAUHOI.Count > 0)
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
