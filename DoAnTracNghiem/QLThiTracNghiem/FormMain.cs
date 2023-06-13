using DevExpress.Utils.Registrator;
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
    public partial class FormMain : Form
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormMain()
        {
            InitializeComponent();
            if(Program.KetNoi() == 0)
            {
                DisableEditingData();
            }

        }

        private void EnableEditingData()
        {
            switch(Program.groupLoginType)
            {
                case Simple.GroupLoginType.NONE:
                    btnSignup.Enabled = false;
                    rbQuanly.Visible = false;
                    rbGV.Visible = false;
                    rbSinhVien.Visible = false;
                    rbPageBaoCao.Visible = false;
                    break;
                case Simple.GroupLoginType.Truong:
                    btnSignup.Enabled = true;
                    rbQuanly.Visible = true;
                    rbGV.Visible = true;
                    rbSinhVien.Visible = false;
                    rbPageBaoCao.Visible = true;
                    break;
                case Simple.GroupLoginType.CoSo:
                    rbQuanly.Visible = true;
                    rbGV.Visible = true;
                    btnSignup.Enabled = true;
                    rbSinhVien.Visible = false;
                    rbPageBaoCao.Visible = true;
                    break;
                case Simple.GroupLoginType.Giangvien:
                    rbQuanly.Visible = false;
                    rbGV.Visible = true;
                    btnSignup.Enabled = false;
                    rbSinhVien.Visible = false;
                    rbPageBaoCao.Visible = false;
                    break;
                case Simple.GroupLoginType.Sinhvien:
                    rbQuanly.Visible = false;
                    rbGV.Visible = false;
                    btnSignup.Enabled = false;
                    rbSinhVien.Visible = true;
                    rbPageBaoCao.Visible = false;
                    break;
            }
            btnLogin.Enabled = false;
            btnLogout.Enabled = true;

            //
            this.CheckExists(typeof(FormDangNhap))?.Hide();
        }

        private void DisableEditingData()
        {
            btnLogin.Enabled = true;
            
            btnLogout.Enabled = false;
            btnSignup.Enabled = false;

            rbQuanly.Visible = false;
            rbGV.Visible = false;
            rbSinhVien.Visible = false;
            rbPageBaoCao.Visible = false;
            //redirect to login form
            foreach (Form f in this.MdiChildren)
            {
                if(f.GetType() !=  typeof(FormDangNhap))
                {
                    f.Close();
                }
            }
            this.CheckExists(typeof(FormDangNhap))?.Show();
        }

        public void AssignUserLoginData()
        {
            this.MAUSER.Text = $"Ma User: {Program.username}";
            this.HOTEN.Text = $"Ho Ten: {Program.fullname}";
            this.NHOM.Text = $"Nhom: {Program.groupLoginType}";
            EnableEditingData();
        }

        #region Button Handler
        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDangNhap formLogin = CheckExists(typeof(FormDangNhap)) as FormDangNhap;
            if (formLogin == null)
            {
                formLogin = new FormDangNhap();
            }
            formLogin.MdiParent = this;
            formLogin.Show();
        }
        
        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.ResetUser();
            this.MAUSER.Text = "MAUSER";
            this.HOTEN.Text = "HOTEN";
            this.NHOM.Text = "NHOM";
            DisableEditingData();

        }
        
        private void btnMonhoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return; ;
            FormMonHoc formMonHoc = CheckExists(typeof(FormMonHoc)) as FormMonHoc;
            if (formMonHoc == null)
            {
                formMonHoc = new FormMonHoc();
            }
            formMonHoc.MdiParent = this;
            formMonHoc.Show();
        }  
        
        private void barBtnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return; ;
            FormKhoaLop formKhoaLop = CheckExists(typeof(FormKhoaLop)) as FormKhoaLop;
            if (formKhoaLop == null)
            {
                formKhoaLop = new FormKhoaLop();
            }
            formKhoaLop.MdiParent = this;
            formKhoaLop.Show();
        }
  
        private void barBtnSINHVIEN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return; ;
            FormSinhVien formSinhVien = CheckExists(typeof(FormSinhVien)) as FormSinhVien;
            if (formSinhVien == null)
            {
                formSinhVien = new FormSinhVien();
            }
            formSinhVien.MdiParent = this;
            formSinhVien.Show();

        }

        private void btnSignup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTaoTK frmTK = CheckExists(typeof(FormTaoTK)) as FormTaoTK;
            if (frmTK == null)
            {
                frmTK = new FormTaoTK();
            }
            frmTK.MdiParent = this;
            frmTK.Show();
        }

        private void btnDkyThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDangkyThi frmDKThi = CheckExists(typeof(FormDangkyThi)) as FormDangkyThi;
            if (frmDKThi == null)
            {
                frmDKThi = new FormDangkyThi();
            }
            frmDKThi.MdiParent = this;
            frmDKThi.Show();
           
        }

        private void btnGIAOVIEN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormGiaoVien frmGiaoVien = CheckExists(typeof(FormGiaoVien)) as FormGiaoVien;
            if (frmGiaoVien == null)
            {
                frmGiaoVien = new FormGiaoVien();
            }
            frmGiaoVien.MdiParent = this;
            frmGiaoVien.Show();
        }

        private void btnTHITHU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLichThiThu formLichThiThu = CheckExists(typeof(FormLichThiThu)) as FormLichThiThu;
            if (formLichThiThu == null)
            {
                formLichThiThu = new FormLichThiThu();
            }
            formLichThiThu.MdiParent = this;
            formLichThiThu.Show();
        }

        private void btnBODE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormNhapDe frmBode = CheckExists(typeof(FormNhapDe)) as FormNhapDe;
            if (frmBode == null)
            {
                frmBode = new FormNhapDe();
            }
            frmBode.MdiParent = this;
            frmBode.Show();
        }

        private void btnThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormChonLichThi frm = CheckExists(typeof(FormChonLichThi)) as FormChonLichThi;
            if (frm == null)
            {
                frm = new FormChonLichThi();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnBaoCaoDKyThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frpt_Xem_DanhSach_Dangky_thi frm = CheckExists(typeof(Frpt_Xem_DanhSach_Dangky_thi)) as Frpt_Xem_DanhSach_Dangky_thi;
            if (frm == null)
            {
                frm = new Frpt_Xem_DanhSach_Dangky_thi();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnXemKQThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrptCTBaiThi frm = CheckExists(typeof(FrptCTBaiThi)) as FrptCTBaiThi;
            if (frm == null)
            {
                frm = new FrptCTBaiThi();
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormBangDiem frm = CheckExists(typeof(FormBangDiem)) as FormBangDiem;
            if (frm == null)
            {
                frm = new FormBangDiem();
            }
            frm.MdiParent = this;
            frm.Show();
        }
    }
    #endregion

}
