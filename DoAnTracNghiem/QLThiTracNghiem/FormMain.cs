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
            this.COSO.Text = Program.servername;
        }
    }
}
