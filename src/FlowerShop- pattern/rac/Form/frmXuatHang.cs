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
    public partial class frmXuatHang : Form
    {
        public string idnv;
        LinQDataContext dbs = new LinQDataContext();
        ANhanVien nv = new NhanVienThuNgan();
        public frmXuatHang()
        {
            InitializeComponent();
        }
        void load()
        {

            var DSSP = dbs.sp_LoadSanPham();
            txtCBBTenSP.DataSource = DSSP.ToList();
            txtCBBTenSP.DisplayMember = "TenSP";
            txtCBBTenSP.ValueMember = "IDSP";


            var info = dbs.sp_getNhanVienByID(Convert.ToInt32(idnv));
            foreach (var a in info)
            {
                txtNguoiXuat.Text = a.TenNV;
            }
        }

        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            load();
        }

        static int dem = 1;
        static double tongtien = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                double tien = Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtGiaXuat.Text);
                if (tien <= 0)
                {
                    MessageBox.Show("Vui lòng nhập nhập đúng dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuong.ResetText();
                    txtSoLuong.Focus();
                }
                else
                {
                    int idsp = Convert.ToInt32(txtCBBTenSP.SelectedIndex) + 1;
                    int tongsoluongsp = Convert.ToInt32(dbs.sp_getSumSanPhamByID(idsp).SingleOrDefault().SumSP);
                    if (tongsoluongsp < Convert.ToInt32(txtSoLuong.Text))
                    {
                        MessageBox.Show("Sản phẩm trong kho hiện chỉ còn có " + tongsoluongsp, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSoLuong.Text = tongsoluongsp.ToString();
                    }
                    else
                    {
                        tongtien += tien;
                        dgvHoaDon.Rows.Add(dem, txtCBBTenSP.Text, txtNguoiXuat.Text, txtSoLuong.Text, txtGiaXuat.Text, tien.ToString());
                        dem++;
                        txtTongtien.Text = tongtien.ToString();
                        txtSoLuong.ResetText();
                        txtSoLuong.Focus();
                    }


                }

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập nhập đúng dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.ResetText();
                txtSoLuong.Focus();
            }

        }


        private void txtCBBTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idsp = Convert.ToInt32(txtCBBTenSP.SelectedIndex) + 1;
            var gia = dbs.sp_getGiaSanPhamByID(idsp).SingleOrDefault();
            txtGiaXuat.Text = gia.Gia.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable("HoaDon");
            table1.Columns.Add(new DataColumn("Ten", typeof(string)));
            table1.Columns.Add(new DataColumn("SoLuong", typeof(string)));
            table1.Columns.Add(new DataColumn("DonGia", typeof(string)));
            table1.Columns.Add(new DataColumn("ThanhTien", typeof(string)));

            if (dgvHoaDon.Rows.Count > 1)
            {
                int sodem = 0;
                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                {
                    sodem++;
                    table1.Rows.Add(row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString());
                    if (sodem >= dgvHoaDon.Rows.Count - 1)
                        break;
                }

                int idhoadon = Convert.ToInt32(dbs.sp_MaxHoaDon().SingleOrDefault().MaxIDHoaDon);

                //Lưu hóa đơn.
                dbs.sp_insertHoaDon(DateTime.Today, Convert.ToInt32(idnv), Convert.ToInt32(txtTongtien.Text), "Đã Thanh Toán");

                //Lưu chi tiết hóa đơn.
                for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                {
                    int idsp = dbs.sp_getIDSPByName(dgvHoaDon.Rows[i].Cells[1].Value.ToString()).SingleOrDefault().IDSP;
                    int sl = Convert.ToInt32(dgvHoaDon.Rows[i].Cells[3].Value.ToString());
                    int dongia = Convert.ToInt32(dgvHoaDon.Rows[i].Cells[4].Value.ToString());

                    //bắt đầu lưu

                    nv.LuuChiTietHoaDon(idhoadon, idsp, sl, dongia);
                }

                dbs.SubmitChanges();
                tongtien = 0;
                dem = 0;
                txtSoLuong.ResetText();
                txtTongtien.Text = "0";
                dgvHoaDon.Rows.Clear();
                txtCBBTenSP.SelectedIndex = 0;
                DialogResult result = MessageBox.Show("Bạn có muốn xuất ra file Excel ?", "Xác Nhận !!!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    nv.InHoaDon(table1, "Hóa Đơn", "HoaDon");
                else
                    MessageBox.Show("Bạn đã lưu thành công !!!");
            }
        }




   
       
    }
}
