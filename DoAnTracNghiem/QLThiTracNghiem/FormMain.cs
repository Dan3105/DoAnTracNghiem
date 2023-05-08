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
                    rbQuanly.Visible = false;
                    btnSignup.Enabled = false;
                    break;
                case Simple.GroupLoginType.TRUONG:
                case Simple.GroupLoginType.COSO:
                    rbQuanly.Visible = true;
                    btnSignup.Enabled = true;
                    break;
                case Simple.GroupLoginType.GIANGVIEN:
                    rbQuanly.Visible = false;
                    btnSignup.Enabled = false;
                    break;
                case Simple.GroupLoginType.SINHVIEN:
                    rbQuanly.Visible = false;
                    btnSignup.Enabled = false;
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
            rbQuanly.Visible = false;
            btnLogout.Enabled = false;
            btnSignup.Enabled = false;
            //redirect to login form
            foreach(Form f in this.MdiChildren)
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
        #endregion

    }
}
