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
            if(Program.Connect() == 0)
            {
                DisableEditingData();
            }

        }

        private void EnableEditingData()
        {
            if (Program.groupLoginType == Simple.GroupLoginType.SINHVIEN) return;
            btnMonhoc.Enabled = true;
            btnLogin.Enabled = false;
            //
            this.CheckExists(typeof(FormDangNhap))?.Hide();
        }

        private void DisableEditingData()
        {
            btnMonhoc.Enabled = false; 
            btnLogin.Enabled = true;

            //redirect to login form
            this.ActiveMdiChild?.Hide();
            this.CheckExists(typeof(FormDangNhap))?.Show();
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDangNhap formLogin = CheckExists(typeof(FormDangNhap)) as FormDangNhap;
            if(formLogin == null)
            {
                formLogin = new FormDangNhap();
            }
            formLogin.MdiParent = this;
            formLogin.Show();
        }
        
        public void AssignUserLoginData()
        {
            this.MAUSER.Text = Program.username;
            this.HOTEN.Text = Program.fullname;
            this.NHOM.Text = Program.groupLoginType.ToString();
            EnableEditingData();
        }

        private void btnMonhoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Program.Connect() == 0) return;;
            FormMonHoc formMonHoc = CheckExists(typeof(FormMonHoc)) as FormMonHoc;
            if(formMonHoc == null)
            {
                formMonHoc = new FormMonHoc();
            }
            formMonHoc.MdiParent = this;
            formMonHoc.Show();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.ResetUser();
            DisableEditingData();
        }
    }
}
