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
    public partial class frmChiTietCuaHang : Form
    {
        LinQDataContext dbs = new LinQDataContext();
        ChiTietCuaHang ctch = new ChiTietCuaHang();
        public frmChiTietCuaHang()
        {
            InitializeComponent();
        }
        void ketQuaBanHang()
        {
            double countGiaNgayHienTai = 0;
            countGiaNgayHienTai=ctch.loadGiaHoaDonNgayHienTai();
            double countGiaNgayHomQua = 0;
            countGiaNgayHomQua= ctch.loadGiaHomQua();
            int countSL = ctch.loadSoLuong();
            txtGiaHoaDonBan.Text = countGiaNgayHienTai.ToString() + " Đ";
            txtHoaDonBan.Text = countSL.ToString() + " Hóa Đơn";
            //hieu suat

            double hieuxuat = countGiaNgayHienTai / (countGiaNgayHienTai + countGiaNgayHomQua) * 100;
            if (countGiaNgayHienTai > countGiaNgayHomQua)
            {
                Bitmap bm = new Bitmap(Application.StartupPath+"\\HinhAnh\\tang.png");
                ptbHieuSuat.Image = bm;
                txtHieuSuat.ForeColor = SystemColors.ActiveCaption;
                txtHieuSuat.Text = "+" + Convert.ToInt32(hieuxuat).ToString() + "%";
                txtTangGiam.Text = "Tăng";
            }
            else if (countGiaNgayHienTai < countGiaNgayHomQua)
            {
                txtHieuSuat.Text = "-" + Convert.ToInt32(hieuxuat).ToString() + "%";
            }
            else txtHieuSuat.Text = "0%";
            //hang bi huy

            txtSoHoaDonHuy.Text = ctch.loadHDHuy();
        }
        
        private void frmChiTietCuaHang_Load(object sender, EventArgs e)
        {
            ctch.LoadFacade();

            //
            ketQuaBanHang();
            //
            txtDoanhThu.Text = ctch.Mang[0].ToString();
            //
            chartDoanhThu.Series["Gia"].Points.AddXY("Tháng Này", ctch.Mang[1]);
            chartDoanhThu.Series["Gia"].Points.AddXY("Tháng Trước", ctch.Mang[2]);
            //
            var spBanChay = dbs.sp_LoadSanPhamBanChayNhat();
            chartSanPham.DataSource = spBanChay.ToList();
            chartSanPham.Series["Số Lượng"].XValueMember = "TenSP";
            chartSanPham.Series["Số Lượng"].YValueMembers = "Max";


        }
        private void cbbDoanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            double count1 = 0;
            double count2 = 0;
            double[] hieuxuatdoanhthu = new double[2];
            ShowHieuSuatDoanhThu s = new ShowHieuSuatDoanhThu();
            switch (Convert.ToInt32(cbbDoanhThu.SelectedIndex))
            {
                case 0:
                    chartDoanhThu.Series["Gia"].Points.Clear();
                    var Tuannay = dbs.sp_LoadDoanhThuTuan();
                    foreach (var index in Tuannay)
                        count1 += ctch.tinhToan(Convert.ToDouble(index.Gia.ToString()), Convert.ToDouble(index.SoLuong));

                    var tuantruoc = dbs.sp_LoadDoanhThuTuanTruoc();
                    foreach (var index in tuantruoc)
                        count2 += ctch.tinhToan(Convert.ToDouble(index.Gia.ToString()), Convert.ToDouble(index.SoLuong));


                    chartDoanhThu.Series["Gia"].Points.AddXY("Tuần Này", count1);
                    chartDoanhThu.Series["Gia"].Points.AddXY("Tuần Trước", count2);
                    break;
                case 1:
                    chartDoanhThu.Series["Gia"].Points.Clear();
                    var thangnay = dbs.sp_LoadDoanhThuThang();
                    foreach (var index in thangnay)
                        count1 += ctch.tinhToan(Convert.ToDouble(index.Gia.ToString()), Convert.ToDouble(index.SoLuong));

                    var thangtruoc = dbs.sp_LoadDoanhThuThangTruoc();
                    foreach (var index in thangtruoc)
                        count2 += ctch.tinhToan(Convert.ToDouble(index.Gia.ToString()), Convert.ToDouble(index.SoLuong));

                    chartDoanhThu.Series["Gia"].Points.AddXY("Tháng Này", count1);
                    chartDoanhThu.Series["Gia"].Points.AddXY("Tháng Trước", count2);
                    break;
                case 2:
                    chartDoanhThu.Series["Gia"].Points.Clear();
                    var namnay = dbs.sp_LoadDoanhThuNam();
                    foreach (var index in namnay)
                        count1 += ctch.tinhToan(Convert.ToDouble(index.Gia.ToString()), Convert.ToDouble(index.SoLuong));

                    var namtruoc = dbs.sp_LoadDoanhThuNamTruoc();
                    foreach (var index in namtruoc)
                        count2 += ctch.tinhToan(Convert.ToDouble(index.Gia.ToString()), Convert.ToDouble(index.SoLuong));

                    chartDoanhThu.Series["Gia"].Points.AddXY("Năm Này", count1);
                    chartDoanhThu.Series["Gia"].Points.AddXY("Năm Trước", count2);
                    break;
            }
            
        }
    }
}
