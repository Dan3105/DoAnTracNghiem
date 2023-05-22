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
    public partial class FormBode : DevExpress.XtraEditors.XtraForm
    {
        int currPosition = 0;
        bool addMode = false;
        public FormBode()
        {
            InitializeComponent();
        }

        private void bodeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBode.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_THI_TN);

        }

        private void FormBode_Load(object sender, EventArgs e)
        {
            this.dB_THI_TN.EnforceConstraints = false;

            this.monhocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.monhocTableAdapter.Fill(this.dB_THI_TN.Monhoc);

            this.bodeTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bodeTableAdapter.Fill(this.dB_THI_TN.Bode);

            this.chiTiet_BaiThiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTiet_BaiThiTableAdapter.Fill(this.dB_THI_TN.ChiTiet_BaiThi);


            btnThem.Enabled = btnSua.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            this.panelCauhoi.Enabled = false;

            if (bdsBode.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsMonhoc.Count == 0)
            {
                MessageBox.Show("Chưa có môn học để thêm câu hỏi");
                return;
            }

            addMode = true;

            currPosition = this.bdsBode.Position;
            bdsBode.AddNew();
            ActionBeforeEdit();

            mAMHComboBox.SelectedIndex = 0;
            tRINHDOComboBox.SelectedIndex = 0;
            nOIDUNGTextEdit.Text = "";
            dAP_ANComboBox.SelectedIndex = 0;
            aTextEdit.Text = "";
            bTextEdit.Text = "";
            cTextEdit.Text = "";
            dTextEdit.Text = "";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            currPosition = this.bdsBode.Position;
            ActionBeforeEdit();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maCauHoi = ((DataRowView)bdsBode[bdsBode.Position])["CAUHOI"].ToString(); ;

            if (bdsCTBaithi.Find("CAUHOI", maCauHoi) != -1)
            {
                MessageBox.Show("Không thể xóa câu hỏi này vì đã có sinh viên thi");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    
                    bdsBode.RemoveCurrent();

                    this.bodeTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bodeTableAdapter.Update(this.dB_THI_TN.Bode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá câu hỏi. Bạn hãy xoá lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.bodeTableAdapter.Fill(this.dB_THI_TN.Bode);
                    bdsBode.Position = bdsBode.Find("CAUHOI", maCauHoi);
                    return;
                }
            }

            if (bdsBode.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateInput() == false) return;

            try
            {
                if (addMode)
                {
                    String cmd = "INSERT INTO Bode(MAMH, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN, MAGV) " +
                             "VALUES ("
                            + "'" + mAMHComboBox.SelectedValue + "',"  //Mã môn học
                            + "'" + tRINHDOComboBox.Text + "'," //Trình độ
                            + "N'" + nOIDUNGTextEdit.Text + "',"  //Nội dung câu hỏi
                            + "N'" + aTextEdit.Text + "',"    //Đáp án A
                            + "N'" + bTextEdit.Text + "',"    //Đáp án B
                            + "N'" + cTextEdit.Text + "',"    //Đáp án C
                            + "N'" + dTextEdit.Text + "',"    //Đáp án D
                            + "'" + dAP_ANComboBox.Text + "',"   //Đáp án đúng
                            + "'" + Program.username + "'"  //Mã giảng viên tạo câu hỏi
                            + ")";
                    //Execute query
                    Program.ExecSqlNonQuery(cmd);
                    addMode = false;
                    Console.WriteLine("\naddMode\n");
                }
                else
                {
                    bdsBode.EndEdit();
                    bdsBode.ResetCurrentItem();
                    this.bodeTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bodeTableAdapter.Update(this.dB_THI_TN.Bode);
                }

                this.bodeTableAdapter.Fill(this.dB_THI_TN.Bode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
            }

            ActionAfterEdit();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBode.CancelEdit();
            if (!btnThem.Enabled) bdsBode.Position = currPosition;
            ActionAfterEdit();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.bodeTableAdapter.Fill(this.dB_THI_TN.Bode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Reloading: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void ActionBeforeEdit()
        {

            panelCauhoi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnUndo.Enabled = btnGhi.Enabled = true;
            gcBode.Enabled = false;
        }

        private void ActionAfterEdit()
        {
            gcBode.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
            panelCauhoi.Enabled = false;
        }

        private bool ValidateInput()
        {
            string cauHoi = nOIDUNGTextEdit.Text.Trim();
            if (nOIDUNGTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung câu hỏi không được để trống!", "", MessageBoxButtons.OK);
                nOIDUNGTextEdit.Focus();
                return false;
            }

            if (aTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án a không được để trống!", "", MessageBoxButtons.OK);
                aTextEdit.Focus();
                return false;
            }

            if (bTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án b không được để trống!", "", MessageBoxButtons.OK);
                bTextEdit.Focus();
                return false;
            }

            if (cTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án c không được để trống!", "", MessageBoxButtons.OK);
                cTextEdit.Focus();
                return false;
            }

            if (dTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án d không được để trống!", "", MessageBoxButtons.OK);
                dTextEdit.Focus();
                return false;
            }

            return true;
        }
    }
}