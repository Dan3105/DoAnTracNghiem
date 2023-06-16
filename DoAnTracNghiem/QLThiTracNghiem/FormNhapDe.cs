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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLThiTracNghiem
{
    public partial class FormNhapDe : DevExpress.XtraEditors.XtraForm
    {
        int currPosition = 0;
        bool isAddMode = false;
        public FormNhapDe()
        {
            InitializeComponent();
        }

        private void Reload()
        {
            this.monhocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.monhocTableAdapter.Fill(this.DB_THI_TN.Monhoc);

            this.sP_Lay_DS_CauHoiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_Lay_DS_CauHoiTableAdapter.Fill(this.DB_THI_TN.SP_Lay_DS_CauHoi, Program.username, (string)CBMonhoc.SelectedValue);

            if (bdsBode.Count <= 0)
            {
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void EditingMode()
        {
            panelMonhoc.Enabled = false;
            panelCauhoi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
        }

        private void ReadMode()
        {
            panelMonhoc.Enabled = true;
            panelCauhoi.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;

            if(bdsBode.Count <= 0)
            {
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void FormNhapDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DB_THI_TN.Monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.DB_THI_TN.Monhoc);
            this.DB_THI_TN.EnforceConstraints = false;
            Reload();
            ReadMode();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            currPosition = this.bdsBode.Position;
            bdsBode.AddNew();
            EditingMode();

            txtMaCauhoi.Text = "";
            CBTrinhDo.Text = "A";
            CBDapAn.Text = "A";
            txtNoidung.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";

            isAddMode = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            currPosition = this.bdsBode.Position;
            EditingMode();
        }

        private bool canEraseCauhoi(string maCauHoi)
        {
            try
            {
                String cmd = "Declare @check int " +
                    $"EXEC @check = SP_Kiem_Tra_CauHoi '{maCauHoi}' " +
                    $"Select 'result' = @check";
                Program.myReader = Program.ExecSqlDataReader(cmd);
                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result == 1)
                {
                    MessageBox.Show("Câu hỏi đã có sinh viên thi! Không thể xoá!", "", MessageBoxButtons.OK);
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maCauHoi = txtMaCauhoi.Text;

            if (!canEraseCauhoi(maCauHoi)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsBode.RemoveCurrent();

                    string idCauHoi = ((DataRowView)bdsBode[bdsBode.Position])["IDCAUHOI"].ToString();
                    String cmd = "DELETE FROM Bode WHERE CAUHOI = " + idCauHoi;
                    //Execute query
                    Program.ExecSqlNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá câu hỏi. Bạn hãy xoá lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.sP_Lay_DS_CauHoiTableAdapter.Fill(this.DB_THI_TN.SP_Lay_DS_CauHoi, Program.username, (string)CBMonhoc.SelectedValue);
                    bdsBode.Position = bdsBode.Find("IDCAUHOI", maCauHoi);
                    return;
                }
            }

            ReadMode();
        }

        private bool ValidateInput()
        {
            if (txtNoidung.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung câu hỏi không được để trống!", "", MessageBoxButtons.OK);
                txtNoidung.Focus();
                return false;
            }

            if (txtA.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án a không được để trống!", "", MessageBoxButtons.OK);
                txtA.Focus();
                return false;
            }

            if (txtB.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án b không được để trống!", "", MessageBoxButtons.OK);
                txtB.Focus();
                return false;
            }

            if (txtC.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án c không được để trống!", "", MessageBoxButtons.OK);
                txtC.Focus();
                return false;
            }

            if (txtD.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án d không được để trống!", "", MessageBoxButtons.OK);
                txtD.Focus();
                return false;
            }

            return true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateInput() == false) return;

            try
            {
                if (isAddMode)
                {
                    String cmd = $"Exec SP_Them_CauHoi {CBMonhoc.SelectedValue}, N'{CBTrinhDo.Text}', N'{txtNoidung.Text}', N'{txtA.Text}', N'{txtB.Text}',N'{txtC.Text}',N'{txtD.Text}', N'{CBDapAn.Text}', N'{Program.username}'";
                    //Execute query
                    Program.ExecSqlNonQuery(cmd);
                    isAddMode = false;
                }
                else
                {
                    bdsBode.EndEdit();
                    bdsBode.ResetCurrentItem();
                    String cmd = $"Exec SP_Sua_CauHoi {txtMaCauhoi.Text}, N'{CBTrinhDo.Text}', N'{txtNoidung.Text}', N'{txtA.Text}', N'{txtB.Text}',N'{txtC.Text}',N'{txtD.Text}', N'{CBDapAn.Text}'";
                    //Execute query
                    Program.ExecSqlNonQuery(cmd);
                }

                this.sP_Lay_DS_CauHoiTableAdapter.Fill(this.DB_THI_TN.SP_Lay_DS_CauHoi, Program.username, (string)CBMonhoc.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
            }

            ReadMode();
            bdsBode.Position = currPosition;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBode.CancelEdit();
            if (!btnThem.Enabled) bdsBode.Position = currPosition;
            ReadMode();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int currMonhocPos = CBMonhoc.SelectedIndex;
                Reload();
                CBMonhoc.SelectedIndex = currMonhocPos;
                ReadMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Reloading: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void CBMonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sP_Lay_DS_CauHoiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_Lay_DS_CauHoiTableAdapter.Fill(this.DB_THI_TN.SP_Lay_DS_CauHoi, Program.username, (string)CBMonhoc.SelectedValue);
            ReadMode();
        }
    }
}