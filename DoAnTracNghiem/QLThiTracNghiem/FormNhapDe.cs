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

            this.bodeTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bodeTableAdapter.Fill(this.DB_THI_TN.Bode);

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
                    MessageBox.Show("Câu hỏi đã có sinh viên thi!", "", MessageBoxButtons.OK);
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

            if (!canEraseCauhoi(maCauHoi))
            {
                MessageBox.Show("Không thể xóa câu hỏi này!", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsBode.RemoveCurrent();

                    this.bodeTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bodeTableAdapter.Update(this.DB_THI_TN.Bode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá câu hỏi. Bạn hãy xoá lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.bodeTableAdapter.Fill(this.DB_THI_TN.Bode);
                    bdsBode.Position = bdsBode.Find("CAUHOI", maCauHoi);
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
                    String cmd = "INSERT INTO Bode(MAMH, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN, MAGV) " +
                             "VALUES ("
                            + "'" + CBMonhoc.SelectedValue + "',"  //Mã môn học
                            + "'" + CBTrinhDo.Text + "'," //Trình độ
                            + "N'" + txtNoidung.Text + "',"  //Nội dung câu hỏi
                            + "N'" + txtA.Text + "',"    //Đáp án A
                            + "N'" + txtB.Text + "',"    //Đáp án B
                            + "N'" + txtC.Text + "',"    //Đáp án C
                            + "N'" + txtD.Text + "',"    //Đáp án D
                            + "'" + CBDapAn.Text + "',"   //Đáp án đúng
                            + "'" + Program.username + "'"  //Mã giảng viên tạo câu hỏi
                            + ")";
                    //Execute query
                    Program.ExecSqlNonQuery(cmd);
                    isAddMode = false;
                }
                else
                {
                    bdsBode.EndEdit();
                    bdsBode.ResetCurrentItem();
                    this.bodeTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bodeTableAdapter.Update(this.DB_THI_TN.Bode);
                }

                this.bodeTableAdapter.Fill(this.DB_THI_TN.Bode);
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
                Reload();
                ReadMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Reloading: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void CBMonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}