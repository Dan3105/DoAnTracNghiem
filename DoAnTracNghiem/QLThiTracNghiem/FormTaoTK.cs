using DevExpress.XtraEditors;
using QLThiTracNghiem.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLThiTracNghiem.Simple;

namespace QLThiTracNghiem
{
    public partial class FormTaoTK : DevExpress.XtraEditors.XtraForm
    {
        public class ComboRole
        {
            public string nameRole;
            public GroupLoginType valueRole;

            public ComboRole(string nameRole, GroupLoginType valueRole)
            {
                this.nameRole = nameRole;
                this.valueRole = valueRole;
            }

            public override string ToString()
            {
                return nameRole;
            }
        }
       
        private string maGV;
        
        public string MaGV
        {
            private get {
                return maGV;
            }
             set
            {
                this.maGV = value;
                this.txtMAGV.Text = maGV;
            }
        }
        
        public FormTaoTK()
        {
            InitializeComponent();
            FillRole();
            SetRole();
        }

        private void FillRole()
        {
            this.cbNhom.DisplayMember = "nameRole";
            this.cbNhom.ValueMember = "valueRole";
        }

        private void SetRole()
        {
            switch (Program.groupLoginType)
            {
                case GroupLoginType.CoSo:
                    this.cbNhom.Items.Add(new ComboRole("Cơ sở",GroupLoginType.CoSo ));
                    this.cbNhom.Items.Add(new ComboRole("Giảng Viên", GroupLoginType.Giangvien));
                    this.cbNhom.SelectedIndex = 0;
                    this.cbNhom.Enabled = true;
                    break;
                case GroupLoginType.Truong:
                    this.cbNhom.Items.Add(new ComboRole("Trường", GroupLoginType.Truong));
                    this.cbNhom.SelectedIndex = 0;
                    this.cbNhom.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btnXemGV_Click(object sender, EventArgs e)
        {
            FormChonGiangVien form = new FormChonGiangVien();
             form.SetFormTK(this);
            form.ShowDialog(this);
           
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string txtMaGV = this.txtMAGV.Text.Trim();
            string txtMatKhau = this.txtMATKHAU.Text.Trim();
            string txtTaiKhoan = this.txtTenTK.Text.Trim();

            string roleName = ((ComboRole)this.cbNhom.SelectedItem).valueRole.ToString();

            if(txtMaGV == "")
            {
                MessageBox.Show("Bạn chưa chọn giảng viên!", "Lỗi Đăng ký", MessageBoxButtons.OK);
                return;
            }

            if (txtMatKhau == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi Đăng ký", MessageBoxButtons.OK);
                return;
            }

            if (txtTaiKhoan == "")
            {
                MessageBox.Show("Tài khoản không được để trống", "Lỗi Đăng ký", MessageBoxButtons.OK);
                return;
            }


            string sqlCmd = $"Exec SP_Create_User_Login {txtTaiKhoan}, {txtMatKhau}, {roleName}, {txtMaGV}";
            int success = Program.ExecSqlNonQuery(sqlCmd);
            if(success == 1)
            {
                MessageBox.Show("Tạo tài khoản thành công", "", MessageBoxButtons.OK);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}