using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
namespace rac
{
    public partial class frmMain : Form
    {
        public String idnv;
        BUS.ANhanVien nhanVien = new BUS.NhanVienQuanLy();
        public frmMain()
        {
            InitializeComponent();
        }
        LinQDataContext dbs = new LinQDataContext();
        private void menuDX_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Hide();
            Form frm = new frmLogin();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            int loainv = 0;
            loainv = nhanVien.LoadLoaiNV(Convert.ToInt32(idnv));
            txtID.Text = idnv;
            var info = dbs.sp_getNhanVienByID(Convert.ToInt32(idnv));
            foreach(var a in info)
            {
                txtName.Text = a.TenNV;
                txtLoaiNV.Text = a.LoaiNV;
            }
            if(loainv==2)
            {
                menuQuanlynguoidung.Enabled = false;
                menuItemQuanli.Enabled = false;
            }
            else if(loainv==3)
            {
                menuQuanlynguoidung.Enabled = false;
                menuXuatHang.Enabled = false;
                menuNV.Enabled = false;
                menuSanPham.Enabled = false;
            }
        }

        private void menuDoiMK_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmChangePassword")
                {
                    f.Activate();
                    return;
                }
            }          
            frmChangePassword frmCP = new frmChangePassword();
            frmCP.idnv = this.idnv;
            frmCP.MdiParent = this;
            frmCP.Show();
            frmCP.Top = 0;
            frmCP.Left = 0;
        }

        private void mnuSV_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmNhanVien")
                {
                    f.Activate();
                    return;
                }
            }

            Form frmNV = new frmNhanVien();
            frmNV.Show();
            frmNV.MdiParent = this;
            frmNV.Show();
            frmNV.Top = 0;
            frmNV.Left = 0;
           
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuSanPham_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmSanPham")
                {
                    f.Activate();
                    return;
                }
            }

            Form frmSP = new frmSanPham();
            frmSP.Show();
            frmSP.MdiParent = this;
            frmSP.Show();
            frmSP.Top = 0;
            frmSP.Left = 0;
        }

        private void menuQuanlynguoidung_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmAccount")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmAC = new frmAccount();
            frmAC.Show();
            frmAC.MdiParent = this;
            frmAC.Show();
            frmAC.Top = 0;
            frmAC.Left = 0;
        }

        private void menuKhoHang_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmKhoHang")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmKH = new frmKhoHang();
            frmKH.Show();
            frmKH.MdiParent = this;
            frmKH.Show();
            frmKH.Top = 0;
            frmKH.Left = 0;
        }

        private void menuThongtincuahang_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmChiTietCuaHang")
                {
                    f.Activate();
                    return;
                }
            }
            frmChiTietCuaHang frmCP = new frmChiTietCuaHang();
            //frmCP.idnv = this.idnv;
            frmCP.MdiParent = this;
            frmCP.Show();
            frmCP.Top = 0;
            frmCP.Left = 0;
        }

        private void menuHoaDon_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmThongKeHoaDon")
                {
                    f.Activate();
                    return;
                }
            }
            frmThongKeHoaDon frmCP = new frmThongKeHoaDon();
            //frmCP.idnv = this.idnv;
            frmCP.MdiParent = this;
            frmCP.Show();
            frmCP.Top = 0;
            frmCP.Left = 0;
        }

        private void menuSPHetHan_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmHetHan")
                {
                    f.Activate();
                    return;
                }
            }
            frmHetHan frmCP = new frmHetHan();
            //frmCP.idnv = this.idnv;
            frmCP.MdiParent = this;
            frmCP.Show();
            frmCP.Top = 0;
            frmCP.Left = 0;
        }

        private void menuXuatHang_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmXuatHang")
                {
                    f.Activate();
                    return;
                }
            }
            frmXuatHang frmCP = new frmXuatHang();
            frmCP.idnv = this.idnv;
            frmCP.MdiParent = this;
            frmCP.Show();
            frmCP.Top = 0;
            frmCP.Left = 0;
        }

        private void menuItemTroGiup_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmTroGiup")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmCP = new frmTroGiup();
            frmCP.MdiParent = this;
            frmCP.Show();
            frmCP.Top = 0;
            frmCP.Left = 0;
        }
    }
}
