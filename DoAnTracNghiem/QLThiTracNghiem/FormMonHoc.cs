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
        public FormMonHoc()
        {
            InitializeComponent();       
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            DB_TracNghiemMonHoc.EnforceConstraints = false;
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dB_TracNghiemMonHoc.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Fill(this.DB_TracNghiemMonHoc.MONHOC);
            SetCbServer();
            CustomHeaderButtons();
            //this.mONHOCGridControl.MainView.OptionsLayout = false;
            this.gcMonHoc.OptionsBehavior.Editable = false;
        }

        private void SetCbServer()
        {
            this.cbServer.DataSource = Program.bds_dspm;
            this.cbServer.DisplayMember = "TenCS";
            this.cbServer.ValueMember = "MaCS";
            this.cbServer.SelectedIndex = Program.mserverSelected;

        }

        private void CustomHeaderButtons()
        {
            switch (Program.groupLoginType)
            {
                case Simple.GroupLoginType.TRUONG:
                case Simple.GroupLoginType.GIANGVIEN:
                    btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnUndo.Enabled = btnWrite.Enabled =
                        btnReload.Enabled = false;
                    this.cbServer.Enabled = true;
                    panelDataView.Enabled = false;
                    break;
                case Simple.GroupLoginType.COSO:
                    btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnUndo.Enabled = btnWrite.Enabled =
                        btnReload.Enabled = true;
                    this.cbServer.Enabled = false;
                    panelDataView.Enabled = true;
                    break;
                default:
                    Console.WriteLine($"Error Info user {Program.groupLoginType.ToString()}");
                    btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnUndo.Enabled = btnWrite.Enabled =
                        btnReload.Enabled = false;
                    this.cbServer.Enabled = false;
                    panelDataView.Enabled = false;
                    break;

            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            crrPosition = this.bdsMONHOC.Position;
            panelDataView.Enabled = true;
            bdsMONHOC.AddNew();

            btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = false;
            btnUndo.Enabled = btnWrite.Enabled = true;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 st = 0;
            if(MessageBox.Show("U sure to del ?", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    crrPosition = int.Parse(((DataRowView)bdsMONHOC[bdsMONHOC.Position])["MAMH"].ToString());
                    bdsMONHOC.RemoveCurrent();

                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MONHOCTableAdapter.Update(this.DB_TracNghiemMonHoc.MONHOC);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex}", "", MessageBoxButtons.OK);
                    this.MONHOCTableAdapter.Fill(this.DB_TracNghiemMonHoc.MONHOC);
                    bdsMONHOC.Position = crrPosition;
                }
            }

            if (bdsMONHOC.Count == 0) btnDel.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            crrPosition = this.bdsMONHOC.Position;
            panelDataView.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = false;
            btnUndo.Enabled = btnWrite.Enabled = true;
            
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                MONHOCTableAdapter.Fill(this.DB_TracNghiemMonHoc.MONHOC);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error Reloading: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMONHOC.CancelEdit();
            if(!btnAdd.Enabled) bdsMONHOC.Position = crrPosition;
            gcMonHoc.OptionsBehavior.Editable = false;
            panelDataView.Enabled = false;

            btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = true;
            btnUndo.Enabled = btnWrite.Enabled = false;
        }

        private void btnWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
